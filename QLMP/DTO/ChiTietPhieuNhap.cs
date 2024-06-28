using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        public string IdPhieuNhap { get; set; }
        public string TenSanPham { get; set; }
        public string TenNhaCungCap { get; set; }
        public DateTime NgayLap {  get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public decimal TongTien { get; set; }

        public ChiTietPhieuNhap() { }
    }
}
