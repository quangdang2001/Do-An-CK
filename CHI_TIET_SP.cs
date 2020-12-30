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
        public CHI_TIET_SP(SANPHAM SanPham, LOAI_SP MaLoai, string ThuongHieu)
        {
            this.SanPham = SanPham;
            this.MaLoai = MaLoai;
            this.ThuongHieu = ThuongHieu;
        }
    }
}
