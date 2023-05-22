using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMO
{

    public partial class ThongTinThietBi : Form
    {
        private string err = "";
        private int check = 0;
        bool Them = true;

        ThietBiLayer tb = new ThietBiLayer();
        public ThongTinThietBi()
        {
            InitializeComponent();
        }


        void LoadData()
        {
            try
            {

                // Đưa dữ liệu lên DataGridView  
                gdv_ThietBi.DataSource = tb.listThietBi();
                gdv_ThietBi.Columns[4].Visible = false;
                gdv_ThietBi.Columns[5].Visible = false;
     
         
                // Thay đổi độ rộng cột 
                gdv_ThietBi.AutoResizeColumns();
        
                // Xóa trống các đối tượng trong Panel 
                this.txtMaLoaiTB.ResetText();
                this.txtMaTB.ResetText();
                this.txtSoluong.ResetText();
                this.txtTenTb.ResetText();
                this.btnLuu.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnCapNhat.Enabled = true;
                this.btnXoa.Enabled = true;
    
                gdv_ThietBi_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!!!");
            }
        }
        private void ThongTinThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void gdv_ThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = gdv_ThietBi.CurrentCell.RowIndex;
            txtMaTB.Text = gdv_ThietBi.Rows[i].Cells[0].Value.ToString();
            txtMaLoaiTB.Text = gdv_ThietBi.Rows[i].Cells[1].Value.ToString();
            txtTenTb.Text = gdv_ThietBi.Rows[i].Cells[2].Value.ToString();
            txtSoluong.Text = gdv_ThietBi.Rows[i].Cells[3].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            gdv_ThietBi_CellClick(null, null);
       
            this.btnLuu.Enabled = true;
            this.btn_HuyBo.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btn_timkiem.Enabled = false;

            this.txtTenTb.Focus();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            try
            {        
                int r = gdv_ThietBi.CurrentCell.RowIndex;     
                string strthietbi =
                gdv_ThietBi.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    kq = tb.XoaThietBi(ref err, int.Parse(txtMaTB.Text));
                    if (kq)
                    {
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                }
                else
                {

                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Them = false;
            // Cho phép thao tác trên Panel 
            gdv_ThietBi_CellClick(null, null);

            this.btnLuu.Enabled = true;

            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btn_timkiem.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.txtMaTB.Enabled = false;
            this.txtMaLoaiTB.Enabled = true;
            this.txtTenTb.Enabled = true;
            this.txtSoluong.Enabled = true;
            this.txtTenTb.Focus();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn đang tìm kiếm?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                gdv_ThietBi.DataSource = tb.TimKiem(ref err, txtTenTb.Text);
                gdv_ThietBi.Columns[4].Visible = false;
                gdv_ThietBi.Columns[5].Visible = false;
            }

            else
            {

                // Thông báo 
                MessageBox.Show("Không thể tìm kiếm được!");
            }

        }

        private void gdv_ThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (check == 0)
            {
                int i = gdv_ThietBi.CurrentRow.Index;
                txtMaTB.Text = gdv_ThietBi.Rows[i].Cells[0].Value.ToString();
                txtMaLoaiTB.Text = gdv_ThietBi.Rows[i].Cells[1].Value.ToString();
                txtTenTb.Text = gdv_ThietBi.Rows[i].Cells[2].Value.ToString();
                txtSoluong.Text = gdv_ThietBi.Rows[i].Cells[3].Value.ToString();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kq = false;
            string err = "";
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {

                    kq = tb.ThemThietBi(ref err, int.Parse(txtMaLoaiTB.Text), txtTenTb.Text, int.Parse(txtSoluong.Text));
                    if (kq)
                    {
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }

                }
                catch (SqlException)
                {
                    err = "Không thêm được. Lỗi rồi";
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                kq = false;
                // Thứ tự dòng hiện hành 
                int r = gdv_ThietBi.CurrentCell.RowIndex;
                // MaKH hiện hành 
                string strTHANHPHO =
                gdv_ThietBi.Rows[r].Cells[0].Value.ToString();

                // Câu lệnh SQL 
                kq = tb.CapNhatThietBi(ref err, int.Parse(txtMaTB.Text), txtTenTb.Text, int.Parse(txtMaLoaiTB.Text), int.Parse(txtSoluong.Text));
                if (kq)
                {
                    LoadData();
                    MessageBox.Show("Đã cập nhật!");
                }
            }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtMaLoaiTB.ResetText();
            this.txtMaTB.ResetText();
            this.txtTenTb.ResetText();
            this.txtSoluong.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa 
            this.btnThem.Enabled = true;
            this.btnCapNhat.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btn_timkiem.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy 
            this.btnLuu.Enabled = false;
       
            gdv_ThietBi_CellClick(null, null);
        }
    }
}
