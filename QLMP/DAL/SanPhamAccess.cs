using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.ComponentModel;
using Oracle.ManagedDataAccess.Client;
using System.Globalization;

namespace DAL
{
    public class SanPhamAccess : DBConnection
    {
        List<SanPham> dsdl = new List<SanPham>();
        public List<SanPham> laytoanbosanpham()
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.SELECT_SANPHAM";
            command.Connection = conn;

            OracleParameter outCursor = new OracleParameter("OUT_CURSOR", OracleDbType.RefCursor);
            outCursor.Direction = ParameterDirection.Output;
            command.Parameters.Add(outCursor);

            OracleDataReader reader = command.ExecuteReader();
            List<SanPham> dsdl = new List<SanPham>();

            while (reader.Read())
            {
                string maSanPham = reader.GetString(0);
                string tenSanPham = reader.GetString(1);
                int soLuongTon = reader.GetInt32(2);
                float gia = reader.GetFloat(3);
                string moTa = reader.GetString(4);
                string thuongHieu = reader.GetString(5);
                string idDanhMuc = reader.GetString(6);

                SanPham dl = new SanPham
                {
                    idSanPham = maSanPham,
                    tenSanPham = tenSanPham,
                    soLuongTon = soLuongTon,
                    Gia = gia,
                    moTa = moTa,
                    thuongHieu = thuongHieu,
                    TenDanhMuc = idDanhMuc
                };

                dsdl.Add(dl);
            }

            reader.Close();
            return dsdl;
        }
        public bool xoaSanPham(string maSanPham)
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.XOA_SANPHAM";
            command.Connection = conn;
            command.Parameters.Add(":maSanPham", OracleDbType.Varchar2).Value = maSanPham;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool ThemSanPham(SanPham dl)
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.INSERT_SANPHAM_PROC";
            command.Connection = conn;
            command.Parameters.Add("p_idSanPham", OracleDbType.NVarchar2, 10).Value = dl.idSanPham;
            command.Parameters.Add("p_tenSanPham", OracleDbType.NVarchar2, 30).Value = dl.tenSanPham;
            command.Parameters.Add("p_soLuongTon", OracleDbType.Int32).Value = dl.soLuongTon;
            command.Parameters.Add("p_gia", OracleDbType.BinaryFloat).Value = dl.Gia;
            command.Parameters.Add("p_moTa", OracleDbType.NVarchar2, 50).Value = dl.moTa;
            command.Parameters.Add("p_thuongHieu", OracleDbType.Varchar2, 20).Value = dl.thuongHieu;
            command.Parameters.Add("p_tenDanhMuc", OracleDbType.NVarchar2, 30).Value = dl.TenDanhMuc;

            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool SuaSanPham(SanPham dl)
        {
            Moketnoi();
            OracleCommand command = new OracleCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MI.UPDATE_SANPHAM_PROC";
            command.Connection = conn;

            command.Parameters.Add("P_ID_SP", OracleDbType.NVarchar2).Value = dl.idSanPham;
            command.Parameters.Add("P_TEN_SP", OracleDbType.NVarchar2).Value = dl.tenSanPham;
            command.Parameters.Add("P_SL_TON", OracleDbType.Int32).Value = dl.soLuongTon;
            command.Parameters.Add("P_GIA", OracleDbType.BinaryFloat).Value = dl.Gia;
            command.Parameters.Add("P_MOTA", OracleDbType.NVarchar2).Value = dl.moTa;
            command.Parameters.Add("P_THUONGHIEU", OracleDbType.Varchar2).Value = dl.thuongHieu;
            command.Parameters.Add("P_TENDANHMUC", OracleDbType.NVarchar2).Value = dl.TenDanhMuc;

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }

    }
}
