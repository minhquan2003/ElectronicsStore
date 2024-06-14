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
    public partial class frmHoaDonXuat : Form
    {
        public frmHoaDonXuat()
        {
            InitializeComponent();
        }

        private void dgvHoaDonXuat_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
            {
                con.Open();
                string mahdx = dgvHoaDonXuat.CurrentRow.Cells[0].Value.ToString();
                SqlCommand command = new SqlCommand("Select * From LayHDXChiTietTuHDX('" + mahdx + "')", con);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvHoaDonXuatChiTiet.DataSource = table;
            }
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
            string chuoi = "Select * From vw_HoaDonXuat";
            dgvHoaDonXuat.DataSource = ketnoi.Docdulieu(chuoi);
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = dgvHoaDonXuat.CurrentRow.Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(ketnoi.chuoiketnoi());
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("Delete From HoaDonXuatChiTiet where MaHDX= '" + mahd + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                conn.Close();


                truyxuat.Xoa("HoaDonXuat", "MaHDX", dgvHoaDonXuat);
                MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");

                string hd = "SELECT * FROM HoaDonXuat";
                dgvHoaDonXuat.DataSource = ketnoi.Docdulieu(hd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xoá hoá đơn. Lỗi");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            string chuoi = "Select * From vw_HoaDonXuat";
            dgvHoaDonXuat.DataSource = ketnoi.Docdulieu(chuoi);
        }
    }
}
