using BUS;
using DTO;

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
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Frm_ThemSanPham : Form
    {
        public Frm_ThemSanPham()
        {
            InitializeComponent();
            loadcombobox();
        }
        static string host = DAL.DBConnection.host;
        static int port = DAL.DBConnection.port;
        static string sid = DAL.DBConnection.sid;
        static string user = DAL.DBConnection.user;
        static string password = DAL.DBConnection.password;

        private string connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
        
        
        public void loadcombobox()
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();
                // Thực hiện truy vấn để lấy dữ liệu từ bảng DANHMUC (ví dụ)
                string query = "SELECT TEN_DM FROM MI.DANHMUC";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Xóa dữ liệu hiện có trong ComboBox (nếu có)
                        cbb_danhmuc.Items.Clear();
                        // Đọc dữ liệu từ truy vấn và thêm vào ComboBox
                        while (reader.Read())
                        {
                            string tenDanhMuc = reader.GetString(0);
                            cbb_danhmuc.Items.Add(tenDanhMuc);
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.idSanPham = txt_MaSP.Text;
            sp.tenSanPham = txt_TenSP.Text;
            sp.soLuongTon = Int32.Parse(txt_SoLuong.Text);
            sp.moTa = txt_MoTa.Text;
            sp.Gia = float.Parse(txt_Gia.Text);
            sp.thuongHieu = txt_ThuongHieu.Text;
            sp.TenDanhMuc = cbb_danhmuc.Text;
            SanPhamBUS spbus = new SanPhamBUS();
            bool kq = spbus.themSanPham(sp);
            if (kq = true)
            {
                DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    Frm_ThemSanPham frm = new Frm_ThemSanPham();
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
