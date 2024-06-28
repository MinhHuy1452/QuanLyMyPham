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

namespace WindowsFormsApp1
{
    public partial class Frm_ThemThongKe : Form
    {
        public Frm_ThemThongKe()
        {
            InitializeComponent();
            loadPhieuNhap();
            loadsanpham();
            loadtennhacc();
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



        private void btn_Them_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap pn = new ChiTietPhieuNhap();
            pn.IdPhieuNhap = CBB_MaPhieuNhap.Text;
            pn.TenSanPham = CBB_tensanpham.Text;
            pn.TenNhaCungCap = cbb_nhacc.Text;
            pn.SoLuong = Int32.Parse(txt_soluong.Text);
            pn.DonGia = float.Parse(txt_dongia.Text);
            CTPhieuNhapBUS spbus = new CTPhieuNhapBUS();
            bool kq = spbus.themCTPhieunhap(pn);
            if (kq = true)
            {
                DialogResult tb = MessageBox.Show("Thêm Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (tb == DialogResult.OK)
                {
                    Frm_ThemThongKe frm = new Frm_ThemThongKe();
                    this.Close();

                }
            }
        }
        public void loadsanpham()
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("MI.SELECT_TEN_SANPHAM", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Tạo tham số OUT_CURSOR để nhận kết quả của stored procedure
                    command.Parameters.Add(new OracleParameter("out_cursor", OracleDbType.RefCursor, ParameterDirection.Output));

                    // Sử dụng OracleDataReader để đọc dữ liệu từ tham số OUT_CURSOR
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Xóa dữ liệu hiện có trong ComboBox (nếu có)
                        CBB_tensanpham.Items.Clear();

                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ OracleDataReader và thêm vào ComboBox
                            string tenSanPham = reader.GetString(0);
                            CBB_tensanpham.Items.Add(tenSanPham);
                        }
                    }
                }
            }

        }
        public void loadtennhacc()
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand("MI.SELECT_NCC", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Tạo tham số OUT_CURSOR để nhận kết quả của stored procedure
                    command.Parameters.Add(new OracleParameter("out_cursor", OracleDbType.RefCursor, ParameterDirection.Output));

                    // Sử dụng OracleDataReader để đọc dữ liệu từ tham số OUT_CURSOR
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Xóa dữ liệu hiện có trong ComboBox (nếu có)
                        cbb_nhacc.Items.Clear();

                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ OracleDataReader và thêm vào ComboBox
                            string idPhieuNhap = reader["ID_NCC"].ToString();
                            cbb_nhacc.Items.Add(idPhieuNhap);
                        }
                    }
                }
            }

        }

        public void loadPhieuNhap()
        {
            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                // Tạo một OracleCommand để gọi stored procedure
                using (OracleCommand command = new OracleCommand("MI.SELECT_ID_PN", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Tạo tham số OUT_CURSOR để nhận kết quả của stored procedure
                    command.Parameters.Add(new OracleParameter("out_cursor", OracleDbType.RefCursor, ParameterDirection.Output));

                    // Tạo OracleDataAdapter để đọc dữ liệu từ tham số OUT_CURSOR
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        // Tạo DataTable để lưu trữ dữ liệu
                        DataTable dataTable = new DataTable();

                        // Đổ dữ liệu vào DataTable từ tham số OUT_CURSOR
                        adapter.Fill(dataTable);

                        // Xóa dữ liệu hiện có trong ComboBox (nếu có)
                        CBB_MaPhieuNhap.Items.Clear();

                        // Đọc dữ liệu từ DataTable và thêm vào ComboBox
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string idPhieuNhap = row["ID_PN"].ToString();
                            CBB_MaPhieuNhap.Items.Add(idPhieuNhap);
                        }
                    }
                }
            }
        }
        private void Frm_ThemThongKe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
