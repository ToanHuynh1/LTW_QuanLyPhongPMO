using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PMO.Models;
namespace PMO
{
    public class NhanSuLayer
    {
        Context dbs = new Context();
        public List<NhanSu> listNhanSu()
        {
            return dbs.NhanSus.ToList();
        }
        public bool XoaNhanSu(ref string err, int nhansu)
        {
            bool flag = false;
            var toDelete = dbs.NhanSus.Find(nhansu);
            if (toDelete != null)
            {
                dbs.NhanSus.Remove(toDelete);
                dbs.SaveChanges();
                flag = true;
            }
            return flag;
        }
        
        public bool ThemNhanSu(ref string err , string hoten, string cmnd, DateTime ngaysinh, string sdt, string mssv,
            string phai, int macv, string linkface)
        {
            bool flag = false;
            try
            {

               // maxNS++;
                
                NhanSu tp = new NhanSu();
                tp.HoTen = hoten;
                tp.CMND = cmnd;
                tp.NgaySinh = ngaysinh;
                tp.SDT = sdt;
                tp.MSSV = mssv;
                tp.Phai = phai;
                tp.MaCV = macv;
                tp.LinkFB = linkface;
                tp.ChucVu = dbs.ChucVus.Find(macv);
                dbs.NhanSus.Add(tp);
                dbs.SaveChanges();
                int maxNS = dbs.NhanSus.Count();
                tp.DangNhap = dbs.DangNhaps.Add(new DangNhap { UserLogin = string.Format("NV_{0:0000}", maxNS.ToString()),PassLogin="1",NhanSu=tp  });
                dbs.SaveChanges();
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi rui!!!";
            }
            return flag;
        }

    }
}
