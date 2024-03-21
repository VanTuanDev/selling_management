using DAL.Reponsitories;
using System;
using System.Data;

namespace BLL
{
    public class KhachHangManager
    {
        private KhachHangReponsitory Process;

        public KhachHangManager()
        {
            Process = new KhachHangReponsitory();
        }

        public DataTable HienThiDanhSachKhachHang()
        {
            return Process.HienThiDanhSachKhachHang();
        }
        public void ThemKhachHang(string maKhachHang, string tenKhachHang)
        {
            Process.ThemKhachHang(maKhachHang, tenKhachHang);
        }
        public void CapNhatKhachHang(string makhachhang, string tenkhachhang)
        {
            if (string.IsNullOrEmpty(makhachhang) || string.IsNullOrEmpty(tenkhachhang))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin.");
            }

            try
            {
                Process.CapNhatKhachHang(makhachhang, tenkhachhang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaKhachHang(string makhachhang)
        {
            if (string.IsNullOrEmpty(makhachhang) == true)
            {
                return false;
            }
            return Process.XoaKhachHang(makhachhang);
        }
        public string[] LayTenKhachHang()
        {
            return Process.LayTenKhachHang("TenKhachHang", "KhachHang");
        }

    }
}
