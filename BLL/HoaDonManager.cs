using DAL.Reponsitories;
using System.Data;
using DAL.Entity;

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
        public int TaoHoaDon(HoaDonEntity hoaDon)
        {
            return Process.TaoHoaDon(hoaDon);
        }
        public void TaoChiTietHoaDon(CTHDEntity chiTietHoaDon)
        {
            Process.TaoChiTietHoaDon(chiTietHoaDon);
        }
        public string LayMaSanPhamTuTen(SanPhamEntity sanPham)
        {
            return Process.LayMaSanPhamTuTen(sanPham);
        }
        public void CapNhatTrangThaiHoaDon(int maHoaDon, string tinhTrang)
        {
            HoaDonEntity hoaDon = new HoaDonEntity
            {
                MaHoaDon = maHoaDon,
                TinhTrang = tinhTrang
            };

            Process.CapNhatTrangThaiHoaDon(hoaDon);
        }
        public DataTable LayThongTinHoaDon(HoaDonEntity hoaDon)
        {
            return Process.LayThongTinHoaDon(hoaDon);
        }
        public DataTable LayChiTietHoaDon(CTHDEntity chiTietHoaDon)
        {
            return Process.LayChiTietHoaDon(chiTietHoaDon);
        }
    }
}
