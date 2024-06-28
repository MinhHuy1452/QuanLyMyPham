using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapAccess cc = new NhaCungCapAccess();
        public bool themNhaCungCap(NhaCungCap ncc)
        {
            return cc.ThemNhaCungCap(ncc);
        }
    }
}
