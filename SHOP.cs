using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    public class SHOP
    {
        public string MaShop { get; set; }
        public string TenShop { get; set; }
        public string DiaChi { get; set; }
        public SHOP(string MaShop, string TenShop, string DiaChi)
        {
            this.MaShop = MaShop;
            this.TenShop = TenShop;
            this.DiaChi = DiaChi;
        }
    }
}
