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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            string chuoi = "Select * From vw_TaiKhoan";
            dgvTaiKhoan.DataSource = ketnoi.Docdulieu(chuoi);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string chuoi = "Select * From vw_TaiKhoan";
            dgvTaiKhoan.DataSource = ketnoi.Docdulieu(chuoi);
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string select = "Select * From vw_TaiKhoan where MaTK='" + txtMaTK.Text + "'";
                {
                    string MaTK = txtMaTK.Text;
                    string TenTaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi());
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ThemTaiKhoan", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaTK", SqlDbType.VarChar).Value = MaTK;
                    cmd.Parameters.Add("@TaiKhoan", SqlDbType.VarChar).Value = TenTaiKhoan;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = MatKhau;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Add Customer", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        con.Close();
                        txtMaTK.ResetText();
                        txtTaiKhoan.ResetText();
                        txtMatKhau.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Add Customer", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể thêm thông tin tài khoản. Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaTK = txtMaTK.Text;
                string TenTaiKhoan = txtTaiKhoan.Text;
                string MatKhau = txtMatKhau.Text;

                using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    con.Open();

                    // Kiểm tra xem tài khoản đã tồn tại chưa
                    string selectQuery = "SELECT COUNT(*) FROM vw_TaiKhoan WHERE MaTK = @MaTK";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@MaTK", MaTK);

                    int existingCount = Convert.ToInt32(selectCmd.ExecuteScalar());

                    if (existingCount == 0)
                    {
                        MessageBox.Show("Tài khoản không tồn tại!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Thực hiện cập nhật thông tin tài khoản
                        SqlCommand updateCmd = new SqlCommand("SuaTaiKhoan", con);
                        updateCmd.CommandType = CommandType.StoredProcedure;
                        updateCmd.Parameters.Add("@MaTK", SqlDbType.VarChar).Value = MaTK;
                        updateCmd.Parameters.Add("@TaiKhoan", SqlDbType.VarChar).Value = TenTaiKhoan;
                        updateCmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = MatKhau;

                        if (updateCmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Cập nhật thành công!", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại", "Update Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể cập nhật thông tin tài khoản. Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có xóa thông tin tài khoản hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    string MaTKToDelete = dgvTaiKhoan.CurrentRow.Cells["MaTK"].Value.ToString();

                    using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("XoaTaiKhoan", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaTK", SqlDbType.VarChar).Value = MaTKToDelete;

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");

                            string load = "Select * From TaiKhoan";
                            dgvTaiKhoan.DataSource = ketnoi.Docdulieu(load);
                        }
                    }
                }
            }
            catch{
                MessageBox.Show("Không thể xóa thông tin tài khoản.Lỗi: ");
            }
        }

        private void dgvTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            txtMaTK.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            txtMaTK.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtTaiKhoan.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fnName = "TimTaiKhoanTheoNV";
                string chuoi = txtTimKiem.Text;

                using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM " + fnName + "(@tenNhanVien)", con);
                    command.Parameters.Add("@tenNhanVien", SqlDbType.NVarChar).Value = chuoi;

                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);

                    dgvTaiKhoan.DataSource = table;
                }
            }
            catch 
            {
                MessageBox.Show("Không thể truy cập.");
            }
            
        }
    }

}