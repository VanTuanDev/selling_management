using System;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;
using DAL.Entity;

namespace DAL.Reponsitories
{
    public class HoaDonReponsitory
    {
        private Database database = new Database();
        public DataTable HienThiDSHoaDon()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachHoaDon", parameters);
        }
        public int TaoHoaDon(HoaDonEntity hoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[3]
            {
                new SqlParameter("@MaKhachHang", hoaDon.MaKhachHang),
                new SqlParameter("@TinhTrang", hoaDon.TinhTrang),
                new SqlParameter("@MaHoaDon", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_TaoHoaDon", parameters);

            int maHoaDon = Convert.ToInt32(parameters[2].Value);
            return maHoaDon;
        }

        public void TaoChiTietHoaDon(CTHDEntity chiTietHoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", chiTietHoaDon.MaHoaDon),
                new SqlParameter("@MaSanPham", chiTietHoaDon.MaSanPham),
                new SqlParameter("@SoLuongDat", chiTietHoaDon.SoLuongDat),
                new SqlParameter("@ThanhTien", chiTietHoaDon.ThanhTien)
            };

            database.ExecuteNonQuery("sp_TaoChiTietHoaDon", parameters);
        }
        public string LayMaSanPhamTuTen(SanPhamEntity sanPham)
        {
            string maSanPham = null;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenSanPham", sanPham.TenSanPham)
            };

            maSanPham = database.ExecuteScalarStoredProcedure("sp_LayMaSanPham", parameters);

            return maSanPham;
        }
        public void CapNhatTrangThaiHoaDon(HoaDonEntity hoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", hoaDon.MaHoaDon),
                new SqlParameter("@TinhTrang", hoaDon.TinhTrang)
            };

            database.ExecuteNonQuery("sp_CapNhatTrangThaiHoaDon", parameters);
        }
        public DataTable LayThongTinHoaDon(HoaDonEntity hoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", hoaDon.MaHoaDon)
            };

            return database.ExecuteQuery("sp_LayTenKhachHang", parameters);
        }
        public DataTable LayChiTietHoaDon(CTHDEntity chiTietHoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", chiTietHoaDon.MaHoaDon)
            };

            return database.ExecuteQuery("sp_LayChiTietHoaDon", parameters);
        }
    }
}
