namespace WindowsFormsApp1
{
    partial class Frm_QLND
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_unlock = new System.Windows.Forms.Button();
            this.btn_lock = new System.Windows.Forms.Button();
            this.btn_reload3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_xuatfile = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_reload2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_tim2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_reload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_linkkey = new System.Windows.Forms.TextBox();
            this.txt_linkenc = new System.Windows.Forms.TextBox();
            this.btn_chon2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_chon1 = new System.Windows.Forms.Button();
            this.btn_de = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_linkfile1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_en = new System.Windows.Forms.Button();
            this.btn_chon = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.txt_tenDME = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_prik = new System.Windows.Forms.Button();
            this.txt_prit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_pbk = new System.Windows.Forms.Button();
            this.txt_pbt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tenDM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_idDM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_re = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_themDM = new System.Windows.Forms.Button();
            this.btn_generateKey = new System.Windows.Forms.Button();
            this.txt_test = new System.Windows.Forms.TextBox();
            this.txt_tenDMpick = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_unlock);
            this.tabPage3.Controls.Add(this.btn_lock);
            this.tabPage3.Controls.Add(this.btn_reload3);
            this.tabPage3.Controls.Add(this.comboBox3);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(847, 429);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn username";
            // 
            // btn_unlock
            // 
            this.btn_unlock.Location = new System.Drawing.Point(200, 62);
            this.btn_unlock.Name = "btn_unlock";
            this.btn_unlock.Size = new System.Drawing.Size(75, 23);
            this.btn_unlock.TabIndex = 4;
            this.btn_unlock.Text = "mở khóa ";
            this.btn_unlock.UseVisualStyleBackColor = true;
            this.btn_unlock.Click += new System.EventHandler(this.btn_unlock_Click);
            // 
            // btn_lock
            // 
            this.btn_lock.Location = new System.Drawing.Point(281, 62);
            this.btn_lock.Name = "btn_lock";
            this.btn_lock.Size = new System.Drawing.Size(75, 23);
            this.btn_lock.TabIndex = 3;
            this.btn_lock.Text = "khóa";
            this.btn_lock.UseVisualStyleBackColor = true;
            this.btn_lock.Click += new System.EventHandler(this.btn_lock_Click);
            // 
            // btn_reload3
            // 
            this.btn_reload3.Location = new System.Drawing.Point(766, 62);
            this.btn_reload3.Name = "btn_reload3";
            this.btn_reload3.Size = new System.Drawing.Size(75, 23);
            this.btn_reload3.TabIndex = 2;
            this.btn_reload3.Text = "reload";
            this.btn_reload3.UseVisualStyleBackColor = true;
            this.btn_reload3.Click += new System.EventHandler(this.btn_reload3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(17, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(177, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 105);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(818, 312);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_xuatfile);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_reload2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.btn_tim2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lịch sử thực thi của người dùng ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.Location = new System.Drawing.Point(150, 82);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(75, 23);
            this.btn_xuatfile.TabIndex = 11;
            this.btn_xuatfile.Text = "xuất file ";
            this.btn_xuatfile.UseVisualStyleBackColor = true;
            this.btn_xuatfile.Click += new System.EventHandler(this.btn_xuatfile_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(267, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(556, 397);
            this.dataGridView2.TabIndex = 6;
            // 
            // btn_reload2
            // 
            this.btn_reload2.Location = new System.Drawing.Point(23, 82);
            this.btn_reload2.Name = "btn_reload2";
            this.btn_reload2.Size = new System.Drawing.Size(121, 23);
            this.btn_reload2.TabIndex = 10;
            this.btn_reload2.Text = "hiện thị tất cả";
            this.btn_reload2.UseVisualStyleBackColor = true;
            this.btn_reload2.Click += new System.EventHandler(this.btn_reload2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn user";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(23, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // btn_tim2
            // 
            this.btn_tim2.Location = new System.Drawing.Point(150, 53);
            this.btn_tim2.Name = "btn_tim2";
            this.btn_tim2.Size = new System.Drawing.Size(75, 23);
            this.btn_tim2.TabIndex = 9;
            this.btn_tim2.Text = "TÌM";
            this.btn_tim2.UseVisualStyleBackColor = true;
            this.btn_tim2.Click += new System.EventHandler(this.btn_tim2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_reload);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btn_tim);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lịch sử truy cập của người dùng ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(56, 91);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(160, 23);
            this.btn_reload.TabIndex = 5;
            this.btn_reload.Text = "hiện thị tất cả";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn user";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(183, 62);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 4;
            this.btn_tim.Text = "TÌM";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 455);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(847, 429);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mã hóa file ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_linkkey);
            this.groupBox2.Controls.Add(this.txt_linkenc);
            this.groupBox2.Controls.Add(this.btn_chon2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_chon1);
            this.groupBox2.Controls.Add(this.btn_de);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(425, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giải hóa file ";
            // 
            // txt_linkkey
            // 
            this.txt_linkkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linkkey.Location = new System.Drawing.Point(96, 108);
            this.txt_linkkey.Name = "txt_linkkey";
            this.txt_linkkey.Size = new System.Drawing.Size(235, 20);
            this.txt_linkkey.TabIndex = 8;
            // 
            // txt_linkenc
            // 
            this.txt_linkenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linkenc.Location = new System.Drawing.Point(96, 59);
            this.txt_linkenc.Name = "txt_linkenc";
            this.txt_linkenc.Size = new System.Drawing.Size(235, 20);
            this.txt_linkenc.TabIndex = 7;
            // 
            // btn_chon2
            // 
            this.btn_chon2.Location = new System.Drawing.Point(343, 98);
            this.btn_chon2.Name = "btn_chon2";
            this.btn_chon2.Size = new System.Drawing.Size(47, 35);
            this.btn_chon2.TabIndex = 6;
            this.btn_chon2.Text = "...";
            this.btn_chon2.UseVisualStyleBackColor = true;
            this.btn_chon2.Click += new System.EventHandler(this.btn_chon2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn file";
            // 
            // btn_chon1
            // 
            this.btn_chon1.Location = new System.Drawing.Point(343, 49);
            this.btn_chon1.Name = "btn_chon1";
            this.btn_chon1.Size = new System.Drawing.Size(47, 35);
            this.btn_chon1.TabIndex = 3;
            this.btn_chon1.Text = "...";
            this.btn_chon1.UseVisualStyleBackColor = true;
            this.btn_chon1.Click += new System.EventHandler(this.btn_chon1_Click);
            // 
            // btn_de
            // 
            this.btn_de.Location = new System.Drawing.Point(155, 157);
            this.btn_de.Name = "btn_de";
            this.btn_de.Size = new System.Drawing.Size(235, 35);
            this.btn_de.TabIndex = 2;
            this.btn_de.Text = "Giải hóa";
            this.btn_de.UseVisualStyleBackColor = true;
            this.btn_de.Click += new System.EventHandler(this.btn_de_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_linkfile1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_en);
            this.groupBox1.Controls.Add(this.btn_chon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa file";
            // 
            // txt_linkfile1
            // 
            this.txt_linkfile1.Enabled = false;
            this.txt_linkfile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_linkfile1.Location = new System.Drawing.Point(96, 66);
            this.txt_linkfile1.Name = "txt_linkfile1";
            this.txt_linkfile1.Size = new System.Drawing.Size(235, 20);
            this.txt_linkfile1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn file";
            // 
            // btn_en
            // 
            this.btn_en.Location = new System.Drawing.Point(96, 157);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(235, 35);
            this.btn_en.TabIndex = 1;
            this.btn_en.Text = "Mã hóa";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(349, 57);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(47, 35);
            this.btn_chon.TabIndex = 0;
            this.btn_chon.Text = "...";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.txt_tenDMpick);
            this.tabPage5.Controls.Add(this.txt_test);
            this.tabPage5.Controls.Add(this.btn_encrypt);
            this.tabPage5.Controls.Add(this.txt_tenDME);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.btn_prik);
            this.tabPage5.Controls.Add(this.txt_prit);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.btn_pbk);
            this.tabPage5.Controls.Add(this.txt_pbt);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txt_tenDM);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.txt_idDM);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.btn_re);
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Controls.Add(this.btn_decrypt);
            this.tabPage5.Controls.Add(this.btn_themDM);
            this.tabPage5.Controls.Add(this.btn_generateKey);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(847, 429);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mã hóa RSA";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(115, 207);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(121, 45);
            this.btn_encrypt.TabIndex = 36;
            this.btn_encrypt.Text = "Mã hóa";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // txt_tenDME
            // 
            this.txt_tenDME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDME.Location = new System.Drawing.Point(115, 147);
            this.txt_tenDME.Name = "txt_tenDME";
            this.txt_tenDME.Size = new System.Drawing.Size(210, 24);
            this.txt_tenDME.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tên DM mã hóa";
            // 
            // btn_prik
            // 
            this.btn_prik.Location = new System.Drawing.Point(331, 270);
            this.btn_prik.Name = "btn_prik";
            this.btn_prik.Size = new System.Drawing.Size(34, 23);
            this.btn_prik.TabIndex = 33;
            this.btn_prik.Text = "...";
            this.btn_prik.UseVisualStyleBackColor = true;
            this.btn_prik.Click += new System.EventHandler(this.btn_prik_Click);
            // 
            // txt_prit
            // 
            this.txt_prit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prit.Location = new System.Drawing.Point(115, 272);
            this.txt_prit.Name = "txt_prit";
            this.txt_prit.Size = new System.Drawing.Size(210, 26);
            this.txt_prit.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Private key";
            // 
            // btn_pbk
            // 
            this.btn_pbk.Location = new System.Drawing.Point(331, 175);
            this.btn_pbk.Name = "btn_pbk";
            this.btn_pbk.Size = new System.Drawing.Size(34, 23);
            this.btn_pbk.TabIndex = 29;
            this.btn_pbk.Text = "...";
            this.btn_pbk.UseVisualStyleBackColor = true;
            this.btn_pbk.Click += new System.EventHandler(this.btn_pbk_Click);
            // 
            // txt_pbt
            // 
            this.txt_pbt.Location = new System.Drawing.Point(115, 177);
            this.txt_pbt.Name = "txt_pbt";
            this.txt_pbt.Size = new System.Drawing.Size(210, 20);
            this.txt_pbt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Public key";
            // 
            // txt_tenDM
            // 
            this.txt_tenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDM.Location = new System.Drawing.Point(115, 119);
            this.txt_tenDM.Name = "txt_tenDM";
            this.txt_tenDM.Size = new System.Drawing.Size(210, 24);
            this.txt_tenDM.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên Danh mục";
            // 
            // txt_idDM
            // 
            this.txt_idDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idDM.Location = new System.Drawing.Point(115, 79);
            this.txt_idDM.Name = "txt_idDM";
            this.txt_idDM.Size = new System.Drawing.Size(210, 24);
            this.txt_idDM.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID Danh mục";
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(275, 23);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(121, 42);
            this.btn_re.TabIndex = 22;
            this.btn_re.Text = "Reload";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.btn_re_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(402, 23);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(429, 229);
            this.dataGridView4.TabIndex = 21;
            this.dataGridView4.SelectionChanged += new System.EventHandler(this.dataGridView4_SelectionChanged);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(380, 272);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(121, 45);
            this.btn_decrypt.TabIndex = 20;
            this.btn_decrypt.Text = "Giải mã";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_themDM
            // 
            this.btn_themDM.Location = new System.Drawing.Point(256, 208);
            this.btn_themDM.Name = "btn_themDM";
            this.btn_themDM.Size = new System.Drawing.Size(121, 42);
            this.btn_themDM.TabIndex = 19;
            this.btn_themDM.Text = "Thêm Danh Mục";
            this.btn_themDM.UseVisualStyleBackColor = true;
            this.btn_themDM.Click += new System.EventHandler(this.btn_themDM_Click);
            // 
            // btn_generateKey
            // 
            this.btn_generateKey.Location = new System.Drawing.Point(18, 23);
            this.btn_generateKey.Name = "btn_generateKey";
            this.btn_generateKey.Size = new System.Drawing.Size(121, 45);
            this.btn_generateKey.TabIndex = 18;
            this.btn_generateKey.Text = "Khởi tạo Key";
            this.btn_generateKey.UseVisualStyleBackColor = true;
            this.btn_generateKey.Click += new System.EventHandler(this.btn_generateKey_Click);
            // 
            // txt_test
            // 
            this.txt_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_test.Location = new System.Drawing.Point(115, 349);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(210, 26);
            this.txt_test.TabIndex = 37;
            // 
            // txt_tenDMpick
            // 
            this.txt_tenDMpick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDMpick.Location = new System.Drawing.Point(115, 310);
            this.txt_tenDMpick.Name = "txt_tenDMpick";
            this.txt_tenDMpick.Size = new System.Drawing.Size(210, 26);
            this.txt_tenDMpick.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Tên Danh mục";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Kết quả";
            // 
            // Frm_QLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_QLND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiemSoat";
            this.Load += new System.EventHandler(this.Frm_QLND_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_unlock;
        private System.Windows.Forms.Button btn_lock;
        private System.Windows.Forms.Button btn_reload3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_reload2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_tim2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_xuatfile;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_linkkey;
        private System.Windows.Forms.TextBox txt_linkenc;
        private System.Windows.Forms.Button btn_chon2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_chon1;
        private System.Windows.Forms.Button btn_de;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_linkfile1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_generateKey;
        private System.Windows.Forms.Button btn_themDM;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btn_prik;
        private System.Windows.Forms.TextBox txt_prit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_pbk;
        private System.Windows.Forms.TextBox txt_pbt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tenDM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_idDM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox txt_tenDME;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_test;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tenDMpick;
    }
}