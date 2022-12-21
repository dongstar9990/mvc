using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication23.Models
{
    public class SanPhamMua
    {
        public string maSP { get; set; }
        public int soLuong { get; set; }

        public override bool Equals(object obj)
        {
            SanPhamMua spm = (SanPhamMua)obj;
            return (spm.maSP.Equals(this.maSP));
        }
    }
}