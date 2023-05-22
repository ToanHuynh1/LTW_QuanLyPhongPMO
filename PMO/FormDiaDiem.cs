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
    public partial class FormDiaDiem : Form
    {
        DiaDiemLayer ddLayer = new DiaDiemLayer();
        public FormDiaDiem()
        {
            InitializeComponent();
        }

        private void FormDiaDiem_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dataGridView1.DataSource = ddLayer.LayDiaDiem();
                dataGridView1.Columns[0].HeaderText = "Mã Địa Điểm";
                dataGridView1.Columns[1].HeaderText = "Tên Địa Điểm";
                dataGridView1.Columns[2].Visible = false;
              
            }catch
            {

            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            string err = null;
            dataGridView1.DataSource = ddLayer.TimKiem(ref err, tbTK.Text);
            if(err != null)
            {
                MessageBox.Show(err);
                LoadData();
            }    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbTK_TextChanged(object sender, EventArgs e)
        {
            btnTK_Click(sender, e);
        }
    }
}
