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
    public partial class TrangChuPMO : Form
    {
        public TrangChuPMO()
        {
            InitializeComponent();
        }

        private void TrangChuPMO_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form hientai;
        private void OpenFormNew(string tenForm,Form formNew)
        {
            if(hientai != null)
            {
                hientai.Close();
            }
            label1.Text = tenForm;
            hientai = formNew;
            formNew.TopLevel = false;
            formNew.FormBorderStyle = FormBorderStyle.None;
            formNew.Dock = DockStyle.Fill;
            panel1.Controls.Add((formNew));
            panel1.Tag = formNew;
            formNew.BringToFront();
            formNew.Show();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ThongTinCaNhanLayer tttk = new ThongTinCaNhanLayer();
            tttk.ThongTinNhanSu();       
            OpenFormNew("Thông Tin "+tttk.chucVu,new ThongTinCaNhan());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFormNew("Trang Chủ)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFormNew("Thông Tin Tư Liệu", new ThongTinTuLieu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFormNew("Thông Tin Các Nhân Sự", new ThongTinNhanSu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFormNew("Thông Tin Sản Phẩm",new ThongTinSanPham());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFormNew("Thông Tin Hoạt Động",new ThongTinHoatDong());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFormNew("Thông Tin Thiết Bị", new ThongTinThietBi());
        }
    }
}
