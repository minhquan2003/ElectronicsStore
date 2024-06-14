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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void tbTkdiachikh_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[DiaChi] like '%" + tbTkdiachikh.Text + "%'";
            dgvKhachHang.DataSource = truyxuat.timkiemdtgrif(dgvKhachHang, chuoi);
        }

        private void tbTksdtkh_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[Sdt] like '%" + tbTksdtkh.Text + "%'";
            dgvKhachHang.DataSource = truyxuat.timkiemdtgrif(dgvKhachHang, chuoi);
        }

        private void tbTksdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        private void tbTKtenkh_TextChanged(object sender, EventArgs e)
        {
            string fnName = "TimKiemTenKH";
            string chuoi = tbTKtenkh.Text;
            SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi());
            con.Open();

            SqlCommand command = new SqlCommand("Select * from " + fnName + "(@string)", con);
            command.Parameters.Add("@string", SqlDbType.NChar).Value = chuoi;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dgvKhachHang.DataSource = table;

        }

        private void rdTimtenkh_CheckedChanged(object sender, EventArgs e)
        {
            tbTKtenkh.Enabled = true;
            tbTkdiachikh.Enabled = false;
            tbTksdtkh.Enabled = false;
            tbTkdiachikh.ResetText();
            tbTksdtkh.ResetText();
            tbTKtenkh.ResetText();
        }

        private void rdTimsdtkh_CheckedChanged(object sender, EventArgs e)
        {
            tbTKtenkh.Enabled = false;
            tbTkdiachikh.Enabled = false;
            tbTksdtkh.Enabled = true;
            tbTkdiachikh.ResetText();
            tbTksdtkh.ResetText();
            tbTKtenkh.ResetText();
        }

        private void rdTimgioitinhkh_CheckedChanged(object sender, EventArgs e)
        {
            tbTKtenkh.Enabled = false;
            tbTkdiachikh.Enabled = false;
            tbTksdtkh.Enabled = false;
            tbTkdiachikh.ResetText();
            tbTksdtkh.ResetText();
            tbTKtenkh.ResetText();
        }

        private void rdTimdiachikh_CheckedChanged(object sender, EventArgs e)
        {
            tbTKtenkh.Enabled = false;
            tbTkdiachikh.Enabled = true;
            tbTksdtkh.Enabled = false;
            tbTkdiachikh.ResetText();
            tbTksdtkh.ResetText();
            tbTKtenkh.ResetText();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string kh = "EXEC LayKhachHang";
            dgvKhachHang.DataSource = ketnoi.Docdulieu(kh);
            btnLoad.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dtNgaysinh.Format = DateTimePickerFormat.Custom;
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";

            dtLayNgayDau.Format = DateTimePickerFormat.Custom;
            dtLayNgayDau.CustomFormat = "dd/MM/yyyy";

            dtLayNgayCuoi.Format = DateTimePickerFormat.Custom;
            dtLayNgayCuoi.CustomFormat = "dd/MM/yyyy";

            dgvKhachHang.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            string lapkh = "SELECT MaKH, TenKH FROM vw_KhachHang";
            cbMaKH.DataSource = ketnoi.Docdulieu(lapkh);
            cbMaKH.DisplayMember = "TenKH";
            cbMaKH.ValueMember = "MaKH";

            
            cbMaKHCapNhatD.DataSource = ketnoi.Docdulieu(lapkh);
            cbMaKHCapNhatD.DisplayMember = "TenKH";
            cbMaKHCapNhatD.ValueMember = "MaKH";

            cbGioitinh.Items.Add("Nam");
            cbGioitinh.Items.Add("Nu");

            string kh = "SELECT * FROM vw_KhachHang";
            dgvKhachHang.DataSource = ketnoi.Docdulieu(kh);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                tbTenkhachhang.Text = chuanhoa.viethoa(this.tbTenkhachhang.Text);
                tbDiachi.Text = chuanhoa.viethoa(this.tbDiachi.Text);
                using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ThemKhachHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = tbMakhachhang.Text;
                    cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = tbTenkhachhang.Text;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtNgaysinh.Value;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value = cbGioitinh.Text;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = tbDiachi.Text;
                    cmd.Parameters.Add("@Sdt", SqlDbType.VarChar).Value = tbSodienthoai.Text;
                    cmd.Parameters.Add("@TongDiemTichLuy", SqlDbType.Float).Value = Convert.ToDouble(txtTongDiemTichLuy.Text);
                        

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");

                        string chuoi2 = "Select * From KhachHang";
                        dgvKhachHang.DataSource = ketnoi.Docdulieu(chuoi2);

                        resettext();

                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                string lapkh = "SELECT MaKH, TenKH FROM vw_KhachHang";
                cbMaKHCapNhatD.DataSource = ketnoi.Docdulieu(lapkh);
                cbMaKHCapNhatD.DisplayMember = "TenKH";
                cbMaKHCapNhatD.ValueMember = "MaKH";
                cbMaKH.DataSource = ketnoi.Docdulieu(lapkh);
                cbMaKH.DisplayMember = "TenKH";
                cbMaKH.ValueMember = "MaKH";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex);
            }
        }
        private void resettext()
        {
            tbMakhachhang.ResetText();
            tbTenkhachhang.ResetText();
            cbGioitinh.ResetText();
            dtNgaysinh.ResetText();
            tbDiachi.ResetText();
            tbSodienthoai.ResetText();
            txtTongDiemTichLuy.ResetText();
            
        }

        private void btnCapNhatDiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("CapNhatTongDiemTichLuyKhachHang", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaKH", SqlDbType.VarChar).Value = cbMaKHCapNhatD.SelectedValue;
                    cmd.Parameters.Add("@TongDiemMoi", SqlDbType.Float).Value = Convert.ToDouble(txtCapNhatDiem.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật điểm thành công!", "Thông báo");
                        string chuoi2 = "Select * From KhachHang";
                        dgvKhachHang.DataSource = ketnoi.Docdulieu(chuoi2);
                        resettext();
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật điểm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTongDiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.TinhTongDiemTichLuy(@maKH, @ngayThangNamBatDau, @ngayThangNamKetThuc)", con);
                    cmd.Parameters.Add("@maKH", SqlDbType.VarChar).Value = cbMaKH.SelectedValue;
                    cmd.Parameters.Add("@ngayThangNamBatDau", SqlDbType.Date).Value = dtLayNgayDau.Value;
                    cmd.Parameters.Add("@ngayThangNamKetThuc", SqlDbType.Date).Value = dtLayNgayCuoi.Value;
                    object result = cmd.ExecuteScalar();
                    txtDiem.Text = result.ToString();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void rdTimsdtkh_CheckedChanged_1(object sender, EventArgs e)
        {
            tbTKtenkh.Enabled = false;
            tbTkdiachikh.Enabled = false;
            tbTksdtkh.Enabled = true;
            tbTkdiachikh.ResetText();
            tbTksdtkh.ResetText();
            tbTKtenkh.ResetText();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    DialogResult check = MessageBox.Show("Bạn có sửa thông tin khách hàng hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (check == DialogResult.OK)
                    {
                        string update = "Update KhachHang Set TenKH=N'" +
                        tbTenkhachhang.Text + "',NgaySinh=N'" + dtNgaysinh.Value.ToString("yyyy/MM/dd") + "',GioiTinh=N'" +
                        cbGioitinh.Text + "',DiaChi=N'" +
                        tbDiachi.Text + "',Sdt=N'" + tbSodienthoai.Text + "',TongDiemTichLuy= " + Convert.ToDouble(txtTongDiemTichLuy.Text) +
                        " WHERE MaKH='" + tbMakhachhang.Text + "'";
                        truyxuat.sua(update);
                        MessageBox.Show("Sửa khách hàng thành công!", "Thông báo");
                        string chuoi2 = "Select * From KhachHang";
                        dgvKhachHang.DataSource = ketnoi.Docdulieu(chuoi2);
                        resettext();
                    }
                }
            }
            catch (Exception ex)
            {
                       MessageBox.Show("Có lỗi xảy ra! Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có xóa thông tin khách hàng này hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    truyxuat.Xoa("KhachHang", "MaKH", dgvKhachHang);
                    MessageBox.Show("Xóa thông tin thành công!", "Thông báo");

                    string load = "Select * From KhachHang";
                    dgvKhachHang.DataSource = ketnoi.Docdulieu(load);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra! Lỗi");
            }
            
        }

        private void dgvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            tbMakhachhang.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            tbMakhachhang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            tbTenkhachhang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            dtNgaysinh.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            cbGioitinh.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            tbDiachi.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            tbSodienthoai.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtTongDiemTichLuy.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
