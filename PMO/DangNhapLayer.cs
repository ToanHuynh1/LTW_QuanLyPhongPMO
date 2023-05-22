using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMO.Models;

namespace PMO
{
    public class DangNhapLayer
    {

        Context dbs = new Context();
        public bool dangNhap(ref string err,string userLogin, string passLogin)
        {
            bool flag = false;
            var dn = from tkLogin in dbs.DangNhaps join nscv in dbs.NhanSus
                     on tkLogin.MaNS equals nscv.MaNS
                     where tkLogin.UserLogin == userLogin &&
                     tkLogin.PassLogin == passLogin
                     select nscv;
         
           
            if (dn.Count() == 0)
            {
                err = "Tên Đăng Nhập hoặc Mật Khẩu sai !";
            }
            else
            {
                flag = true;
                foreach (var cn in dn)
                {
                    LoginDangNhap.MaNS = cn.MaNS;
                    LoginDangNhap.MaCV = (int)cn.MaCV;
                }
            }
            return flag;
        }
    }
}
