using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class GIOHANG
    {
        public string MaGH { get; set; }
        public HOADON HoaDon { get; set; }
        public GIOHANG(string MaGH, HOADON HoaDon)
        {
            this.MaGH = MaGH;
            this.HoaDon = HoaDon;
        }

    }
}
