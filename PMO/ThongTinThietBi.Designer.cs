namespace PMO
{
    partial class ThongTinThietBi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdv_ThietBi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTb = new System.Windows.Forms.TextBox();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLoaiTB = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_HuyBo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_ThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // gdv_ThietBi
            // 
            this.gdv_ThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_ThietBi.Location = new System.Drawing.Point(35, 12);
            this.gdv_ThietBi.Name = "gdv_ThietBi";
            this.gdv_ThietBi.RowHeadersWidth = 51;
            this.gdv_ThietBi.RowTemplate.Height = 24;
            this.gdv_ThietBi.Size = new System.Drawing.Size(855, 300);
            this.gdv_ThietBi.TabIndex = 0;
            this.gdv_ThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_ThietBi_CellClick);
            this.gdv_ThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_ThietBi_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số lượng";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(400, 450);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(127, 27);
            this.txtSoluong.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã loại TB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên TB:";
            // 
            // txtTenTb
            // 
            this.txtTenTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTb.Location = new System.Drawing.Point(400, 398);
            this.txtTenTb.Name = "txtTenTb";
            this.txtTenTb.Size = new System.Drawing.Size(127, 27);
            this.txtTenTb.TabIndex = 20;
            // 
            // txtMaTB
            // 
            this.txtMaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTB.Location = new System.Drawing.Point(144, 395);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(130, 27);
            this.txtMaTB.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã TB:";
            // 
            // txtMaLoaiTB
            // 
            this.txtMaLoaiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiTB.Location = new System.Drawing.Point(148, 446);
            this.txtMaLoaiTB.Name = "txtMaLoaiTB";
            this.txtMaLoaiTB.Size = new System.Drawing.Size(126, 27);
            this.txtMaLoaiTB.TabIndex = 27;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(572, 324);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 65);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(701, 428);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 64);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(811, 428);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 64);
            this.btnCapNhat.TabIndex = 31;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(811, 318);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 71);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(572, 427);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(80, 65);
            this.btn_timkiem.TabIndex = 34;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyBo.Location = new System.Drawing.Point(697, 324);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(80, 65);
            this.btn_HuyBo.TabIndex = 35;
            this.btn_HuyBo.Text = "Hủy bỏ";
            this.btn_HuyBo.UseVisualStyleBackColor = true;
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // ThongTinThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 611);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMaLoaiTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTb);
            this.Controls.Add(this.txtMaTB);
            this.Controls.Add(this.gdv_ThietBi);
            this.Name = "ThongTinThietBi";
            this.Text = "ThongTinThietBi";
            this.Load += new System.EventHandler(this.ThongTinThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_ThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gdv_ThietBi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTb;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoaiTB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_HuyBo;
    }
}