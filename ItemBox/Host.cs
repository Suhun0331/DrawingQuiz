using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Net;

namespace ItemBox
{
    public partial class Host : Form
    {
        TcpClient clientSocket = new TcpClient();
        string IP = "";
        static String strConn = "Server=13.209.111.12;Port=59876;Database=itemBox_DB;Uid=root;Pwd=9999";
        MySqlConnection conn = new MySqlConnection(strConn);

        // Host 생성자
        public Host()
        {
            InitializeComponent();
            IP = getIP();
            Label ipLabel = new Label();
            ipLabel.Text = "IP 주소:";
            ipLabel.Location = new Point(10, 10);
            this.Controls.Add(ipLabel);

            Label portLabel = new Label();
            portLabel.Text = "포트 번호:";
            portLabel.Location = new Point(10, 35);
            this.Controls.Add(portLabel);

            Label ipAddressLabel = new Label();
            ipAddressLabel.Text = IP;
            ipAddressLabel.Location = new Point(120, 10);
            this.Controls.Add(ipAddressLabel);

            Label portNumberLabel = new Label();
            portNumberLabel.Text = "9999";
            portNumberLabel.Location = new Point(120, 35);
            this.Controls.Add(portNumberLabel);
        }

        // 로컬 IP 주소 얻는 메서드
        public string getIP()
        {
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP = address.ToString();
                }
            }
            return IP;
        }

        // 서버의 IP 주소를 데이터베이스에 저장
        private void serverIPSave()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = strConn;
                conn.Open();

                // 해당 IP 주소값이 이미 저장되어 있는지 확인
                string query1 = "select count(*) from host where ip=@ip";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                cmd1.CommandText = query1;
                cmd1.Parameters.AddWithValue("@ip", IP);
                int checkIP = Convert.ToInt32(cmd1.ExecuteScalar());

                // 이미 저장되어 있다면 업데이트
                if (checkIP > 0)
                {
                    string query2 = "update host set room_num=@room_num, curr_num=@curr_num where ip=@ip";
                    MySqlCommand newUser1 = new MySqlCommand(query1, conn);
                    newUser1.CommandText = query2;
                    newUser1.Parameters.AddWithValue("@ip", IP);
                    newUser1.Parameters.AddWithValue("@room_num", comboBox.SelectedItem);
                    newUser1.Parameters.AddWithValue("@curr_num", 1);
                    newUser1.ExecuteNonQuery();
                }
                else // 저장되어 있지 않다면 삽입
                {
                    string query3 = "insert into host values(room_id, @ip, @room_num, @curr_num)";
                    MySqlCommand newUser2 = new MySqlCommand(query1, conn);
                    newUser2.CommandText = query3;
                    newUser2.Parameters.AddWithValue("@ip", IP);
                    newUser2.Parameters.AddWithValue("@room_num", comboBox.SelectedItem);
                    newUser2.Parameters.AddWithValue("@curr_num", 1);
                    newUser2.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Host_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.BackgroundImage = Properties.Resources.BackgroundImage;
            SetFont();
        }

        // 마우스 커서 이벤트 핸들러
        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }

        // 뒤로 가기 버튼 클릭 이벤트 핸들러
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select form1 = new Select();
            form1.ShowDialog();
            this.Close();
        }

        // 클라이언트 소켓 반환
        public TcpClient SetSocket() { return clientSocket; }

        // 서버와 연결
        private void Connect() { clientSocket.Connect(IP, 9999); }
        private void OK_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex < 0)
                MessageBox.Show("인원수를 선택해주세요.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            else
            {
                // 서버 프로그램 시작
                Process.Start(Environment.CurrentDirectory + "\\Server\\bin\\Debug\\Server.exe");

                // Host가 server와 연결 시도
                try { serverIPSave(); Connect(); }
                catch
                {
                    MessageBox.Show("서버와 연결할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Hide();
                    Select form1 = new Select();
                    form1.ShowDialog();
                    this.Close();
                    return;
                }
                this.Hide();
                Profile form4 = new Profile(this);
                form4.ShowDialog();
                this.Close();
            }
        }

        // 글꼴 설정 메서드
        private void SetFont()
        {
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile(Environment.CurrentDirectory + "\\Font\\한나체.ttf");
            Font font9 = new Font(privateFonts.Families[0], 9f);
            Font font18 = new Font(privateFonts.Families[0], 18f);
            numLabel.Font = font18;
            backLabel.Font = font18;
            okLabel.Font = font18;
            comboBox.Font = font9;
        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}