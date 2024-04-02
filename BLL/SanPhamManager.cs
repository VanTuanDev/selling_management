using DAL.Reponsitories;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class SanPhamManager
    {
        private SanPhamReponsitory Process = null;
        public SanPhamManager()
        {
            Process = new SanPhamReponsitory();
        }
        public System.Data.DataTable HienThiDanhSachSanPham()
        {
            return Process.HienThiDanhSachSanPham();
        }
        public System.Data.DataTable HienThiDanhSachSanPhamBanHang()
        {
            return Process.HienThiDanhSachSanPhamBanHang();
        }
        public void ThemSanPham(string tenDangNhap, string tenDayDu, string matKhau, string maQuyen, string donGia)
        {
            Process.ThemSanPham(tenDangNhap, tenDayDu, matKhau, maQuyen, donGia);
        }
        public void SuaSanPham(string maSanPham, string tenSanPham, string tenDVT, string tenDanhMuc, decimal donGia)
        {
            Process.SuaSanPham(maSanPham, tenSanPham, tenDVT, tenDanhMuc, donGia);
        }
        public void XoaSanPham(string maSanPham)
        {
            Process.XoaSanPham(maSanPham);
        }
        public DataTable LayDanhMuc()
        {
            return Process.LayDanhMuc();
        }
        public DataTable LayDVT()
        {
            return Process.LayDVT();
        }
        public List<string> LayTenDanhMuc()
        {
            return Process.LayTenDanhMuc();
        }
        public List<string> LayTenDVT()
        {
            return Process.LayTenDVT();
        }
    }
}
