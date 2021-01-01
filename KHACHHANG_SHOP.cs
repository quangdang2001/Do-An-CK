using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class KHACHHANG_SHOP
    {
        public KHACHHANG KhachHang { get; set; }
        public SHOP Shop { get; set; }
        public KHACHHANG_SHOP(KHACHHANG KhachHang, SHOP Shop)
        {
            this.KhachHang = KhachHang;
            this.Shop = Shop;
        }
    }
}
