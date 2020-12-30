using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class CHITIET_GIOHANG
    {
        public GIOHANG GioHang { get; set; }
        public SANPHAM SanPham { get; set; }
        public int SoLuong { get; set; }
        public HOADON HoaDon { get; set; }
        public CHITIET_GIOHANG(GIOHANG GioHang, SANPHAM SanPham, int SoLuong, HOADON HoaDon)
        {
            this.GioHang = GioHang;
            this.SanPham = SanPham;
            this.HoaDon = HoaDon;
            this.SoLuong = SoLuong;
        }
    }
}
