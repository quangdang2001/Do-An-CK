using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class KHACHHANG_SANPHAM
    {
        public KHACHHANG KhachHang { get; set; }
        public SANPHAM SanPham { get; set; }
        public KHACHHANG_SANPHAM(KHACHHANG KhachHang, SANPHAM SanPham)
        {
            this.KhachHang = KhachHang;
            this.SanPham = SanPham;
        }
    }
}
