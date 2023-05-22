using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMO
{
    public partial class LoginDangNhap : Form
    {
        public static int MaNS = 0;
        public static int MaCV = 0;
        public LoginDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string err = "Tài Khoản hoặc Mật Khẩu bị sai";
            DangNhapLayer dnLayer = new DangNhapLayer();
            if(dnLayer.dangNhap(ref err, tbUserlogin.Text,tbPasslogin.Text) == true)
            {
                TrangChuPMO tcPMO = new TrangChuPMO();
                this.Hide();
                tcPMO.ShowDialog();
                this.Show();
            }else
                MessageBox.Show(err);
        }
    }
}
