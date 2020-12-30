﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class SANPHAM
    {
        public string MaSP { get; set; }
        public LOAI_SP LoaiSP { get; set; }
        public string TenSP { get; set; }
        public double DonGiaSP { get; set; }
        public SANPHAM(string MaSP, LOAI_SP LoaiSP, string TenSP, string MaNVQL,double DonGiaSP, NHACUNGCAP NhaCungCap)
        {
            this.MaSP = MaSP;
            this.LoaiSP = LoaiSP;
            this.TenSP = TenSP;
            this.DonGiaSP = DonGiaSP;
        }
    }
}
