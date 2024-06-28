using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class ChiTietPhieuNhapAccess : DBConnection
    {
        List<ChiTietPhieuNhap> dsCTPN = new List<ChiTietPhieuNhap>();
        public List<ChiTietPhieuNhap> laytoanbosanpham()
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.GetCTPNData";

            // Tạo đối số đầu ra
            OracleParameter outCursor = new OracleParameter();
            outCursor.ParameterName = "p_cursor";
            outCursor.OracleDbType = OracleDbType.RefCursor;
            outCursor.Direction = ParameterDirection.Output;
            command.Parameters.Add(outCursor);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);

                List<ChiTietPhieuNhap> dsCTPN = new List<ChiTietPhieuNhap>();

                foreach (DataRow row in dataTable.Rows)
                {
                    ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                    ctpn.IdPhieuNhap = row["ID_PN"].ToString();
                    ctpn.NgayLap = Convert.ToDateTime(row["NGAYLAP"]);
                    ctpn.TenSanPham = row["TEN_SP"].ToString();
                    ctpn.TenNhaCungCap = row["TEN_NCC"].ToString();
                    ctpn.SoLuong = Convert.ToInt32(row["SOLUONG"]);
                    ctpn.DonGia = Convert.ToSingle(row["DONGIA"]);
                    ctpn.TongTien = Convert.ToDecimal(row["TongTien"]);
                    dsCTPN.Add(ctpn);
                }

                return dsCTPN;
            }
            finally
            {
                dataTable.Dispose();
                adapter.Dispose();
            }
        }

        public bool xoaCTPhieuNhap(string CTphieunhapid)
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from MI.CTPN where ID_PN =:ID_PN";
            command.Connection = conn;
            command.Parameters.Add(":ID_PN", OracleDbType.NVarchar2).Value = CTphieunhapid;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool ThemCTPhieunhap(ChiTietPhieuNhap CTPN)
        {
            Moketnoi();
            // Tạo đối tượng OracleCommand
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.THEM_CHITIET_PHIEUNHAP";
            command.Connection = conn;
            // Thêm tham số cho stored procedure
            command.Parameters.Add("p_ID_PN", OracleDbType.Varchar2, 10).Value = CTPN.IdPhieuNhap;
            command.Parameters.Add("p_TenSP", OracleDbType.NVarchar2, 30).Value = CTPN.TenSanPham;
            command.Parameters.Add("p_TenNCC", OracleDbType.NVarchar2, 30).Value = CTPN.TenNhaCungCap;
            command.Parameters.Add("p_SOLUONG", OracleDbType.Int32).Value = CTPN.SoLuong;
            command.Parameters.Add("p_DONGIA", OracleDbType.Decimal).Value = Convert.ToDecimal(CTPN.DonGia);


            // Thực thi stored procedure
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }


        public List<ChiTietPhieuNhap> TimKiemTheoMaPhieuNhap(string maPhieuNhap)
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.TimKiemCTPNTheoMaPhieuNhap";

            // Thêm đối số đầu vào - mã phiếu nhập cần tìm
            OracleParameter inMaPhieuNhap = new OracleParameter();
            inMaPhieuNhap.ParameterName = "p_ID_PN";
            inMaPhieuNhap.OracleDbType = OracleDbType.Varchar2;
            inMaPhieuNhap.Direction = ParameterDirection.Input;
            inMaPhieuNhap.Value = maPhieuNhap;
            command.Parameters.Add(inMaPhieuNhap);

            // Tạo đối số đầu ra
            OracleParameter outCursor = new OracleParameter();
            outCursor.ParameterName = "p_cursor";
            outCursor.OracleDbType = OracleDbType.RefCursor;
            outCursor.Direction = ParameterDirection.Output;
            command.Parameters.Add(outCursor);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);

                List<ChiTietPhieuNhap> dsCTPN = new List<ChiTietPhieuNhap>();

                foreach (DataRow row in dataTable.Rows)
                {
                    ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap();
                    ctpn.IdPhieuNhap = row["ID_PN"].ToString();
                    ctpn.NgayLap = Convert.ToDateTime(row["NGAYLAP"]);
                    ctpn.TenSanPham = row["TEN_SP"].ToString();
                    ctpn.TenNhaCungCap = row["TEN_NCC"].ToString();
                    ctpn.SoLuong = Convert.ToInt32(row["SOLUONG"]);
                    ctpn.DonGia = Convert.ToSingle(row["DONGIA"]);
                    ctpn.TongTien = Convert.ToDecimal(row["TongTien"]);
                    dsCTPN.Add(ctpn);
                }

                return dsCTPN;
            }
            finally
            {
                dataTable.Dispose();
                adapter.Dispose();
            }
        }
        //public bool SuaCTPhieunhap(ChiTietPhieuNhap CTPN)
        //{
        //    Moketnoi();
        //    OracleCommand command = new OracleCommand();
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "ChinhSuaChiTietPhieuNhap";
        //    command.Connection = conn;
        //    command.Parameters.Add("@idCTphieunhap", CTPN.chiTietPhieuNhapID);
        //    command.Parameters.Add("@idPhieuNhap", CTPN.phieuNhapID);
        //    command.Parameters.Add("@idSanPham", CTPN.sanPhamID);
        //    command.Parameters.Add("@soLuong", CTPN.soLuong);
        //    command.Parameters.Add("@giaNhap", CTPN.giaNhap);

        //    int kq = command.ExecuteNonQuery();
        //    return kq > 0;

        //}
    }
}
