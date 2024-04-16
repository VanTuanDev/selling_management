using DAL.Reponsitories;
using System;
using System.Data;
using DAL.Entity;
using System.Collections.Generic;

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
        public void ThemKhachHang(KhachHangEntity khachHang, out string errorMessage)
        {
            Process.ThemKhachHang(khachHang, out errorMessage);
        }
        public void CapNhatKhachHang(KhachHangEntity khachHang)
        {
            Process.CapNhatKhachHang(khachHang);

        }
        public bool XoaKhachHang(KhachHangEntity khachHang)
        {
            return Process.XoaKhachHang(khachHang);
        }
        public List<string> LayTenKhachHang()
        {
            return Process.LayTenKhachHang();
        }
    }
}
