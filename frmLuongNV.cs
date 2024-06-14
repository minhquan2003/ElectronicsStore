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
    public partial class frmLuongNV : Form
    {
        public frmLuongNV()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM vw_LuongNhanVien";
            dgvLuongNV.DataSource = ketnoi.Docdulieu(chuoi);
            resettext();
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            dtNgayPhatLuong.Format = DateTimePickerFormat.Custom;
            dtNgayPhatLuong.CustomFormat = "dd/MM/yyyy";
            dgvLuongNV.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            string laynv = "Select MaNV, HoTen From vw_NhanVien";
            cbTenNV.DataSource = ketnoi.Docdulieu(laynv);
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DisplayMember = "HoTen";
            conn = new SqlConnection(ketnoi.chuoiketnoi());
            string chuoi = "SELECT * FROM vw_LuongNhanVien";
            dgvLuongNV.DataSource = ketnoi.Docdulieu(chuoi);
        }

        private void cbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            string var = cbTenNV.Text;
            string select = "Select MaNV from vw_NhanVien where HoTen=N'" + var + "'";
            txtMaNV.Text = truyxuat.laychuoi(select, cbTenNV.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                dtNgayPhatLuong.Format = DateTimePickerFormat.Custom;
                dtNgayPhatLuong.CustomFormat = "dd/MM/yyyy";
                string sl = "Select * From LuongNhanVien where MaNV='" + txtMaNV.Text + "' and NgayPhatLuong='" + dtNgayPhatLuong.Text + "'";
                string select = "Select * From NhanVien where MaTK='" + txtMaNV.Text + "' and NgayPhatLuong='" + dtNgayPhatLuong.Text + "' and MaNV='" + txtMaNV.Text + "'";

                {

                    using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("ThemLuongNhanVien", con);
                        SqlCommand tinhluong = new SqlCommand("TinhLuongNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV.Text;
                        cmd.Parameters.Add("@NgayPhatLuong", SqlDbType.Date).Value = dtNgayPhatLuong.Value;
                        cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = cbTenNV.Text;
                        cmd.Parameters.Add("@NamKinhNghiem", SqlDbType.Float).Value = float.Parse(txtNamKinhNghiem.Text);
                        cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = float.Parse(txtHeSoLuong.Text);
                        cmd.Parameters.Add("@SoNgayThuong", SqlDbType.Float).Value = float.Parse(txtSoNgayThuong.Text);
                        cmd.Parameters.Add("@ThuongThanhTich", SqlDbType.Float).Value = float.Parse(txtThuongThanhTich.Text);
                        cmd.Parameters.Add("@SoNgayNghi", SqlDbType.Float).Value = float.Parse(txtSoNgayNghi.Text);
                        cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = 0;

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm thông tin lương nhân viên thành công!", "Thông báo");

                            string chuoi2 = "Select * From LuongNhanVien";
                            dgvLuongNV.DataSource = ketnoi.Docdulieu(chuoi2);

                            resettext();

                            btnSua.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Thêm lương nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex.Message); }


        }
        private void resettext()
        {

            txtMaNV.ResetText();
            txtHeSoLuong.ResetText();
            txtLuong.ResetText();
            txtNamKinhNghiem.ResetText();
            dtNgayPhatLuong.ResetText();
            cbTenNV.ResetText();
            txtThuongThanhTich.ResetText();
            txtSoNgayThuong.ResetText();
            txtSoNgayNghi.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                string sl = "Select * From LuongNhanVien where MaNV='" + txtMaNV.Text + "' and NgayPhatLuong='" + dtNgayPhatLuong.Text + "'";
                string select = "Select * From NhanVien where MaTK='" + txtMaNV.Text + "' and NgayPhatLuong='" + dtNgayPhatLuong.Text + "' and MaNV='" + txtMaNV.Text + "'";
                {

                    using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SuaLuongNhanVien", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = txtMaNV.Text;
                        cmd.Parameters.Add("@NgayPhatLuong", SqlDbType.Date).Value = dtNgayPhatLuong.Value;
                        cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = cbTenNV.Text;
                        cmd.Parameters.Add("@NamKinhNghiem", SqlDbType.Int).Value = int.Parse(txtNamKinhNghiem.Text);
                        cmd.Parameters.Add("@HeSoLuong", SqlDbType.NVarChar).Value = float.Parse(txtHeSoLuong.Text);
                        cmd.Parameters.Add("@SoNgayThuong", SqlDbType.VarChar).Value = int.Parse(txtSoNgayThuong.Text);
                        cmd.Parameters.Add("@ThuongThanhTich", SqlDbType.Float).Value = float.Parse(txtThuongThanhTich.Text);
                        cmd.Parameters.Add("@SoNgayNghi", SqlDbType.VarChar).Value = int.Parse(txtSoNgayNghi.Text);
                        cmd.Parameters.Add("@Luong", SqlDbType.VarChar).Value = 0;

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Thêm thông tin lương nhân viên thành công!", "Thông báo");

                            string chuoi2 = "Select * From LuongNhanVien";
                            dgvLuongNV.DataSource = ketnoi.Docdulieu(chuoi2);

                            resettext();

                            txtMaNV.Enabled = true;
                            btnThem.Enabled = true;
                            btnSua.Enabled = true;

                        }
                        else
                        {
                            MessageBox.Show("Thêm lương nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex.Message); }
        }

        private void txtThuongThanhTich_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.tiente(txtThuongThanhTich);
        }

        private void dgvLuongNV_DoubleClick(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            btnThem.Enabled = false;

            txtMaNV.Text = dgvLuongNV.CurrentRow.Cells[0].Value.ToString();
            dtNgayPhatLuong.Text = dgvLuongNV.CurrentRow.Cells[1].Value.ToString();
            cbTenNV.Text = dgvLuongNV.CurrentRow.Cells[2].Value.ToString();
            txtNamKinhNghiem.Text = dgvLuongNV.CurrentRow.Cells[3].Value.ToString();
            txtHeSoLuong.Text = dgvLuongNV.CurrentRow.Cells[4].Value.ToString();
            txtSoNgayThuong.Text = dgvLuongNV.CurrentRow.Cells[5].Value.ToString();
            txtThuongThanhTich.Text = dgvLuongNV.CurrentRow.Cells[6].Value.ToString();
            txtSoNgayNghi.Text = dgvLuongNV.CurrentRow.Cells[7].Value.ToString();
            txtLuong.Text = dgvLuongNV.CurrentRow.Cells[8].Value.ToString();
        }

        private void tbTimTenNV_TextChanged(object sender, EventArgs e)
        {
            string fnName = "TimTenTrongLuongNV";
            string chuoi = tbTimTenNV.Text;
            SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi());
            con.Open();

            SqlCommand command = new SqlCommand("Select * from " + fnName + "(@string)", con);
            command.Parameters.Add("@string", SqlDbType.NChar).Value = chuoi;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dgvLuongNV.DataSource = table;
        }

        private void btnTinhtongluong_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.TinhTongLuongNVTheoThang(@Thang, @Nam)", con);
                    cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = int.Parse(tbThang.Text);
                    cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = int.Parse(tbNam.Text);

                    object result = cmd.ExecuteScalar();
                    double tongluong = (double)result; // change data type to double
                    string tongluongString = tongluong.ToString(); // convert to string
                    tbTongLuong.Text = result.ToString();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

    }
}
