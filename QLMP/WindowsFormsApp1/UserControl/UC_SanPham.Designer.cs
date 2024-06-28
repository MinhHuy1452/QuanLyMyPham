namespace WindowsFormsApp1.GUI
{
    partial class UC_SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_SP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_TON_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THUONGHIEU_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_nhatky = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(537, 18);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(113, 42);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm Sản Phẩm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(656, 18);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(113, 42);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa Sản Phẩm";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Location = new System.Drawing.Point(775, 16);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(113, 42);
            this.btn_HienThi.TabIndex = 9;
            this.btn_HienThi.Text = "Hiển Thị Thông Tin";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 21);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã Sản Phẩm",
            "Tên Sản Phẩm",
            "Thương Hiệu",
            "Danh Mục"});
            this.comboBox1.Location = new System.Drawing.Point(3, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SP_COL,
            this.TEN_SP_COL,
            this.SL_TON_COL,
            this.GIA_COL,
            this.MOTA_COL,
            this.THUONGHIEU_COL,
            this.ID_DM});
            this.dataGridView1.Location = new System.Drawing.Point(3, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(926, 451);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit_1);
            // 
            // ID_SP_COL
            // 
            this.ID_SP_COL.HeaderText = "Mã Sản Phẩm";
            this.ID_SP_COL.Name = "ID_SP_COL";
            // 
            // TEN_SP_COL
            // 
            this.TEN_SP_COL.HeaderText = "Tên Sản Phẩm";
            this.TEN_SP_COL.Name = "TEN_SP_COL";
            this.TEN_SP_COL.Width = 120;
            // 
            // SL_TON_COL
            // 
            this.SL_TON_COL.HeaderText = "Số Lượng";
            this.SL_TON_COL.Name = "SL_TON_COL";
            // 
            // GIA_COL
            // 
            this.GIA_COL.HeaderText = "Giá";
            this.GIA_COL.Name = "GIA_COL";
            // 
            // MOTA_COL
            // 
            this.MOTA_COL.HeaderText = "Mô Tả";
            this.MOTA_COL.Name = "MOTA_COL";
            this.MOTA_COL.Width = 210;
            // 
            // THUONGHIEU_COL
            // 
            this.THUONGHIEU_COL.HeaderText = "Thương Hiệu";
            this.THUONGHIEU_COL.Name = "THUONGHIEU_COL";
            // 
            // ID_DM
            // 
            this.ID_DM.HeaderText = "Danh Mục";
            this.ID_DM.Name = "ID_DM";
            this.ID_DM.Width = 170;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(358, 30);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 23);
            this.btn_timkiem.TabIndex = 13;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_nhatky
            // 
            this.btn_nhatky.Location = new System.Drawing.Point(439, 30);
            this.btn_nhatky.Name = "btn_nhatky";
            this.btn_nhatky.Size = new System.Drawing.Size(75, 23);
            this.btn_nhatky.TabIndex = 14;
            this.btn_nhatky.Text = "nhật ký";
            this.btn_nhatky.UseVisualStyleBackColor = true;
            this.btn_nhatky.Click += new System.EventHandler(this.btn_nhatky_Click);
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btn_nhatky);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(938, 541);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_TON_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn THUONGHIEU_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DM;
        private System.Windows.Forms.Button btn_nhatky;
    }
}
