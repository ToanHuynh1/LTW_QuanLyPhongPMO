using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PMO.Models;
namespace PMO
{
    public class ThietBiLayer
    {
        Context tbs = new Context();
        public List<ThietBi> listThietBi()
        {
            return tbs.ThietBis.ToList();
        }

        public List<ThietBi> TimKiem(ref string err, string thietbi)
        {

            var tk = from moitb in tbs.ThietBis
                     where moitb.TenTB.Contains(thietbi)
                     select moitb;
          
            if (tk.Count() == 0)
            {
                err = "Không tìm thấy";

            }
            return tk.ToList();
        }
   
        public bool XoaThietBi(ref string err, int thietbi)
        {
            bool flag = false;
            
            var toDelete = tbs.ThietBis.Find(thietbi);
            if (toDelete != null)
            {
                tbs.ThietBis.Remove(toDelete);
                tbs.SaveChanges();
                flag = true;
            }
            return flag;
        }

        public bool ThemThietBi(ref string err,int maloaitb,string tentb, int soluong)
        {
            bool flag = false;
            try
            {

                ThietBi tb = new ThietBi();        
                tb.TenTB = tentb;
                tb.SoLuong = soluong;
           
                tb.LoaiThietBi = tbs.LoaiThietBis.Find(maloaitb);
                tbs.ThietBis.Add(tb);
                tbs.SaveChanges();
                
                flag = true;
            }
            catch (SqlException)
            {
                err = "Loi rui!!!";
            }
            return flag;
        }

        public bool CapNhatThietBi(ref string err, int matb, string tenthietbi,int maloaitb, int soluong)
        {
            bool flag = false;
            try
            {
                var tb = tbs.ThietBis.Find(matb);
                if (tb != null)
                {
                    tb.TenTB = tenthietbi;
                    tb.MaLoaiTB = maloaitb;
                    tb.SoLuong = soluong;
                    tbs.SaveChanges();
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
