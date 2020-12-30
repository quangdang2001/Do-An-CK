using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    public class TAIKHOAN
    {
        public string ID;
        public KHACHHANG KhachHang;
        public string pass;
        public string Ngaydk;
        public TAIKHOAN(string ID, KHACHHANG KhachHang, string pass, string Ngaydk)
        {
            this.ID = ID;
            this.KhachHang = KhachHang;
            this.pass = pass;
            this.Ngaydk = Ngaydk;
        }
    }
}
