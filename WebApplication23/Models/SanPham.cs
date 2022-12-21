using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication23.Models
{
    public class SanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string hinhAnh { get; set; }
        public int giaTien { get; set; }

        public SanPham()
        {

        }
        public SanPham(string maSP)
        {
            this.maSP = maSP;
        }
        public SanPham(string maSP, string tenSP, string hinhAnh, int giaTien) : this(maSP)
        {
            this.tenSP = tenSP;
            this.hinhAnh = hinhAnh;
            this.giaTien = giaTien;
        }

        public override bool Equals(object obj)
        {
            SanPham other = obj as SanPham;
            return (other.maSP.Equals(this.maSP));
        }
    }
}