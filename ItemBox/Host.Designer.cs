namespace ItemBox
{
    partial class Host
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Host));
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.backPanel = new System.Windows.Forms.Panel();
            this.backLabel = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.Panel();
            this.okPanel = new System.Windows.Forms.Panel();
            this.okLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            this.okPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("굴림", 9F);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.comboBox.Location = new System.Drawing.Point(499, 379);
            this.comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(124, 23);
            this.comboBox.TabIndex = 6;
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.Transparent;
            this.backPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backPanel.BackgroundImage")));
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.backLabel);
            this.backPanel.Location = new System.Drawing.Point(312, 480);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(154, 68);
            this.backPanel.TabIndex = 14;
            this.backPanel.Click += new System.EventHandler(this.Back_Click);
            this.backPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.backPanel_Paint);
            this.backPanel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.backPanel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.BackColor = System.Drawing.Color.Transparent;
            this.backLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLabel.ForeColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(37, 17);
            this.backLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(97, 37);
            this.backLabel.TabIndex = 13;
            this.backLabel.Text = "BACK";
            this.backLabel.Click += new System.EventHandler(this.Back_Click);
            this.backLabel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.backLabel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // ItemBox
            // 
            this.ItemBox.BackColor = System.Drawing.Color.Transparent;
            this.ItemBox.BackgroundImage = global::ItemBox.Properties.Resources.ItemBox;
            this.ItemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemBox.Location = new System.Drawing.Point(307, 185);
            this.ItemBox.Margin = new System.Windows.Forms.Padding(2);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(419, 112);
            this.ItemBox.TabIndex = 12;
            // 
            // okPanel
            // 
            this.okPanel.BackColor = System.Drawing.Color.Transparent;
            this.okPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("okPanel.BackgroundImage")));
            this.okPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okPanel.Controls.Add(this.okLabel);
            this.okPanel.Location = new System.Drawing.Point(567, 480);
            this.okPanel.Margin = new System.Windows.Forms.Padding(2);
            this.okPanel.Name = "okPanel";
            this.okPanel.Size = new System.Drawing.Size(145, 68);
            this.okPanel.TabIndex = 9;
            this.okPanel.Click += new System.EventHandler(this.OK_Click);
            this.okPanel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.okPanel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // okLabel
            // 
            this.okLabel.AutoSize = true;
            this.okLabel.BackColor = System.Drawing.Color.Transparent;
            this.okLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.okLabel.ForeColor = System.Drawing.Color.White;
            this.okLabel.Location = new System.Drawing.Point(52, 21);
            this.okLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(55, 30);
            this.okLabel.TabIndex = 13;
            this.okLabel.Text = "OK";
            this.okLabel.Click += new System.EventHandler(this.OK_Click);
            this.okLabel.MouseEnter += new System.EventHandler(this.cursor_MouseEnter);
            this.okLabel.MouseLeave += new System.EventHandler(this.cursor_MouseLeave);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.BackColor = System.Drawing.Color.Transparent;
            this.numLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numLabel.ForeColor = System.Drawing.Color.White;
            this.numLabel.Image = ((System.Drawing.Image)(resources.GetObject("numLabel.Image")));
            this.numLabel.Location = new System.Drawing.Point(393, 373);
            this.numLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(73, 30);
            this.numLabel.TabIndex = 7;
            this.numLabel.Text = "인원";
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 625);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.okPanel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.comboBox);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Host";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ItemBox";
            this.Load += new System.EventHandler(this.Host_Load);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.okPanel.ResumeLayout(false);
            this.okPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Panel okPanel;
        private System.Windows.Forms.Panel ItemBox;
        private System.Windows.Forms.Label okLabel;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label backLabel;
    }
}