using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using DoAn_Nhom08_CuaHangDienDienLanh;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class frmMain : Form
    {
        SqlConnection conn = null;
        List<Banhang> DSban = new List<Banhang>();
        List<Capnhapmh> DScapnhap = new List<Capnhapmh>();
        List<Themmoimh> DSthemmoi = new List<Themmoimh>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void mnQLnhanvien_Click(object sender, EventArgs e)
        {
            
        }

        private void mnQLncc_Click(object sender, EventArgs e)
        {
            frmNhacungcap frm = new frmNhacungcap();
            frm.ShowDialog();
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            mainLoad(sender,e);
        }


        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnQLloaihang_Click(object sender, EventArgs e)
        {
            frmLoaihang frm = new frmLoaihang();
            frm.ShowDialog();
        }


        public string idTaikhoan { get; set; }

        public string idQuyen { get; set; }

        private void tbTimsp_TextChanged(object sender, EventArgs e)
        {
            string fnName = "TimSP";
            string chuoi = tbTimsp.Text;
            SqlConnection con = new SqlConnection(ketnoi.chuoiketnoi());
            con.Open();

            SqlCommand command = new SqlCommand("Select * from " + fnName + "(@string)", con);
            command.Parameters.Add("@string", SqlDbType.NChar).Value = chuoi;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            dtgShowfullsp.DataSource = table;
        }


        private void rdTimtensp_CheckedChanged(object sender, EventArgs e)
        {
            tbTimtensp.Enabled = true;
            cbTimgiasp.Enabled = false;
            cbTimgiasp.ResetText();
        }

        private void rdTimgiasp_CheckedChanged(object sender, EventArgs e)
        {
            cbTimgiasp.Enabled = true;
            tbTimtensp.Enabled = false;
            tbTimtensp.ResetText();
        }

        private void tbTimtensp_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[TenMH] like '%" + tbTimtensp.Text + "%'";
            dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi);
        }

        private void cbTimgiasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimgiasp.Text == "Nhỏ hơn 500k")
            {
                string chuoi1 = "[GiaBan] < 500000";
                dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi1);
            }
            else if (cbTimgiasp.Text == "500k - 2tr")
            {
                string chuoi2 = "500000 < [GiaBan] and [GiaBan] <= 2000000";
                dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi2);
            }
            else if (cbTimgiasp.Text == "2tr - 4tr")
            {
                string chuoi3 = "2000000 < [GiaBan] and [GiaBan] <= 4000000";
                dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi3);
            }
            else if (cbTimgiasp.Text == "4tr - 6tr")
            {
                string chuoi4 = "4000000 < [GiaBan] and [GiaBan] <= 6000000";
                dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi4);
            }
            else if (cbTimgiasp.Text == "6tr - 8tr")
            {
                if (dtgShowfullsp.DataSource != null)
                {
                    string chuoi5 = "6000000 < [GiaBan] and [GiaBan] <= 8000000";
                    dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi5);
                }
            }
            else if (cbTimgiasp.Text == "8tr - 10tr")
            {
                string chuoi6 = "8000000 < [GiaBan] and [GiaBan] <= 10000000";
                dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi6);
            }
            else if (cbTimgiasp.Text == "Lon hon 10tr")
            {
                string chuoi7 = "[GiaBan] > 10000000";
                dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi7);
            }
        }

        private void mainLoad(object sender, EventArgs e)
        {
            string select = "Select HoTen from vw_TaiKhoan_NhanVien where TaiKhoan=N'" + idTaikhoan + "'";

            lbUser.Text = truyxuat.laychuoi(select, lbUser.Text);

            tbUpdateNhapten.ResetText();
            tbUpdategia.ResetText();
            tbUpdatema.ResetText();

            cbTimgiasp.Items.Add("Nhỏ hơn 500k");
            cbTimgiasp.Items.Add("500k - 2tr");
            cbTimgiasp.Items.Add("2tr - 4tr");
            cbTimgiasp.Items.Add("4tr - 6tr");
            cbTimgiasp.Items.Add("6tr - 8tr");
            cbTimgiasp.Items.Add("8tr - 10tr");
            cbTimgiasp.Items.Add("Lon hon 10tr");
            this.cbTimgiasp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dtNgayban.Format = DateTimePickerFormat.Custom;
            dtNgayban.CustomFormat = "dd/MM/yyyy";
            dtNgaynhap.Format = DateTimePickerFormat.Custom;
            dtNgaynhap.CustomFormat = "dd/MM/yyyy";

            string ttmathang = "SELECT TenMH, SoLuong FROM vw_MatHang ORDER BY SoLuong ASC";
            dtgTTsanpham.DataSource = ketnoi.Docdulieu(ttmathang);

            string nhaphang = "SELECT MaMH, TenMH FROM vw_MatHang";
            dtgCapnhapmh.DataSource = ketnoi.Docdulieu(nhaphang);

            string khachhang = "SELECT * FROM vw_KhachHang";
            cbMaKH.DataSource = ketnoi.Docdulieu(khachhang);
            cbMaKH.DisplayMember = "TenKH";
            cbMaKH.ValueMember = "MaKH";

            string fullmh = "SELECT * FROM vw_MatHang";
            dtgShowfullsp.DataSource = ketnoi.Docdulieu(fullmh);

            string laynv = "Select MaNV, HoTen From vw_NhanVien";
            cbChonnvNhap.DataSource = ketnoi.Docdulieu(laynv);
            cbChonnvNhap.ValueMember = "MaNV";
            cbChonnvNhap.DisplayMember = "HoTen";
            conn = new SqlConnection(ketnoi.chuoiketnoi());

            DisplayMatHangCount();
        }

        private void btnLamms_Click(object sender, EventArgs e)
        {
            mainLoad(sender,e);
        }

        private void tbUpdateNhapten_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[TenMH] like '%" + tbUpdateNhapten.Text + "%'";
            dtgShowfullsp.DataSource = truyxuat.timkiemdtgrif(dtgShowfullsp, chuoi);
        }

        private void btnCapnhapgia_Click(object sender, EventArgs e)
        {
            string update = "Update MatHang Set GiaBan='" + Convert.ToDouble(tbUpdategia.Text) + "' where MaMH='" + tbUpdatema.Text + "'";
            truyxuat.sua(update);
            MessageBox.Show("Cập nhập thành công!", "Thông báo");
            tbUpdatema.ResetText();
            tbUpdateNhapten.ResetText();
            tbUpdategia.ResetText();

            string ttmathang = "SELECT TenMH, SoLuong FROM MatHang ORDER BY SoLuong ASC";
            dtgTTsanpham.DataSource = ketnoi.Docdulieu(ttmathang);
            string fullmh = "SELECT * FROM MatHang";
            dtgShowfullsp.DataSource = ketnoi.Docdulieu(fullmh);
        }

        private void dtgShowfullsp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tbUpdatema.Text = dtgShowfullsp.CurrentRow.Cells[0].Value.ToString();
            this.tbUpdateNhapten.Text = dtgShowfullsp.CurrentRow.Cells[1].Value.ToString();
            this.tbUpdategia.Text = dtgShowfullsp.CurrentRow.Cells[8].Value.ToString();
        }

        private void tbUpdategia_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.tiente(tbUpdategia);
        }

        private void tabWiew_MouseClick(object sender, MouseEventArgs e)
        {
            string ttmathang = "SELECT MaMH, TenMH FROM MatHang";
            dtgNhaptenhang.DataSource = ketnoi.Docdulieu(ttmathang);
            string ttnhanvien = "SELECT MaNV, HoTen FROM NhanVien";
            dtgNhanvienban.DataSource = ketnoi.Docdulieu(ttnhanvien);
        }

        private void tbNhaptenmh_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[TenMH] like '%" + tbNhaptenmh.Text + "%'";
            dtgNhaptenhang.DataSource = truyxuat.timkiemdtgrif(dtgNhaptenhang, chuoi);
        }

        private void tbTennhanvienban_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[HoTen] like '%" + tbTennhanvienban.Text + "%'";
            dtgNhanvienban.DataSource = truyxuat.timkiemdtgrif(dtgNhanvienban, chuoi);
        }

        private void btnChonmh_Click(object sender, EventArgs e)
        {
            if (tbSoluongban.Text == "")
            {
                MessageBox.Show("Số lượng không được bỏ trống! " + tbSoluongban.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSoluongban.Focus();
            }
            else if (tbSoluongban.Text != "")
            {
                decimal slupdate;
                string maban = dtgNhaptenhang.CurrentRow.Cells[0].Value.ToString();
                string laysl = "Select SoLuong From MatHang where MaMH='" + maban + "'";
                int slb = Convert.ToInt32(tbSoluongban.Text);
                int slhienco = truyxuat.layrasoluong(laysl);
                slupdate = slhienco - slb;
                if (slupdate < 0)
                {
                    MessageBox.Show("Số lượng không lớn hơn số lượng đang có! " + tbSoluongban.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbSoluongban.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(tbSoluongban.Text)) return;
                    dtgDSmuahang.DataSource = null;
                    Banhang DS = new Banhang();
                    DS.lstMaMH = dtgNhaptenhang.CurrentRow.Cells[0].Value.ToString();
                    string chuoi = "Select GiaBan from MatHang where MaMH=N'" + DS.lstMaMH + "'";
                    DS.lstTenMH = dtgNhaptenhang.CurrentRow.Cells[1].Value.ToString();
                    DS.lstSoLuong = int.Parse(tbSoluongban.Text);
                    DS.lstGiaban = decimal.Parse(truyxuat.layso(chuoi, DS.lstGiaban.ToString()));
                    if (DSban.Any(n => n.lstMaMH == DS.lstMaMH))
                    {
                        DSban.First(n => n.lstMaMH == DS.lstMaMH).lstSoLuong = int.Parse(tbSoluongban.Text);
                        DSban.First(n => n.lstMaMH == DS.lstMaMH).lstGiaban = decimal.Parse(truyxuat.layso(chuoi, DS.lstGiaban.ToString()));
                        if (int.Parse(tbSoluongban.Text) == 0) DSban.Remove(DSban.First(n => n.lstMaMH == DS.lstMaMH));
                    }
                    else
                        DSban.Add(DS);
                    dtgDSmuahang.DataSource = DSban;
                    tbSoluongban.ResetText();
                    LoadTongTien();

                    dtgDSmuahang.Columns[0].HeaderText = "Mã MH";
                    dtgDSmuahang.Columns[1].HeaderText = "Tên MH";
                    dtgDSmuahang.Columns[2].HeaderText = "Số lượng";
                    dtgDSmuahang.Columns[3].HeaderText = "Giá bán";
                    dtgDSmuahang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dtgDSmuahang.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
            }
        }

        private void LoadTongTien()
        {
            decimal s = 0;
            foreach (var item in DSban)
            {
                s+= item.lstSoLuong * item.lstGiaban;
            }
            tbThanhtienban.Text = s.ToString();
        }

        private void btnChonnvban_Click(object sender, EventArgs e)
        {
            this.tbManvban.Text = dtgNhanvienban.CurrentRow.Cells[0].Value.ToString();
        }

        public void xdlThemhdxuat()
        {
            tbMahdxuat.ResetText();
            tbNhaptenmh.ResetText();
            tbSoluongban.ResetText();
            tbThanhtienban.ResetText();
            tbTennhanvienban.ResetText();
            tbManvban.ResetText();
        }

        private void btnThemhdxuat_Click(object sender, EventArgs e)
        {
            string select = "Select * From HoaDonXuat where MaHDX='" + tbMahdxuat.Text + "'";
            try
            {           
                {
                    if (DSban.Count == 0) return;
                    conn = new SqlConnection(ketnoi.chuoiketnoi());
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string ghihdxuat = "Insert Into HoaDonXuat(MaHDX, MaKH, ThanhTien, ThoiGianBan, MaNV, DiemTichLuy)" + "Values('" +
                                tbMahdxuat.Text + "', '" +
                                cbMaKH.SelectedValue + "', '" + Convert.ToDecimal(tbThanhtienban.Text) + "','" +
                                dtNgayban.Value.ToString("yyyy/MM/dd") + "', '" + tbManvban.Text + "'," + 0 + ")";
                            truyxuat.them(ghihdxuat);
                            foreach (var i in DSban)
                            {
                                string ghitDetail = "Insert Into HoaDonXuatChiTiet(MaHDX, MaMH, SoLuong, GiaTien, TenMH)" + "Values('" +
                                tbMahdxuat.Text + "', '" + i.lstMaMH + "', '" + i.lstSoLuong + "', N'" + i.lstGiaban + "','" + i.lstTenMH + "')";
                                truyxuat.them(ghitDetail);

                                decimal slud = i.lstSoLuong;

                                if (slud == 0)
                                {
                                    string tt = "Hết hàng";
                                    string updatesl3 = "Update MatHang Set TinhTrang=N'" + tt + "' where MaMH=N'" + i.lstMaMH + "'";
                                    truyxuat.sua(updatesl3);
                                    //string updatesl = "Update MatHang Set SoLuong=N'" + slud + "' where MaMH=N'" + i.lstMaMH + "'";
                                    //truyxuat.sua(updatesl);
                                }
                                else if(slud > 0)
                                {
                                    //string updatesl = "Update MatHang Set SoLuong=N'" + slud + "' where MaMH=N'" + i.lstMaMH + "'";
                                    //truyxuat.sua(updatesl);
                                }
                                
                            }
                            tran.Commit();

                            string ttmathang = "SELECT TenMH, SoLuong FROM MatHang ORDER BY SoLuong ASC";
                            dtgTTsanpham.DataSource = ketnoi.Docdulieu(ttmathang);
                            string fullmh = "SELECT * FROM MatHang";
                            dtgShowfullsp.DataSource = ketnoi.Docdulieu(fullmh);

                            xdlThemhdxuat();

                            MessageBox.Show("Ghi thành công hóa đơn!", "Thông báo");
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                    DSban = new List<Banhang>();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void tbSoluongban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSodienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private float tinhtien(float a, int b)
        {
            return a * b;
        }

        private void tbThanhtienban_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.tiente(tbThanhtienban);
        }

        private void btnHuyhdxuat_Click(object sender, EventArgs e)
        {
            tbMahdxuat.ResetText();
            tbNhaptenmh.ResetText();
            tbSoluongban.ResetText();
            tbTennhanvienban.ResetText();
        }

        private void xoatextnhap()
        {
            cbChonnvNhap.ResetText();
            tbManvnhap.ResetText();
            tbGianhap.ResetText();
            tbSoluongnhap.ResetText();
            tbThanhtiennhap.ResetText();
            dtNgaynhap.ResetText();
            tbNhaptenmhcapnhap.ResetText();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string select = "Select * From HoaDonNhap where MaHDN='" + tbMahdnhap.Text + "'";

                {
                    string ghihdnhap = "Insert Into HoaDonNhap(MaHDN, ThanhTien, MaNV, ThoiGianNhap)" + "Values(N'" +
                        tbMahdnhap.Text + "', '" + decimal.Parse(tbThanhtiennhap.Text) + "', '" +
                        cbChonnvNhap.SelectedValue + "', '" + dtNgaynhap.Value.ToString("yyyy/MM/dd HH:mm:ss") + "')";
                    truyxuat.them(ghihdnhap);
                    if (dtgDScapnhapmh.DataSource != null)
                    {
                        if (DScapnhap.Count == 0) return;
                        conn = new SqlConnection(ketnoi.chuoiketnoi());
                        conn.Open();
                        using (SqlTransaction tran = conn.BeginTransaction())
                        {
                            try
                            {
                                foreach (var i in DScapnhap)
                                {
                                    string mancc = "";
                                    string chuoi1 = "Select MaNCC From MatHang where MaMH='" + i.lstMaMH + "'";
                                    mancc = truyxuat.laychuoi(chuoi1, mancc);
                                    string malh = "";
                                    string chuoi2 = "Select MaLH From MatHang where MaMH='" + i.lstMaMH + "'";
                                    malh = truyxuat.laychuoi(chuoi2, malh);
                                    
                                    string ghihdDetail = "Insert Into HoaDonNhapChiTiet(MaHDN, MaMH, MaNCC, SoLuong, GiaNhap, TenMH)" + "Values('" +
                                     tbMahdnhap.Text + "', '" + i.lstMaMH + "', '" + mancc + "', '" +
                                    i.lstSoLuong + "', '" + i.lstGianhap + "', N'" + i.lstTenMH + "')";
                                    truyxuat.them(ghihdDetail);
                                    
                                    //string laysl2 = "Select SoLuong From MatHang where MaMH='" + i.lstMaMH + "'";
                                    //int slupadate;
                                    //int slhienco = truyxuat.layrasoluong(laysl2);
                                    //int slnhap = int.Parse(i.lstSoLuong.ToString());
                                    //slupadate = slhienco + slnhap;
                                    //string updatemh = "Update MatHang Set SoLuong=N'" + slupadate + "' where MaMH=N'" + i.lstMaMH + "'";
                                    //truyxuat.sua(updatemh);
                                    
                                    decimal gb;
                                    decimal gn = i.lstGianhap;
                                    gb = (gn * 100 / 75);
                                    string giabancn = Math.Round(gb).ToString();
                                    string updategiab = "Update MatHang Set GiaBan=N'" + Convert.ToDouble(giabancn) + "' where MaMH=N'" + i.lstMaMH + "'";
                                    truyxuat.sua(updategiab);
                                    
                                    string tt = "Còn hàng";
                                    string updatesl3 = "Update MatHang Set TinhTrang=N'" + tt + "' where MaMH=N'" + i.lstMaMH + "'";

                                    truyxuat.sua(updatesl3);

                                }
                                tran.Commit();

                                string ttmathang = "SELECT TenMH, SoLuong FROM MatHang ORDER BY SoLuong ASC";
                                dtgTTsanpham.DataSource = ketnoi.Docdulieu(ttmathang);
                                string fullmh = "SELECT * FROM MatHang";
                                dtgShowfullsp.DataSource = ketnoi.Docdulieu(fullmh);

                                xoatextnhap();

                                MessageBox.Show("Ghi thành công hóa đơn!", "Thông báo");

                                dtgDScapnhapmh.DataSource = null;
                                conn.Close();
                            }
                            catch
                            {
                                tran.Rollback();
                                throw;
                            }
                        }
                        DScapnhap = new List<Capnhapmh>();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! Thông tin: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbChonnvNhap.ResetText();
            tbManvnhap.ResetText();
            tbGianhap.ResetText();
            tbSoluongnhap.ResetText();
            tbThanhtiennhap.ResetText();
            dtNgaynhap.ResetText();
            tbNhaptenmhcapnhap.ResetText();
        }

        private void tbGianhap_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.tiente(tbGianhap);
            if (tbGianhap.Text != "")
            {
                tbSoluongnhap.Enabled = true;
            }
            else
            {
                tbSoluongnhap.Enabled = false;
            }
        }

        private void tbGianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSoluongnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSoluongnhap_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.chuansl(tbSoluongnhap, tbGianhap, tbThanhtiennhap);
        }

        private void tbThanhtiennhap_TextChanged(object sender, EventArgs e)
        {
            chuanhoa.tiente(tbThanhtiennhap);
        }

        private void btnSelecmh_Click(object sender, EventArgs e)
        {
            if (tbSoluongnhap.Text == "")
            {
                MessageBox.Show("Số lượng không được bỏ trống! " + tbSoluongnhap.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSoluongnhap.Focus();
            }
            else if (tbGianhap.Text == "")
            {
                MessageBox.Show("Giá nhập không được bỏ trống! " + tbGianhap.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbGianhap.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(tbSoluongnhap.Text)) return;
                dtgDScapnhapmh.DataSource = null;
                Capnhapmh DS = new Capnhapmh();
                DS.lstMaMH = dtgCapnhapmh.CurrentRow.Cells[0].Value.ToString();
                DS.lstTenMH = dtgCapnhapmh.CurrentRow.Cells[1].Value.ToString();
                DS.lstSoLuong = int.Parse(tbSoluongnhap.Text);
                DS.lstGianhap = decimal.Parse(tbGianhap.Text);
                if (DScapnhap.Any(n => n.lstMaMH == DS.lstMaMH))
                {
                    DScapnhap.First(n => n.lstMaMH == DS.lstMaMH).lstSoLuong = int.Parse(tbSoluongnhap.Text);
                    DScapnhap.First(n => n.lstMaMH == DS.lstMaMH).lstGianhap = decimal.Parse(tbGianhap.Text);
                    if (int.Parse(tbSoluongnhap.Text) == 0) DScapnhap.Remove(DScapnhap.First(n => n.lstMaMH == DS.lstMaMH));
                }
                else
                    DScapnhap.Add(DS);
                dtgDScapnhapmh.DataSource = DScapnhap;
                tbSoluongnhap.ResetText();
                tbGianhap.ResetText();
                tinhtiennhap();

                dtgDScapnhapmh.Columns[0].HeaderText = "Mã MH";
                dtgDScapnhapmh.Columns[1].HeaderText = "Tên mặt hàng";
                dtgDScapnhapmh.Columns[2].HeaderText = "Số lượng";
                dtgDScapnhapmh.Columns[3].HeaderText = "Giá nhập";
                dtgDScapnhapmh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dtgDScapnhapmh.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void tinhtiennhap()
        {
            decimal s = 0, v = 0, t = 0;
            foreach (var item in DScapnhap)
            {
                s+= item.lstSoLuong * item.lstGianhap;
            }
            foreach (var i in DSthemmoi)
            {
                v+= i.Soluong * i.Gianhap;
            }
            t = s + v;
            tbThanhtiennhap.Text = t.ToString();
        }

        private void cbChonnvNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbManvnhap.ResetText();
            string var = cbChonnvNhap.Text;
            string select = "Select MaNV from NhanVien where HoTen=N'" + var + "'";
            tbManvnhap.Text = truyxuat.laychuoi(select, tbManvnhap.Text);
        }

        private void tbNhaptenmhcapnhap_TextChanged(object sender, EventArgs e)
        {
            string chuoi = "[TenMH] like '%" + tbNhaptenmhcapnhap.Text + "%'";
            dtgCapnhapmh.DataSource = truyxuat.timkiemdtgrif(dtgCapnhapmh, chuoi);
        }
       
        private void btnThemmh_Click(object sender, EventArgs e)
        {
            frmThemmathang frm = new frmThemmathang();
            frm.ShowDialog();
        }
        

        
        private void btnLammoithemmh_Click(object sender, EventArgs e)
        {

        }


        private void tbUpdategia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimk frm = new frmDoimk();
            frm.Tentaikhoan = idTaikhoan;
            frm.ShowDialog();
        }
        
        private void btnSuattsp_Click(object sender, EventArgs e)
        {
            frmSuamathang frm = new frmSuamathang();
            frm.Mamh = dtgShowfullsp.CurrentRow.Cells[0].Value.ToString();
            frm.Tenmh = dtgShowfullsp.CurrentRow.Cells[1].Value.ToString();
            frm.Mancc = dtgShowfullsp.CurrentRow.Cells[2].Value.ToString();
            frm.Malh = dtgShowfullsp.CurrentRow.Cells[3].Value.ToString();
            frm.Hangsx = dtgShowfullsp.CurrentRow.Cells[4].Value.ToString();
            frm.Noisx = dtgShowfullsp.CurrentRow.Cells[5].Value.ToString();
            frm.Kythuat = dtgShowfullsp.CurrentRow.Cells[6].Value.ToString();
            frm.Soluong = dtgShowfullsp.CurrentRow.Cells[7].Value.ToString();
            frm.Giaban = dtgShowfullsp.CurrentRow.Cells[8].Value.ToString();
            frm.Tinhtrang = dtgShowfullsp.CurrentRow.Cells[9].Value.ToString();
            frm.ShowDialog();
            DisplayMatHangCount();
        }
        

        private void btnXoattsp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult check = MessageBox.Show("Bạn có xóa thông tin mặt hàng hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (check == DialogResult.OK)
                {
                    truyxuat.Xoa("MatHang", "MaMH", dtgShowfullsp);
                    MessageBox.Show("Xóa Thông tin thành công!", "Thông báo");
                    string chuoi2 = "Select * From MatHang";
                    dtgShowfullsp.DataSource = ketnoi.Docdulieu(chuoi2);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xoá. Lỗi: " + ex);
            }
            DisplayMatHangCount();
        }

        private void tsThongTinNV_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.ShowDialog();
        }

        private void tsLuongNV_Click(object sender, EventArgs e)
        {
            frmLuongNV fLNV = new frmLuongNV();
            fLNV.ShowDialog();
        }
        
        private void tsQLChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu fCV = new frmChucVu();
            fCV.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmView fV = new frmView();
            fV.ShowDialog();
        }
        frmView fV = new frmView();
        private void tsmXemDonXuat_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemDonXuat";
            fV.lbView.Text = fV.lbView.Text + " ĐƠN XUẤT";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmNhanVienNhapHang_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemNhanVienNhapHang";
            fV.lbView.Text = fV.lbView.Text + " NHÂN VIÊN NHẬP HÀNG";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmBanHang_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemNhanVienBanHang";
            fV.lbView.Text = fV.lbView.Text + " NHÂN VIÊN BÁN HÀNG";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmChiTietNhap_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemChiTietHoaDonNhap";
            fV.lbView.Text = fV.lbView.Text + " CHI TIẾT HOÁ ĐƠN NHẬP";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmChiTietXuat_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemChiTietHoaDonXuat";
            fV.lbView.Text = fV.lbView.Text + " CHI TIẾT HOÁ ĐƠN XUẤT";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmPhiNhapThang_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemChiPhiNhapTheoThang";
            fV.lbView.Text = fV.lbView.Text + " CHI PHÍ NHẬP THEO THÁNG";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmTongThuThang_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemDoanhThuTheoThang";
            fV.lbView.Text = fV.lbView.Text + " TỔNG TIỀN THU THEO THÁNG";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmTongLuongThang_Click(object sender, EventArgs e)
        {
            string chuoi = "SELECT * FROM XemTongLuongNVThang";
            fV.lbView.Text = fV.lbView.Text + " LƯƠNG NHÂN VIÊN THEO THÁNG";
            fV.DgvView.DataSource = ketnoi.Docdulieu(chuoi);
            fV.ShowDialog();
        }

        private void tsmTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan fTK = new frmTaiKhoan();
            fTK.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemmathang fThem = new frmThemmathang();
            fThem.ShowDialog();
            DisplayMatHangCount();
        }

        private void tsmQLKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang fKH = new frmKhachHang();
            fKH.ShowDialog();
        }

        private void btnTongHangTheoLoai_Click(object sender, EventArgs e)
        {
            string fnName = "SELECT * FROM TongHangTheoLoaiHang()";
            fV.lbView.Text = fV.lbView.Text + " TỔNG HÀNG THEO LOẠI HÀNG";
            DataTable table = ketnoi.Docdulieu(fnName);
            fV.DgvView.DataSource = table;
            fV.ShowDialog();
        }

        private void bntThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHang fKH = new frmKhachHang();
            fKH.ShowDialog();
        }

        private void DisplayMatHangCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ketnoi.chuoiketnoi()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("EXEC TinhTongSoLuong", connection);
                    int totalRows = (int)command.ExecuteScalar();

                    lbTongSoHang.Text = "Tổng số lượng hàng: " + totalRows;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi tải tổng số lượng hàng", "Lỗi");
            }
        }

        private void btnThemhdnhap_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tsmHoaDonNhap_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap fdonnhap = new frmHoaDonNhap();
            fdonnhap.ShowDialog();
        }

        private void tmsHoaDonXuat_Click(object sender, EventArgs e)
        {
            frmHoaDonXuat fdonxuat = new frmHoaDonXuat();
            fdonxuat.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login frm = new Login();
            frm.ShowDialog();
        }
    }

    public class Banhang
    {
        public string lstMaMH { get; set; }

        public string lstTenMH { get; set; }

        public int lstSoLuong { get; set; }

        public decimal lstGiaban { get; set; }
    }

    public class Capnhapmh
    {
        public string lstMaMH { get; set; }

        public string lstTenMH { get; set; }

        public int lstSoLuong { get; set; }

        public decimal lstGianhap { get; set; }
    }

    public class Themmoimh
    {
        public string MaMH { get; set; }

        public string TenMH { get; set; }

        public string MaNCC { get; set; }

        public string MaLH { get; set; }

        public string HangSX { get; set; }

        public string NoiSX { get; set; }

        public string Thongsokythuat { get; set; }

        public int Soluong { get; set; }

        public decimal Gianhap { get; set; }

        public decimal Giaban { get; set; }

        public string Tinhtrang { get; set; }

    }
}
