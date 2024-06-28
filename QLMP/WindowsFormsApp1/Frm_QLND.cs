using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using DAL;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Input;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    public partial class Frm_QLND : Form
    {
        private DBConnection dbConnection = new DBConnection();
        static string host = DAL.DBConnection.host;
        static int port = DAL.DBConnection.port;
        static string sid = DAL.DBConnection.sid;
        static string user = DAL.DBConnection.user;
        static string password = DAL.DBConnection.password;
        private string selectedFilePath = "";
        private string selectedEncFilePath = "";
        private string selectedKeyFilePath = "";

        private string filter;
        private DESCryptoServiceProvider des;
        private RSACryptoServiceProvider rsa;

        private string connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
        protected OracleConnection conn = null;
        public Frm_QLND()
        {
            InitializeComponent();
            des = new DESCryptoServiceProvider();
            LoadData();
            LoadData2();
            LoadData3();
            rsa = new RSACryptoServiceProvider(1024);

        }
        private void LoadData()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadAuditHistoryData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadUsernamesIntoComboBox()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadUsernamesIntoComboBox", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["USERNAME"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataToDataGridView(string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadAuditHistoryDataByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có tên người dùng được chọn không
            if (comboBox1.SelectedItem != null)
            {
                string selectedUsername = comboBox1.SelectedItem.ToString();
                LoadDataToDataGridView(selectedUsername);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Frm_QLND_Load(object sender, EventArgs e)
        {
            LoadUsernamesIntoComboBox();
            LoadUsernamesIntoComboBox2();
            LoadUsernamesIntoComboBox3();
        }

        // ------- tab 2 ----------
        private void LoadData2()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadAuditLogHistoryData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadUsernamesIntoComboBox2()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadUsernamesIntoComboBox2", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox2.Items.Add(reader["USERNAME"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadDataToDataGridView2(string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadALHistoryDataByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_reload2_Click(object sender, EventArgs e)
        {
            LoadData2();
        }

        private void btn_tim2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có tên người dùng được chọn không
            if (comboBox2.SelectedItem != null)
            {
                string selectedUsername = comboBox2.SelectedItem.ToString();
                LoadDataToDataGridView2(selectedUsername);
            }
        }

        // ------- tab 3 ----------
        private void LoadData3()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadUsersByProfile", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView3.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadUsernamesIntoComboBox3()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LoadUNByProfileinCbb", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_cursor", OracleDbType.RefCursor, ParameterDirection.Output);

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBox3.Items.Add(reader["USERNAME"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_reload3_Click(object sender, EventArgs e)
        {
            LoadData3();
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có tên người dùng được chọn không
                if (comboBox3.SelectedItem != null)
                {
                    string selectedUsername = comboBox3.SelectedItem.ToString();
                    LockUserAccount(selectedUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LockUserAccount(string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.LockUserAccount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Tài khoản {username} đã bị khóa");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btn_unlock_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có tên người dùng được chọn không
                if (comboBox3.SelectedItem != null)
                {
                    string selectedUsername = comboBox3.SelectedItem.ToString();
                    UnLockUserAccount(selectedUsername);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UnLockUserAccount(string username)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.UnLockUserAccount", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Tài khoản {username} đã được mở khóa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {
            XuatRaExcel(dataGridView2);
        }
        private void XuatRaExcel(DataGridView dataGridView)
        {
            // Tạo một hộp thoại lưu tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn đường dẫn để lưu file Excel";

            // Mở hộp thoại lưu tệp và kiểm tra xem người dùng đã chọn một đường dẫn hay chưa
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tạo một ứng dụng Excel mới
                Excel.Application excelApp = null;
                Excel.Workbook excelWorkbook = null;
                Excel.Worksheet excelWorksheet = null;

                try
                {
                    excelApp = new Excel.Application();
                    excelWorkbook = excelApp.Workbooks.Add();
                    excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                    // Sao chép nội dung DataGridView vào Excel
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            excelWorksheet.Cells[i + 1, j + 1] = dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }

                    // Lưu tệp Excel tại đường dẫn đã chọn
                    excelWorkbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Dữ liệu đã được xuất ra Excel và lưu tại đường dẫn đã chọn thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất ra Excel: " + ex.Message);
                }
                finally
                {
                    // Đóng đối tượng Excel
                    if (excelWorksheet != null)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);

                    if (excelWorkbook != null)
                    {
                        excelWorkbook.Close();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                    }

                    if (excelApp != null)
                    {
                        excelApp.Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    }
                }
            }
        }
        // --------------------------------------------------------------------------------------------
        private string GetFileDialogOpen(string v)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = filter,
                Title = "Select File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;

            return null;
        }

        private byte[] ReadByteFile(string filePath)
        {
            byte[] data = null;
            try
            {
                data = File.ReadAllBytes(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Path.GetFileName(filePath)} not found or cannot be read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }

        private bool WriteByteFile(string fileName, byte[] data)
        {
            try
            {
                File.WriteAllBytes(fileName, data);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to create file {Path.GetFileName(fileName)} for writing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private object ReadObjectFile(string filePath)
        {
            object obj = null;
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    obj = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Path.GetFileName(filePath)} not found or cannot be read", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return obj;
        }

        private bool WriteObjectFile(string fileName, object data)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                {
                    BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                    binaryWriter.Write((byte[])data);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to create file {Path.GetFileName(fileName)} for writing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private byte[] Encrypt(byte[] data, byte[] key)
        {
            using (DESCryptoServiceProvider desCrypto = new DESCryptoServiceProvider())
            {
                desCrypto.Key = key;
                desCrypto.Mode = CipherMode.ECB; // Use your preferred mode here
                desCrypto.Padding = PaddingMode.PKCS7; // Use your preferred padding here

                using (ICryptoTransform encryptor = desCrypto.CreateEncryptor())
                {
                    return encryptor.TransformFinalBlock(data, 0, data.Length);
                }
            }
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            string filePath = GetFileDialogOpen("*.*");
            if (filePath != null)
                txt_linkfile1.Text = filePath;
        }


        private void btn_en_Click(object sender, EventArgs e)
        {
            string filePath = txt_linkfile1.Text;
            byte[] data = ReadByteFile(filePath);

            data = Encrypt(data, des.Key);
            if (WriteByteFile(filePath + ".enc", data) &&
                WriteObjectFile(filePath + ".key", des.Key))
            {
                File.Delete(filePath);
                MessageBox.Show($"{filePath}.enc\nEncryption Key: {Path.GetFileName(filePath)}.key\nDone",
                                "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_chon1_Click(object sender, EventArgs e)
        {
            string filePath = GetFileDialogOpen("Encrypted Files (*.enc)|*.enc|All Files (*.*)|*.*");
            if (filePath != null)
                txt_linkenc.Text = filePath;
        }

        private void btn_chon2_Click(object sender, EventArgs e)
        {
            string filePath = GetFileDialogOpen("Key Files (*.key)|*.key|All Files (*.*)|*.*");
            if (filePath != null)
                txt_linkkey.Text = filePath;
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            string encryptedFilePath = txt_linkenc.Text;
            string keyFilePath = txt_linkkey.Text;

            if (string.IsNullOrEmpty(encryptedFilePath) || string.IsNullOrEmpty(keyFilePath))
            {
                MessageBox.Show("Vui lòng chọn cả tệp .enc và tệp .key", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileInfo encryptedFileInfo = new FileInfo(encryptedFilePath);
            FileInfo keyFileInfo = new FileInfo(keyFilePath);

            if (!encryptedFileInfo.Exists)
            {
                MessageBox.Show("Không tìm thấy tệp .enc hoặc không thể truy cập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!keyFileInfo.Exists)
            {
                MessageBox.Show("Không tìm thấy tệp .key hoặc không thể truy cập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] data = ReadByteFile(encryptedFilePath);
            byte[] key = (byte[])ReadObjectFile(keyFilePath);
            data = Decrypt(data, key);

            string filename = encryptedFileInfo.FullName.Substring(0, encryptedFileInfo.FullName.Length - 4);
            if (WriteByteFile(filename, data))
            {
                encryptedFileInfo.Delete();
                keyFileInfo.Delete();
                MessageBox.Show("Tệp giải mã thành công", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private byte[] Decrypt(byte[] data, byte[] key)
        {
            using (DESCryptoServiceProvider desCrypto = new DESCryptoServiceProvider())
            {
                desCrypto.Key = key;
                desCrypto.Mode = CipherMode.ECB; // Sử dụng chế độ mong muốn của bạn ở đây
                desCrypto.Padding = PaddingMode.PKCS7; // Sử dụng phương thức đệm mong muốn của bạn ở đây

                using (ICryptoTransform decryptor = desCrypto.CreateDecryptor())
                {
                    return decryptor.TransformFinalBlock(data, 0, data.Length);
                }
            }
        }

        private void btn_generateKey_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng RSA với key size là 1024 bits
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    // Hiển thị hộp thoại lưu tệp để chọn nơi lưu cho public key
                    var saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Text Files|*.txt",
                        Title = "Save Public Key"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportKeyToFile(saveFileDialog.FileName, rsa.ToXmlString(false));
                    }

                    // Hiển thị hộp thoại lưu tệp để chọn nơi lưu cho private key
                    saveFileDialog.Title = "Save Private Key";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportKeyToFile(saveFileDialog.FileName, rsa.ToXmlString(true));
                    }

                    MessageBox.Show("Key pair generated and exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        static void ExportKeyToFile(string fileName, string key)
        {
            using (var sw = new StreamWriter(fileName))
            {
                sw.Write(key);
            }
        }

        private void btn_re_Click(object sender, EventArgs e)
        {
            // Kết nối đến cơ sở dữ liệu Oracle
            using (var connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                // Truy vấn dữ liệu từ bảng DANHMUC
                string query = "SELECT * FROM MI.DANHMUC";
                using (var adapter = new OracleDataAdapter(query, connection))
                {
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Hiển thị dữ liệu lên DataGridView
                    dataGridView4.DataSource = dataTable;
                }
            }
        }

        private void btn_pbk_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.Title = "Choose Public Key File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_pbt.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }
        private void btn_prik_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.Title = "Choose Private Key File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_prit.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
        }

        private void btn_themDM_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (var cmd = new OracleCommand("MI.ThemDanhMuc", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("p_ten_dm", OracleDbType.NVarchar2).Value = txt_tenDME.Text;
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Danh mục đã được thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy văn bản cần mã hóa từ textbox
                string plaintext = txt_tenDM.Text;

                // Đọc khóa công khai từ tệp tin
                string publicKey = txt_pbt.Text;

                // Khởi tạo đối tượng RSA với khóa công khai
                using (var rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(publicKey);

                    // Mã hóa văn bản
                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plaintext), false);

                    // Xuất kết quả ra textbox
                    txt_tenDME.Text = Convert.ToBase64String(encryptedData);
                }

                MessageBox.Show("Encryption successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy văn bản đã mã hóa từ textbox
                string encryptedText = txt_tenDMpick.Text;

                // Đọc khóa riêng tư từ tệp tin
                string privateKey = txt_prit.Text;

                // Khởi tạo đối tượng RSA với khóa riêng tư
                using (var rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);

                    // Giải mã văn bản
                    byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(encryptedText), false);

                    // Xuất kết quả giải mã ra textbox
                    txt_test.Text = Encoding.UTF8.GetString(decryptedData);
                }

                MessageBox.Show("Giải mã thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Lấy giá trị cột "TEN_DM" của dòng được chọn
                string tenDM = dataGridView4.SelectedRows[0].Cells["TEN_DM"].Value.ToString();

                // Xuất giá trị lên TextBox
                txt_tenDMpick.Text = tenDM;
            }
        }
    }
}

   