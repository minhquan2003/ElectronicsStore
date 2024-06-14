using DoAn_Nhom08_CuaHangDienDienLanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmThemmathang : Form
    {
        public frmThemmathang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("ThemMatHang", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaMH", SqlDbType.VarChar).Value = tbMamh.Text;
                        cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar).Value = tbTenmh.Text;
                        cmd.Parameters.Add("@MaLH", SqlDbType.NVarChar).Value = tbMalhnhap.Text;
                        cmd.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = tbManccnhap.Text;
                        cmd.Parameters.Add("@HangSX", SqlDbType.NVarChar).Value = tbHsx.Text;
                        cmd.Parameters.Add("@NoiSX", SqlDbType.VarChar).Value = tbNoisx.Text;
                        cmd.Parameters.Add("@ThongSoKyThuat", SqlDbType.NVarChar).Value = tbKythuat.Text;
                        cmd.Parameters.Add("@SoLuong", SqlDbType.VarChar).Value = 0;
                        cmd.Parameters.Add("@GiaBan", SqlDbType.Float).Value = Convert.ToDouble(txtGiaNhap.Text)*100/75;
                        cmd.Parameters.Add("@TinhTrang", SqlDbType.VarChar).Value = "Con hang";

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm mặt hàng thành công!", "Thông báo");  
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Thêm mặt hàng thất bại. Lỗi: " + ex.Message);
            }
            
        }

        private void tbnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbnThemlhnhap_Click(object sender, EventArgs e)
        {
            frmLoaihang frm = new frmLoaihang();
            frm.ShowDialog();
        }

        private void frmThemmathang_Load(object sender, EventArgs e)
        {
            //Add chọn NCC nhập

            string nccnhap = "Select TenNCC from NhaCungCap ";
            truyxuat.layracombobox(nccnhap, cbChonnccnhap);
            this.cbChonnccnhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            //Add loại hàng

            string loaihangn = "Select TenLoaiHang from LoaiHang ";
            truyxuat.layracombobox(loaihangn, cbChonlhnhap);
            this.cbChonlhnhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cbChonnccnhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbManccnhap.ResetText();
            //Select NCC
            string var = cbChonnccnhap.Text;
            string select = "Select MaNCC from NhaCungCap where TenNCC=N'" + var + "'";
            tbManccnhap.Text = truyxuat.laychuoi(select, tbManccnhap.Text);
        }

        private void cbChonlhnhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMalhnhap.ResetText();

            string var = cbChonlhnhap.Text;
            string select = "Select MaLH from LoaiHang where TenLoaiHang=N'" + var + "'";
            tbMalhnhap.Text = truyxuat.laychuoi(select, tbMalhnhap.Text);
        }

        private void btnThemncc_Click(object sender, EventArgs e)
        {
            frmNhacungcap frm = new frmNhacungcap();
            frm.ShowDialog();
        }

        private void cbChonnccnhap_Click(object sender, EventArgs e)
        {
            cbChonnccnhap.Items.Clear();
            string nccnhap = "Select TenNCC from NhaCungCap ";
            truyxuat.layracombobox(nccnhap, cbChonnccnhap);
            this.cbChonnccnhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cbChonlhnhap_Click(object sender, EventArgs e)
        {
            cbChonlhnhap.Items.Clear();
            string loaihangn = "Select TenLoaiHang from LoaiHang ";
            truyxuat.layracombobox(loaihangn, cbChonlhnhap);
            this.cbChonlhnhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }

    public class themmh
    {
        public static string ma = "";
        public static string ten = "";
        public static string ncc = "";
        public static string lh = "";
        public static string hang = "";
        public static string noi = "";
        public static string ttkythuat = "";
        public static string tinhtr = "";
    }
}
