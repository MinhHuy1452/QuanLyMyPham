using BUS;
using DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main(string user)
        {
            InitializeComponent();
            lbName.Text = user;

            kiemtra();
        }
        public void kiemtra()
        {
            List<string> userRoles = GetRolesForUser(lbName.Text);
            if (userRoles != null)
            {
                if (userRoles.Contains("GIAMDOC"))
                {
                    lb_ChucVu.Text = "GIÁM ĐỐC";
                    share_data.chucvu = "GIÁM ĐỐC";
                    // Xử lý cho người dùng có vai trò "GIAM_DOC"
                }
                else if (userRoles.Contains("QUANLY"))
                {
                    lb_ChucVu.Text = "QUẢN LÝ";
                    share_data.chucvu = "QUẢN LÝ";
                    // Xử lý cho người dùng có vai trò "QUAN_LY"
                }
                else if (userRoles.Contains("NHANVIEN"))
                {
                    lb_ChucVu.Text = "NHÂN VIÊN";
                    share_data.chucvu = "NHÂN VIÊN";
                    // Xử lý cho người dùng có vai trò "NHAN_VIEN"
                }
                else
                {
                    MessageBox.Show("Không tìm thấy vai trò phù hợp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        static string host = DAL.DBConnection.host;
        static int port = DAL.DBConnection.port;
        static string sid = DAL.DBConnection.sid;
        static string user = DAL.DBConnection.user;
        static string password = DAL.DBConnection.password;

        private string connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
        protected OracleConnection conn = null;

        public List<string> GetRolesForUser(string username)
        {


            List<string> roles = new List<string>();

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                string query = "SELECT granted_role FROM sys.dba_role_privs WHERE grantee = :username";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("username", OracleDbType.Varchar2)).Value = username;

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader.GetString(0);
                            roles.Add(role);
                        }
                    }
                }
            }
            return roles;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            panel_Main.Controls.Add(new UC_Home());
              
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lb_ChucVu.Text != "NHÂN VIÊN")
            {
                MessageBox.Show("CHỈ CÓ NHÂN VIÊN ĐƯỢC PHÉP SỬ DỤNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(new UC_SanPham());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new UC_Home());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lb_ChucVu.Text != "QUẢN LÝ")
            {
                MessageBox.Show("CHỈ CÓ QUẢN LÝ ĐƯỢC PHÉP SỬ DỤNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                panel_Main.Controls.Clear();
                panel_Main.Controls.Add(new UC_ThongKe());
            }    
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lb_ChucVu.Text != "GIÁM ĐỐC")
            {
                MessageBox.Show("CHỈ CÓ GIÁM ĐỐC ĐƯỢC PHÉP SỬ DỤNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Frm_PhanQuyen frm = new Frm_PhanQuyen();
                frm.Show();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            Frm_ThongTin frm = new Frm_ThongTin();
            frm.Show();
        }

        private void btn_KiemSoat_Click(object sender, EventArgs e)
        {
            if (lb_ChucVu.Text != "GIÁM ĐỐC")
            {
                MessageBox.Show("CHỈ CÓ GIÁM ĐỐC ĐƯỢC PHÉP SỬ DỤNG", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Frm_QLND frm = new Frm_QLND();
                frm.Show();

            }
        }
    }
}
