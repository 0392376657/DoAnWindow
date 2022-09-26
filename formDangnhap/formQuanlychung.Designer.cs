namespace formDangnhap
{
    partial class formQuanlychung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuanlychung));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDoimatkhau = new System.Windows.Forms.ToolStripButton();
            this.tsbDatphong = new System.Windows.Forms.ToolStripButton();
            this.tsbThanhtoan = new System.Windows.Forms.ToolStripButton();
            this.tsbQuanliphong = new System.Windows.Forms.ToolStripButton();
            this.tsbThongke = new System.Windows.Forms.ToolStripButton();
            this.tsbTrogiup = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 41);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDoimatkhau,
            this.tsbDatphong,
            this.tsbThanhtoan,
            this.tsbQuanliphong,
            this.tsbThongke,
            this.tsbTrogiup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1165, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDoimatkhau
            // 
            this.tsbDoimatkhau.Image = ((System.Drawing.Image)(resources.GetObject("tsbDoimatkhau.Image")));
            this.tsbDoimatkhau.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDoimatkhau.Name = "tsbDoimatkhau";
            this.tsbDoimatkhau.Size = new System.Drawing.Size(82, 35);
            this.tsbDoimatkhau.Text = "Đổi mật khẩu";
            this.tsbDoimatkhau.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbDoimatkhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDoimatkhau.Click += new System.EventHandler(this.tsbDoimatkhau_Click);
            // 
            // tsbDatphong
            // 
            this.tsbDatphong.Image = ((System.Drawing.Image)(resources.GetObject("tsbDatphong.Image")));
            this.tsbDatphong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDatphong.Name = "tsbDatphong";
            this.tsbDatphong.Size = new System.Drawing.Size(67, 35);
            this.tsbDatphong.Text = "Đặt phòng";
            this.tsbDatphong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbThanhtoan
            // 
            this.tsbThanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("tsbThanhtoan.Image")));
            this.tsbThanhtoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThanhtoan.Name = "tsbThanhtoan";
            this.tsbThanhtoan.Size = new System.Drawing.Size(71, 35);
            this.tsbThanhtoan.Text = "Thanh toán";
            this.tsbThanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbQuanliphong
            // 
            this.tsbQuanliphong.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuanliphong.Image")));
            this.tsbQuanliphong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuanliphong.Name = "tsbQuanliphong";
            this.tsbQuanliphong.Size = new System.Drawing.Size(87, 35);
            this.tsbQuanliphong.Text = "Quản lí phòng";
            this.tsbQuanliphong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbThongke
            // 
            this.tsbThongke.Image = ((System.Drawing.Image)(resources.GetObject("tsbThongke.Image")));
            this.tsbThongke.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThongke.Name = "tsbThongke";
            this.tsbThongke.Size = new System.Drawing.Size(60, 35);
            this.tsbThongke.Text = "Thống kê";
            this.tsbThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbTrogiup
            // 
            this.tsbTrogiup.Image = ((System.Drawing.Image)(resources.GetObject("tsbTrogiup.Image")));
            this.tsbTrogiup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTrogiup.Name = "tsbTrogiup";
            this.tsbTrogiup.Size = new System.Drawing.Size(54, 35);
            this.tsbTrogiup.Text = "Trợ giúp";
            this.tsbTrogiup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hệ thống",
            "Đổi mật khẩu"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 17);
            this.listBox1.TabIndex = 0;
            // 
            // formQuanlychung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1163, 636);
            this.Controls.Add(this.panel1);
            this.Name = "formQuanlychung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chung";
            this.Load += new System.EventHandler(this.Quanlichung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbDoimatkhau;
        private System.Windows.Forms.ToolStripButton tsbDatphong;
        private System.Windows.Forms.ToolStripButton tsbThanhtoan;
        private System.Windows.Forms.ToolStripButton tsbQuanliphong;
        private System.Windows.Forms.ToolStripButton tsbThongke;
        private System.Windows.Forms.ToolStripButton tsbTrogiup;
    }
}