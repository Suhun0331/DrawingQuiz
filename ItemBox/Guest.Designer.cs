namespace ItemBox
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            this.room3 = new System.Windows.Forms.Panel();
            this.max_user3 = new System.Windows.Forms.Label();
            this.userCount3 = new System.Windows.Forms.Label();
            this.lbl_max3 = new System.Windows.Forms.Label();
            this.count3 = new System.Windows.Forms.Label();
            this.roomList3 = new System.Windows.Forms.Label();
            this.room2 = new System.Windows.Forms.Panel();
            this.max_user2 = new System.Windows.Forms.Label();
            this.userCount2 = new System.Windows.Forms.Label();
            this.lbl_max2 = new System.Windows.Forms.Label();
            this.count2 = new System.Windows.Forms.Label();
            this.roomList2 = new System.Windows.Forms.Label();
            this.room1 = new System.Windows.Forms.Panel();
            this.max_user1 = new System.Windows.Forms.Label();
            this.userCount1 = new System.Windows.Forms.Label();
            this.lbl_max1 = new System.Windows.Forms.Label();
            this.count1 = new System.Windows.Forms.Label();
            this.roomList1 = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.backLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.room3.SuspendLayout();
            this.room2.SuspendLayout();
            this.room1.SuspendLayout();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // room3
            // 
            this.room3.BackColor = System.Drawing.Color.Transparent;
            this.room3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("room3.BackgroundImage")));
            this.room3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room3.Controls.Add(this.max_user3);
            this.room3.Controls.Add(this.userCount3);
            this.room3.Controls.Add(this.lbl_max3);
            this.room3.Controls.Add(this.count3);
            this.room3.Controls.Add(this.roomList3);
            this.room3.Location = new System.Drawing.Point(272, 371);
            this.room3.Margin = new System.Windows.Forms.Padding(2);
            this.room3.Name = "room3";
            this.room3.Size = new System.Drawing.Size(474, 68);
            this.room3.TabIndex = 23;
            this.room3.Click += new System.EventHandler(this.select_room);
            // 
            // max_user3
            // 
            this.max_user3.AutoSize = true;
            this.max_user3.Location = new System.Drawing.Point(419, 20);
            this.max_user3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_user3.Name = "max_user3";
            this.max_user3.Size = new System.Drawing.Size(0, 15);
            this.max_user3.TabIndex = 26;
            this.max_user3.Click += new System.EventHandler(this.select_room);
            // 
            // userCount3
            // 
            this.userCount3.AutoSize = true;
            this.userCount3.Location = new System.Drawing.Point(401, 20);
            this.userCount3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userCount3.Name = "userCount3";
            this.userCount3.Size = new System.Drawing.Size(13, 15);
            this.userCount3.TabIndex = 22;
            this.userCount3.Text = "/";
            this.userCount3.Click += new System.EventHandler(this.select_room);
            // 
            // lbl_max3
            // 
            this.lbl_max3.AutoSize = true;
            this.lbl_max3.Location = new System.Drawing.Point(422, 20);
            this.lbl_max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max3.Name = "lbl_max3";
            this.lbl_max3.Size = new System.Drawing.Size(0, 15);
            this.lbl_max3.TabIndex = 3;
            this.lbl_max3.Click += new System.EventHandler(this.select_room);
            // 
            // count3
            // 
            this.count3.AutoSize = true;
            this.count3.BackColor = System.Drawing.Color.Transparent;
            this.count3.ForeColor = System.Drawing.Color.Black;
            this.count3.Location = new System.Drawing.Point(383, 20);
            this.count3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count3.Name = "count3";
            this.count3.Size = new System.Drawing.Size(0, 15);
            this.count3.TabIndex = 3;
            this.count3.Click += new System.EventHandler(this.select_room);
            // 
            // roomList3
            // 
            this.roomList3.AutoSize = true;
            this.roomList3.BackColor = System.Drawing.Color.Transparent;
            this.roomList3.ForeColor = System.Drawing.Color.Black;
            this.roomList3.Location = new System.Drawing.Point(88, 20);
            this.roomList3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomList3.Name = "roomList3";
            this.roomList3.Size = new System.Drawing.Size(107, 15);
            this.roomList3.TabIndex = 2;
            this.roomList3.Text = "방이 없습니다.";
            this.roomList3.Click += new System.EventHandler(this.select_room);
            // 
            // room2
            // 
            this.room2.BackColor = System.Drawing.Color.Transparent;
            this.room2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("room2.BackgroundImage")));
            this.room2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room2.Controls.Add(this.max_user2);
            this.room2.Controls.Add(this.userCount2);
            this.room2.Controls.Add(this.lbl_max2);
            this.room2.Controls.Add(this.count2);
            this.room2.Controls.Add(this.roomList2);
            this.room2.Location = new System.Drawing.Point(272, 272);
            this.room2.Margin = new System.Windows.Forms.Padding(2);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(474, 68);
            this.room2.TabIndex = 22;
            this.room2.Click += new System.EventHandler(this.select_room);
            // 
            // max_user2
            // 
            this.max_user2.AutoSize = true;
            this.max_user2.Location = new System.Drawing.Point(419, 22);
            this.max_user2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_user2.Name = "max_user2";
            this.max_user2.Size = new System.Drawing.Size(0, 15);
            this.max_user2.TabIndex = 25;
            this.max_user2.Click += new System.EventHandler(this.select_room);
            // 
            // userCount2
            // 
            this.userCount2.AutoSize = true;
            this.userCount2.Location = new System.Drawing.Point(402, 22);
            this.userCount2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userCount2.Name = "userCount2";
            this.userCount2.Size = new System.Drawing.Size(13, 15);
            this.userCount2.TabIndex = 21;
            this.userCount2.Text = "/";
            this.userCount2.Click += new System.EventHandler(this.select_room);
            // 
            // lbl_max2
            // 
            this.lbl_max2.AutoSize = true;
            this.lbl_max2.Location = new System.Drawing.Point(422, 22);
            this.lbl_max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max2.Name = "lbl_max2";
            this.lbl_max2.Size = new System.Drawing.Size(0, 15);
            this.lbl_max2.TabIndex = 3;
            this.lbl_max2.Click += new System.EventHandler(this.select_room);
            // 
            // count2
            // 
            this.count2.AutoSize = true;
            this.count2.BackColor = System.Drawing.Color.Transparent;
            this.count2.ForeColor = System.Drawing.Color.Black;
            this.count2.Location = new System.Drawing.Point(383, 22);
            this.count2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count2.Name = "count2";
            this.count2.Size = new System.Drawing.Size(0, 15);
            this.count2.TabIndex = 2;
            this.count2.Click += new System.EventHandler(this.select_room);
            // 
            // roomList2
            // 
            this.roomList2.AutoSize = true;
            this.roomList2.BackColor = System.Drawing.Color.Transparent;
            this.roomList2.ForeColor = System.Drawing.Color.Black;
            this.roomList2.Location = new System.Drawing.Point(88, 22);
            this.roomList2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomList2.Name = "roomList2";
            this.roomList2.Size = new System.Drawing.Size(107, 15);
            this.roomList2.TabIndex = 1;
            this.roomList2.Text = "방이 없습니다.";
            this.roomList2.Click += new System.EventHandler(this.select_room);
            // 
            // room1
            // 
            this.room1.BackColor = System.Drawing.Color.Transparent;
            this.room1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("room1.BackgroundImage")));
            this.room1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.room1.Controls.Add(this.max_user1);
            this.room1.Controls.Add(this.userCount1);
            this.room1.Controls.Add(this.lbl_max1);
            this.room1.Controls.Add(this.count1);
            this.room1.Controls.Add(this.roomList1);
            this.room1.Location = new System.Drawing.Point(272, 175);
            this.room1.Margin = new System.Windows.Forms.Padding(2);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(474, 68);
            this.room1.TabIndex = 21;
            this.room1.Click += new System.EventHandler(this.select_room);
            // 
            // max_user1
            // 
            this.max_user1.AutoSize = true;
            this.max_user1.Location = new System.Drawing.Point(419, 22);
            this.max_user1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.max_user1.Name = "max_user1";
            this.max_user1.Size = new System.Drawing.Size(0, 15);
            this.max_user1.TabIndex = 24;
            this.max_user1.Click += new System.EventHandler(this.select_room);
            // 
            // userCount1
            // 
            this.userCount1.AutoSize = true;
            this.userCount1.Location = new System.Drawing.Point(402, 22);
            this.userCount1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userCount1.Name = "userCount1";
            this.userCount1.Size = new System.Drawing.Size(13, 15);
            this.userCount1.TabIndex = 20;
            this.userCount1.Text = "/";
            this.userCount1.Click += new System.EventHandler(this.select_room);
            // 
            // lbl_max1
            // 
            this.lbl_max1.AutoSize = true;
            this.lbl_max1.Location = new System.Drawing.Point(422, 22);
            this.lbl_max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max1.Name = "lbl_max1";
            this.lbl_max1.Size = new System.Drawing.Size(0, 15);
            this.lbl_max1.TabIndex = 2;
            this.lbl_max1.Click += new System.EventHandler(this.select_room);
            // 
            // count1
            // 
            this.count1.AutoSize = true;
            this.count1.BackColor = System.Drawing.Color.Transparent;
            this.count1.ForeColor = System.Drawing.Color.Black;
            this.count1.Location = new System.Drawing.Point(383, 22);
            this.count1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count1.Name = "count1";
            this.count1.Size = new System.Drawing.Size(0, 15);
            this.count1.TabIndex = 1;
            this.count1.Click += new System.EventHandler(this.select_room);
            // 
            // roomList1
            // 
            this.roomList1.AutoSize = true;
            this.roomList1.BackColor = System.Drawing.Color.Transparent;
            this.roomList1.ForeColor = System.Drawing.Color.Black;
            this.roomList1.Location = new System.Drawing.Point(88, 22);
            this.roomList1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomList1.Name = "roomList1";
            this.roomList1.Size = new System.Drawing.Size(107, 15);
            this.roomList1.TabIndex = 0;
            this.roomList1.Text = "방이 없습니다.";
            this.roomList1.Click += new System.EventHandler(this.select_room);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.BackgroundImage = global::ItemBox.Properties.Resources.Blue;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.backLabel);
            this.backPanel.Location = new System.Drawing.Point(421, 497);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(159, 67);
            this.backPanel.TabIndex = 16;
            this.backPanel.Click += new System.EventHandler(this.Back_Click);
            this.backPanel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.backPanel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.backLabel.ForeColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(41, 25);
            this.backLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(93, 30);
            this.backLabel.TabIndex = 13;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.Back_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ItemBox.Properties.Resources.ItemBox;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(272, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 117);
            this.panel1.TabIndex = 5;
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 658);
            this.Controls.Add(this.room3);
            this.Controls.Add(this.room2);
            this.Controls.Add(this.room1);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ItemBox";
            this.Load += new System.EventHandler(this.Guest_Load);
            this.room3.ResumeLayout(false);
            this.room3.PerformLayout();
            this.room2.ResumeLayout(false);
            this.room2.PerformLayout();
            this.room1.ResumeLayout(false);
            this.room1.PerformLayout();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel room3;
        private System.Windows.Forms.Label userCount3;
        private System.Windows.Forms.Label lbl_max3;
        private System.Windows.Forms.Label count3;
        private System.Windows.Forms.Label roomList3;
        private System.Windows.Forms.Panel room2;
        private System.Windows.Forms.Label userCount2;
        private System.Windows.Forms.Label lbl_max2;
        private System.Windows.Forms.Label count2;
        private System.Windows.Forms.Label roomList2;
        private System.Windows.Forms.Panel room1;
        private System.Windows.Forms.Label userCount1;
        private System.Windows.Forms.Label lbl_max1;
        private System.Windows.Forms.Label count1;
        private System.Windows.Forms.Label roomList1;
        private System.Windows.Forms.Label max_user3;
        private System.Windows.Forms.Label max_user2;
        private System.Windows.Forms.Label max_user1;
    }
}