using DoAn_Nhom08_CuaHangDienDienLanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmSuamathang : Form
    {
        public frmSuamathang()
        {
            InitializeComponent();
        }

        private void frmSuamathang_Load(object sender, EventArgs e)
        {
            //Load nhà cung cấp và loại hàng 

            string ncc = "Select TenNCC from NhaCungCap ";
            truyxuat.layracombobox(ncc, cbNhacc);
            this.cbNhacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            string lh = "Select TenLoaiHang from LoaiHang ";
            truyxuat.layracombobox(lh, cbLoaihang);
            this.cbLoaihang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Load Data

            tbMamh.Text = Mamh;
            tbTenmh.Text = Tenmh;

            tbMancc.Text = Mancc;
            string chuoi = "Select TenNCC From NhaCungCap where MaNCC='"+ tbMancc.Text +"'";
            cbNhacc.Text = truyxuat.laychuoi(chuoi, cbNhacc.Text);

            tbMalh.Text = Malh;
            string chuoi2 = "Select TenLoaiHang From LoaiHang where MaLH='"+ tbMalh.Text +"'";
            cbLoaihang.Text = truyxuat.laychuoi(chuoi2, cbLoaihang.Text);

            tbHangsx.Text = Hangsx;
            tbNoisx.Text = Noisx;
            tbKythuat.Text = Kythuat;
            tbSoluong.Text = Soluong;
            tbGiaban.Text = Giaban;
            tbTinhtrang.Text = Tinhtrang;
        }

        private void cbNhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMancc.ResetText();
            string var = cbNhacc.Text;
            string select = "Select MaNCC from NhaCungCap where TenNCC=N'" + var + "'";
            tbMancc.Text = truyxuat.laychuoi(select, tbMancc.Text);
        }

        private void cbLoaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMalh.ResetText();
            string var = cbLoaihang.Text;
            string select = "Select MaLH from LoaiHang where TenLoaiHang=N'" + var + "'";
            tbMalh.Text = truyxuat.laychuoi(select, tbMalh.Text);
        }

        public string Mamh { get; set; }

        public string Tenmh { get; set; }

        public string Mancc { get; set; }

        public string Malh { get; set; }

        public string Hangsx { get; set; }

        public string Noisx { get; set; }

        public string Kythuat { get; set; }

        public string Soluong { get; set; }

        public string Giaban { get; set; }

        public string Tinhtrang { get; set; }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string editsp = "Update MatHang Set TenMH=N'" + tbTenmh.Text + "', MaMH='" +
                tbMalh.Text + "', MaNCC='" + tbMancc.Text + "', HangSX=N'" + tbHangsx.Text + "', NoiSX=N'" + tbNoisx.Text +
                "', ThongSoKyThuat=N'" + tbKythuat.Text + "', SoLuong='" + int.Parse(tbSoluong.Text) +
                "', GiaBan='" + Convert.ToDouble(tbGiaban.Text) + "', TinhTrang=N'" + tbTinhtrang.Text +
                "' where MaMH='" + tbMamh.Text + "'";
                truyxuat.sua(editsp);
                MessageBox.Show("Sửa thông tin thành công!");
                this.Close();
            } 
            catch (Exception ex) {
                MessageBox.Show("Không thể sửa. Lỗi: " + ex.Message);
            }
            
            
            
        }

        private void tbGiaban_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.tiente(tbGiaban);
        }

        private void tbGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
