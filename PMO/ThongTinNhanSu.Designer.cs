namespace PMO
{
    partial class ThongTinNhanSu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanSu = new System.Windows.Forms.DataGridView();
            this.txtTenNS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.datetPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.raButNam = new System.Windows.Forms.RadioButton();
            this.raButNu = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLinkFace = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanSu);
            this.panel1.Location = new System.Drawing.Point(24, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 289);
            this.panel1.TabIndex = 0;
            // 
            // dgvNhanSu
            // 
            this.dgvNhanSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhanSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanSu.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanSu.Name = "dgvNhanSu";
            this.dgvNhanSu.RowHeadersVisible = false;
            this.dgvNhanSu.RowHeadersWidth = 51;
            this.dgvNhanSu.RowTemplate.Height = 24;
            this.dgvNhanSu.Size = new System.Drawing.Size(1009, 289);
            this.dgvNhanSu.TabIndex = 0;
            this.dgvNhanSu.Click += new System.EventHandler(this.dgvNhanSu_Click);
            // 
            // txtTenNS
            // 
            this.txtTenNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNS.Location = new System.Drawing.Point(120, 336);
            this.txtTenNS.Name = "txtTenNS";
            this.txtTenNS.Size = new System.Drawing.Size(126, 27);
            this.txtTenNS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "CMND";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(327, 336);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(93, 27);
            this.txtCMND.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "SDT";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(488, 336);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(101, 27);
            this.txtSDT.TabIndex = 13;
            // 
            // datetPNgaySinh
            // 
            this.datetPNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetPNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetPNgaySinh.Location = new System.Drawing.Point(124, 394);
            this.datetPNgaySinh.Name = "datetPNgaySinh";
            this.datetPNgaySinh.Size = new System.Drawing.Size(126, 27);
            this.datetPNgaySinh.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày Sinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(335, 392);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(89, 27);
            this.txtMSSV.TabIndex = 17;
            // 
            // raButNam
            // 
            this.raButNam.AutoSize = true;
            this.raButNam.Location = new System.Drawing.Point(447, 394);
            this.raButNam.Name = "raButNam";
            this.raButNam.Size = new System.Drawing.Size(58, 21);
            this.raButNam.TabIndex = 19;
            this.raButNam.TabStop = true;
            this.raButNam.Text = "Nam";
            this.raButNam.UseVisualStyleBackColor = true;
            // 
            // raButNu
            // 
            this.raButNu.AutoSize = true;
            this.raButNu.Location = new System.Drawing.Point(511, 394);
            this.raButNu.Name = "raButNu";
            this.raButNu.Size = new System.Drawing.Size(47, 21);
            this.raButNu.TabIndex = 20;
            this.raButNu.TabStop = true;
            this.raButNu.Text = "Nữ";
            this.raButNu.UseVisualStyleBackColor = true;
            this.raButNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã CV";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCV.Location = new System.Drawing.Point(123, 455);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(89, 27);
            this.txtMaCV.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Link facebook";
            // 
            // txtLinkFace
            // 
            this.txtLinkFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkFace.Location = new System.Drawing.Point(342, 455);
            this.txtLinkFace.Name = "txtLinkFace";
            this.txtLinkFace.Size = new System.Drawing.Size(250, 27);
            this.txtLinkFace.TabIndex = 23;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(667, 336);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 103);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(811, 455);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 90);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(942, 455);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(90, 90);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(923, 336);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 103);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(667, 452);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 90);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThongTinNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 554);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLinkFace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.raButNu);
            this.Controls.Add(this.raButNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datetPNgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenNS);
            this.Controls.Add(this.panel1);
            this.Name = "ThongTinNhanSu";
            this.Text = "ThongTinNhanSu";
            this.Load += new System.EventHandler(this.ThongTinNhanSu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanSu;
        private System.Windows.Forms.TextBox txtTenNS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker datetPNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.RadioButton raButNam;
        private System.Windows.Forms.RadioButton raButNu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLinkFace;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
    }
}