namespace formDangnhap
{
    partial class formQuanliphong
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
            this.components = new System.ComponentModel.Container();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuyluusan = new System.Windows.Forms.Button();
            this.btnLuusan = new System.Windows.Forms.Button();
            this.btnSuasan = new System.Windows.Forms.Button();
            this.btnXoasan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbThongtin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtTensan = new System.Windows.Forms.TextBox();
            this.txtLoaisan = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.labelTrangthai = new System.Windows.Forms.Label();
            this.labelLoaiphong = new System.Windows.Forms.Label();
            this.labelTenphong = new System.Windows.Forms.Label();
            this.labelMaphong = new System.Windows.Forms.Label();
            this.qLSBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).BeginInit();
            this.gbThongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(560, 157);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 40);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuyluusan
            // 
            this.btnHuyluusan.Enabled = false;
            this.btnHuyluusan.Location = new System.Drawing.Point(936, 157);
            this.btnHuyluusan.Name = "btnHuyluusan";
            this.btnHuyluusan.Size = new System.Drawing.Size(88, 40);
            this.btnHuyluusan.TabIndex = 12;
            this.btnHuyluusan.Text = "Huỷ lưu";
            this.btnHuyluusan.UseVisualStyleBackColor = true;
            // 
            // btnLuusan
            // 
            this.btnLuusan.Enabled = false;
            this.btnLuusan.Location = new System.Drawing.Point(842, 157);
            this.btnLuusan.Name = "btnLuusan";
            this.btnLuusan.Size = new System.Drawing.Size(88, 40);
            this.btnLuusan.TabIndex = 11;
            this.btnLuusan.Text = "Lưu";
            this.btnLuusan.UseVisualStyleBackColor = true;
            // 
            // btnSuasan
            // 
            this.btnSuasan.Location = new System.Drawing.Point(748, 157);
            this.btnSuasan.Name = "btnSuasan";
            this.btnSuasan.Size = new System.Drawing.Size(88, 40);
            this.btnSuasan.TabIndex = 10;
            this.btnSuasan.Text = "Sửa";
            this.btnSuasan.UseVisualStyleBackColor = true;
            // 
            // btnXoasan
            // 
            this.btnXoasan.Location = new System.Drawing.Point(654, 157);
            this.btnXoasan.Name = "btnXoasan";
            this.btnXoasan.Size = new System.Drawing.Size(88, 40);
            this.btnXoasan.TabIndex = 9;
            this.btnXoasan.Text = "Xoá";
            this.btnXoasan.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.sanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1030, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // sanBindingSource
            // 
            this.sanBindingSource.DataMember = "San";
            // 
            // gbThongtin
            // 
            this.gbThongtin.Controls.Add(this.dataGridView1);
            this.gbThongtin.Controls.Add(this.groupBox1);
            this.gbThongtin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtin.Location = new System.Drawing.Point(12, 12);
            this.gbThongtin.Name = "gbThongtin";
            this.gbThongtin.Size = new System.Drawing.Size(1139, 597);
            this.gbThongtin.TabIndex = 2;
            this.gbThongtin.TabStop = false;
            this.gbThongtin.Text = "Thông tin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnHuyluusan);
            this.groupBox1.Controls.Add(this.btnLuusan);
            this.groupBox1.Controls.Add(this.btnSuasan);
            this.groupBox1.Controls.Add(this.btnXoasan);
            this.groupBox1.Controls.Add(this.txtTrangthai);
            this.groupBox1.Controls.Add(this.txtTensan);
            this.groupBox1.Controls.Add(this.txtLoaisan);
            this.groupBox1.Controls.Add(this.txtMaphong);
            this.groupBox1.Controls.Add(this.labelTrangthai);
            this.groupBox1.Controls.Add(this.labelLoaiphong);
            this.groupBox1.Controls.Add(this.labelTenphong);
            this.groupBox1.Controls.Add(this.labelMaphong);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(642, 84);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(338, 26);
            this.txtTrangthai.TabIndex = 7;
            // 
            // txtTensan
            // 
            this.txtTensan.Location = new System.Drawing.Point(642, 22);
            this.txtTensan.Name = "txtTensan";
            this.txtTensan.Size = new System.Drawing.Size(338, 26);
            this.txtTensan.TabIndex = 5;
            this.txtTensan.TextChanged += new System.EventHandler(this.txtTensan_TextChanged);
            // 
            // txtLoaisan
            // 
            this.txtLoaisan.Location = new System.Drawing.Point(102, 94);
            this.txtLoaisan.Name = "txtLoaisan";
            this.txtLoaisan.Size = new System.Drawing.Size(338, 26);
            this.txtLoaisan.TabIndex = 6;
            this.txtLoaisan.TextChanged += new System.EventHandler(this.txtLoaisan_TextChanged);
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(102, 22);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(338, 26);
            this.txtMaphong.TabIndex = 4;
            // 
            // labelTrangthai
            // 
            this.labelTrangthai.AutoSize = true;
            this.labelTrangthai.Location = new System.Drawing.Point(541, 87);
            this.labelTrangthai.Name = "labelTrangthai";
            this.labelTrangthai.Size = new System.Drawing.Size(80, 18);
            this.labelTrangthai.TabIndex = 3;
            this.labelTrangthai.Text = "Trạng thái:";
            this.labelTrangthai.Click += new System.EventHandler(this.labelTrangthai_Click);
            // 
            // labelLoaiphong
            // 
            this.labelLoaiphong.AutoSize = true;
            this.labelLoaiphong.Location = new System.Drawing.Point(6, 97);
            this.labelLoaiphong.Name = "labelLoaiphong";
            this.labelLoaiphong.Size = new System.Drawing.Size(90, 18);
            this.labelLoaiphong.TabIndex = 2;
            this.labelLoaiphong.Text = "Loại phòng:";
            this.labelLoaiphong.Click += new System.EventHandler(this.labelLoaisan_Click);
            // 
            // labelTenphong
            // 
            this.labelTenphong.AutoSize = true;
            this.labelTenphong.Location = new System.Drawing.Point(536, 25);
            this.labelTenphong.Name = "labelTenphong";
            this.labelTenphong.Size = new System.Drawing.Size(85, 18);
            this.labelTenphong.TabIndex = 1;
            this.labelTenphong.Text = "Tên phòng:";
            // 
            // labelMaphong
            // 
            this.labelMaphong.AutoSize = true;
            this.labelMaphong.Location = new System.Drawing.Point(15, 22);
            this.labelMaphong.Name = "labelMaphong";
            this.labelMaphong.Size = new System.Drawing.Size(81, 18);
            this.labelMaphong.TabIndex = 0;
            this.labelMaphong.Text = "Mã phòng:";
            // 
            // formQuanliphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 621);
            this.Controls.Add(this.gbThongtin);
            this.Name = "formQuanliphong";
            this.Text = "Quản lý phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).EndInit();
            this.gbThongtin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource qLSBDataSetBindingSource;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuyluusan;
        private System.Windows.Forms.Button btnLuusan;
        private System.Windows.Forms.Button btnSuasan;
        private System.Windows.Forms.Button btnXoasan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sanBindingSource;
        private System.Windows.Forms.GroupBox gbThongtin;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtTensan;
        private System.Windows.Forms.TextBox txtLoaisan;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Label labelTrangthai;
        private System.Windows.Forms.Label labelLoaiphong;
        private System.Windows.Forms.Label labelTenphong;
        private System.Windows.Forms.Label labelMaphong;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}