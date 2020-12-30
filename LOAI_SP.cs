using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    public class LOAI_SP
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public NHANVIEN NhanVienQL { get; set; }
        public LOAI_SP(string MaLoai, string TenLoai,NHANVIEN NhanVienQL)
        {
            this.MaLoai = MaLoai;
            this.TenLoai = TenLoai;
            this.NhanVienQL = NhanVienQL;
        }
    }
}
