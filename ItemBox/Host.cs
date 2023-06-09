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
       

        // Host 생성자
        public Host()
        {
           
        }

        // 로컬 IP 주소 얻는 메서드
       

        // 서버의 IP 주소를 데이터베이스에 저장
        private void serverIPSave()
        {
            
        }

        private void Host_Load(object sender, EventArgs e)
        {
            
        }

        // 마우스 커서 이벤트 핸들러
        private void cursor_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void cursor_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Arrow; }

        // 뒤로 가기 버튼 클릭 이벤트 핸들러
        private void Back_Click(object sender, EventArgs e)
        {
           
        }

        // 클라이언트 소켓 반환

        // 서버와 연결
        private void OK_Click(object sender, EventArgs e)
        {
           
        }

        // 글꼴 설정 메서드
        private void SetFont()
        {
           
        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
