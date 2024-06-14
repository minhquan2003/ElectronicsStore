namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    partial class frmLoaihang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaihang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelLoaiHangCount = new System.Windows.Forms.Label();
            this.tbTimten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgShow = new System.Windows.Forms.DataGridView();
            this.malh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaihang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thongtin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbThongtin = new System.Windows.Forms.TextBox();
            this.tbTenlh = new System.Windows.Forms.TextBox();
            this.tbMalh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(6, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 442);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.labelLoaiHangCount);
            this.groupBox2.Controls.Add(this.tbTimten);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnLammoi);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.dtgShow);
            this.groupBox2.Location = new System.Drawing.Point(10, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(687, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại hàng";
            // 
            // labelLoaiHangCount
            // 
            this.labelLoaiHangCount.AutoSize = true;
            this.labelLoaiHangCount.Location = new System.Drawing.Point(460, 247);
            this.labelLoaiHangCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoaiHangCount.Name = "labelLoaiHangCount";
            this.labelLoaiHangCount.Size = new System.Drawing.Size(115, 13);
            this.labelLoaiHangCount.TabIndex = 7;
            this.labelLoaiHangCount.Text = "Tổng số loại Hàng:";
            // 
            // tbTimten
            // 
            this.tbTimten.Location = new System.Drawing.Point(97, 20);
            this.tbTimten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTimten.Name = "tbTimten";
            this.tbTimten.Size = new System.Drawing.Size(150, 20);
            this.tbTimten.TabIndex = 6;
            this.tbTimten.TextChanged += new System.EventHandler(this.tbTimten_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tìm tên:";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(299, 18);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(72, 23);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(418, 18);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(496, 18);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(574, 18);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgShow
            // 
            this.dtgShow.AllowUserToAddRows = false;
            this.dtgShow.AllowUserToDeleteRows = false;
            this.dtgShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgShow.ColumnHeadersHeight = 35;
            this.dtgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malh,
            this.tenloaihang,
            this.thongtin});
            this.dtgShow.Location = new System.Drawing.Point(13, 47);
            this.dtgShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgShow.Name = "dtgShow";
            this.dtgShow.ReadOnly = true;
            this.dtgShow.RowHeadersVisible = false;
            this.dtgShow.RowHeadersWidth = 43;
            this.dtgShow.Size = new System.Drawing.Size(659, 237);
            this.dtgShow.TabIndex = 0;
            this.dtgShow.DoubleClick += new System.EventHandler(this.dtgShow_DoubleClick);
            // 
            // malh
            // 
            this.malh.DataPropertyName = "MaLH";
            this.malh.FillWeight = 61.53846F;
            this.malh.HeaderText = "Mã loại hàng";
            this.malh.MinimumWidth = 6;
            this.malh.Name = "malh";
            this.malh.ReadOnly = true;
            // 
            // tenloaihang
            // 
            this.tenloaihang.DataPropertyName = "TenLoaiHang";
            this.tenloaihang.FillWeight = 71.85085F;
            this.tenloaihang.HeaderText = "Tên loại hàng";
            this.tenloaihang.MinimumWidth = 6;
            this.tenloaihang.Name = "tenloaihang";
            this.tenloaihang.ReadOnly = true;
            // 
            // thongtin
            // 
            this.thongtin.DataPropertyName = "ThongTin";
            this.thongtin.FillWeight = 166.6107F;
            this.thongtin.HeaderText = "Thông tin";
            this.thongtin.MinimumWidth = 6;
            this.thongtin.Name = "thongtin";
            this.thongtin.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.tbThongtin);
            this.groupBox1.Controls.Add(this.tbTenlh);
            this.groupBox1.Controls.Add(this.tbMalh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(666, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin loại hàng";
            // 
            // tbThongtin
            // 
            this.tbThongtin.Location = new System.Drawing.Point(401, 25);
            this.tbThongtin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbThongtin.Multiline = true;
            this.tbThongtin.Name = "tbThongtin";
            this.tbThongtin.Size = new System.Drawing.Size(214, 62);
            this.tbThongtin.TabIndex = 5;
            // 
            // tbTenlh
            // 
            this.tbTenlh.Location = new System.Drawing.Point(161, 66);
            this.tbTenlh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTenlh.Name = "tbTenlh";
            this.tbTenlh.Size = new System.Drawing.Size(116, 20);
            this.tbTenlh.TabIndex = 4;
            // 
            // tbMalh
            // 
            this.tbMalh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMalh.Location = new System.Drawing.Point(161, 26);
            this.tbMalh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMalh.Name = "tbMalh";
            this.tbMalh.Size = new System.Drawing.Size(116, 20);
            this.tbMalh.TabIndex = 3;
            this.tbMalh.Click += new System.EventHandler(this.tbMalh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thông tin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên LH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã LH:";
            // 
            // frmLoaihang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 457);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.841584F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLoaihang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại hàng";
            this.Load += new System.EventHandler(this.frmLoaihang_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTimten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbThongtin;
        private System.Windows.Forms.TextBox tbTenlh;
        private System.Windows.Forms.TextBox tbMalh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn malh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaihang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thongtin;
        private System.Windows.Forms.Label labelLoaiHangCount;
    }
}