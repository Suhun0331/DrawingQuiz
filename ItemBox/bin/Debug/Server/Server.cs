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
using System.IO;
using socketProtocol_Library;
using MySql.Data.MySqlClient;

namespace Server
{
    public partial class Server : Form
    {
        

        private void resetBuffer(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }

        public Server()
        {
            InitializeComponent();

            //서버 시작
            Thread thStart = new Thread(InitSocket);
            thStart.IsBackground = true;
            thStart.Start();
        }



        private void InitSocket()
        {

            
        }

        void h_client_OnDisconnected(TcpClient clientSocket)
        {   
        }

        private void listenRequest(int requestType, byte[] readBuffer, int cli_num)
        {   
        }

        private void drawReceived(byte[] buffer, int count, int cli_num)
        {
            
        }

        private void msgReceived(string message, string nickName)
        {   
        }

        private void profileReceived(string nickName, byte[] buffer, int count, int cli_num)
        {   
        }

        private void stateReceived(bool state)
        {
           
        }

        private void answerReceived(int client, int score, string message, int clientNum)
        {
        }

        public void SendTurnAll(int turn, string message, bool state)
        {
        }
        public void SendScoreAll()
        {
            
       
        }


        public void SendMessageAll(string message, string nickName, bool flag)
        {
            
        }

        public void SendDrawAll(int cli_num)
        {
            
        }

       


        class handleClient // 클라이언트를 다루기 위한 클래스 -> 메세지 저장. 전송
        {
           

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

