using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    public class CHI_TIET_SP
    {
        public SANPHAM SanPham { get; set; }
        public LOAI_SP MaLoai { get; set; }
        public string ThuongHieu { get; set; }
        public string NoiSanXuat { get; set; }
        public string Mau { get; set; }
        public NHACUNGCAP NhaCungCap { get; set; }

        public CHI_TIET_SP(SANPHAM SanPham, LOAI_SP MaLoai, string ThuongHieu,string NoiSanXuat, string Mau
            , NHANVIEN NhanVienQL, NHACUNGCAP NhaCungCap)
        {
            this.SanPham = SanPham;
            this.MaLoai = MaLoai;
            this.ThuongHieu = ThuongHieu;
            this.NoiSanXuat = NoiSanXuat;
            this.Mau = Mau;
            this.NhaCungCap = NhaCungCap;
        }
    }
}
