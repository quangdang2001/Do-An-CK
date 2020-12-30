using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnline
{
    public class NHACUNGCAP
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string NuocSX {get; set;}
        public NHACUNGCAP(string MaNCC, string TenNCC, string DiaChi, string SDT, string Email)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Email = Email;
            this.NuocSX= NuocSX;
        }
    }
}
