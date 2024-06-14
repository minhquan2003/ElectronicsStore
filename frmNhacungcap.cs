using DoAn_Nhom08_CuaHangDienDienLanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmNhacungcap : Form
    {

        public frmNhacungcap()
        {
            InitializeComponent();
        }

        private void frmNhacungcap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmNhacungcap_Load(object sender, EventArgs e)
        {
            //Load thông tin nhà cung cấp

            string chuoi = "Select * From vw_NhaCungCap";
            dtgShow.DataSource = ketnoi.Docdulieu(chuoi);
            tbTenncc.Focus();
            DisplayNhaCungCapCount();
        }

        private void tbSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void resettext()
        {
            tbMancc.ResetText();
            tbTenncc.ResetText();
            tbSdt.ResetText();
            tbDiachi.ResetText();
        }

        private void tbTimten_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.TimKiemTheoTenNhaCungCap(@TenNhaCungCap)", connection);
                command.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = tbTimten.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dtgShow.DataSource = table;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            tbMancc.Enabled = true;
            btnThem.Enabled = true;
            btnDelete.Enabled = true;
            string chuoi = "Select * From vw_NhaCungCap";
            dtgShow.DataSource = ketnoi.Docdulieu(chuoi);
            resettext();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    tbDiachi.Text = chuanhoa.viethoa(this.tbDiachi.Text);

                    SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi());
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ThemNhaCungCap", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Mancc", SqlDbType.VarChar).Value = tbMancc.Text;
                    cmd.Parameters.Add("@Tenncc", SqlDbType.NVarChar).Value = tbTenncc.Text;
                    cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = tbDiachi.Text;
                    cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = tbSdt.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Lưu thành công thông tin Loại hàng!", "Thông báo");
                        con.Close();
                        DisplayNhaCungCapCount();
                        string chuoi2 = "Select * From NHACUNGCAP";
                        dtgShow.DataSource = ketnoi.Docdulieu(chuoi2);
                        resettext();
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại!", "Thông báo");
                        con.Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex.Message); }
        }
        private void dtgShow_DoubleClick(object sender, EventArgs e)
        {
            tbMancc.Enabled = false;
            btnThem.Enabled = false;
            btnDelete.Enabled = false;
            tbMancc.Text = dtgShow.CurrentRow.Cells[0].Value.ToString();
            tbTenncc.Text = dtgShow.CurrentRow.Cells[1].Value.ToString();
            tbDiachi.Text = dtgShow.CurrentRow.Cells[2].Value.ToString();
            tbSdt.Text = dtgShow.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có sửa thông tin nhà cung cấp hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    tbDiachi.Text = chuanhoa.viethoa(this.tbDiachi.Text);

                    using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("ThemCapNhatNhaCungCap", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Mancc", SqlDbType.VarChar).Value = tbMancc.Text;
                        cmd.Parameters.Add("@Tenncc", SqlDbType.NVarChar).Value = tbTenncc.Text;
                        cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = tbDiachi.Text;
                        cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = tbSdt.Text;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật thành công!", "Thông báo");

                    string chuoi2 = "Select * From NHACUNGCAP";
                    dtgShow.DataSource = ketnoi.Docdulieu(chuoi2);
                    resettext();
                    DisplayNhaCungCapCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Lỗi: " + ex.Message);
            }
            
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có xóa thông tin nhà cung cấp hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    truyxuat.Xoa("NhaCungCap", "MaNCC", dtgShow);
                    MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");
                    string chuoi2 = "Select * From NhaCungCap";
                    dtgShow.DataSource = ketnoi.Docdulieu(chuoi2);
                    resettext();
                    DisplayNhaCungCapCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xoá. Lỗi: " + ex.Message);
            }
        }

        private void tbMancc_Click(object sender, EventArgs e)
        {
            //btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void DisplayNhaCungCapCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT dbo.NhaCungCap_TotalCount() AS TotalCount", connection);
                    int totalRows = (int)command.ExecuteScalar();

                    labelNhaCungCapCount.Text = "Tổng số nhà cung cấp: " + totalRows;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi tải tổng số nhà cung cấp", "Lỗi");
            }
        }
    }
}
