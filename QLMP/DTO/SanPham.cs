using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public string idSanPham { get; set; }
        public string tenSanPham { get; set; }
        public int soLuongTon { get; set; }
        public float Gia { get; set; }
        public string moTa { get; set; }
        public string thuongHieu { get; set; }
        public string TenDanhMuc { get; set; }
        public SanPham() {
            
        
        }
    }
}
