using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhap
    {
        public string IdPhieuNhap {  get; set; }
        public DateTime ngayLap { get; set; }
        public string TenTaiKhoan { get; set; }

        public PhieuNhap() { }
    }
}
