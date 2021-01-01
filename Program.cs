using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline
{
    class Program
    {
        public static List<KHACHHANG> dskh = new List<KHACHHANG>();
        public static List<NHANVIEN> dsnv = new List<NHANVIEN>();
        public static List<SHOP> dsShop = new List<SHOP>();
        public static List<BOPHAN_GIAOHANG> dsbpgiaohang = new List<BOPHAN_GIAOHANG>();
        public static List<CHI_TIET_SP> dschitietsp = new List<CHI_TIET_SP>();
        public static List<GIOHANG> dsgiohang = new List<GIOHANG>();
        public static List<HOADON> dshoadon = new List<HOADON>();
        public static List<LICHSU_MUAHANG> dslsmuahang = new List<LICHSU_MUAHANG>();
        public static List<LOAI_SP> dsloaisp = new List<LOAI_SP>();
        public static List<NHACUNGCAP> dsnhacungcap = new List<NHACUNGCAP>();
        public static List<SANPHAM> dssanpham = new List<SANPHAM>();
        public static List<TAIKHOAN> dstaikhoan = new List<TAIKHOAN>();
        public static List<CHITIET_GIOHANG> dschitietgiohang = new List<CHITIET_GIOHANG>();

        public static void TaoHoaDon()
        {
        }
        public static void TaoGioHang()
        {
        }
        public static void TaoCHITIET_GIOHANG()
        {
        }
        public static void TaoDSKH()
        {
            dskh.Add(new KHACHHANG("kh001", "QuangPro", "Nam", "America", "0999999999", "quangdang2001@gmail.com", "22/11/2001"));
            dskh.Add(new KHACHHANG("kh002", "QuangPro1", "Nam1", "MyTho", "0999999998", "quangdang2001@gmail.com", "22/11/2001"));
            dskh.Add(new KHACHHANG("kh003", "QuangPro2", "Nam", "America", "0999999997", "quangdang2001@gmail.com", "22/11/2001"));
            dskh.Add(new KHACHHANG("kh004", "QuangPro3", "Nam1", "HaNoi", "0999999996", "quangdang2001@gmail.com", "22/11/2001"));
            dskh.Add(new KHACHHANG("kh005", "QuangPro4", "Nam", "HCM", "0999999995", "quangdang2001@gmail.com", "22/11/2001"));
            dskh.Add(new KHACHHANG("kh006", "QuangPro5", "Nam1", "America", "0999999994", "quangdang2001@gmail.com", "22/11/2001"));
        }
        public static void TaoDSSHOP()
        {
            dsShop.Add(new SHOP("s01", "ShopChicken", "HCM"));
            dsShop.Add(new SHOP("s02", "ShopChicken1", "HCMm"));
            dsShop.Add(new SHOP("s03", "ShopChicken2", "HCMmm"));
            dsShop.Add(new SHOP("s04", "ShopChicken3", "HCMmmm"));
            dsShop.Add(new SHOP("s05", "ShopChicken4", "HCMmmmm"));

        }
        public static void TaoDSNV()
        {
            dsnv.Add(new NHANVIEN("nv01", dsShop[0], "Fuck Ngu", "Be De", "My Tho", "01010101", "qeqeqe", "1111",null,null ));
            dsnv.Add(new NHANVIEN("nv02", dsShop[2], "Fuck Nguuuu", "Be De", "My Tho", "01010101", "qeqeqe", "1111",dsnv[0],null));

        }
        public static void TinhTongTien()
        {
            int length = dshoadon.Count();
            for (int i=0;i<length;i++)
            {
                double sotien = 0;
                for(int k=0;k<dschitietgiohang.Count(); k++)
                    if (dshoadon[i].GioHang==dschitietgiohang[k].GioHang)
                    {
                        sotien += dschitietgiohang[k].SoLuong * dschitietgiohang[k].SanPham.DonGiaSP;
                    }
                dshoadon[i].TongTien = sotien;
            }
        }
        static void Main(string[] args)
        {        
            TaoDSKH();
            TaoDSSHOP();
            TaoDSNV();

            //var nhanvien = dsnv.Select(n => n.TenNV);
            //foreach (var i in nhanvien)
            //    Console.WriteLine(i);
            //var khachhang = dskh.Where(n => n.DiaChi == "America");
            //foreach(var i in khachhang)
            //{
            //    Console.WriteLine(i.TenKH);
            //}
            //var nv = dsnv.Where(n =>  n.MaNQL.MaNV !=null );
            //foreach (var i in nv)
            //{
            //    Console.WriteLine(i.Shop.TenShop);
            //}
            // Tim ten shop cua nhan vien co ma NQL nv01                               
            var nhanvien =
                from nv in dsnv
                where nv.NguoiQL != null && nv.NguoiQL.MaNV=="nv01"
                select nv.TenNV;
            foreach (var i in nhanvien)
                Console.WriteLine(i);
                
            Console.ReadKey();
        }
    }
}
