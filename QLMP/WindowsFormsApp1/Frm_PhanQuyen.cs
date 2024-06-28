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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Frm_PhanQuyen : Form
    {
        public Frm_PhanQuyen()
        {
            InitializeComponent();
            lbl_ten.Text = DAL.DBConnection.user;
            lbl_chucvu.Text = share_data.chucvu;
            
            
            cbb_TenBang.SelectedIndex = 0;
            LoadUsersInTablespace();
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
        //public void loaduser()
        //{
        //    using (OracleConnection connection = new OracleConnection(connectionSTR))
        //    {
        //        connection.Open();

        //        // Lấy giá trị đã chọn từ ComboBox cbb_NhomQuyen
        //        string selectedRole = cbb_NhomQuyen.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox

        //        // Thay đổi truy vấn SQL để lấy danh sách người dùng thuộc vai trò đã chọn
        //        string query = "SELECT grantee FROM dba_role_privs WHERE granted_role = :role";
        //        using (OracleCommand command = new OracleCommand(query, connection))
        //        {
        //            // Sử dụng tham số để thêm giá trị của vai trò đã chọn
        //            command.Parameters.Add(new OracleParameter("role", OracleDbType.Varchar2)).Value = selectedRole;

        //            using (OracleDataReader reader = command.ExecuteReader())
        //            {
        //                // Xóa dữ liệu hiện có trong ComboBox (nếu có)
        //                cbb_User.Items.Clear();

        //                while (reader.Read())
        //                {
        //                    // Đọc danh sách người dùng và thêm vào ComboBox
        //                    string userName = reader.GetString(0);
        //                    cbb_User.Items.Add(userName);
        //                }
        //            }
        //        }
        //    }
        //}


        //private void button3_Click(object sender, EventArgs e)
        //{
        //    loaduser();
        //}



        private void LoadUsersInTablespace()
        {
            cbb_UserName.Items.Clear();
            string query = $"SELECT USERNAME FROM dba_users WHERE DEFAULT_TABLESPACE = 'NHANSU_TB'";

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbb_UserName.Items.Add(reader["USERNAME"].ToString());
                        }
                    }
                }
            }
        }
        private void LoadData()
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand cmd = new OracleCommand("SYS.LoadDataForUserTable", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Đối số đầu vào: tên GRANTEE và tên TABLE_NAME
                    cmd.Parameters.Add("p_grantee", OracleDbType.Varchar2).Value = cbb_NhomQuyen.Text;
                    cmd.Parameters.Add("p_tableName", OracleDbType.Varchar2).Value = cbb_TenBang.Text;

                    // Đối số đầu ra: kết quả dưới dạng SYS_REFCURSOR
                    cmd.Parameters.Add("p_result", OracleDbType.RefCursor, ParameterDirection.Output);

                    // Thực hiện stored procedure và lấy kết quả trả về
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Xóa dữ liệu cũ trên DataGridView

                        while (reader.Read())
                        {
                            int rowIndex = dataGridView1.Rows.Add();

                            // Thêm dữ liệu vào từng ô trong hàng mới
                            dataGridView1.Rows[rowIndex].Cells["GRANTEE"].Value = reader["GRANTEE"].ToString();
                            dataGridView1.Rows[rowIndex].Cells["TABLE_NAME"].Value = reader["TABLE_NAME"].ToString();
                            dataGridView1.Rows[rowIndex].Cells["PRIVILEGE"].Value = reader["PRIVILEGE"].ToString();
                        }
                    }
                }
            }
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadUsersInTablespace();
            LoadRolesForUser(cbb_NhomQuyen);
            LoadRolesForUser(cbb_NhomQuyen2);
            LoadDataIntoDataGridView();
            LoadUsersInCbb();
        }

        private void btn_TaoUser_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand cmd = new OracleCommand("SYS.CreateOracleUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Đối số đầu vào: tên người dùng và mật khẩu
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = txt_TaoUser.Text;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = txt_Password.Text;

                    // Thực hiện stored procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Người dùng {txt_TaoUser.Text} đã được tạo thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_TaoUser.ResetText();
                    txt_Password.ResetText();
                }
            }
        }

        // COMBOBOX LOAD USER ĐỂ XÓA USER
        private void LoadUsersInCbb()
        {
            cbb_xoauser.Items.Clear();

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("SYS.GetNHANSUTBUsernames", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Định nghĩa tham số đầu ra
                    OracleParameter outParameter = new OracleParameter("result", OracleDbType.RefCursor);
                    outParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outParameter);

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbb_xoauser.Items.Add(reader["USERNAME"].ToString());
                        }
                    }
                }
            }
        }
        private void DeleteSelectedUser()
        {
            if (cbb_xoauser.SelectedItem != null)
            {
                string selectedUsername = cbb_xoauser.SelectedItem.ToString();

                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand("SYS.DeleteUserByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào cho tên người dùng
                        command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = selectedUsername;

                        // Thực thi stored procedure để xóa người dùng
                        command.ExecuteNonQuery();


                        // Sau khi xóa, cập nhật lại ComboBox
                        LoadUsersInCbb();
                        MessageBox.Show("Xóa user thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("CHỌN USERNAME ĐỂ XÓA.");
            }
        }
        private void btn_xoauser_Click(object sender, EventArgs e)
        {
            DeleteSelectedUser();
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
        private void btn_GanQuyen_Click(object sender, EventArgs e)
        {
            string username = cbb_UserName.SelectedItem.ToString();
            string role = cbb_NhomQuyen2.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và chọn nhóm quyền.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand cmd = new OracleCommand("SYS.GrantRoleToUser", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_roleName", OracleDbType.Varchar2).Value = role;
                    cmd.Parameters.Add("p_username", OracleDbType.Varchar2).Value = username;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Đã gán nhóm quyền {role} cho người dùng {username}.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi gán quyền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadRolesForUser(ComboBox comboBoxRoles)
        {
            // Kết nối vào cơ sở dữ liệu Oracle
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("SYS.GetUserRoles", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("p_username", OracleDbType.Varchar2).Value = lbl_ten.Text;
                    command.Parameters.Add("p_roles", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        comboBoxRoles.Items.Clear();

                        while (reader.Read())
                        {
                            comboBoxRoles.Items.Add(reader.GetString(0));
                        }

                        if (comboBoxRoles.Items.Count > 0)
                        {
                            comboBoxRoles.SelectedIndex = 0;
                        }
                    }
                }
            }
        }
        // TẠO NHÓM QUYỀN
        private void btn_TaoNhomQuyen_Click(object sender, EventArgs e)
        {
            string roleName = txt_TenNhomQuyen.Text;

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Vui lòng nhập tên nhóm quyền.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                string createRoleSql = $"CREATE ROLE {roleName}";

                using (OracleCommand createRoleCmd = new OracleCommand(createRoleSql, connection))
                {
                    try
                    {
                        createRoleCmd.ExecuteNonQuery();
                        MessageBox.Show($"Đã tạo nhóm quyền {roleName}.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_TenNhomQuyen.ResetText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tạo nhóm quyền: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // LOAD GRIDVIEW THỨ 2
        private void LoadDataIntoDataGridView()
        {
            dataGridView2.Rows.Clear();
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand cmd = new OracleCommand("SYS.GetUsersWithRole", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Định nghĩa đối số cursorVar để lấy kết quả
                    cmd.Parameters.Add("cursorVar", OracleDbType.RefCursor, ParameterDirection.Output);

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ SqlDataReader và thêm vào DataGridView
                            string username = reader.GetString(0);
                            string role = reader.GetString(1);

                            // Tạo một dòng mới
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView2);
                            row.Cells[0].Value = username;
                            row.Cells[1].Value = role;

                            // Thêm dòng vào DataGridView
                            dataGridView2.Rows.Add(row);
                        }
                    }
                }
            }


        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (cbb_NhomQuyen.SelectedIndex >= 0 && cbb_TenBang.SelectedIndex >= 0)
        //    {
        //        string permissions = "";

        //        if (SELECT_checkBox.Checked)
        //        {
        //            permissions += "SELECT, ";
        //        }
        //        if (DELETE_checkBox.Checked)
        //        {
        //            permissions += "DELETE, ";
        //        }
        //        if (UPDATE_checkBox.Checked)
        //        {
        //            permissions += "UPDATE, ";
        //        }
        //        if (INSERT_checkBox.Checked)
        //        {
        //            permissions += "INSERT, ";
        //        }
        //        if (CONNECT_checkBox.Checked)
        //        {
        //            permissions += "CONNECT, ";
        //        }
        //        if (EXECUTE_checkBox.Checked)
        //        {
        //            permissions += "EXECUTE, ";
        //        }
        //        if (RESOURCE_checkBox.Checked)
        //        {
        //            permissions += "RESOURCE, ";
        //        }

        //        if (!string.IsNullOrEmpty(permissions))
        //        {
        //            Loại bỏ dấu phẩy cuối cùng nếu có
        //            permissions = permissions.Substring(0, permissions.Length - 2);

        //            Tên người dùng hoặc role cần cấp hoặc thu hồi quyền
        //            string usernameOrRole = cbb_NhomQuyen.SelectedItem.ToString();

        //            Tên bảng hoặc stored procedure mà bạn muốn cấp hoặc thu hồi quyền
        //            string objectName = "MI." + cbb_TenBang.SelectedItem.ToString();

        //            Sử dụng lệnh REVOKE hoặc GRANT để cấp hoặc thu hồi quyền
        //            using (OracleConnection connection = new OracleConnection(connectionSTR))
        //            {
        //                connection.Open();
        //                if (RESOURCE_checkBox.Checked || CONNECT_checkBox.Checked)
        //                {
        //                    string revokeCommand = "REVOKE " + permissions + " FROM " + usernameOrRole;
        //                    using (OracleCommand command = new OracleCommand(revokeCommand, connection))
        //                    {
        //                        command.ExecuteNonQuery();
        //                    }
        //                    MessageBox.Show("Đã thu hồi quyền: " + permissions + " từ " + usernameOrRole, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //                else
        //                {
        //                    try
        //                    {
        //                        string revokeCommand = "REVOKE " + permissions + " ON " + objectName + " FROM " + usernameOrRole;
        //                        using (OracleCommand command = new OracleCommand(revokeCommand, connection))
        //                        {
        //                            command.ExecuteNonQuery();
        //                        }
        //                        MessageBox.Show("Đã thu hồi quyền: " + permissions + " cho " + usernameOrRole, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show("Bạn Đã Thu hồi quyền: " + permissions + " từ " + usernameOrRole, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            Thông báo nếu không chọn quyền nào
        //            MessageBox.Show("Vui lòng chọn ít nhất một quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    else
        //    {
        //        Thông báo nếu chưa chọn người dùng / role hoặc bảng/ stored procedure
        //        MessageBox.Show("Vui lòng chọn người dùng/role và bảng/stored procedure!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbb_NhomQuyen.SelectedIndex >= 0 && cbb_TenBang.SelectedIndex >= 0)
            {
                string permissions = "";

                if (SELECT_checkBox.Checked)
                {
                    permissions += "SELECT, ";
                }
                if (DELETE_checkBox.Checked)
                {
                    permissions += "DELETE, ";
                }
                if (UPDATE_checkBox.Checked)
                {
                    permissions += "UPDATE, ";
                }
                if (INSERT_checkBox.Checked)
                {
                    permissions += "INSERT, ";
                }
                if (CONNECT_checkBox.Checked)
                {
                    permissions += "CONNECT, ";
                }
                if (EXECUTE_checkBox.Checked)
                {
                    permissions += "EXECUTE, ";
                }
                if (RESOURCE_checkBox.Checked)
                {
                    permissions += "RESOURCE, ";
                }

                if (!string.IsNullOrEmpty(permissions))
                {
                    // Remove the trailing comma
                    permissions = permissions.Substring(0, permissions.Length - 2);

                    // Username or role to grant or revoke permissions
                    string usernameOrRole = cbb_NhomQuyen.SelectedItem.ToString();

                    // Object name (table or stored procedure) to grant or revoke permissions
                    string objectName = "MI." + cbb_TenBang.SelectedItem.ToString();

                    // Use REVOKE or GRANT to grant or revoke permissions
                    using (OracleConnection connection = new OracleConnection(connectionSTR))
                    {
                        connection.Open();
                        if (RESOURCE_checkBox.Checked || CONNECT_checkBox.Checked)
                        {
                            string revokeCommand = "REVOKE " + permissions + " FROM " + usernameOrRole;
                            using (OracleCommand command = new OracleCommand(revokeCommand, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Permissions revoked: " + permissions + " from " + usernameOrRole, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            try
                            {
                                string revokeCommand = "REVOKE " + permissions + " ON " + objectName + " FROM " + usernameOrRole;

                                // If INSERT permission and objectName is MI.SANPHAM, add an additional REVOKE statement
                                if (objectName.Equals("MI.SANPHAM"))
                                {
                                    // Check for INSERT permission
                                    if (INSERT_checkBox.Checked)
                                    {
                                        string revokeInsertCommand = "REVOKE EXECUTE ON MI.INSERT_SANPHAM_PROC FROM " + usernameOrRole;
                                        using (OracleCommand insertCommand = new OracleCommand(revokeInsertCommand, connection))
                                        {
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                    // Check for SELECT permission
                                    if (SELECT_checkBox.Checked)
                                    {
                                        string revokeSelectCommand = "REVOKE EXECUTE ON MI.SELECT_SANPHAM FROM " + usernameOrRole;
                                        using (OracleCommand selectCommand = new OracleCommand(revokeSelectCommand, connection))
                                        {
                                            selectCommand.ExecuteNonQuery();
                                        }
                                    }
                                    if (DELETE_checkBox.Checked)
                                    {
                                        string revokeSelectCommand = "REVOKE EXECUTE ON MI.XOA_SANPHAM FROM " + usernameOrRole;
                                        using (OracleCommand selectCommand = new OracleCommand(revokeSelectCommand, connection))
                                        {
                                            selectCommand.ExecuteNonQuery();
                                        }
                                    }
                                    if (UPDATE_checkBox.Checked)
                                    {
                                        string revokeSelectCommand = "REVOKE EXECUTE ON MI.UPDATE_SANPHAM_PROC FROM " + usernameOrRole;
                                        using (OracleCommand selectCommand = new OracleCommand(revokeSelectCommand, connection))
                                        {
                                            selectCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                                if (objectName.Equals("MI.CTPN"))
                                {
                                    if (INSERT_checkBox.Checked)
                                    {
                                        string revokeInsertCommand = "REVOKE EXECUTE ON MI.THEM_CHITIET_PHIEUNHAP FROM " + usernameOrRole;
                                        using (OracleCommand insertCommand = new OracleCommand(revokeInsertCommand, connection))
                                        {
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                    if (SELECT_checkBox.Checked)
                                    {
                                        string revokeSelectCommand = "REVOKE EXECUTE ON MI.GetCTPNData FROM " + usernameOrRole;
                                        using (OracleCommand selectCommand = new OracleCommand(revokeSelectCommand, connection))
                                        {
                                            selectCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                                if (objectName.Equals("MI.PHIEUNHAP"))
                                {
                                    if (INSERT_checkBox.Checked)
                                    {
                                        string revokeInsertCommand = "REVOKE EXECUTE ON MI.TaoPhieuNhap FROM " + usernameOrRole;
                                        using (OracleCommand insertCommand = new OracleCommand(revokeInsertCommand, connection))
                                        {
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                                    // Continue with the existing logic
                                    using (OracleCommand command = new OracleCommand(revokeCommand, connection))
                                {
                                    command.ExecuteNonQuery();
                                }
                                MessageBox.Show("Permissions revoked: " + permissions + " for " + usernameOrRole, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error revoking permissions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    // Show a message if no permissions are selected
                    MessageBox.Show("Please select at least one permission!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btn_CapQuyen_Click(object sender, EventArgs e)
        {

            if (cbb_NhomQuyen.SelectedIndex >= 0 && cbb_TenBang.SelectedIndex >= 0)
            {
                string permissions = "";

                if (SELECT_checkBox.Checked)
                {
                    permissions += "SELECT, ";
                }
                if (DELETE_checkBox.Checked)
                {
                    permissions += "DELETE, ";
                }
                if (UPDATE_checkBox.Checked)
                {
                    permissions += "UPDATE, ";
                }
                if (INSERT_checkBox.Checked)
                {
                    permissions += "INSERT, ";
                }
                if (CONNECT_checkBox.Checked)
                {
                    permissions += "CONNECT, ";
                }
                if (EXECUTE_checkBox.Checked)
                {
                    permissions += "EXECUTE, ";
                }
                if (RESOURCE_checkBox.Checked)
                {
                    permissions += "RESOURCE, ";
                }
                if (!string.IsNullOrEmpty(permissions))
                {
                    // Loại bỏ dấu phẩy cuối cùng nếu có
                    permissions = permissions.Substring(0, permissions.Length - 2);

                    // Tên người dùng hoặc role cần cấp quyền
                    string usernameOrRole = cbb_NhomQuyen.SelectedItem.ToString();

                    // Tên bảng hoặc stored procedure mà bạn muốn cấp quyền
                    string objectName = "MI." + cbb_TenBang.SelectedItem.ToString();

                    // Sử dụng lệnh GRANT để cấp quyền
                    using (OracleConnection connection = new OracleConnection(connectionSTR))
                    {
                        connection.Open();
                        if (RESOURCE_checkBox.Checked || CONNECT_checkBox.Checked)
                        {
                            string grantCommand = "GRANT " + permissions + " TO " + usernameOrRole;
                            using (OracleCommand command = new OracleCommand(grantCommand, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Đã cấp quyền: " + permissions + " cho " + usernameOrRole, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string grantCommand = "GRANT " + permissions + " ON " + objectName + " TO " + usernameOrRole;
                            if (objectName.Equals("MI.SANPHAM"))
                            {
                                // Check for INSERT permission
                                if (INSERT_checkBox.Checked)
                                {
                                    string grantInsertCommand = "GRANT EXECUTE ON MI.INSERT_SANPHAM_PROC TO " + usernameOrRole;
                                    using (OracleCommand insertCommand = new OracleCommand(grantInsertCommand, connection))
                                    {
                                        insertCommand.ExecuteNonQuery();
                                    }
                                }

                                // Check for SELECT permission
                                if (SELECT_checkBox.Checked)
                                {
                                    string grantSelectCommand = "GRANT EXECUTE ON MI.SELECT_SANPHAM TO " + usernameOrRole;
                                    using (OracleCommand selectCommand = new OracleCommand(grantSelectCommand, connection))
                                    {
                                        selectCommand.ExecuteNonQuery();
                                    }
                                }

                                if (DELETE_checkBox.Checked)
                                {
                                    string grantSelectCommand = "GRANT EXECUTE ON MI.XOA_SANPHAM TO " + usernameOrRole;
                                    using (OracleCommand selectCommand = new OracleCommand(grantSelectCommand, connection))
                                    {
                                        selectCommand.ExecuteNonQuery();
                                    }
                                }
                                if (UPDATE_checkBox.Checked)
                                {
                                    string grantSelectCommand = "GRANT EXECUTE ON MI.UPDATE_SANPHAM_PROC TO " + usernameOrRole;
                                    using (OracleCommand selectCommand = new OracleCommand(grantSelectCommand, connection))
                                    {
                                        selectCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            if (objectName.Equals("MI.CTPN"))
                            {
                                if (INSERT_checkBox.Checked)
                                {
                                    string grantInsertCommand = "GRANT EXECUTE ON MI.THEM_CHITIET_PHIEUNHAP TO " + usernameOrRole;
                                    using (OracleCommand insertCommand = new OracleCommand(grantInsertCommand, connection))
                                    {
                                        insertCommand.ExecuteNonQuery();
                                    }
                                }
                                if (SELECT_checkBox.Checked)
                                {
                                    string grantSelectCommand = "GRANT EXECUTE ON MI.GetCTPNData TO " + usernameOrRole;
                                    using (OracleCommand selectCommand = new OracleCommand(grantSelectCommand, connection))
                                    {
                                        selectCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            if (objectName.Equals("MI.PHIEUNHAP"))
                            {
                                if (INSERT_checkBox.Checked)
                                {
                                    string grantInsertCommand = "GRANT EXECUTE ON MI.TaoPhieuNhap TO " + usernameOrRole;
                                    using (OracleCommand insertCommand = new OracleCommand(grantInsertCommand, connection))
                                    {
                                        insertCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            using (OracleCommand command = new OracleCommand(grantCommand, connection))
                            {
                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show("Đã cấp quyền: " + permissions + " cho " + usernameOrRole, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    // Thông báo nếu không chọn quyền nào
                    MessageBox.Show("Vui lòng chọn ít nhất một quyền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Thông báo nếu chưa chọn người dùng/role hoặc bảng/stored procedure
                MessageBox.Show("Vui lòng chọn người dùng/role và bảng/stored procedure!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
 }
 