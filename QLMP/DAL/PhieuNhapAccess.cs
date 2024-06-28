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
    public class PhieuNhapAccess : DBConnection
    {
        List<PhieuNhap> dsNH = new List<PhieuNhap>();
        //public List<PhieuNhap> laytoanbosanpham()
        //{
        //    //Moketnoi();
        //    //OracleCommand command = new OracleCommand();
        //    //command.CommandType = CommandType.Text;
        //    //command.CommandText = "Select * from PHIEUNHAP";
        //    //command.Connection = conn;
        //    //OracleDataReader reader = command.ExecuteReader();
        //    //while (reader.Read())
        //    //{
                
        //    //    string IdHoaDon = reader.GetString(0);
        //    //    float TongTien = reader.GetFloat(1);
        //    //    DateTime NgayLap = reader.GetDateTime(2);
        //    //    string ThanhToan = reader.GetString(3);
        //    //    string SDT = reader.GetString(4);
        //    //    PhieuNhap hd = new PhieuNhap();
        //    //    hd.IdHoaDon = IdHoaDon;
        //    //    hd.TongTien = TongTien;
        //    //    hd.ngayLap = NgayLap;
        //    //    hd.thanhToan = ThanhToan;
        //    //    hd.SDT = SDT;
        //    //    dsNH.Add(hd);
        //    //}
        //    //reader.Close();
        //    //return dsNH;
        //}
        //public bool xoaNhapHang(string nhaphangid)
        //{
        //    //Moketnoi();
        //    //OracleCommand command = new OracleCommand();
        //    //command.CommandType = CommandType.Text;
        //    //command.CommandText = "delete from HOADON where IDHOADON=:IdHoaDon";
        //    //command.Connection = conn;
        //    //command.Parameters.Add(":IdHoaDon", OracleDbType.NVarchar2).Value = nhaphangid;
        //    //int kq = command.ExecuteNonQuery();
        //    //return kq > 0;
        //}
        //public bool ThemNhapHang(PhieuNhap NH)
        //{
        //    //Moketnoi();
        //    //OracleCommand command = new OracleCommand();
        //    //command.CommandType = CommandType.Text;
        //    //command.CommandText = "INSERT INTO HOADON (IDHOADON, TONGTIEN,NGAYLAP,THANHTOAN,SDT) VALUES (:IdHoaDon, :TongTien,:NgayLap, :ThanhToan,:SDT)";
        //    //command.Connection = conn;
        //    //command.Parameters.Add(":IdHoaDon", NH.IdHoaDon);
        //    //command.Parameters.Add(":TongTien", NH.TongTien);
        //    //command.Parameters.Add(":NgayLap", NH.ngayLap);
        //    //command.Parameters.Add(":ThanhToan", NH.thanhToan);
        //    //command.Parameters.Add(":SDT", NH.SDT);

        //    //int kq = command.ExecuteNonQuery();
        //    //return kq > 0;

        //}
        //public bool SuaNhaphang(PhieuNhap NH)
        //{
        ////    Moketnoi();
        ////    OracleCommand command = new OracleCommand();
        ////    command.CommandType = CommandType.Text;
        ////    command.CommandText = "UPDATE HOADON SET TONGTIEN = :TONGTIEN, NGAYLAP = :NGAYLAP, THANHTOAN = :THANHTOAN, SDT = :SDT Where IDHOADON = :IDHOADON";
        ////    command.Connection = conn;
        ////    command.Parameters.Add(":IDHOADON", NH.IdHoaDon);
        ////    command.Parameters.Add(":TONGTIEN", NH.TongTien);
        ////    command.Parameters.Add(":NGAYLAP", NH.ngayLap);
        ////    command.Parameters.Add(":THANHTOAN", NH.thanhToan);
        ////    command.Parameters.Add(":SDT", NH.SDT);
        ////    int kq = command.ExecuteNonQuery();
        ////    return kq > 0;

        //}
    }
}
