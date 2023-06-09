using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using socketProtocol_Library;
using System.IO;
using MySql.Data.MySqlClient;

namespace ItemBox
{
    public partial class Room : Form
    {

        // 그림판
        bool isDrag = false;
        Point previousPoint;
        int setTool = 0;
        int setColor = 0;
        int prevTool = 0;
        int prevColor = 0;
        bool eraser = false;
        Pen currentPen;
        Bitmap bitmap;
        Graphics g;



        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }
        public TcpClient SetSocket() { return clientSocket; }
        private void resetBuffer(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }

        public Room(Profile profile)
        {

        }

        public Room()
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {
            //배경 설정
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.BackgroundImage = Properties.Resources.BackgroundImage;
            //그림판 비트맵 설정
            bitmap = new Bitmap(this.gamePanel.Width, this.gamePanel.Height);
            g = Graphics.FromImage(bitmap);


        }


        private void startButton_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }


        ///////////////////////////////////////////////////////패킷 통신-게임 룰////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////   그림판   ////////////////////////////////////////////////////////
        private void rBtn_10pt_CheckedChanged(object sender, EventArgs e)
        {//펜 두께 설정
            RadioButton selectedRadioButton = (RadioButton)sender;
            switch (selectedRadioButton.Name)
            {
                case "rBtn_1pt":
                    setTool = 1;
                    break;
                case "rBtn_3pt":
                    setTool = 2;
                    break;
                case "rBtn_5pt":
                    setTool = 3;
                    break;
                case "rBtn_10pt":
                    setTool = 4;
                    break;
            }
        }

        private void panel_color_click(object sender, EventArgs e)
        {//펜 색
            Panel selectedColor = (Panel)sender;
            if (eraser == true)
            {
                eraser = false;
                rBtn_1pt.Checked = false;
                rBtn_3pt.Checked = false;
                rBtn_5pt.Checked = false;
                rBtn_10pt.Checked = false;
                setTool = prevTool;

                if (setTool == 0)
                    rBtn_1pt.Checked = true;
                else if (setTool == 1)
                    rBtn_1pt.Checked = true;
                else if (setTool == 2)
                    rBtn_3pt.Checked = true;
                else if (setTool == 3)
                    rBtn_5pt.Checked = true;
                else if (setTool == 4)
                    rBtn_10pt.Checked = true;
            }

            switch (selectedColor.Name)
            {
                case "panel_black":
                    setColor = 0;
                    break;
                case "panel_red":
                    setColor = 1;
                    break;
                case "panel_orange":
                    setColor = 2;
                    break;
                case "panel_yellow":
                    setColor = 3;
                    break;
                case "panel_green":
                    setColor = 4;
                    break;
                case "panel_blue":
                    setColor = 5;
                    break;
                case "panel_navy":
                    setColor = 6;
                    break;
                case "panel_purple":
                    setColor = 7;
                    break;
            }
        }

        private void panel_pic_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            previousPoint = new Point(e.X, e.Y);
        }

        private void panel_pic_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
            if (!lockDrawing)
            {
                //한 획 그을 때마다 그림 저장
                gamePicture.DrawToBitmap(bitmap, new Rectangle(0, 0, gamePicture.Width, gamePicture.Height));
                bitmap.Save(Environment.CurrentDirectory + "\\UserImage\\" + client_number + "Turn.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                sendPicture();
            }
        }


        private void sendPicture()
        {
            byte[] sendBuffer = new byte[1024 * 4];
            //////////////////////////////   그림 파일 정보 전송   //////////////////////////////
            ClientDrawingInfo drawInfo = new ClientDrawingInfo();
            drawInfo.Type = (int)PacketType.그림정보;
            drawInfo.clientNum = client_number;
            Packet.Serialize(drawInfo).CopyTo(sendBuffer, 0);
            stream.Write(sendBuffer, 0, sendBuffer.Length);
            stream.Flush();
            //////////////////////////////   그림 파일 전송   //////////////////////////////
            ClientDrawing draw = new ClientDrawing();
            FileInfo file = new FileInfo(Environment.CurrentDirectory + "\\UserImage\\" + client_number + "Turn.jpg");
            FileStream fileStrm = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fileStrm);


            int count = (int)(file.Length) / (1024) + 1;

            for (int i = 0; i < count; i++)
            {
                draw.buffer = reader.ReadBytes(1024);
                draw.count = count;
                draw.Type = (int)PacketType.그림;
                draw.clientNum = client_number;
                Packet.Serialize(draw).CopyTo(sendBuffer, 0);
                stream.Write(sendBuffer, 0, sendBuffer.Length);
                this.stream.Flush();
                resetBuffer(sendBuffer);
            }
            fileStrm.Close();
        }

        private void panel_pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag == true)
            {
                Point currentPoint = new Point(e.X, e.Y);
                if (setColor == 0)
                    currentPen = new Pen(Color.Black);
                else if (setColor == 1)
                    currentPen = new Pen(Color.Red);
                else if (setColor == 2)
                    currentPen = new Pen(Color.Orange);
                else if (setColor == 3)
                    currentPen = new Pen(Color.Yellow);
                else if (setColor == 4)
                    currentPen = new Pen(Color.Green);
                else if (setColor == 5)
                    currentPen = new Pen(Color.Blue);
                else if (setColor == 6)
                    currentPen = new Pen(Color.Navy);
                else if (setColor == 7)
                    currentPen = new Pen(Color.Purple);
                else if (setColor == 8)
                    currentPen = new Pen(Color.White);


                if (setTool == 0)
                    currentPen.Width = 1;
                else if (setTool == 1)
                    currentPen.Width = 1;
                else if (setTool == 2)
                    currentPen.Width = 3;
                else if (setTool == 3)
                    currentPen.Width = 5;
                else if (setTool == 4)
                    currentPen.Width = 10;

                if (!lockDrawing)
                {
                    g.DrawLine(currentPen, previousPoint, currentPoint);
                    previousPoint = currentPoint;
                    gamePicture.Image = bitmap;
                }
            }
        }

        private void lbl_reset_Click(object sender, EventArgs e)
        {
            gamePanel.Invalidate();
            g.Clear(Color.White);
            gamePicture.Image = bitmap;
        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            prevColor = setColor;
            prevTool = setTool;
            eraser = true;
            setColor = 8;
            setTool = 4;
            rBtn_1pt.Checked = false;
            rBtn_3pt.Checked = false;
            rBtn_5pt.Checked = false;
            rBtn_10pt.Checked = true;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Next_Form()
        {
            this.Invoke(new MethodInvoker(delegate () {
                this.Hide();
                Result form6 = new Result(this);
                form6.ShowDialog();
                this.Close();
            }));
        }

        private void turn_Click(object sender, EventArgs e)
        {

        }
    }
}