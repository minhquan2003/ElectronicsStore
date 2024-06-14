using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    public static class LoginData
    {
        public static string username;
        public static string password;
        public static bool adminRole;
    }
    public class ketnoi
    {

        public static string chuoiketnoi()
        {
            return  $"Data Source=ADMIN; Initial Catalog=CuaHangDienDienLanh;User ID={LoginData.username};Password={LoginData.password};";
        }

        public static DataTable Docdulieu(string query)
        {
            string chuoikn =  $"Data Source=ADMIN; Initial Catalog=CuaHangDienDienLanh;User ID={LoginData.username};Password={LoginData.password};";
            SqlConnection conn = new SqlConnection(chuoikn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cmd.Dispose();
            conn.Close();
            return data;
        }

        public static object ExcuteScalar(string query)
        {
            object data = 0;
            SqlConnection conn = new SqlConnection(ketnoi.chuoiketnoi());
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                data = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi ExecuteScalar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public static int getListCount(string sl)
        {
            string query = string.Format(sl);

            return (int)ExcuteScalar(query);
        }
    }
}
