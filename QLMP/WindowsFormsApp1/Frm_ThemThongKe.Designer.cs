namespace WindowsFormsApp1
{
    partial class Frm_ThemThongKe
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
            this.label6 = new System.Windows.Forms.Label();
            this.CBB_MaPhieuNhap = new System.Windows.Forms.ComboBox();
            this.CBB_tensanpham = new System.Windows.Forms.ComboBox();
            this.cbb_nhacc = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label6.Location = new System.Drawing.Point(192, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thêm Phiếu Nhập";
            // 
            // CBB_MaPhieuNhap
            // 
            this.CBB_MaPhieuNhap.FormattingEnabled = true;
            this.CBB_MaPhieuNhap.Location = new System.Drawing.Point(228, 128);
            this.CBB_MaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBB_MaPhieuNhap.Name = "CBB_MaPhieuNhap";
            this.CBB_MaPhieuNhap.Size = new System.Drawing.Size(219, 24);
            this.CBB_MaPhieuNhap.TabIndex = 12;
            // 
            // CBB_tensanpham
            // 
            this.CBB_tensanpham.FormattingEnabled = true;
            this.CBB_tensanpham.Location = new System.Drawing.Point(228, 174);
            this.CBB_tensanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBB_tensanpham.Name = "CBB_tensanpham";
            this.CBB_tensanpham.Size = new System.Drawing.Size(219, 24);
            this.CBB_tensanpham.TabIndex = 13;
            // 
            // cbb_nhacc
            // 
            this.cbb_nhacc.FormattingEnabled = true;
            this.cbb_nhacc.Location = new System.Drawing.Point(228, 220);
            this.cbb_nhacc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_nhacc.Name = "cbb_nhacc";
            this.cbb_nhacc.Size = new System.Drawing.Size(219, 24);
            this.cbb_nhacc.TabIndex = 14;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(228, 268);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(219, 22);
            this.txt_soluong.TabIndex = 15;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(228, 316);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(219, 22);
            this.txt_dongia.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(92, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Phiếu Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(92, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(92, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên Nhà Cung Cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(92, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Số Lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(92, 320);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Đơn Giá:";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.Location = new System.Drawing.Point(209, 373);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(172, 34);
            this.btn_Them.TabIndex = 22;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // Frm_ThemThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(616, 465);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.cbb_nhacc);
            this.Controls.Add(this.CBB_tensanpham);
            this.Controls.Add(this.CBB_MaPhieuNhap);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ThemThongKe";
            this.Text = "Frm_ThemThongKe";
            this.Load += new System.EventHandler(this.Frm_ThemThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBB_MaPhieuNhap;
        private System.Windows.Forms.ComboBox CBB_tensanpham;
        private System.Windows.Forms.ComboBox cbb_nhacc;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Them;
    }
}