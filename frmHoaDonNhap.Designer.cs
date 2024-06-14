namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    partial class frmHoaDonNhap
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonNhapChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.Mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapChiTiet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnXoaHoaDon);
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(802, 533);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn nhập hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dgvHoaDonNhapChiTiet);
            this.groupBox4.Location = new System.Drawing.Point(22, 257);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(758, 256);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DS Sản phẩm đã nhập";
            // 
            // dgvHoaDonNhapChiTiet
            // 
            this.dgvHoaDonNhapChiTiet.AllowUserToAddRows = false;
            this.dgvHoaDonNhapChiTiet.AllowUserToDeleteRows = false;
            this.dgvHoaDonNhapChiTiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDonNhapChiTiet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDonNhapChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDonNhapChiTiet.ColumnHeadersHeight = 34;
            this.dgvHoaDonNhapChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonNhapChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.TenSP,
            this.Mancc,
            this.Malh,
            this.SL,
            this.Gianhap});
            this.dgvHoaDonNhapChiTiet.Location = new System.Drawing.Point(19, 19);
            this.dgvHoaDonNhapChiTiet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHoaDonNhapChiTiet.Name = "dgvHoaDonNhapChiTiet";
            this.dgvHoaDonNhapChiTiet.ReadOnly = true;
            this.dgvHoaDonNhapChiTiet.RowHeadersVisible = false;
            this.dgvHoaDonNhapChiTiet.RowHeadersWidth = 43;
            this.dgvHoaDonNhapChiTiet.Size = new System.Drawing.Size(731, 211);
            this.dgvHoaDonNhapChiTiet.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.dgvHoaDonNhap);
            this.groupBox3.Location = new System.Drawing.Point(25, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(552, 227);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DS Hóa đơn";
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.AllowUserToAddRows = false;
            this.dgvHoaDonNhap.AllowUserToDeleteRows = false;
            this.dgvHoaDonNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDonNhap.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDonNhap.ColumnHeadersHeight = 34;
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahd,
            this.Thanhtien,
            this.Manv,
            this.Ngaynhap});
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(18, 23);
            this.dgvHoaDonNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.ReadOnly = true;
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.RowHeadersWidth = 43;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(515, 184);
            this.dgvHoaDonNhap.TabIndex = 0;
            this.dgvHoaDonNhap.Click += new System.EventHandler(this.dgvHoaDonNhap_Click);
            // 
            // Mahd
            // 
            this.Mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mahd.DataPropertyName = "MaHDN";
            this.Mahd.HeaderText = "Mã hoá đơn";
            this.Mahd.Name = "Mahd";
            this.Mahd.ReadOnly = true;
            this.Mahd.Width = 105;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "ThanhTien";
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Width = 150;
            // 
            // Manv
            // 
            this.Manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Manv.DataPropertyName = "MaNV";
            this.Manv.HeaderText = "Mã NV";
            this.Manv.Name = "Manv";
            this.Manv.ReadOnly = true;
            this.Manv.Width = 105;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "ThoiGianNhap";
            this.Ngaynhap.HeaderText = "Ngày nhập";
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.ReadOnly = true;
            this.Ngaynhap.Width = 150;
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(644, 152);
            this.btnXoaHoaDon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(88, 23);
            this.btnXoaHoaDon.TabIndex = 3;
            this.btnXoaHoaDon.Text = "Xóa";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(644, 67);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(88, 23);
            this.btnLammoi.TabIndex = 1;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // Masp
            // 
            this.Masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Masp.DataPropertyName = "MaHDN";
            this.Masp.HeaderText = "Mã hoá đơn";
            this.Masp.Name = "Masp";
            this.Masp.ReadOnly = true;
            this.Masp.Width = 105;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSP.DataPropertyName = "MaMH";
            this.TenSP.HeaderText = "Mã mặt hàng";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 105;
            // 
            // Mancc
            // 
            this.Mancc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mancc.DataPropertyName = "MaNCC";
            this.Mancc.HeaderText = "Mã nhà cung cấp";
            this.Mancc.Name = "Mancc";
            this.Mancc.ReadOnly = true;
            this.Mancc.Width = 140;
            // 
            // Malh
            // 
            this.Malh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Malh.DataPropertyName = "SoLuong";
            this.Malh.HeaderText = "Số lượng";
            this.Malh.Name = "Malh";
            this.Malh.ReadOnly = true;
            this.Malh.Width = 105;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SL.DataPropertyName = "GiaNhap";
            this.SL.HeaderText = "Giá nhập";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 105;
            // 
            // Gianhap
            // 
            this.Gianhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gianhap.DataPropertyName = "TenMH";
            this.Gianhap.HeaderText = "Tên mặt hàng";
            this.Gianhap.Name = "Gianhap";
            this.Gianhap.ReadOnly = true;
            this.Gianhap.Width = 160;
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 556);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHoaDonNhap";
            this.Text = "frmHoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapChiTiet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHoaDonNhapChiTiet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
    }
}