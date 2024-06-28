namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.dangnhap = new System.Windows.Forms.Button();
            this.taikhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.cbb_sid = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_port = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_host = new System.Windows.Forms.ComboBox();
            this.ck_MaHoa = new System.Windows.Forms.CheckBox();
            this.USERNAME = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label1.Location = new System.Drawing.Point(383, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Thoat.FlatAppearance.BorderSize = 2;
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Thoat.Location = new System.Drawing.Point(465, 315);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(108, 36);
            this.btn_Thoat.TabIndex = 25;
            this.btn_Thoat.Text = "Exit";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhap.FlatAppearance.BorderSize = 2;
            this.dangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dangnhap.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.dangnhap.Location = new System.Drawing.Point(353, 315);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(106, 36);
            this.dangnhap.TabIndex = 24;
            this.dangnhap.Text = "Login";
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // taikhoan
            // 
            this.taikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.ForeColor = System.Drawing.Color.Gray;
            this.taikhoan.Location = new System.Drawing.Point(349, 184);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(224, 22);
            this.taikhoan.TabIndex = 4;
            this.taikhoan.Text = "Tài Khoản";
            this.taikhoan.Click += new System.EventHandler(this.taikhoan_Click);
            this.taikhoan.TextChanged += new System.EventHandler(this.taikhoan_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // matkhau
            // 
            this.matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.ForeColor = System.Drawing.Color.Gray;
            this.matkhau.Location = new System.Drawing.Point(351, 232);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(224, 22);
            this.matkhau.TabIndex = 4;
            this.matkhau.Text = "Mật Khẩu";
            this.matkhau.UseSystemPasswordChar = true;
            this.matkhau.TextChanged += new System.EventHandler(this.matkhau_TextChanged);
            // 
            // cbb_sid
            // 
            this.cbb_sid.FormattingEnabled = true;
            this.cbb_sid.Items.AddRange(new object[] {
            "orcl2",
            "orcl1",
            "orcl"});
            this.cbb_sid.Location = new System.Drawing.Point(630, 83);
            this.cbb_sid.Name = "cbb_sid";
            this.cbb_sid.Size = new System.Drawing.Size(121, 21);
            this.cbb_sid.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(602, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Sid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(587, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "PORT:";
            // 
            // cbb_port
            // 
            this.cbb_port.FormattingEnabled = true;
            this.cbb_port.Items.AddRange(new object[] {
            "1521",
            "1522"});
            this.cbb_port.Location = new System.Drawing.Point(630, 110);
            this.cbb_port.Name = "cbb_port";
            this.cbb_port.Size = new System.Drawing.Size(121, 21);
            this.cbb_port.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(587, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "HOST:";
            // 
            // cbb_host
            // 
            this.cbb_host.FormattingEnabled = true;
            this.cbb_host.Items.AddRange(new object[] {
            "localhost"});
            this.cbb_host.Location = new System.Drawing.Point(630, 137);
            this.cbb_host.Name = "cbb_host";
            this.cbb_host.Size = new System.Drawing.Size(121, 21);
            this.cbb_host.TabIndex = 32;
            // 
            // ck_MaHoa
            // 
            this.ck_MaHoa.AutoSize = true;
            this.ck_MaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_MaHoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ck_MaHoa.Location = new System.Drawing.Point(489, 272);
            this.ck_MaHoa.Name = "ck_MaHoa";
            this.ck_MaHoa.Size = new System.Drawing.Size(84, 24);
            this.ck_MaHoa.TabIndex = 34;
            this.ck_MaHoa.Text = "Mã Hoá";
            this.ck_MaHoa.UseVisualStyleBackColor = true;
            // 
            // USERNAME
            // 
            this.USERNAME.AutoSize = true;
            this.USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.USERNAME.Location = new System.Drawing.Point(242, 184);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(101, 20);
            this.USERNAME.TabIndex = 35;
            this.USERNAME.Text = "USERNAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(242, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "PASSWORD";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(861, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.ck_MaHoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_host);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_sid);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.TextBox taikhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.ComboBox cbb_sid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_host;
        private System.Windows.Forms.CheckBox ck_MaHoa;
        private System.Windows.Forms.Label USERNAME;
        private System.Windows.Forms.Label label5;
    }
}

