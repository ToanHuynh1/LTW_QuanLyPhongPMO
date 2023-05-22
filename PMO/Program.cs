using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PMO
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new Initializer());
            RunLocalQuery();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginDangNhap());
        }
        private static void RunLocalQuery()
        {
            using (var context = new Context())
            {
                //context.nhanSus.ToList();
                context.NhanSus.Load();


            }
        }
    }
}
