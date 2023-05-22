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
    public partial class ThongTinCaNhan : Form
    {
        
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinNhanSu_Load(object sender, EventArgs e)
        {
            ThongTinCaNhanLayer tttklayer = new ThongTinCaNhanLayer();
            tttklayer.ThongTinNhanSu();
            tbHoTen.Text = tttklayer.hoTen;
            tbCMND.Text = tttklayer.cmnd;
            tbMssv.Text = tttklayer.mssv;
            tbSdt.Text = tttklayer.sdt;
            if (tttklayer.phai == "Nam")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else if (tttklayer.phai == "Nữ")
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            //dtpNS.Text = tttklayer.ngaySinh.ToString();
            tbLinkfb.Text = tttklayer.linkFB.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinCaNhanLayer tttklayer = new ThongTinCaNhanLayer();
            if (MessageBox.Show("Bạn có chắc muốn sửa thông tin","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string err = "";
                string gt = "";
                if (radioButton1.Checked == true)
                {
                    gt = radioButton1.Text;
                }else
                    gt = radioButton2.Text;
                if (tttklayer.CapNhatCaNhan(ref err, tbHoTen.Text, tbCMND.Text, dtpNS.Value, tbSdt.Text, tbMssv.Text, tbLinkfb.Text, gt) == true)
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                else
                    MessageBox.Show("Cập Nhật Thất Bại");

            }    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
