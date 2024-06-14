using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom08_CuaHangDienDienLanh
{
    class chuanhoa
    {

        //Viết hoa chữ cái đầu

        public static string viethoa(string s)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
        }

        //Chuẩn hiển thị tiền mặt

        public static void tiente(TextBox a)
        {
            try
            {

                double flTienThuong = double.Parse(a.Text.Replace(",", ""));
                a.Text = flTienThuong.ToString("0,00.##");
                a.Select(a.TextLength, 0);
            }
            catch (Exception)
            {

            }
        }

        //Chuẩn hóa nhập số lượng

        public static void chuansl(TextBox slb, TextBox gia, TextBox tt)
        {
            if (slb.Text == "0")
            {
                float gian = !string.IsNullOrEmpty(gia.Text) ? float.Parse(gia.Text) : 0;
                int sl = !string.IsNullOrEmpty(slb.Text) ? int.Parse(slb.Text) : 0;
                double kq = gian * sl;
                tt.Text = kq.ToString();
                int sl1 = !string.IsNullOrEmpty(slb.Text) ? int.Parse(slb.Text) : 0;
                slb.Text = sl1.ToString();
            }
            else
            {
                float gian = !string.IsNullOrEmpty(gia.Text) ? float.Parse(gia.Text) : 0;
                int sl = !string.IsNullOrEmpty(slb.Text) ? int.Parse(slb.Text) : 0;
                double kq = gian * sl;
                tt.Text = kq.ToString();
            }
        }

    }
}
