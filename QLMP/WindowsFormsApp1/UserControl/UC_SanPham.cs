using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp1.GUI
{
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
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

        //private bool CheckInsertPermission()
        //{
        //    try
        //    {
        //        using (OracleConnection connection = new OracleConnection(connectionSTR))
        //        {
        //            connection.Open();

        //            using (OracleCommand cmd = new OracleCommand("SELECT TABLE_NAME, PRIVILEGE FROM DBA_TAB_PRIVS WHERE GRANTEE = 'NHANVIEN' AND TABLE_NAME = 'SANPHAM' AND PRIVILEGE = 'INSERT'", connection))
        //            {
        //                using (OracleDataReader reader = cmd.ExecuteReader())
        //                {
        //                    Nếu có bản ghi trả về, người dùng có quyền INSERT
        //                    return reader.HasRows;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    Người dùng không có quyền INSERT
        //    return false;
        //}

        //private void btn_them_Click(object sender, EventArgs e)
        //{
        //    if (CheckInsertPermission())
        //    {
        //        Mở form hoặc thực hiện hành động tương ứng nếu có quyền
        //        Frm_ThemSanPham frm = new Frm_ThemSanPham();
        //        frm.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Bạn không có quyền thêm sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void btn_them_Click(object sender, EventArgs e)
        {
            Frm_ThemSanPham frm = new Frm_ThemSanPham();
            frm.Show();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            loaddata();


        }
        public void loaddata()
        {
            SanPhamBUS dlbus = new SanPhamBUS();
            List<SanPham> dsdlGUI = dlbus.laytoanbosanpham();

            // Tạo BindingList từ danh sách sản phẩm để dễ dàng quản lý dữ liệu
            BindingList<SanPham> bindingList = new BindingList<SanPham>(dsdlGUI);

            // Thiết lập DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingList;

            // Tạo các cột cho DataGridView và thiết lập DataPropertyName tương ứng
            ID_SP_COL.DataPropertyName = "idSanPham";
            TEN_SP_COL.DataPropertyName = "tenSanPham";
            SL_TON_COL.DataPropertyName = "soLuongTon";
            THUONGHIEU_COL.DataPropertyName = "thuongHieu";
            MOTA_COL.DataPropertyName = "moTa";
            GIA_COL.DataPropertyName = "Gia";
            ID_DM.DataPropertyName = "TenDanhMuc";

            // Thêm các cột vào DataGridView
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    SanPham selectedProduct = selectedRow.DataBoundItem as SanPham;

                    if (selectedProduct != null)
                    {
                        DialogResult tb = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (tb == DialogResult.OK)
                        {
                            SanPhamBUS dlbus = new SanPhamBUS();
                            bool kq = dlbus.xoaSanPham(selectedProduct.idSanPham);

                            if (!kq)
                            {
                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Xóa dòng đã chọn từ DataGridView
                                dataGridView1.Rows.Remove(selectedRow);

                                // Cập nhật nguồn dữ liệu của DataGridView (nếu sử dụng BindingSource)
                                // bindingSource.ResetBindings(false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string keyword = textBox1.Text;
                SanPhamBUS dlbus = new SanPhamBUS();

                List<SanPham> dsdlGUI = dlbus.laytoanbosanpham();
                List<SanPham> dsDaLoc = dsdlGUI.Where(x => x.idSanPham.Contains(keyword)).ToList();
                BindingList<SanPham> bindingList = new BindingList<SanPham>(dsDaLoc);
                dataGridView1.DataSource = bindingList;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string keyword = textBox1.Text;
                SanPhamBUS dlbus = new SanPhamBUS();

                List<SanPham> dsdlGUI = dlbus.laytoanbosanpham();
                List<SanPham> dsDaLoc = dsdlGUI.Where(x => x.tenSanPham.Contains(keyword)).ToList();
                BindingList<SanPham> bindingList = new BindingList<SanPham>(dsDaLoc);
                dataGridView1.DataSource = bindingList;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                string keyword = textBox1.Text;
                SanPhamBUS dlbus = new SanPhamBUS();

                List<SanPham> dsdlGUI = dlbus.laytoanbosanpham();
                List<SanPham> dsDaLoc = dsdlGUI.Where(x => x.thuongHieu.Contains(keyword)).ToList();
                BindingList<SanPham> bindingList = new BindingList<SanPham>(dsDaLoc);
                dataGridView1.DataSource = bindingList;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                string keyword = textBox1.Text;
                SanPhamBUS dlbus = new SanPhamBUS();

                List<SanPham> dsdlGUI = dlbus.laytoanbosanpham();
                List<SanPham> dsDaLoc = dsdlGUI.Where(x => x.TenDanhMuc.Contains(keyword)).ToList();
                BindingList<SanPham> bindingList = new BindingList<SanPham>(dsDaLoc);
                dataGridView1.DataSource = bindingList;
            }
        }

        

        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Lấy dòng được chỉnh sửa
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy giá trị từ các ô cột
                string idSanPham = row.Cells["ID_SP_COL"].Value.ToString();
                string tenSanPham = row.Cells["TEN_SP_COL"].Value.ToString();
                int soLuongTon = Convert.ToInt32(row.Cells["SL_TON_COL"].Value);
                float gia = Convert.ToSingle(row.Cells["GIA_COL"].Value);
                string moTa = row.Cells["MOTA_COL"].Value.ToString();
                string thuongHieu = row.Cells["THUONGHIEU_COL"].Value.ToString();
                string tenDanhMuc = row.Cells["ID_DM"].Value.ToString(); // Chú ý: Đây là ID_DM, không phải tên danh mục

                // Tạo đối tượng SanPham và cập nhật thông tin
                SanPham dl = new SanPham();
                dl.idSanPham = idSanPham;
                dl.tenSanPham = tenSanPham;
                dl.soLuongTon = soLuongTon;
                dl.Gia = gia;
                dl.moTa = moTa;
                dl.thuongHieu = thuongHieu;
                dl.TenDanhMuc = tenDanhMuc;

                // Gọi phương thức cập nhật sản phẩm trong BUS
                SanPhamBUS dlbus = new SanPhamBUS();
                bool kq = dlbus.suaSanPham(dl);
                if (!kq)
                {
                    DialogResult tb = MessageBox.Show("Bạn Có Muốn Cập Nhật Hay Không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (tb == DialogResult.OK)
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi xảy ra
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nhatky_Click(object sender, EventArgs e)
        {
            NhatKySanPham frm = new NhatKySanPham();
            frm.Show();
        }

        
    }
}
