using DAL.Reponsitories;
using System.Data;

namespace BLL
{
    public class HoaDonManager
    {
        private HoaDonReponsitory Process;
        public HoaDonManager()
        {
            Process = new HoaDonReponsitory();
        }
        public System.Data.DataTable HienThiDSHoaDon()
        {
            return Process.HienThiDSHoaDon();
        }
        public int TaoHoaDon(string maKhachHang, string tinhTrang)
        {
            return Process.TaoHoaDon(maKhachHang, tinhTrang);
        }
        public void TaoChiTietHoaDon(int maHoaDon, string maSanPham, int soLuongDat, decimal thanhTien)
        {
            Process.TaoChiTietHoaDon(maHoaDon, maSanPham, soLuongDat, thanhTien);
        }
        public string LayMaKhachHangTuTen(string tenKhachHang)
        {
            return Process.LayMaKhachHangTuTen(tenKhachHang);
        }
        public string LayMaSanPhamTuTen(string tenSanPham)
        {
            return Process.LayMaSanPhamTuTen(tenSanPham);
        }
        public void CapNhatTrangThaiHoaDon(int maHoaDon, string tinhTrangMoi)
        {
            Process.CapNhatTrangThaiHoaDon(maHoaDon, tinhTrangMoi);
        }
        public DataTable LayThongTinHoaDon(int maHoaDon)
        {
            return Process.LayThongTinHoaDon(maHoaDon);
        }
        public DataTable LayChiTietHoaDon(int maHoaDon)
        {
            return Process.LayChiTietHoaDon(maHoaDon);
        }
    }
}
