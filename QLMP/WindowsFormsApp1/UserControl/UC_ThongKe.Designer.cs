namespace WindowsFormsApp1.GUI
{
    partial class UC_ThongKe
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
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_PN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NCC_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_SP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL_TON_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN_COL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_TaoPhieu = new System.Windows.Forms.Button();
            this.btn_ThemThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(296, 41);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PN_COL,
            this.TEN_NCC_COL,
            this.TEN_SP_COL,
            this.NGAYLAP_COL,
            this.SL_TON_COL,
            this.GIA_COL,
            this.TONGTIEN_COL});
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(944, 373);
            this.dataGridView1.TabIndex = 19;
            // 
            // ID_PN_COL
            // 
            this.ID_PN_COL.HeaderText = "Mã Phiếu Nhập";
            this.ID_PN_COL.MinimumWidth = 6;
            this.ID_PN_COL.Name = "ID_PN_COL";
            this.ID_PN_COL.Width = 125;
            // 
            // TEN_NCC_COL
            // 
            this.TEN_NCC_COL.HeaderText = "Tên Nhà Cung Cấp";
            this.TEN_NCC_COL.MinimumWidth = 6;
            this.TEN_NCC_COL.Name = "TEN_NCC_COL";
            this.TEN_NCC_COL.Width = 150;
            // 
            // TEN_SP_COL
            // 
            this.TEN_SP_COL.HeaderText = "Tên Sản Phẩm";
            this.TEN_SP_COL.MinimumWidth = 6;
            this.TEN_SP_COL.Name = "TEN_SP_COL";
            this.TEN_SP_COL.Width = 150;
            // 
            // NGAYLAP_COL
            // 
            this.NGAYLAP_COL.HeaderText = "Ngày Lập";
            this.NGAYLAP_COL.MinimumWidth = 6;
            this.NGAYLAP_COL.Name = "NGAYLAP_COL";
            this.NGAYLAP_COL.Width = 125;
            // 
            // SL_TON_COL
            // 
            this.SL_TON_COL.HeaderText = "Số Lượng";
            this.SL_TON_COL.MinimumWidth = 6;
            this.SL_TON_COL.Name = "SL_TON_COL";
            this.SL_TON_COL.Width = 130;
            // 
            // GIA_COL
            // 
            this.GIA_COL.HeaderText = "Giá";
            this.GIA_COL.MinimumWidth = 6;
            this.GIA_COL.Name = "GIA_COL";
            this.GIA_COL.Width = 125;
            // 
            // TONGTIEN_COL
            // 
            this.TONGTIEN_COL.HeaderText = "Tổng Tiền";
            this.TONGTIEN_COL.MinimumWidth = 6;
            this.TONGTIEN_COL.Name = "TONGTIEN_COL";
            this.TONGTIEN_COL.Width = 185;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(47, 43);
            this.txt_timkiem.Multiline = true;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(243, 21);
            this.txt_timkiem.TabIndex = 17;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.Location = new System.Drawing.Point(799, 31);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(113, 42);
            this.btn_HienThi.TabIndex = 16;
            this.btn_HienThi.Text = "Hiển Thị Thông Tin";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(676, 32);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(113, 42);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa Sản Phẩm";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_TaoPhieu
            // 
            this.btn_TaoPhieu.Location = new System.Drawing.Point(473, 37);
            this.btn_TaoPhieu.Name = "btn_TaoPhieu";
            this.btn_TaoPhieu.Size = new System.Drawing.Size(89, 31);
            this.btn_TaoPhieu.TabIndex = 21;
            this.btn_TaoPhieu.Text = "Tạo Phiếu";
            this.btn_TaoPhieu.UseVisualStyleBackColor = true;
            this.btn_TaoPhieu.Click += new System.EventHandler(this.btn_TaoPhieu_Click);
            // 
            // btn_ThemThongKe
            // 
            this.btn_ThemThongKe.Location = new System.Drawing.Point(568, 32);
            this.btn_ThemThongKe.Name = "btn_ThemThongKe";
            this.btn_ThemThongKe.Size = new System.Drawing.Size(100, 41);
            this.btn_ThemThongKe.TabIndex = 23;
            this.btn_ThemThongKe.Text = "Thêm Phiếu Thu";
            this.btn_ThemThongKe.UseVisualStyleBackColor = true;
            this.btn_ThemThongKe.Click += new System.EventHandler(this.btn_ThemThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ThemThongKe);
            this.Controls.Add(this.btn_TaoPhieu);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_HienThi);
            this.Controls.Add(this.btn_xoa);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(944, 477);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_TaoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PN_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NCC_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_SP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_TON_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA_COL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN_COL;
        private System.Windows.Forms.Button btn_ThemThongKe;
        private System.Windows.Forms.Label label1;
    }
}
