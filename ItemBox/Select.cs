using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ItemBox
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(900, 550);        // 폼의 크기 설정
            this.BackgroundImage = Properties.Resources.BackgroundImage;   // 배경 이미지 설정
            SetFont();   // 글꼴 설정 메서드 호출

            // 이전에 그렸던 자기 자신의 이미지 삭제
            string filepath = Environment.CurrentDirectory + "\\UserImage\\userPic.jpg";   // 이미지 파일 경로
            FileInfo file = new FileInfo(filepath); 
            if (file.Exists)
                file.Delete();   // 이미지 파일 삭제
        }

        private void host_button(object sender, EventArgs e)
        {
            this.Hide();   // 현재 폼 숨기기
            Host host = new Host();  
            host.ShowDialog(); 
            this.Close();   // 현재 폼 닫기
        }

        private void guest_button(object sender, EventArgs e)
        {
            this.Hide();   // 현재 폼 숨기기
            Guest guest = new Guest();   
            guest.ShowDialog(); 
            this.Close();   // 현재 폼 닫기
        }

        private void cursor_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;   // 버튼 위에 마우스가 올라갈 때 커서 모양을 손가락 모양으로 변경
        }

        private void cursor_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;   // 버튼을 벗어날 때 커서 모양을 화살표 모양으로 변경
        }

        private void SetFont()   // 글꼴 설정 메서드
        {
            System.Drawing.Text.PrivateFontCollection privateFonts = new System.Drawing.Text.PrivateFontCollection();
            privateFonts.AddFontFile(Environment.CurrentDirectory + "\\Font\\한나체.ttf");   // 한나체 글꼴 파일 경로
            Font font18 = new Font(privateFonts.Families[0], 18f);   // 한나체 글꼴을 크기 18으로 설정
            hostLabel.Font = font18;  
            guestLabel.Font = font18; 
        }

        private void guestPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
