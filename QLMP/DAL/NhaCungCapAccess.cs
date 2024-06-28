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
    public class NhaCungCapAccess : DBConnection
    {
        public bool ThemNhaCungCap(NhaCungCap cc)
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO Nhacungcap (idnhacungcap, tennhacungcap, diachi, sodt) VALUES (@Idkhachhang,@TenKhachHang,@DiaChi,@sodt)";
            command.Connection = conn;
            command.Parameters.Add("@Idkhachhang", cc.nhaCungCapID);
            command.Parameters.Add("@TenKhachHang", cc.tenNhaCungCap);
            command.Parameters.Add("@DiaChi", cc.diaChi);
            command.Parameters.Add("@sodt", cc.soDienThoai);
           
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
