namespace WindowsFormsApp1
{
    partial class Frm_PhanQuyen
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
            this.SELECT_checkBox = new System.Windows.Forms.CheckBox();
            this.INSERT_checkBox = new System.Windows.Forms.CheckBox();
            this.UPDATE_checkBox = new System.Windows.Forms.CheckBox();
            this.DELETE_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.EXECUTE_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CONNECT_checkBox = new System.Windows.Forms.CheckBox();
            this.RESOURCE_checkBox = new System.Windows.Forms.CheckBox();
            this.btn_GoQuyen = new System.Windows.Forms.Button();
            this.btn_CapQuyen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_TenBang = new System.Windows.Forms.ComboBox();
            this.lbl_chucvu = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_NhomQuyen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_xoauser = new System.Windows.Forms.Button();
            this.cbb_xoauser = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_TaoUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TaoUser = new System.Windows.Forms.TextBox();
            this.cbb_UserName = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_GanQuyen = new System.Windows.Forms.Button();
            this.cbb_NhomQuyen2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GRANTEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TABLE_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIVILEGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRANTED_ROLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_TaoNhomQuyen = new System.Windows.Forms.Button();
            this.txt_TenNhomQuyen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // SELECT_checkBox
            // 
            this.SELECT_checkBox.AutoSize = true;
            this.SELECT_checkBox.Location = new System.Drawing.Point(6, 28);
            this.SELECT_checkBox.Name = "SELECT_checkBox";
            this.SELECT_checkBox.Size = new System.Drawing.Size(67, 17);
            this.SELECT_checkBox.TabIndex = 0;
            this.SELECT_checkBox.Text = "SELECT";
            this.SELECT_checkBox.UseVisualStyleBackColor = true;
            // 
            // INSERT_checkBox
            // 
            this.INSERT_checkBox.AutoSize = true;
            this.INSERT_checkBox.Location = new System.Drawing.Point(6, 52);
            this.INSERT_checkBox.Name = "INSERT_checkBox";
            this.INSERT_checkBox.Size = new System.Drawing.Size(66, 17);
            this.INSERT_checkBox.TabIndex = 1;
            this.INSERT_checkBox.Text = "INSERT";
            this.INSERT_checkBox.UseVisualStyleBackColor = true;
            // 
            // UPDATE_checkBox
            // 
            this.UPDATE_checkBox.AutoSize = true;
            this.UPDATE_checkBox.Location = new System.Drawing.Point(118, 28);
            this.UPDATE_checkBox.Name = "UPDATE_checkBox";
            this.UPDATE_checkBox.Size = new System.Drawing.Size(70, 17);
            this.UPDATE_checkBox.TabIndex = 2;
            this.UPDATE_checkBox.Text = "UPDATE";
            this.UPDATE_checkBox.UseVisualStyleBackColor = true;
            // 
            // DELETE_checkBox
            // 
            this.DELETE_checkBox.AutoSize = true;
            this.DELETE_checkBox.Location = new System.Drawing.Point(118, 52);
            this.DELETE_checkBox.Name = "DELETE_checkBox";
            this.DELETE_checkBox.Size = new System.Drawing.Size(68, 17);
            this.DELETE_checkBox.TabIndex = 3;
            this.DELETE_checkBox.Text = "DELETE";
            this.DELETE_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btn_Reload);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_GoQuyen);
            this.groupBox1.Controls.Add(this.btn_CapQuyen);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbb_TenBang);
            this.groupBox1.Controls.Add(this.lbl_chucvu);
            this.groupBox1.Controls.Add(this.lbl_ten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_NhomQuyen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 311);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp Quyền";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EXECUTE_checkBox);
            this.groupBox4.Controls.Add(this.UPDATE_checkBox);
            this.groupBox4.Controls.Add(this.SELECT_checkBox);
            this.groupBox4.Controls.Add(this.DELETE_checkBox);
            this.groupBox4.Controls.Add(this.INSERT_checkBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 100);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quyền mức đối tượng";
            // 
            // EXECUTE_checkBox
            // 
            this.EXECUTE_checkBox.AutoSize = true;
            this.EXECUTE_checkBox.Location = new System.Drawing.Point(6, 76);
            this.EXECUTE_checkBox.Name = "EXECUTE_checkBox";
            this.EXECUTE_checkBox.Size = new System.Drawing.Size(76, 17);
            this.EXECUTE_checkBox.TabIndex = 19;
            this.EXECUTE_checkBox.Text = "EXECUTE";
            this.EXECUTE_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CONNECT_checkBox);
            this.groupBox3.Controls.Add(this.RESOURCE_checkBox);
            this.groupBox3.Location = new System.Drawing.Point(207, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quyền kết nối";
            // 
            // CONNECT_checkBox
            // 
            this.CONNECT_checkBox.AutoSize = true;
            this.CONNECT_checkBox.Location = new System.Drawing.Point(11, 52);
            this.CONNECT_checkBox.Name = "CONNECT_checkBox";
            this.CONNECT_checkBox.Size = new System.Drawing.Size(78, 17);
            this.CONNECT_checkBox.TabIndex = 17;
            this.CONNECT_checkBox.Text = "CONNECT";
            this.CONNECT_checkBox.UseVisualStyleBackColor = true;
            // 
            // RESOURCE_checkBox
            // 
            this.RESOURCE_checkBox.AutoSize = true;
            this.RESOURCE_checkBox.Location = new System.Drawing.Point(11, 28);
            this.RESOURCE_checkBox.Name = "RESOURCE_checkBox";
            this.RESOURCE_checkBox.Size = new System.Drawing.Size(86, 17);
            this.RESOURCE_checkBox.TabIndex = 18;
            this.RESOURCE_checkBox.Text = "RESOURCE";
            this.RESOURCE_checkBox.UseVisualStyleBackColor = true;
            // 
            // btn_GoQuyen
            // 
            this.btn_GoQuyen.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_GoQuyen.Location = new System.Drawing.Point(113, 262);
            this.btn_GoQuyen.Name = "btn_GoQuyen";
            this.btn_GoQuyen.Size = new System.Drawing.Size(101, 32);
            this.btn_GoQuyen.TabIndex = 15;
            this.btn_GoQuyen.Text = "Gỡ Quyền";
            this.btn_GoQuyen.UseVisualStyleBackColor = false;
            this.btn_GoQuyen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_CapQuyen
            // 
            this.btn_CapQuyen.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_CapQuyen.Location = new System.Drawing.Point(8, 262);
            this.btn_CapQuyen.Name = "btn_CapQuyen";
            this.btn_CapQuyen.Size = new System.Drawing.Size(101, 32);
            this.btn_CapQuyen.TabIndex = 14;
            this.btn_CapQuyen.Text = "Cấp Quyền";
            this.btn_CapQuyen.UseVisualStyleBackColor = false;
            this.btn_CapQuyen.Click += new System.EventHandler(this.btn_CapQuyen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Bảng:";
            // 
            // cbb_TenBang
            // 
            this.cbb_TenBang.FormattingEnabled = true;
            this.cbb_TenBang.Items.AddRange(new object[] {
            "SANPHAM",
            "DANHMUC",
            "NHACUNGCAP",
            "CTPN",
            "PHIEUNHAP"});
            this.cbb_TenBang.Location = new System.Drawing.Point(106, 128);
            this.cbb_TenBang.Name = "cbb_TenBang";
            this.cbb_TenBang.Size = new System.Drawing.Size(165, 21);
            this.cbb_TenBang.TabIndex = 12;
            // 
            // lbl_chucvu
            // 
            this.lbl_chucvu.AutoSize = true;
            this.lbl_chucvu.Location = new System.Drawing.Point(93, 62);
            this.lbl_chucvu.Name = "lbl_chucvu";
            this.lbl_chucvu.Size = new System.Drawing.Size(16, 13);
            this.lbl_chucvu.TabIndex = 9;
            this.lbl_chucvu.Text = "...";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(93, 33);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(16, 13);
            this.lbl_ten.TabIndex = 8;
            this.lbl_ten.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chức Vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên Nhóm Quyền:";
            // 
            // cbb_NhomQuyen
            // 
            this.cbb_NhomQuyen.FormattingEnabled = true;
            this.cbb_NhomQuyen.Location = new System.Drawing.Point(106, 91);
            this.cbb_NhomQuyen.Name = "cbb_NhomQuyen";
            this.cbb_NhomQuyen.Size = new System.Drawing.Size(165, 21);
            this.cbb_NhomQuyen.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên User:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.btn_xoauser);
            this.groupBox2.Controls.Add(this.cbb_xoauser);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_TaoUser);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Password);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_TaoUser);
            this.groupBox2.Location = new System.Drawing.Point(351, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // btn_xoauser
            // 
            this.btn_xoauser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoauser.Location = new System.Drawing.Point(292, 78);
            this.btn_xoauser.Name = "btn_xoauser";
            this.btn_xoauser.Size = new System.Drawing.Size(146, 34);
            this.btn_xoauser.TabIndex = 14;
            this.btn_xoauser.Text = "Xóa User";
            this.btn_xoauser.UseVisualStyleBackColor = false;
            this.btn_xoauser.Click += new System.EventHandler(this.btn_xoauser_Click);
            // 
            // cbb_xoauser
            // 
            this.cbb_xoauser.FormattingEnabled = true;
            this.cbb_xoauser.Location = new System.Drawing.Point(73, 86);
            this.cbb_xoauser.Name = "cbb_xoauser";
            this.cbb_xoauser.Size = new System.Drawing.Size(201, 21);
            this.cbb_xoauser.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Chọn User:";
            // 
            // btn_TaoUser
            // 
            this.btn_TaoUser.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TaoUser.Location = new System.Drawing.Point(292, 13);
            this.btn_TaoUser.Name = "btn_TaoUser";
            this.btn_TaoUser.Size = new System.Drawing.Size(146, 55);
            this.btn_TaoUser.TabIndex = 4;
            this.btn_TaoUser.Text = "Tạo User";
            this.btn_TaoUser.UseVisualStyleBackColor = false;
            this.btn_TaoUser.Click += new System.EventHandler(this.btn_TaoUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(72, 48);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(201, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên User";
            // 
            // txt_TaoUser
            // 
            this.txt_TaoUser.Location = new System.Drawing.Point(72, 19);
            this.txt_TaoUser.Name = "txt_TaoUser";
            this.txt_TaoUser.Size = new System.Drawing.Size(201, 20);
            this.txt_TaoUser.TabIndex = 0;
            // 
            // cbb_UserName
            // 
            this.cbb_UserName.FormattingEnabled = true;
            this.cbb_UserName.Location = new System.Drawing.Point(107, 21);
            this.cbb_UserName.Name = "cbb_UserName";
            this.cbb_UserName.Size = new System.Drawing.Size(201, 21);
            this.cbb_UserName.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox5.Controls.Add(this.btn_GanQuyen);
            this.groupBox5.Controls.Add(this.cbb_NhomQuyen2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbb_UserName);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(351, 223);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(460, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gán Nhóm Quyền";
            // 
            // btn_GanQuyen
            // 
            this.btn_GanQuyen.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_GanQuyen.Location = new System.Drawing.Point(342, 21);
            this.btn_GanQuyen.Name = "btn_GanQuyen";
            this.btn_GanQuyen.Size = new System.Drawing.Size(96, 64);
            this.btn_GanQuyen.TabIndex = 14;
            this.btn_GanQuyen.Text = "Gán Quyền";
            this.btn_GanQuyen.UseVisualStyleBackColor = false;
            this.btn_GanQuyen.Click += new System.EventHandler(this.btn_GanQuyen_Click);
            // 
            // cbb_NhomQuyen2
            // 
            this.cbb_NhomQuyen2.FormattingEnabled = true;
            this.cbb_NhomQuyen2.Location = new System.Drawing.Point(106, 64);
            this.cbb_NhomQuyen2.Name = "cbb_NhomQuyen2";
            this.cbb_NhomQuyen2.Size = new System.Drawing.Size(202, 21);
            this.cbb_NhomQuyen2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tên Nhóm Quyền:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRANTEE,
            this.TABLE_NAME,
            this.PRIVILEGE});
            this.dataGridView1.Location = new System.Drawing.Point(12, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(516, 296);
            this.dataGridView1.TabIndex = 7;
            // 
            // GRANTEE
            // 
            this.GRANTEE.HeaderText = "Tên Nhóm Quyền";
            this.GRANTEE.MinimumWidth = 6;
            this.GRANTEE.Name = "GRANTEE";
            this.GRANTEE.Width = 237;
            // 
            // TABLE_NAME
            // 
            this.TABLE_NAME.HeaderText = "Tên Bảng";
            this.TABLE_NAME.MinimumWidth = 6;
            this.TABLE_NAME.Name = "TABLE_NAME";
            this.TABLE_NAME.Width = 125;
            // 
            // PRIVILEGE
            // 
            this.PRIVILEGE.HeaderText = "Quyền";
            this.PRIVILEGE.MinimumWidth = 6;
            this.PRIVILEGE.Name = "PRIVILEGE";
            this.PRIVILEGE.Width = 236;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME,
            this.GRANTED_ROLE});
            this.dataGridView2.Location = new System.Drawing.Point(534, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(277, 296);
            this.dataGridView2.TabIndex = 8;
            // 
            // USERNAME
            // 
            this.USERNAME.HeaderText = "Tên USER";
            this.USERNAME.MinimumWidth = 6;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Width = 125;
            // 
            // GRANTED_ROLE
            // 
            this.GRANTED_ROLE.HeaderText = "Nhóm Quyền";
            this.GRANTED_ROLE.MinimumWidth = 6;
            this.GRANTED_ROLE.Name = "GRANTED_ROLE";
            this.GRANTED_ROLE.Width = 130;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox6.Controls.Add(this.btn_TaoNhomQuyen);
            this.groupBox6.Controls.Add(this.txt_TenNhomQuyen);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(351, 141);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(459, 72);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhóm Quyền";
            // 
            // btn_TaoNhomQuyen
            // 
            this.btn_TaoNhomQuyen.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_TaoNhomQuyen.Location = new System.Drawing.Point(324, 19);
            this.btn_TaoNhomQuyen.Name = "btn_TaoNhomQuyen";
            this.btn_TaoNhomQuyen.Size = new System.Drawing.Size(114, 32);
            this.btn_TaoNhomQuyen.TabIndex = 15;
            this.btn_TaoNhomQuyen.Text = "Tạo Nhóm Quyền";
            this.btn_TaoNhomQuyen.UseVisualStyleBackColor = false;
            this.btn_TaoNhomQuyen.Click += new System.EventHandler(this.btn_TaoNhomQuyen_Click);
            // 
            // txt_TenNhomQuyen
            // 
            this.txt_TenNhomQuyen.Location = new System.Drawing.Point(107, 25);
            this.txt_TenNhomQuyen.Name = "txt_TenNhomQuyen";
            this.txt_TenNhomQuyen.Size = new System.Drawing.Size(202, 20);
            this.txt_TenNhomQuyen.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên Nhóm Quyền:";
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Reload.Location = new System.Drawing.Point(218, 263);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(104, 33);
            this.btn_Reload.TabIndex = 16;
            this.btn_Reload.Text = "RELOAD";
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // Frm_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 632);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_PhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PhanQuyen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox SELECT_checkBox;
        private System.Windows.Forms.CheckBox INSERT_checkBox;
        private System.Windows.Forms.CheckBox UPDATE_checkBox;
        private System.Windows.Forms.CheckBox DELETE_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_NhomQuyen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_chucvu;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_TenBang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CapQuyen;
        private System.Windows.Forms.Button btn_GoQuyen;
        private System.Windows.Forms.CheckBox EXECUTE_checkBox;
        private System.Windows.Forms.CheckBox RESOURCE_checkBox;
        private System.Windows.Forms.CheckBox CONNECT_checkBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TaoUser;
        private System.Windows.Forms.ComboBox cbb_UserName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_TaoUser;
        private System.Windows.Forms.Button btn_GanQuyen;
        private System.Windows.Forms.ComboBox cbb_NhomQuyen2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_TaoNhomQuyen;
        private System.Windows.Forms.TextBox txt_TenNhomQuyen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRANTEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TABLE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIVILEGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRANTED_ROLE;
        private System.Windows.Forms.Button btn_xoauser;
        private System.Windows.Forms.ComboBox cbb_xoauser;
        private System.Windows.Forms.Label label10;
    }
}