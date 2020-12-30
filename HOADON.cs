using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class HOADON
    {
        public string MaHD { get; set; }
        public LICHSU_MUAHANG LichSu { get; set; }
        public GIOHANG GioHang { get; set; }
        public double TongTien { get; set; }
        public BOPHAN_GIAOHANG GiaoHang{ get; set; }
        public HOADON(string MaHD, LICHSU_MUAHANG LichSu, GIOHANG GioHang, BOPHAN_GIAOHANG GiaoHang)
        {
            this.MaHD = MaHD;
            this.LichSu = LichSu;
            this.GioHang = GioHang;
            this.GiaoHang = GiaoHang;
        }
        
    }
}
