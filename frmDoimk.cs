using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_Nhom08_CuaHangDienDienLanh;
namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmDoimk : Form
    {
        public frmDoimk()
        {
            InitializeComponent();
        }

        public string Tentaikhoan { get; set; }

        private void frmDoimk_Load(object sender, EventArgs e)
        {
            tbTK.Text = Tentaikhoan;
            tbMKcu.Focus();
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn trở lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có muốn đổi mật khẩu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    string select2 = "Select * From TaiKhoan where TaiKhoan='" + tbTK.Text + "' and MatKhau='" + tbMKcu.Text + "'";
                    if (tbMKcu.Text == "")
                    {
                        MessageBox.Show("Mật khẩu cũ không được bỏ trống! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMKcu.ResetText();
                        tbMKmoi.ResetText();
                        tbRePass.ResetText();
                        tbMKcu.Focus();
                    }
                    else if (tbMKmoi.Text == "")
                    {
                        MessageBox.Show("Mật khẩu mới không được bỏ trống! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMKmoi.ResetText();
                        tbRePass.ResetText();
                        tbMKmoi.Focus();
                    }
                    else if (tbRePass.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập lại mật khẩu! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMKmoi.ResetText();
                        tbRePass.ResetText();
                        tbMKmoi.Focus();
                    }
                    else if (tbMKmoi.Text != tbRePass.Text)
                    {
                        MessageBox.Show("Mật khẩu bạn nhập không trùng khớp! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMKmoi.ResetText();
                        tbRePass.ResetText();
                        tbMKmoi.Focus();
                    }
                    else if (truyxuat.kiemtratext(select2) == 1)
                    {
                        string Matkhau = tbMKmoi.Text;
                        string update = "Update TaiKhoan Set MatKhau='" + Matkhau + "' where TaiKhoan='" + tbTK.Text + "'";
                        truyxuat.sua(update);
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu bạn nhập không chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbMKcu.ResetText();
                        tbMKcu.Focus();
                    }
                }
            
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }
    }
}
