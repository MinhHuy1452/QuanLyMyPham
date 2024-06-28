using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTPhieuNhapBUS
    {
        ChiTietPhieuNhapAccess CTPN = new ChiTietPhieuNhapAccess();
        public List<ChiTietPhieuNhap> laytoanbosanpham()
        {
            return CTPN.laytoanbosanpham();
        }
        public bool xoaCTPhieunhap(string maCTPhieunhap)
        {
            return CTPN.xoaCTPhieuNhap(maCTPhieunhap);
        }
        public bool themCTPhieunhap(ChiTietPhieuNhap ctpn)
        {
            return CTPN.ThemCTPhieunhap(ctpn);
        }
        //public bool suaCTphieunhap(ChiTietHoaDon ctpn)
        //{
        //    return CTPN.SuaCTPhieunhap(ctpn);
        //}
    }
}
