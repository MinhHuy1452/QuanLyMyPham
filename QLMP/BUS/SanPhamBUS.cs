using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamAccess dl = new SanPhamAccess();
        public List<SanPham> laytoanbosanpham()
        {
            return dl.laytoanbosanpham();
        }
        public bool xoaSanPham(string maSanPham)
        {
            return dl.xoaSanPham(maSanPham);
        }
        public bool themSanPham(SanPham dll)
        {
            return dl.ThemSanPham(dll);
        }
        public bool suaSanPham(SanPham dll)
        {
            return dl.SuaSanPham(dll);
        }
    }
}
