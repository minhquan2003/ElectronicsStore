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
using System.Data.Sql;
using System.Diagnostics;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public partial class Login : Form
    {
        SqlConnection conn = null;
        private string idUser = "";
        private string idLevel = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginData.username = tbUser.Text.Trim();
                LoginData.password = tbPass.Text.Trim();
                conn = new SqlConnection(ketnoi.chuoiketnoi());
                conn.Open();
                string selectUserRole = "dbo.GetUserRole";
                SqlCommand cmdUserRole = new SqlCommand(selectUserRole, conn);
                cmdUserRole.CommandType = CommandType.StoredProcedure;
                cmdUserRole.Parameters.AddWithValue("@Username", tbUser.Text.Trim());
                cmdUserRole.Parameters.AddWithValue("@Password", tbPass.Text.Trim());
                string userRole = cmdUserRole.ExecuteScalar()?.ToString();
                if (!string.IsNullOrEmpty(userRole))
                {
                    idUser = tbUser.Text.Trim();
                    idLevel = userRole;
                    cmdUserRole.Dispose();
                    conn.Close();
                    frmMain frm = new frmMain();
                    frm.idTaikhoan = idUser;
                    frm.idQuyen = idLevel;
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu!", "Thông báo");
                tbUser.Text = "";
                tbPass.Text = "";
                tbUser.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (check == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
              
        }
    }
}
