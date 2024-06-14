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
    public partial class frmLoaihang : Form
    {
        public frmLoaihang()
        {
            InitializeComponent();
        }

        private void frmLoaihang_Load(object sender, EventArgs e)
        {
            //Load data
            string load = "Select * From vw_LoaiHang";
            dtgShow.DataSource = ketnoi.Docdulieu(load);
            DisplayLoaiHangCount();

        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            tbMalh.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //Load data
            string load = "Select * From vw_LoaiHang";
            dtgShow.DataSource = ketnoi.Docdulieu(load);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            {
                DialogResult check = MessageBox.Show("Bạn có sửa thông tin loại hàng hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
                        {
                            string editlh = "Update LoaiHang Set TenLoaiHang=N'" + tbTenlh.Text + "', ThongTin=N'" + tbThongtin.Text + "' where MaLH=N'" + tbMalh.Text + "'";
                            truyxuat.sua(editlh);
                            MessageBox.Show("Sửa thông tin thành công!");
                            
                        }
                        MessageBox.Show("Cập nhập thành công!", "Thông báo");
                    }
                    catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex.Message); }

                    tbMalh.ResetText();
                    tbTenlh.ResetText();
                    tbThongtin.ResetText();

                    string load = "Select * From LoaiHang";
                    dtgShow.DataSource = ketnoi.Docdulieu(load);
                }
            }
        }

        private void dtgShow_DoubleClick(object sender, EventArgs e)
        {
            tbMalh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            tbMalh.Text = dtgShow.CurrentRow.Cells[0].Value.ToString();
            tbTenlh.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            tbThongtin.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
        }

        private void tbTimten_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
            {
                string query = "SELECT * FROM dbo.TimKiemTheoTenLoaiHang(@TenLoaiHang)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@TenLoaiHang", SqlDbType.NVarChar).Value = tbTimten.Text;

                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgShow.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("themLoaiHang", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MaLH", SqlDbType.VarChar).Value = tbMalh.Text;
                    command.Parameters.Add("@TenLoaiHang", SqlDbType.VarChar).Value = tbTenlh.Text;
                    command.Parameters.Add("@ThongTin", SqlDbType.VarChar).Value = tbThongtin.Text;

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Lưu thành công thông tin Loại hàng!", "Thông báo");

                string load = "SELECT * FROM LoaiHang";
                dtgShow.DataSource = ketnoi.Docdulieu(load);
                DisplayLoaiHangCount();
                tbMalh.ResetText();
                tbTenlh.ResetText();
                tbThongtin.ResetText();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex.Message); }
        }

        private void tbMalh_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có xóa thông tin loại hàng hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            try
            {
                using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    truyxuat.Xoa("LoaiHang", "MaLH", dtgShow);
                    MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");
                }

                // Cập nhật lại danh sách loại hàng sau khi xóa
                string load = "Select * From LoaiHang";
                dtgShow.DataSource = ketnoi.Docdulieu(load);
                DisplayLoaiHangCount();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi");
            }


        }
        private void DisplayLoaiHangCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT dbo.LoaiHang_TotalRows() AS TotalRows", connection);
                    int totalRows = (int)command.ExecuteScalar();

                    labelLoaiHangCount.Text = "Tổng số loại hàng: " + totalRows;

                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi tải tổng số loại hàng.", "Lỗi");
            }
        }
    }
}
