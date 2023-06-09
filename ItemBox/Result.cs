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
    public partial class Result : Form
    {
        

        public Result()
        {
            InitializeComponent();
        }

        public Result(Room room)
        {
            InitializeComponent();
            
        }

        private void Result_Load(object sender, EventArgs e)
        {
           

        }

        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }
        private void resetBuffer(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }

        private void SetFont()
        {
            
        }

        private void Again_Click(object sender, EventArgs e)
        {
          
        }

        private void Exit_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteRoom() {
           

        }

        private void setFianl()   
        {
           
        }

        private void turnReceived(int[] clientscore, string[] clientNickname) 
        {
           
        }

        private void setProfile(int clientNum, int[] clientscore)
        {
          
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            deleteRoom();
        }
    }
}