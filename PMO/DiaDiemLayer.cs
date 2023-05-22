using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using PMO.Models;

namespace PMO
{
    public class DiaDiemLayer
    {
        
        Context dbs = new Context();
        public List<DiaDiem> LayDiaDiem()
        {
            return dbs.DiaDiems.ToList();

        }
        public List<DiaDiem> TimKiem(ref string err, string diaDiem)
        {
            
               var tk =  from moidd in dbs.DiaDiems
                where moidd.TenDD.Contains(diaDiem) 
                    select moidd;
            if(tk.Count() == 0)
            {
                err = "Khong tim thay";
                
            }
            return tk.ToList();
        }
        public bool ThemDiaDiem(ref string err, string diaDiem)
        {
            bool flag = false;
            try
            {
                DiaDiem dd = new DiaDiem();
                dd.TenDD = diaDiem;
                dbs.DiaDiems.Add(dd);
                dbs.SaveChanges();
                flag = true;
            }catch(SqlException)
            {
                err = "Loi";
            }
            return flag;
        }
        public bool XoaDiaDiem(ref string err,int maDD)
        {
            bool flag = false;
            var toDelete = dbs.DiaDiems.Find(maDD);
            if(toDelete != null)
            {
                dbs.DiaDiems.Remove(toDelete);
                dbs.SaveChanges();
                flag=true;
            }
            return flag;
        }
        public bool CapNhatDiaDiem(ref string err,int maDD, string diaDiem)
        {
            bool flag =false;
            try
            {
                var dd = dbs.DiaDiems.Find(maDD);
                if(dd != null)
                {
                    dd.TenDD = diaDiem;
                    dbs.SaveChanges();
                    flag = true;
                }
            }catch(SqlException)
            {
                err ="Loi";
            }
            return flag;
        }
        
    }
}
