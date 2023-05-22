namespace PMO
{
    partial class LoginDangNhap
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
            this.tbUserlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPasslogin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserlogin
            // 
            this.tbUserlogin.Location = new System.Drawing.Point(356, 153);
            this.tbUserlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserlogin.Name = "tbUserlogin";
            this.tbUserlogin.Size = new System.Drawing.Size(279, 28);
            this.tbUserlogin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // tbPasslogin
            // 
            this.tbPasslogin.Location = new System.Drawing.Point(356, 210);
            this.tbPasslogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbPasslogin.Name = "tbPasslogin";
            this.tbPasslogin.Size = new System.Drawing.Size(279, 28);
            this.tbPasslogin.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LoginDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPasslogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUserlogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginDangNhap";
            this.Text = "LoginDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPasslogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}