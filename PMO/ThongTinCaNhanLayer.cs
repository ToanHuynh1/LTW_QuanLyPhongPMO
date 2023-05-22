using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMO
{
    public class ThongTinCaNhanLayer
    {
        Context dbs = new Context();
        public string hoTen = "";
        public string cmnd = "";
        public DateTime ngaySinh;
        public string sdt = "";
        public string mssv = "";
        public  string phai = "";
        public  string chucVu = "";
        public  string linkFB = "";
        public bool ThongTinNhanSu ()
        {
            var ttns = from ns in dbs.NhanSus
                       where ns.MaNS == LoginDangNhap.MaNS
                       select new
                       {
                          hoTen = ns.HoTen,
                           chucVu = ns.ChucVu.TenCV,
                           phai = ns.Phai,
                           cmnd = ns.CMND,
                           ngaySinh = ns.NgaySinh,
                           sdt = ns.SDT,
                           linkFB = ns.LinkFB,
                           mssv = ns.MSSV
                       };
            foreach (var t in ttns)
            {
                hoTen = t.hoTen;
                cmnd = t.cmnd;
                ngaySinh = t.ngaySinh.Value;
                sdt = t.sdt;
                mssv = t.mssv;
                chucVu = t.chucVu;
                linkFB = t.linkFB;
                phai = t.phai;
            }
            return true;
        }

        public bool CapNhatCaNhan(ref string err, string TEN, string CMND, DateTime NS, string SDT, string MSSV, string LINKFB, string PHAI)
        {
            bool flag = false;
            try
            {
                
                var dd = dbs.NhanSus.Find(LoginDangNhap.MaNS);
                if (dd != null)
                {
                    dd.MSSV = MSSV;
                    dd.CMND = CMND;
                    dd.SDT = SDT;
                    dd.LinkFB = LINKFB; 
                    dd.Phai = PHAI;
                    dd.HoTen = TEN;
                    dd.NgaySinh = NS;
                    dbs.SaveChanges();
                    flag = true;
                }
            }
            catch (SqlException)
            {
                err = "Loi";
            }
            return flag;
        }
    }
}
