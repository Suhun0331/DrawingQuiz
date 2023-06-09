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


        public Profile(Host host)
        {
            InitializeComponent();

        }

        public Profile(Guest guest)
        {
            InitializeComponent();

        }

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }
        void bufferReset(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }
        private void resetBuffer(byte[] buffer) { for (int i = 0; i < 1024 * 4; i++) buffer[i] = 0; }

        private void SetFont()
        {

        }

        private void rBtn_10pt_CheckedChanged(object sender, EventArgs e)       // 펜 굵기 설정
        {

        }


        private void panel_color_click(object sender, EventArgs e)          // 펜 색깔 설정
        {

        }


        private void panel_pic_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel_pic_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void panel_pic_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void lbl_reset_Click(object sender, EventArgs e)        // 전체 지우기
        {
        }

        private void Eraser_Click(object sender, EventArgs e)       // 지우개
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void sendNickname()       //서버에 닉네임, 사진 전송
        {

        }
    }
}

