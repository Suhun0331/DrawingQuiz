namespace ItemBox
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Room
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Room";
            this.Load += new System.EventHandler(this.Room_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_user3;
        private System.Windows.Forms.Label lbl_user2;
        private System.Windows.Forms.Label lbl_user1;
        private System.Windows.Forms.Label lbl_eraser;
        private System.Windows.Forms.Label lbl_reset;
        private System.Windows.Forms.Panel panel_reset;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_user4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Panel ItemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn_3pt;
        private System.Windows.Forms.RadioButton rBtn_10pt;
        private System.Windows.Forms.RadioButton rBtn_5pt;
        private System.Windows.Forms.RadioButton rBtn_1pt;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox txtBox_user;
        private System.Windows.Forms.Panel panel_purple;
        private System.Windows.Forms.Panel panel_navy;
        private System.Windows.Forms.Panel panel_blue;
        private System.Windows.Forms.Panel panel_black;
        private System.Windows.Forms.Panel panel_green;
        private System.Windows.Forms.Panel panel_red;
        private System.Windows.Forms.Panel panel_yellow;
        private System.Windows.Forms.Panel panel_orange;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label lbl_score3;
        private System.Windows.Forms.Label lbl_score4;
        private System.Windows.Forms.Label lbl_score2;
        private System.Windows.Forms.Label lbl_score1;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Panel panel_eraser;
        private System.Windows.Forms.PictureBox userPB1;
        private System.Windows.Forms.PictureBox userPB2;
        private System.Windows.Forms.PictureBox userPB3;
        private System.Windows.Forms.PictureBox userPB4;
        private System.Windows.Forms.PictureBox gamePicture;
        private System.Windows.Forms.PictureBox startButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.PictureBox answerPic;
        private System.Windows.Forms.PictureBox drawing1;
        private System.Windows.Forms.PictureBox drawing2;
        private System.Windows.Forms.PictureBox drawing3;
        private System.Windows.Forms.PictureBox drawing4;
    }
}