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
        public CHI_TIET_SP ChiTietSP { get; set; }
        public SANPHAM(string MaSP, string TenSP, double DonGiaSP,CHI_TIET_SP ChiTietSP)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DonGiaSP = DonGiaSP;
            this.ChiTietSP = ChiTietSP;
        }
    }
}