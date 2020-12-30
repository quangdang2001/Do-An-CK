using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class BOPHAN_GIAOHANG
    {
        public string ID_GH { get; set; }
        public string TG_NhanHang { get; set; }
        public string TG_GiaoHang { get; set; }
        public bool ShipCOD { get; set; }
        public BOPHAN_GIAOHANG( string ID_DG, string TG_NhanHang, string TG_GiaoHang, bool ShipCOD)
        {
            this.ID_GH = ID_GH;
            this.TG_NhanHang = TG_NhanHang;
            this.TG_GiaoHang = TG_GiaoHang;
            this.ShipCOD = ShipCOD;
        }
    }
}
