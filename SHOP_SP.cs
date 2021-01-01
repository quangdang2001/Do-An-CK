using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class SHOP_SP
    {
        public SHOP Shop { get; set; }
        public SANPHAM SanPham { get; set; }
        public SHOP_SP(SHOP Shop, SANPHAM SanPham)
        {
            this.Shop = Shop;
            this.SanPham = SanPham;
        }
    }
}
