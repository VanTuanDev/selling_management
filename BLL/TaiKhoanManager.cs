using DAL.Reponsitories;
using System.Data;
using System;
using DAL.Entity;

namespace BLL
{
    public class TaiKhoanManager
    {
        private TaiKhoanReponsitory Process = null;
        public TaiKhoanManager()
        {
            Process = new TaiKhoanReponsitory();
        }

        public System.Data.DataTable HienThiDanhSachTaiKhoan()
        {
            return Process.HienThiDanhSachTaiKhoan();
        }
        public void ThemTaiKhoan(TaiKhoanEntity taiKhoan, out string errorMessage)
        {
            Process.ThemTaiKhoan(taiKhoan, out errorMessage);
        }
        public void CapNhatTaiKhoan(TaiKhoanEntity taiKhoan)
        {
            Process.CapNhatTaiKhoan(taiKhoan);
        }

        public bool XoaTaiKhoan(TaiKhoanEntity taiKhoan)
        {
            return Process.XoaTaiKhoan(taiKhoan);
        }
        public string DangNhap(TaiKhoanEntity taiKhoan)
        {
            return Process.DangNhap(taiKhoan);
        }
        public string ThayDoiMatKhau(TaiKhoanEntity taiKhoan)
        {
            int result = Process.ThayDoiMatKhau(taiKhoan);

            if (result != 0)
            {
                return "Bạn đã cập nhật mật khẩu thành công.";
            }
            else
            {
                return "Bạn đã nhập sai tài khoản hoặc mật khẩu. Vui lòng kiểm tra lại!";
            }
        }
        public DataTable LayDuLieuNguoiDung()
        {
            return Process.LayDuLieuNguoiDung();
        }
    }
}
