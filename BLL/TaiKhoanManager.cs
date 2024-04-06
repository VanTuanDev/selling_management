using DAL.Reponsitories;
using System.Data;
using System;

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
        public void ThemTaiKhoan(string tenDangNhap, string tenDayDu, string matKhau, string maQuyen)
        {
            Process.ThemTaiKhoan(tenDangNhap, tenDayDu, matKhau, maQuyen);
        }
        public void CapNhatTaiKhoan(string tenDangNhap, string tenDayDu, string tenQuyen)
        {
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(tenDayDu) || string.IsNullOrEmpty(tenQuyen))
            {
                throw new Exception("Vui lòng nhập đầy đủ thông tin.");
            }

            try
            {
                Process.CapNhatTaiKhoan(tenDangNhap, tenDayDu, tenQuyen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool XoaTaiKhoan(string tendangnhap)
        {
            return Process.XoaTaiKhoan(tendangnhap);
        }
        public string DangNhap(string username, string password)
        {
            return Process.DangNhap(username, password);
        }
        public string ThayDoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi, string matKhauXacNhan)
        {

            if (String.IsNullOrEmpty(tenDangNhap) || String.IsNullOrEmpty(matKhauCu) || String.IsNullOrEmpty(matKhauMoi) || String.IsNullOrEmpty(matKhauXacNhan))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }

            if (matKhauCu == matKhauMoi)
            {
                return "Vui lòng nhập mật khẩu mới khác mật khẩu cũ!";
            }

            if (matKhauMoi != matKhauXacNhan)
            {
                return "Mật khẩu mới và mật khẩu xác nhận khác nhau. Vui lòng kiểm tra lại!";
            }

            int result = Process.ThayDoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi);

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
