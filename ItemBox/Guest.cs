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
using MySql.Data.MySqlClient;


namespace ItemBox
{
    public partial class Guest : Form
    {
        TcpClient clientSocket = new TcpClient();
        string IP = "127.0.0.1";  // 기본 서버ip주소
        int Port = 9999;  // 기본 서버 port 번호

        static String strConn = "Server=13.209.111.12;Port=59876;Database=itemBox_DB;Uid=root;Pwd=9999";

        MySqlConnection conn = new MySqlConnection(strConn);
        MySqlCommand cmd;

        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.BackgroundImage = Properties.Resources.BackgroundImage;
            SetFont();

            conn = new MySqlConnection();
            conn.ConnectionString = strConn;

            SetFont();
            userCount1.Hide();
            userCount2.Hide();
            userCount3.Hide();
            GetIpList();
        }
        // 
        private void GetIpList()
        {
            int i = 0;
            string limitPlayer = "";
            string ipAddress = "";
            string curPlayer = "";

            try
            {
                string query = "select * from host";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;

                conn.Open();
                MySqlDataReader myReader = cmd.ExecuteReader();

                //DB에 있는 값 읽어서 label에 넣어주기
                while (myReader.Read())
                {
                    limitPlayer = myReader["room_num"].ToString();
                    ipAddress = myReader["ip"].ToString();
                    curPlayer = myReader["curr_num"].ToString();

                    switch (i)
                    {
                        //max label 추가
                        case 0: roomList1.Text = ipAddress; userCount1.Text = curPlayer; max_user1.Text = limitPlayer; userCount1.Show(); break;
                        case 1: roomList2.Text = ipAddress; userCount2.Text = curPlayer; max_user2.Text = limitPlayer; userCount2.Show(); break;
                        case 2: roomList3.Text = ipAddress; userCount3.Text = curPlayer; max_user3.Text = limitPlayer; userCount3.Show(); break;
                        default: break;
                    }
                    i++;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }
        
        public TcpClient SetSocket() { return clientSocket; }

        private void select_room(object sender, EventArgs e)
        {
            string roomName = "";
            switch (sender.GetType().ToString())  
            {
                case "System.Windows.Forms.Panel": roomName = ((Panel)sender).Name; break;
                case "System.Windows.Forms.Label": roomName = ((Label)sender).Name; break;
                default: break;
            }

            string player_count = "";
            string max_player = "";

            // 클릭한 방의 현재 인원과 limit 인원을 가져온다.
            if (roomName == "room1" || roomName == "roomList1" || roomName == "userCount1")     
            { max_player = max_user1.Text; player_count = userCount1.Text; IP = room1.Text; }
            else if (roomName == "room2" || roomName == "roomList2" || roomName == "userCount2")
            { max_player = max_user2.Text; player_count = userCount2.Text; IP = roomList2.Text; }
            else if (roomName == "room3" || roomName == "roomList3" || roomName == "userCount3")
            { max_player = max_user3.Text; player_count = userCount3.Text; IP = roomList3.Text; }

            int curPeople = 0;
            int fulPeople = 0;
            if (player_count != "")
            {
                curPeople = Convert.ToInt32(player_count.Substring(0, 1));
                fulPeople = Convert.ToInt32(max_player.Substring(0, 1));
            }
            // 현재 인원과 limit 인원을 비교하여 방을 입장한다.
            if (curPeople >= fulPeople)
            {        

                MessageBox.Show("방에 입장할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try { Connect(); }
                catch
                {
                    MessageBox.Show("서버와 연결할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                // Client가 방에 입장했으니 방 인원수를 변경하는 작업.IP 이용 위해 여기다 집어넣는다.
                curPeople++;

                conn = new MySqlConnection();
                conn.ConnectionString = strConn;

                string query = "update host set curr_num=@curr_num where ip=@ip";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;

                conn.Open();

                cmd.Parameters.AddWithValue("@curr_num", curPeople);
                cmd.Parameters.AddWithValue("@ip", IP);

                cmd.ExecuteNonQuery();

                conn.Close();


                this.Hide();
                Profile profile= new Profile(this);
                profile.ShowDialog();
                this.Close();
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Select select = new Select();
            select.ShowDialog();
            this.Close();
        }
        private void Connect() { clientSocket.Connect(IP, Port); }

        private void SetFont()
        {
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile(Environment.CurrentDirectory + "\\Font\\한나체.ttf");
            Font font12 = new Font(privateFonts.Families[0], 12f);
            Font font18 = new Font(privateFonts.Families[0], 18f);
       
            backLabel.Font = font18;
            roomList1.Font = font12;
            roomList2.Font = font12;
            roomList3.Font = font12;
            userCount1.Font = font12;
            userCount2.Font = font12;
            userCount3.Font = font12;
        }

    }

}
