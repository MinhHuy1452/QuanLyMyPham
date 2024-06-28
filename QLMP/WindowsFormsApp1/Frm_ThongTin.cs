using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_ThongTin : Form
    {
        public Frm_ThongTin()
        {
            InitializeComponent();
            txt_ten.Text = DAL.DBConnection.user;
            txt_ChucVu.Text = share_data.chucvu;
        }
        static string host = DAL.DBConnection.host;
        static int port = DAL.DBConnection.port;
        static string sid = DAL.DBConnection.sid;
        static string user = DAL.DBConnection.user;
        static string password = DAL.DBConnection.password;

        private string connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
        static string SHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(data);

                // Chuyển kết quả băm thành chuỗi hexa có độ dài cố định 64 ký tự
                string hashedPassword = BitConverter.ToString(hashBytes, 0, 15).Replace("-", string.Empty);

                return hashedPassword;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string username = txt_ten.Text;
            string newPassword = SHA256Hash(txt_password.Text);

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.ChangeUserPassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("p_new_password", OracleDbType.Varchar2).Value = newPassword;

                        command.ExecuteNonQuery();

                        MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
