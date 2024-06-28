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
using DAL;
namespace WindowsFormsApp1
{
    public partial class NhatKySanPham : Form
    {
        private DBConnection dbConnection = new DBConnection();
        public NhatKySanPham()
        {
            InitializeComponent();
            conn = new OracleConnection(connectionSTR);
            LoadData();

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

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {

            using (OracleConnection connection = new OracleConnection(connectionSTR))
            {
                connection.Open();

                using (OracleCommand cmd = new OracleCommand("MI.GET_SANPHAM_GIA_AUDIT", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm đối số đầu ra cho SYS_REFCURSOR
                    OracleParameter outCursor = new OracleParameter("p_cursor", OracleDbType.RefCursor);
                    outCursor.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outCursor);

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bảng dữ liệu đã được điền, giờ bạn có thể gán nó vào DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }


    }
}
