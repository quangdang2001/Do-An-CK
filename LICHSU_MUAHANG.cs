using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class LICHSU_MUAHANG
    {
        public string MaLS { get; set; }
        public HOADON HoaDon { get; set; }
        public string NgayMua { get; set; }
        public string ThoiDiemMua { get; set; }
        public LICHSU_MUAHANG (string MaLS, HOADON HoaDon, string NgayMua , string ThoiDiemMua)
        {
            this.HoaDon = HoaDon;
            this.MaLS = MaLS;
            this.NgayMua = NgayMua;
            this.ThoiDiemMua = ThoiDiemMua;
        }
    }
}
