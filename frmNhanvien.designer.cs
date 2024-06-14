namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTimTheoMaNV = new System.Windows.Forms.RadioButton();
            this.rbTimTheoChucVu = new System.Windows.Forms.RadioButton();
            this.rbTimTheoQuyen = new System.Windows.Forms.RadioButton();
            this.rbTimTheoTen = new System.Windows.Forms.RadioButton();
            this.tbTimten = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtgShow2 = new System.Windows.Forms.DataGridView();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mucluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaTK = new System.Windows.Forms.ComboBox();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnXemMaCV = new System.Windows.Forms.Button();
            this.cbQuyen = new System.Windows.Forms.ComboBox();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.dtNgaylam = new System.Windows.Forms.DateTimePicker();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.tbTennv = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbMucluong = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbManv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow2)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbTimTheoMaNV);
            this.groupBox1.Controls.Add(this.rbTimTheoChucVu);
            this.groupBox1.Controls.Add(this.rbTimTheoQuyen);
            this.groupBox1.Controls.Add(this.rbTimTheoTen);
            this.groupBox1.Controls.Add(this.tbTimten);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.dtgShow2);
            this.groupBox1.Location = new System.Drawing.Point(4, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1336, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // rbTimTheoMaNV
            // 
            this.rbTimTheoMaNV.AutoSize = true;
            this.rbTimTheoMaNV.Location = new System.Drawing.Point(35, 17);
            this.rbTimTheoMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.rbTimTheoMaNV.Name = "rbTimTheoMaNV";
            this.rbTimTheoMaNV.Size = new System.Drawing.Size(115, 17);
            this.rbTimTheoMaNV.TabIndex = 8;
            this.rbTimTheoMaNV.TabStop = true;
            this.rbTimTheoMaNV.Text = "Tìm theo mã NV";
            this.rbTimTheoMaNV.UseVisualStyleBackColor = true;
            // 
            // rbTimTheoChucVu
            // 
            this.rbTimTheoChucVu.AutoSize = true;
            this.rbTimTheoChucVu.Location = new System.Drawing.Point(164, 38);
            this.rbTimTheoChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.rbTimTheoChucVu.Name = "rbTimTheoChucVu";
            this.rbTimTheoChucVu.Size = new System.Drawing.Size(124, 17);
            this.rbTimTheoChucVu.TabIndex = 7;
            this.rbTimTheoChucVu.TabStop = true;
            this.rbTimTheoChucVu.Text = "Tìm theo chức vụ";
            this.rbTimTheoChucVu.UseVisualStyleBackColor = true;
            // 
            // rbTimTheoQuyen
            // 
            this.rbTimTheoQuyen.AutoSize = true;
            this.rbTimTheoQuyen.Location = new System.Drawing.Point(164, 17);
            this.rbTimTheoQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.rbTimTheoQuyen.Name = "rbTimTheoQuyen";
            this.rbTimTheoQuyen.Size = new System.Drawing.Size(112, 17);
            this.rbTimTheoQuyen.TabIndex = 6;
            this.rbTimTheoQuyen.TabStop = true;
            this.rbTimTheoQuyen.Text = "Tìm theo quyền";
            this.rbTimTheoQuyen.UseVisualStyleBackColor = true;
            // 
            // rbTimTheoTen
            // 
            this.rbTimTheoTen.AutoSize = true;
            this.rbTimTheoTen.Location = new System.Drawing.Point(35, 38);
            this.rbTimTheoTen.Margin = new System.Windows.Forms.Padding(2);
            this.rbTimTheoTen.Name = "rbTimTheoTen";
            this.rbTimTheoTen.Size = new System.Drawing.Size(96, 17);
            this.rbTimTheoTen.TabIndex = 5;
            this.rbTimTheoTen.TabStop = true;
            this.rbTimTheoTen.Text = "Tìm theo tên";
            this.rbTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // tbTimten
            // 
            this.tbTimten.Location = new System.Drawing.Point(399, 24);
            this.tbTimten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTimten.Name = "tbTimten";
            this.tbTimten.Size = new System.Drawing.Size(235, 20);
            this.tbTimten.TabIndex = 3;
            this.tbTimten.TextChanged += new System.EventHandler(this.tbTimten_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(296, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nhập thông tin:";
            // 
            // tbnDelete
            // 
            this.tbnDelete.Location = new System.Drawing.Point(1224, 19);
            this.tbnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbnDelete.Name = "tbnDelete";
            this.tbnDelete.Size = new System.Drawing.Size(88, 23);
            this.tbnDelete.TabIndex = 1;
            this.tbnDelete.Text = "Xóa";
            this.tbnDelete.UseVisualStyleBackColor = true;
            this.tbnDelete.Click += new System.EventHandler(this.tbnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1108, 19);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(986, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(740, 19);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtgShow2
            // 
            this.dtgShow2.AllowUserToAddRows = false;
            this.dtgShow2.AllowUserToDeleteRows = false;
            this.dtgShow2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgShow2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgShow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgShow2.ColumnHeadersHeight = 35;
            this.dtgShow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgShow2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manv,
            this.TenNV,
            this.Gioitinh,
            this.Ngaysinh,
            this.Diachi,
            this.Sdt,
            this.Ngaylam,
            this.Chucvu,
            this.Mucluong,
            this.Taikhoan,
            this.Quyen});
            this.dtgShow2.Location = new System.Drawing.Point(19, 61);
            this.dtgShow2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgShow2.Name = "dtgShow2";
            this.dtgShow2.ReadOnly = true;
            this.dtgShow2.RowHeadersVisible = false;
            this.dtgShow2.RowHeadersWidth = 43;
            this.dtgShow2.Size = new System.Drawing.Size(1293, 333);
            this.dtgShow2.TabIndex = 0;
            this.dtgShow2.DoubleClick += new System.EventHandler(this.dtgShow2_DoubleClick);
            // 
            // Manv
            // 
            this.Manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Manv.DataPropertyName = "MaNV";
            this.Manv.HeaderText = "Mã NV";
            this.Manv.MinimumWidth = 6;
            this.Manv.Name = "Manv";
            this.Manv.ReadOnly = true;
            this.Manv.Width = 90;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "HoTen";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 140;
            // 
            // Gioitinh
            // 
            this.Gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gioitinh.DataPropertyName = "GioiTinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.ReadOnly = true;
            this.Gioitinh.Width = 105;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "NgaySinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Width = 101;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "DiaChi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 150;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "SĐT";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            this.Sdt.Width = 101;
            // 
            // Ngaylam
            // 
            this.Ngaylam.DataPropertyName = "NgayVaoLam";
            this.Ngaylam.HeaderText = "Ngày vào làm";
            this.Ngaylam.MinimumWidth = 6;
            this.Ngaylam.Name = "Ngaylam";
            this.Ngaylam.ReadOnly = true;
            this.Ngaylam.Width = 150;
            // 
            // Chucvu
            // 
            this.Chucvu.DataPropertyName = "MaCV";
            this.Chucvu.HeaderText = "Mã chức vụ";
            this.Chucvu.MinimumWidth = 6;
            this.Chucvu.Name = "Chucvu";
            this.Chucvu.ReadOnly = true;
            this.Chucvu.Width = 110;
            // 
            // Mucluong
            // 
            this.Mucluong.DataPropertyName = "MucLuong";
            this.Mucluong.HeaderText = "Mức lương";
            this.Mucluong.MinimumWidth = 6;
            this.Mucluong.Name = "Mucluong";
            this.Mucluong.ReadOnly = true;
            this.Mucluong.Width = 110;
            // 
            // Taikhoan
            // 
            this.Taikhoan.DataPropertyName = "MaTK";
            this.Taikhoan.HeaderText = "Mã tài khoản";
            this.Taikhoan.MinimumWidth = 6;
            this.Taikhoan.Name = "Taikhoan";
            this.Taikhoan.ReadOnly = true;
            this.Taikhoan.Width = 130;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền hạn";
            this.Quyen.MinimumWidth = 6;
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            this.Quyen.Width = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 630);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.cbMaTK);
            this.groupBox2.Controls.Add(this.btnThemTK);
            this.groupBox2.Controls.Add(this.btnXemMaCV);
            this.groupBox2.Controls.Add(this.cbQuyen);
            this.groupBox2.Controls.Add(this.cbChucvu);
            this.groupBox2.Controls.Add(this.dtNgaylam);
            this.groupBox2.Controls.Add(this.dtNgaysinh);
            this.groupBox2.Controls.Add(this.cbGioitinh);
            this.groupBox2.Controls.Add(this.tbTennv);
            this.groupBox2.Controls.Add(this.tbSdt);
            this.groupBox2.Controls.Add(this.tbMucluong);
            this.groupBox2.Controls.Add(this.tbDiachi);
            this.groupBox2.Controls.Add(this.tbManv);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1336, 204);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin";
            // 
            // cbMaTK
            // 
            this.cbMaTK.FormattingEnabled = true;
            this.cbMaTK.Location = new System.Drawing.Point(974, 74);
            this.cbMaTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbMaTK.Name = "cbMaTK";
            this.cbMaTK.Size = new System.Drawing.Size(236, 21);
            this.cbMaTK.TabIndex = 9;
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(1091, 101);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(120, 23);
            this.btnThemTK.TabIndex = 8;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXemMaCV
            // 
            this.btnXemMaCV.Location = new System.Drawing.Point(644, 175);
            this.btnXemMaCV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXemMaCV.Name = "btnXemMaCV";
            this.btnXemMaCV.Size = new System.Drawing.Size(144, 23);
            this.btnXemMaCV.TabIndex = 7;
            this.btnXemMaCV.Text = "Thêm chức vụ";
            this.btnXemMaCV.UseVisualStyleBackColor = true;
            this.btnXemMaCV.Click += new System.EventHandler(this.btnXemMaCV_Click);
            // 
            // cbQuyen
            // 
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.Location = new System.Drawing.Point(978, 147);
            this.cbQuyen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(233, 21);
            this.cbQuyen.TabIndex = 6;
            // 
            // cbChucvu
            // 
            this.cbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(555, 152);
            this.cbChucvu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(231, 21);
            this.cbChucvu.TabIndex = 5;
            this.cbChucvu.SelectedIndexChanged += new System.EventHandler(this.cbChucvu_SelectedIndexChanged);
            // 
            // dtNgaylam
            // 
            this.dtNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaylam.Location = new System.Drawing.Point(572, 114);
            this.dtNgaylam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtNgaylam.Name = "dtNgaylam";
            this.dtNgaylam.Size = new System.Drawing.Size(215, 20);
            this.dtNgaylam.TabIndex = 4;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(170, 153);
            this.dtNgaysinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(221, 20);
            this.dtNgaysinh.TabIndex = 3;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Location = new System.Drawing.Point(164, 114);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(81, 21);
            this.cbGioitinh.TabIndex = 2;
            // 
            // tbTennv
            // 
            this.tbTennv.Location = new System.Drawing.Point(196, 77);
            this.tbTennv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTennv.MaxLength = 50;
            this.tbTennv.Name = "tbTennv";
            this.tbTennv.Size = new System.Drawing.Size(195, 20);
            this.tbTennv.TabIndex = 1;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(520, 77);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSdt.MaxLength = 15;
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(266, 20);
            this.tbSdt.TabIndex = 1;
            this.tbSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSdt_KeyPress);
            // 
            // tbMucluong
            // 
            this.tbMucluong.Location = new System.Drawing.Point(974, 29);
            this.tbMucluong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMucluong.MaxLength = 15;
            this.tbMucluong.Name = "tbMucluong";
            this.tbMucluong.Size = new System.Drawing.Size(236, 20);
            this.tbMucluong.TabIndex = 1;
            this.tbMucluong.TextChanged += new System.EventHandler(this.tbMucluong_TextChanged);
            this.tbMucluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMucluong_KeyPress);
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(533, 34);
            this.tbDiachi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbDiachi.MaxLength = 100;
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(254, 20);
            this.tbDiachi.TabIndex = 1;
            // 
            // tbManv
            // 
            this.tbManv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbManv.Location = new System.Drawing.Point(164, 34);
            this.tbManv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbManv.MaxLength = 5;
            this.tbManv.Name = "tbManv";
            this.tbManv.Size = new System.Drawing.Size(227, 20);
            this.tbManv.TabIndex = 1;
            this.tbManv.Click += new System.EventHandler(this.tbManv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày vào làm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SĐT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(897, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Quyền hạn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(886, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã tài khoản:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(897, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mức lương:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV:";
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1352, 635);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhanvien_FormClosing);
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgShow2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tbnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbQuyen;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.DateTimePicker dtNgaylam;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox tbTennv;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbManv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimten;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMucluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXemMaCV;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.ComboBox cbMaTK;
        private System.Windows.Forms.RadioButton rbTimTheoQuyen;
        private System.Windows.Forms.RadioButton rbTimTheoTen;
        private System.Windows.Forms.RadioButton rbTimTheoChucVu;
        private System.Windows.Forms.RadioButton rbTimTheoMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mucluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
    }
}