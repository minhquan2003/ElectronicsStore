namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    partial class frmLuongNV
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
            this.dgvLuongNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.cbTenNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoNgayNghi = new System.Windows.Forms.TextBox();
            this.txtThuongThanhTich = new System.Windows.Forms.TextBox();
            this.txtSoNgayThuong = new System.Windows.Forms.TextBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.dtNgayPhatLuong = new System.Windows.Forms.DateTimePicker();
            this.txtNamKinhNghiem = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTinhtongluong = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTongLuong = new System.Windows.Forms.TextBox();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.tbThang = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimTenNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLuongNV
            // 
            this.dgvLuongNV.AllowUserToAddRows = false;
            this.dgvLuongNV.AllowUserToDeleteRows = false;
            this.dgvLuongNV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLuongNV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLuongNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLuongNV.ColumnHeadersHeight = 24;
            this.dgvLuongNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLuongNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvLuongNV.Location = new System.Drawing.Point(14, 56);
            this.dgvLuongNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvLuongNV.Name = "dgvLuongNV";
            this.dgvLuongNV.RowHeadersVisible = false;
            this.dgvLuongNV.RowHeadersWidth = 43;
            this.dgvLuongNV.Size = new System.Drawing.Size(1114, 305);
            this.dgvLuongNV.TabIndex = 0;
            this.dgvLuongNV.DoubleClick += new System.EventHandler(this.dgvLuongNV_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayPhatLuong";
            this.Column2.HeaderText = "Ngày phát lương";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNV";
            this.Column3.HeaderText = "Tên nhân viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NamKinhNghiem";
            this.Column4.HeaderText = "Năm kinh nghiệm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HeSoLuong";
            this.Column5.HeaderText = "Hệ số lương";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 105;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoNgayThuong";
            this.Column6.HeaderText = "Số ngày thưởng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 105;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ThuongThanhTich";
            this.Column7.HeaderText = "Thưởng thành tích";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 140;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SoNgayNghi";
            this.Column8.HeaderText = "Số ngày nghỉ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 105;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Luong";
            this.Column9.HeaderText = "Lương";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 130;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.cbTenNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoNgayNghi);
            this.groupBox1.Controls.Add(this.txtThuongThanhTich);
            this.groupBox1.Controls.Add(this.txtSoNgayThuong);
            this.groupBox1.Controls.Add(this.txtHeSoLuong);
            this.groupBox1.Controls.Add(this.dtNgayPhatLuong);
            this.groupBox1.Controls.Add(this.txtNamKinhNghiem);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.kabel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1156, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày phát lương:";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(932, 88);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(116, 20);
            this.txtLuong.TabIndex = 17;
            // 
            // cbTenNV
            // 
            this.cbTenNV.FormattingEnabled = true;
            this.cbTenNV.Location = new System.Drawing.Point(203, 17);
            this.cbTenNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTenNV.Name = "cbTenNV";
            this.cbTenNV.Size = new System.Drawing.Size(195, 21);
            this.cbTenNV.TabIndex = 11;
            this.cbTenNV.SelectedIndexChanged += new System.EventHandler(this.cbTenNV_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên nhân viên:";
            // 
            // txtSoNgayNghi
            // 
            this.txtSoNgayNghi.Location = new System.Drawing.Point(932, 51);
            this.txtSoNgayNghi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoNgayNghi.Name = "txtSoNgayNghi";
            this.txtSoNgayNghi.Size = new System.Drawing.Size(116, 20);
            this.txtSoNgayNghi.TabIndex = 16;
            // 
            // txtThuongThanhTich
            // 
            this.txtThuongThanhTich.Location = new System.Drawing.Point(932, 18);
            this.txtThuongThanhTich.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThuongThanhTich.Name = "txtThuongThanhTich";
            this.txtThuongThanhTich.Size = new System.Drawing.Size(116, 20);
            this.txtThuongThanhTich.TabIndex = 15;
            this.txtThuongThanhTich.TextChanged += new System.EventHandler(this.txtThuongThanhTich_TextChanged);
            // 
            // txtSoNgayThuong
            // 
            this.txtSoNgayThuong.Location = new System.Drawing.Point(574, 92);
            this.txtSoNgayThuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSoNgayThuong.Name = "txtSoNgayThuong";
            this.txtSoNgayThuong.Size = new System.Drawing.Size(138, 20);
            this.txtSoNgayThuong.TabIndex = 14;
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(574, 51);
            this.txtHeSoLuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(138, 20);
            this.txtHeSoLuong.TabIndex = 13;
            // 
            // dtNgayPhatLuong
            // 
            this.dtNgayPhatLuong.Location = new System.Drawing.Point(203, 51);
            this.dtNgayPhatLuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtNgayPhatLuong.Name = "dtNgayPhatLuong";
            this.dtNgayPhatLuong.Size = new System.Drawing.Size(195, 20);
            this.dtNgayPhatLuong.TabIndex = 12;
            // 
            // txtNamKinhNghiem
            // 
            this.txtNamKinhNghiem.Location = new System.Drawing.Point(574, 18);
            this.txtNamKinhNghiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNamKinhNghiem.Name = "txtNamKinhNghiem";
            this.txtNamKinhNghiem.Size = new System.Drawing.Size(138, 20);
            this.txtNamKinhNghiem.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(203, 88);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(195, 20);
            this.txtMaNV.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(810, 93);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Lương:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(810, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số ngày nghỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(810, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thưởng thành tích:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số ngày thưởng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Năm kinh nghiệm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hệ số lương:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            this.label3.Tag = "Ngày phát lương";
            // 
            // kabel1
            // 
            this.kabel1.AutoSize = true;
            this.kabel1.Location = new System.Drawing.Point(77, 91);
            this.kabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kabel1.Name = "kabel1";
            this.kabel1.Size = new System.Drawing.Size(84, 13);
            this.kabel1.TabIndex = 0;
            this.kabel1.Text = "Mã nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnTinhtongluong);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbTongLuong);
            this.groupBox2.Controls.Add(this.tbNam);
            this.groupBox2.Controls.Add(this.tbThang);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbTimTenNV);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.dgvLuongNV);
            this.groupBox2.Location = new System.Drawing.Point(14, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1156, 376);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lương nhân viên";
            // 
            // btnTinhtongluong
            // 
            this.btnTinhtongluong.Location = new System.Drawing.Point(931, 27);
            this.btnTinhtongluong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTinhtongluong.Name = "btnTinhtongluong";
            this.btnTinhtongluong.Size = new System.Drawing.Size(65, 23);
            this.btnTinhtongluong.TabIndex = 26;
            this.btnTinhtongluong.Text = "Tính:";
            this.btnTinhtongluong.UseVisualStyleBackColor = true;
            this.btnTinhtongluong.Click += new System.EventHandler(this.btnTinhtongluong_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(794, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Năm:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(660, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tháng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(643, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Tính tổng lương theo tháng";
            // 
            // tbTongLuong
            // 
            this.tbTongLuong.Location = new System.Drawing.Point(1004, 28);
            this.tbTongLuong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTongLuong.Name = "tbTongLuong";
            this.tbTongLuong.Size = new System.Drawing.Size(135, 20);
            this.tbTongLuong.TabIndex = 23;
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(833, 28);
            this.tbNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(61, 20);
            this.tbNam.TabIndex = 22;
            // 
            // tbThang
            // 
            this.tbThang.Location = new System.Drawing.Point(710, 28);
            this.tbThang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbThang.Name = "tbThang";
            this.tbThang.Size = new System.Drawing.Size(61, 20);
            this.tbThang.TabIndex = 21;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(530, 23);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm theo tên:";
            // 
            // tbTimTenNV
            // 
            this.tbTimTenNV.Location = new System.Drawing.Point(99, 23);
            this.tbTimTenNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTimTenNV.Name = "tbTimTenNV";
            this.tbTimTenNV.Size = new System.Drawing.Size(223, 20);
            this.tbTimTenNV.TabIndex = 5;
            this.tbTimTenNV.TextChanged += new System.EventHandler(this.tbTimTenNV_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(435, 23);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(341, 23);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Tải lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLuongNV";
            this.Text = "frmLuongNV";
            this.Load += new System.EventHandler(this.frmLuongNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLuongNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtSoNgayNghi;
        private System.Windows.Forms.TextBox txtThuongThanhTich;
        private System.Windows.Forms.TextBox txtSoNgayThuong;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.DateTimePicker dtNgayPhatLuong;
        private System.Windows.Forms.ComboBox cbTenNV;
        private System.Windows.Forms.TextBox txtNamKinhNghiem;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimTenNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTongLuong;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.Button btnTinhtongluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}