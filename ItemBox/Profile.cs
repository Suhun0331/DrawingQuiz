using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using socketProtocol_Library;
using System.IO;

namespace ItemBox
{
    public partial class Profile : Form
    {
        TcpClient clientSocket;
        NetworkStream stream = default(NetworkStream);
        private byte[] sendbuffer = new byte[1024 * 4];
        private byte[] readbuffer = new byte[1024 * 4];

        // 그리기를 처리하는 DrawingBoard 객체
        private DrawingBoard drawingBoard;

        private Host host = null;
        private Guest guest = null;

        public Profile(Host host)
        {
            InitializeComponent();
            this.host = host;
            clientSocket = host.SetSocket();
        }

        public Profile(Guest guest)
        {
            InitializeComponent();
            this.guest = guest;
            clientSocket = guest.SetSocket();
        }

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.BackgroundImage = Properties.Resources.BackgroundImage;
            SetFont();

            drawingBoard = new DrawingBoard(drawPicture);
        }

        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }
        void bufferReset(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }
        public TcpClient SetSocket() { return clientSocket; }
        private void resetBuffer(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }

        private void SetFont()
        {
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile(Environment.CurrentDirectory + "\\Font\\한나체.ttf");
            Font font12 = new Font(privateFonts.Families[0], 12f);
            Font font18 = new Font(privateFonts.Families[0], 18f);
            txtBox_id.Font = font12;
            rBtn_1pt.Font = font12;
            rBtn_3pt.Font = font12;
            rBtn_5pt.Font = font12;
            rBtn_10pt.Font = font12;
            label_eraser.Font = font12;
            nameLabel.Font = font18;
            lbl_reset.Font = font18;
            lbl_save.Font = font18;
            lbl_start.Font = font18;
        }

        private void rBtn_10pt_CheckedChanged(object sender, EventArgs e)       // 펜 굵기 설정
        {
            RadioButton selectedRadioButton = (RadioButton)sender;

            if (selectedRadioButton.Checked)
            {
                int penWidth = 0;

                if (selectedRadioButton.Name == "rBtn_1pt")
                    penWidth = 1;
                else if (selectedRadioButton.Name == "rBtn_3pt")
                    penWidth = 2;
                else if (selectedRadioButton.Name == "rBtn_5pt")
                    penWidth = 3;
                else if (selectedRadioButton.Name == "rBtn_10pt")
                    penWidth = 4;

                drawingBoard.SetPenWidth(penWidth);
            }
        }


        private void panel_color_click(object sender, EventArgs e)          // 펜 색깔 설정
        {
            Panel selectedColor = (Panel)sender;
            string colorName = selectedColor.Name;

            string[] colorNames = new string[] { "panel_black", "panel_red", "panel_orange", "panel_yellow",
        "panel_green", "panel_blue", "panel_navy", "panel_purple" };

            int colorIndex = Array.IndexOf(colorNames, colorName);
            if (colorIndex != -1)
            {
                drawingBoard.SetPenColor(colorIndex);
            }
        }


        private void panel_pic_MouseDown(object sender, MouseEventArgs e)
        {
            // 마우스를 누르면 그리기 시작
            drawingBoard.MouseDown(e);
            Cursor = Cursors.Cross;
        }

        private void panel_pic_MouseUp(object sender, MouseEventArgs e)
        {
            // 마우스를 떼면 그리기 중지
            drawingBoard.MouseUp(e);
            Cursor = Cursors.Arrow;
        }

        private void panel_pic_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스를 움직이면 그림을 그림
            drawingBoard.MouseMove(e);
        }

        private void lbl_reset_Click(object sender, EventArgs e)        // 전체 지우기
        {
            drawingBoard.ResetCanvas();
        }

        private void Eraser_Click(object sender, EventArgs e)       // 지우개
        {
            drawingBoard.ChangeToEraser();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            drawingBoard.SaveImage(Environment.CurrentDirectory + "\\UserImage\\userPic.jpg");
            MessageBox.Show("저장되었습니다.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string filepath = Environment.CurrentDirectory + "\\UserImage\\userPic.jpg";
            FileInfo file = new FileInfo(filepath);

            if (txtBox_id.Text == "")
                MessageBox.Show("닉네임을 입력해주세요.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            else if (!file.Exists)
                MessageBox.Show("그림을 저장해주세요.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            else
            {
                sendNickname();
                this.Hide();
                Room form5 = new Room(this);
                form5.ShowDialog();
                this.Close();
            }
        }

        private void sendNickname()       //서버에 닉네임, 사진 전송
        {
            stream = clientSocket.GetStream();

            //닉네임 전송
            ClientProfile clientProfile = new ClientProfile();
            clientProfile.Type = (int)PacketType.닉네임;
            clientProfile.nickName = txtBox_id.Text;
            Packet.Serialize(clientProfile).CopyTo(this.sendbuffer, 0);
            stream.Write(this.sendbuffer, 0, this.sendbuffer.Length);
            this.stream.Flush();
            resetBuffer(sendbuffer);

            //프로필 사진 전송
            clientProfile = new ClientProfile();
            FileInfo file = new FileInfo(Environment.CurrentDirectory + "\\UserImage\\userPic.jpg");
            FileStream fileStrm = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStrm);
            int count = (int)(file.Length) / (1024) + 1;

            for (int i = 0; i < count; i++)
            {
                clientProfile.buffer = reader.ReadBytes(1024);
                clientProfile.count = count;
                clientProfile.nickName = txtBox_id.Text;
                clientProfile.Type = (int)PacketType.프로필;

                Packet.Serialize(clientProfile).CopyTo(this.sendbuffer, 0);
                stream.Write(this.sendbuffer, 0, this.sendbuffer.Length);
                this.stream.Flush();
                resetBuffer(sendbuffer);
            }
            fileStrm.Close();
        }

    }
}
