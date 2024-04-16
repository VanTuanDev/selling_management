using DAL.Reponsitories;
using System.Collections.Generic;
using System.Data;
using DAL.Entity;

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
        public void ThemSanPham(SanPhamEntity sanPham, out string errorMessage)
        {
            Process.ThemSanPham(sanPham, out errorMessage);
        }
        public void SuaSanPham(SanPhamEntity sanPham)
        {
            Process.SuaSanPham(sanPham);
        }
        public bool XoaSanPham(SanPhamEntity sanPham)
        {
            return Process.XoaSanPham(sanPham);
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
