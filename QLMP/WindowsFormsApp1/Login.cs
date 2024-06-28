using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            cbb_sid.SelectedIndex = 0;
            cbb_host.SelectedIndex = 0;
            cbb_port.SelectedIndex = 0;
        }
        private void taikhoan_TextChanged(object sender, EventArgs e)
        {

            taikhoan.ForeColor = Color.White;

        }

        private void matkhau_Click(object sender, EventArgs e)
        {
            matkhau.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            dangnhap.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            dangnhap.ForeColor = Color.PaleVioletRed;
        }

        

        private void taikhoan_Click(object sender, EventArgs e)
        {
            taikhoan.SelectAll(); 
        }
        private void matkhau_TextChanged(object sender, EventArgs e)
        {
                matkhau.ForeColor = Color.White;
            
        }
        
        public string encryption(string password)
        {

            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        static string SHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(data);

                // Chuyển kết quả băm thành chuỗi hexa có độ dài cố định 64 ký tự
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", string.Empty);

                // Cắt hoặc mở rộng chuỗi để có độ dài 30 ký tự
                if (hashedPassword.Length < 30)
                {
                    hashedPassword = hashedPassword.PadRight(30, '0');
                }
                else if (hashedPassword.Length > 30)
                {
                    hashedPassword = hashedPassword.Substring(0, 30);
                }

                return hashedPassword;
            }
        }
        private void dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (ck_MaHoa.Checked)
                {
                    DAL.DBConnection.user = taikhoan.Text;
                    DAL.DBConnection.password = SHA256Hash(matkhau.Text);
                    DAL.DBConnection.sid = cbb_sid.Text;
                    DAL.DBConnection.host = cbb_host.Text;
                    DAL.DBConnection.port = Int32.Parse(cbb_port.Text);
                    if (taikhoan.Text != null || matkhau != null)
                    {
                        // Kết nối thành công, cho phép vào FormMain
                        Main frm = new Main(taikhoan.Text);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Kết nối thất bại, thông báo người dùng và không cho vào FormMain
                        MessageBox.Show("Kết nối cơ sở dữ liệu thất bại. Đăng nhập không thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DAL.DBConnection.user = taikhoan.Text;
                    DAL.DBConnection.password = matkhau.Text;
                    DAL.DBConnection.sid = cbb_sid.Text;
                    DAL.DBConnection.host = cbb_host.Text;
                    DAL.DBConnection.port = Int32.Parse(cbb_port.Text);
                    if (taikhoan.Text != null || matkhau != null)
                    {
                        // Kết nối thành công, cho phép vào FormMain
                        Main frm = new Main(taikhoan.Text);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Kết nối thất bại, thông báo người dùng và không cho vào FormMain
                        MessageBox.Show("Kết nối cơ sở dữ liệu thất bại. Đăng nhập không thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi đăng nhập: Tai khoan bi khoa ");
            }
        }

        

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }


    }
}