namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    partial class frmHoaDonXuat
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
            this.dgvHoaDonXuatChiTiet = new System.Windows.Forms.DataGridView();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDonXuat = new System.Windows.Forms.DataGridView();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.Mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonXuatChiTiet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(14, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(844, 533);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn xuất hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dgvHoaDonXuatChiTiet);
            this.groupBox4.Location = new System.Drawing.Point(24, 265);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(629, 254);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chi tiết sản phẩm đã xuất";
            // 
            // dgvHoaDonXuatChiTiet
            // 
            this.dgvHoaDonXuatChiTiet.AllowUserToAddRows = false;
            this.dgvHoaDonXuatChiTiet.AllowUserToDeleteRows = false;
            this.dgvHoaDonXuatChiTiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDonXuatChiTiet.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDonXuatChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDonXuatChiTiet.ColumnHeadersHeight = 34;
            this.dgvHoaDonXuatChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonXuatChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Masp,
            this.TenSP,
            this.Malh,
            this.SL,
            this.Gianhap});
            this.dgvHoaDonXuatChiTiet.Location = new System.Drawing.Point(21, 25);
            this.dgvHoaDonXuatChiTiet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHoaDonXuatChiTiet.Name = "dgvHoaDonXuatChiTiet";
            this.dgvHoaDonXuatChiTiet.ReadOnly = true;
            this.dgvHoaDonXuatChiTiet.RowHeadersVisible = false;
            this.dgvHoaDonXuatChiTiet.RowHeadersWidth = 43;
            this.dgvHoaDonXuatChiTiet.Size = new System.Drawing.Size(586, 211);
            this.dgvHoaDonXuatChiTiet.TabIndex = 4;
            // 
            // Masp
            // 
            this.Masp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Masp.DataPropertyName = "MaHDX";
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
            this.SL.DataPropertyName = "GiaTien";
            this.SL.HeaderText = "Giá tiền";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.dgvHoaDonXuat);
            this.groupBox3.Controls.Add(this.btnXoaHoaDon);
            this.groupBox3.Controls.Add(this.btnLammoi);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(22, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(797, 227);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DS Hóa đơn";
            // 
            // dgvHoaDonXuat
            // 
            this.dgvHoaDonXuat.AllowUserToAddRows = false;
            this.dgvHoaDonXuat.AllowUserToDeleteRows = false;
            this.dgvHoaDonXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHoaDonXuat.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHoaDonXuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHoaDonXuat.ColumnHeadersHeight = 34;
            this.dgvHoaDonXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahd,
            this.Thanhtien,
            this.Manv,
            this.Ngaynhap,
            this.Column1,
            this.Column2});
            this.dgvHoaDonXuat.Location = new System.Drawing.Point(22, 20);
            this.dgvHoaDonXuat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvHoaDonXuat.Name = "dgvHoaDonXuat";
            this.dgvHoaDonXuat.ReadOnly = true;
            this.dgvHoaDonXuat.RowHeadersVisible = false;
            this.dgvHoaDonXuat.RowHeadersWidth = 43;
            this.dgvHoaDonXuat.Size = new System.Drawing.Size(668, 184);
            this.dgvHoaDonXuat.TabIndex = 0;
            this.dgvHoaDonXuat.Click += new System.EventHandler(this.dgvHoaDonXuat_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(698, 132);
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
            this.btnLammoi.Location = new System.Drawing.Point(698, 64);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(88, 23);
            this.btnLammoi.TabIndex = 1;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // Mahd
            // 
            this.Mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mahd.DataPropertyName = "MaHDX";
            this.Mahd.HeaderText = "Mã hoá đơn";
            this.Mahd.Name = "Mahd";
            this.Mahd.ReadOnly = true;
            this.Mahd.Width = 110;
            // 
            // Thanhtien
            // 
            this.Thanhtien.DataPropertyName = "MaKH";
            this.Thanhtien.HeaderText = "Mã khách hàng";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Width = 120;
            // 
            // Manv
            // 
            this.Manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Manv.DataPropertyName = "ThanhTien";
            this.Manv.HeaderText = "Thành tiền";
            this.Manv.Name = "Manv";
            this.Manv.ReadOnly = true;
            this.Manv.Width = 105;
            // 
            // Ngaynhap
            // 
            this.Ngaynhap.DataPropertyName = "ThoiGianBan";
            this.Ngaynhap.HeaderText = "Ngày bán";
            this.Ngaynhap.Name = "Ngaynhap";
            this.Ngaynhap.ReadOnly = true;
            this.Ngaynhap.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DiemTichLuy";
            this.Column2.HeaderText = "Điểm tích luỹ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // frmHoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 556);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmHoaDonXuat";
            this.Text = "frmHoaDonXuat";
            this.Load += new System.EventHandler(this.frmHoaDonXuat_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonXuatChiTiet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHoaDonXuatChiTiet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHoaDonXuat;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}