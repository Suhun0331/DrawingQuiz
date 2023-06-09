namespace ItemBox
{
    partial class Select
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            this.guestPanel = new System.Windows.Forms.Panel();
            this.guestLabel = new System.Windows.Forms.Label();
            this.hostPanel = new System.Windows.Forms.Panel();
            this.hostLabel = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.Panel();
            this.guestPanel.SuspendLayout();
            this.hostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guestPanel
            // 
            this.guestPanel.BackColor = System.Drawing.Color.Transparent;
            this.guestPanel.BackgroundImage = global::ItemBox.Properties.Resources.Orange;
            this.guestPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guestPanel.Controls.Add(this.guestLabel);
            this.guestPanel.Location = new System.Drawing.Point(438, 495);
            this.guestPanel.Margin = new System.Windows.Forms.Padding(2);
            this.guestPanel.Name = "guestPanel";
            this.guestPanel.Size = new System.Drawing.Size(153, 74);
            this.guestPanel.TabIndex = 0;
            this.guestPanel.Click += new System.EventHandler(this.guest_button);
            this.guestPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.guestPanel_Paint);
            this.guestPanel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.guestPanel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.BackColor = System.Drawing.Color.Transparent;
            this.guestLabel.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guestLabel.ForeColor = System.Drawing.Color.Transparent;
            this.guestLabel.Location = new System.Drawing.Point(34, 31);
            this.guestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(90, 28);
            this.guestLabel.TabIndex = 2;
            this.guestLabel.Tag = "";
            this.guestLabel.Text = "Guest";
            this.guestLabel.Click += new System.EventHandler(this.guest_button);
            this.guestLabel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.guestLabel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // hostPanel
            // 
            this.hostPanel.BackColor = System.Drawing.Color.Transparent;
            this.hostPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hostPanel.BackgroundImage")));
            this.hostPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hostPanel.Controls.Add(this.hostLabel);
            this.hostPanel.Location = new System.Drawing.Point(440, 416);
            this.hostPanel.Margin = new System.Windows.Forms.Padding(2);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(148, 81);
            this.hostPanel.TabIndex = 0;
            this.hostPanel.Click += new System.EventHandler(this.host_button);
            this.hostPanel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.hostPanel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.BackColor = System.Drawing.Color.Transparent;
            this.hostLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hostLabel.ForeColor = System.Drawing.Color.White;
            this.hostLabel.Location = new System.Drawing.Point(39, 28);
            this.hostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(78, 30);
            this.hostLabel.TabIndex = 1;
            this.hostLabel.Tag = "";
            this.hostLabel.Text = "Host";
            this.hostLabel.Click += new System.EventHandler(this.host_button);
            this.hostLabel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.hostLabel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemBox.BackgroundImage = global::ItemBox.Properties.Resources.ItemBox;
            this.ItemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemBox.Location = new System.Drawing.Point(297, 228);
            this.ItemBox.Margin = new System.Windows.Forms.Padding(2);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(418, 131);
            this.ItemBox.TabIndex = 0;
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 587);
            this.Controls.Add(this.guestPanel);
            this.Controls.Add(this.hostPanel);
            this.Controls.Add(this.ItemBox);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ItemBox";
            this.Load += new System.EventHandler(this.Select_Load);
            this.guestPanel.ResumeLayout(false);
            this.guestPanel.PerformLayout();
            this.hostPanel.ResumeLayout(false);
            this.hostPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemBox;
        private System.Windows.Forms.Panel hostPanel;
        private System.Windows.Forms.Panel guestPanel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Label guestLabel;
    }
}

