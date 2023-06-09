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

        private void cursor_MouseEnter(object sender, EventArgs e) { }
        private void cursor_MouseLeave(object sender, EventArgs e) { }
        private void resetBuffer(byte[] buffer) { }

        public Room(Profile profile)
        {


        }

        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }


        private void SetFont()
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        { }


        ///////////////////////////////////////////////////////패킷 통신-게임 룰////////////////////////////////////////////////////////////////////////////
        private void GetRequest()
        {
        }

        private void turnReceived(int turnNum, string word, string message, int[] clientscore)
        { }

        private void settingTurnChange(int turnNum)
        { }

        private void initReceived(string[] namelist, int counter)
        { }

        private void setProfile(int clientNum)
        { }

        private void DisplayText(string text, Color color)
        { }

        private void txtBox_user_KeyDown(object sender, KeyEventArgs e)
        { }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////   그림판   ////////////////////////////////////////////////////////
        private void rBtn_10pt_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel_color_click(object sender, EventArgs e)
        { }

        private void panel_pic_MouseDown(object sender, MouseEventArgs e)
        { }

        private void panel_pic_MouseUp(object sender, MouseEventArgs e)
        { }


        private void sendPicture()
        { }

        private void panel_pic_MouseMove(object sender, MouseEventArgs e)
        { }

        private void lbl_reset_Click(object sender, EventArgs e)
        { }

        private void Eraser_Click(object sender, EventArgs e)
        { }

        private void Next_Form()
        { }

        private void turn_Click(object sender, EventArgs e)
        {

        }
    }
}