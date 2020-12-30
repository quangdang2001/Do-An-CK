using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    public class KHACHHANG
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string NgSinh { get; set; }
        public KHACHHANG(string MaKH, string TenKH, string GioiTinh,string DiaChi, string SDT, string Email, string NgSinh)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Email = Email;
            this.NgSinh = NgSinh;
        }
    }
}
