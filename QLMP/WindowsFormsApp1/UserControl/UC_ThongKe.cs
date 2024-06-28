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

namespace WindowsFormsApp1.GUI
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
            
        }
        static string host = DAL.DBConnection.host;
        static int port = DAL.DBConnection.port;
        static string sid = DAL.DBConnection.sid;
        static string user = DAL.DBConnection.user;
        static string password = DAL.DBConnection.password;

        private string connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;

        public void loaddata()
        {
            CTPhieuNhapBUS dlbus = new CTPhieuNhapBUS();
            List<ChiTietPhieuNhap> dsdlGUI = dlbus.laytoanbosanpham();

            // Tạo BindingList từ danh sách sản phẩm để dễ dàng quản lý dữ liệu
            BindingList<ChiTietPhieuNhap> bindingList = new BindingList<ChiTietPhieuNhap>(dsdlGUI);

            // Thiết lập DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingList;

            // Tạo các cột cho DataGridView và thiết lập DataPropertyName tương ứng
            ID_PN_COL.DataPropertyName = "IdPhieuNhap";
            TEN_NCC_COL.DataPropertyName = "TenNhaCungCap";
            TEN_SP_COL.DataPropertyName = "TenSanPham";
            NGAYLAP_COL.DataPropertyName = "NgayLap";
            SL_TON_COL.DataPropertyName = "Soluong";
            GIA_COL.DataPropertyName = "Dongia";
            TONGTIEN_COL.DataPropertyName = "TongTien";
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btn_ThemThongKe_Click(object sender, EventArgs e)
        {
            Frm_ThemThongKe frm = new Frm_ThemThongKe();
            frm.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                ChiTietPhieuNhap selected = selectedRow.DataBoundItem as ChiTietPhieuNhap;

                if (selected != null)
                {
                    CTPhieuNhapBUS dlbus = new CTPhieuNhapBUS();
                    bool kq = dlbus.xoaCTPhieunhap(selected.IdPhieuNhap);

                    if (kq)
                    {
                        MessageBox.Show("Xoá Thành Công !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xoá dòng đã chọn từ DataGridView
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                    else
                    {
                        MessageBox.Show("Xoá Thất Bại !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_TaoPhieu_Click(object sender, EventArgs e)
        {

            try
            {
                // Tạo kết nối
                using (OracleConnection connection = new OracleConnection(connectionSTR))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo đối tượng Command để gọi stored procedure
                    using (OracleCommand command = new OracleCommand("MI.TaoPhieuNhap", connection))
                    {
                        // Đặt kiểu Command là StoredProcedure
                        command.CommandType = CommandType.StoredProcedure;

                        // Thực thi stored procedure
                        command.ExecuteNonQuery();
                        MessageBox.Show("Đã tạo phiếu nhập thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // Get the entered purchase order ID from the TextBox
            string maPhieuNhap = txt_timkiem.Text;

            // Call the search method
            SearchPhieuNhap(maPhieuNhap);
        }

        private void SearchPhieuNhap(string maPhieuNhap)
        {
            // Call your business logic to get filtered data based on the entered purchase order ID
            CTPhieuNhapBUS dlbus = new CTPhieuNhapBUS();
            List<ChiTietPhieuNhap> dsdlGUI = dlbus.laytoanbosanpham().Where(ct => ct.IdPhieuNhap == maPhieuNhap).ToList();

            // Create a new BindingList with the filtered data
            BindingList<ChiTietPhieuNhap> bindingList = new BindingList<ChiTietPhieuNhap>(dsdlGUI);

            // Update the DataGridView DataSource
            dataGridView1.DataSource = bindingList;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            // If the search box is empty, reload the original data
            if (string.IsNullOrWhiteSpace(txt_timkiem.Text))
            {
                loaddata(); // Call your original method to load data
            }
        }
    }
}
         
