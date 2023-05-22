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
    public partial class ThongTinNhanSu : Form
    {
        private int check = 0;
        NhanSuLayer ns = new NhanSuLayer();
        public ThongTinNhanSu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ThongTinNhanSu_Load(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            dgvNhanSu.DataSource = ns.listNhanSu();
            dgvNhanSu.Columns[9].Visible = false;
            dgvNhanSu.Columns[10].Visible = false;
            dgvNhanSu.Columns[11].Visible = false;
            dgvNhanSu.Columns[12].Visible = false;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = true;
            //btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void dgvNhanSu_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                int i = dgvNhanSu.CurrentRow.Index;
                txtTenNS.Text = dgvNhanSu.Rows[i].Cells[1].Value.ToString();
                txtCMND.Text = dgvNhanSu.Rows[i].Cells[2].Value.ToString();
                txtSDT.Text = dgvNhanSu.Rows[i].Cells[4].Value.ToString();
                txtMSSV.Text = dgvNhanSu.Rows[i].Cells[5].Value.ToString();
                if (dgvNhanSu.Rows[i].Cells[6].Value.ToString() == "Nam")
                    raButNam.Checked = true;
                else
                    raButNu.Checked = true;
                txtMaCV.Text = dgvNhanSu.Rows[i].Cells[7].Value.ToString();
                txtLinkFace.Text = dgvNhanSu.Rows[i].Cells[8].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            check = 1;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                string phai;
                string err = "";
                if (raButNam.Checked == true)
                    phai = "Nam";
                else
                    phai = "Nu";
                ns.ThemNhanSu(ref err, txtTenNS.Text, txtCMND.Text, datetPNgaySinh.Value, txtSDT.Text, txtMSSV.Text, phai,
                   int.Parse(txtMaCV.Text), txtLinkFace.Text);
            }
        }
    }
}
