using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class SANPHAM
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double DonGiaSP { get; set; }
        public NHACUNGCAP NhaCungCap { get; set; }

        public SANPHAM(string MaSP, string TenSP, double DonGiaSP, NHACUNGCAP NhaCungCap)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DonGiaSP = DonGiaSP;
            this.NhaCungCap = NhaCungCap;
        }
    }
}
