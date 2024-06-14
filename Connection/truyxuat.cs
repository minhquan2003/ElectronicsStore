using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    class truyxuat
    {
        //private static string chuoikn = "Data Source=ADMIN; Initial Catalog=CuaHangDienDienLanh; Integrated Security=true";
        private static string chuoikn = $"Data Source=ADMIN; Initial Catalog=CuaHangDienDienLanh;User ID={LoginData.username};Password={LoginData.password};";
        //Thêm dữ liệu vào sql

        public static void them(string chuoi)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(chuoi, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Cập nhập dữ liệu vào sql

        public static void sua(string chuoi)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(chuoi, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Xóa dữ liệu

        public static void Xoa(string tenbang, string doituong, DataGridView dtg)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandType = CommandType.Text;
            int i = dtg.CurrentCell.RowIndex;
            string d = dtg.Rows[i].Cells[0].Value.ToString();
            cmd.CommandText = System.String.Concat("Delete From " + tenbang + " where " + doituong + " = '" + d + "'");
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //Lấy ra 1 chuỗi textbox

        public static string laychuoi(string s, string ra)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ra = reader.GetString(0);
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            return ra;
        }

        //Lấy ra 1 chuỗi số convert to string

        public static string layso(string s, string ra)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ra = reader.GetDouble(0).ToString();
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            return ra;
        }

        public static string decimallayra(string s, string ra)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ra = reader.GetDecimal(0).ToString();
            }
            reader.Close();
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
            return ra;
        }


        //Lấy ra 1 chuỗi combobox

        public static void layracombobox(string s, ComboBox a)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand command = new SqlCommand(s, conn);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                a.Items.Add(read.GetString(0));
            }
            read.Dispose();
            command.Dispose();
            conn.Close();
        }

        //Tìm kiếm trong Datagridview

        public static DataTable timkiemdtgrif(DataGridView dtg, string chuoi)
        {
            if (dtg.DataSource != null)
            {
                DataTable tb = (DataTable)dtg.DataSource;
                tb.DefaultView.RowFilter = chuoi;
                return tb;
            }
            else
            {
                return null;
            }
        }

        //Kiểm tra chuỗi nhập có trùng hay không

        public static int kiemtratext(string s)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                return 1;
            }
            else
            {
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                return 0;
            }
        }

        //Lấy ra số lượng (INT)

        public static int layrasoluong(string s)
        {
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string chuoi1 = "";
                int slhienco;
                chuoi1 = reader.GetInt32(0).ToString();
                cmd.Dispose();
                reader.Close();
                reader.Dispose();
                slhienco = int.Parse(chuoi1);
                return slhienco;
            }
            else
            {
                return 0;
            }
        }
    }
}
