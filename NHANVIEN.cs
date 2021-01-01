using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    public class NHANVIEN
    {
        public string MaNV { get; set; }
        public SHOP Shop { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string NgayLamViec { get; set; }
        public NHANVIEN NguoiQL { get; set; }
        public LOAI_SP Loai_sp { get; set; }

        public NHANVIEN (string MaNV, SHOP Shop, string TenNV, string GioiTinh, string DiaChi, string sdt, string email, string NgayLamViec
            , NHANVIEN NguoiQL, LOAI_SP Loai_sp)
        {
            this.MaNV = MaNV;
            this.Shop = Shop;
            this.TenNV = TenNV;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.sdt = sdt;
            this.email = email;
            this.NgayLamViec = NgayLamViec;
            this.NguoiQL = NguoiQL;
            this.Loai_sp = Loai_sp;
        }
    }
}
