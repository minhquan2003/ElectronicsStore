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
using System.Xml.Linq;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            string chuoi = "Select * From vw_HoaDonNhap";
            dgvHoaDonNhap.DataSource = ketnoi.Docdulieu(chuoi);
        }

        private void dgvHoaDonNhap_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
            {
                con.Open();
                string mahdn = dgvHoaDonNhap.CurrentRow.Cells[0].Value.ToString();
                SqlCommand command = new SqlCommand("Select * From LayHDNChiTietTuHDN('" +mahdn+"')", con);
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvHoaDonNhapChiTiet.DataSource = table;
            }
        }

        private void btnXoachitiet_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = dgvHoaDonNhap.CurrentRow.Cells[0].Value.ToString();
                SqlConnection conn = new SqlConnection(ketnoi.chuoiketnoi());
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("Delete From HoaDonNhapChiTiet where MaHDN= '" + mahd + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                
                conn.Close();


                truyxuat.Xoa("HoaDonNhap", "MaHDN", dgvHoaDonNhap);
                MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");

                string hd = "SELECT * FROM HoaDonNhap";
                dgvHoaDonNhap.DataSource = ketnoi.Docdulieu(hd);
            }
            catch 
            {
                MessageBox.Show("Không thể xoá hoá đơn. Lỗi");
            }
            
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            string chuoi = "Select * From vw_HoaDonNhap";
            dgvHoaDonNhap.DataSource = ketnoi.Docdulieu(chuoi);
        }
    }
}
