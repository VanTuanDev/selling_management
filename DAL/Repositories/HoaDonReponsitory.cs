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
            string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_LayMaSanPham", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenSanPham", sanPham.TenSanPham);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maSanPham = reader["MaSanPham"].ToString();
                        }
                    }
                }
            }

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
