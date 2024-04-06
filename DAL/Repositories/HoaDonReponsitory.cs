using System;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;

namespace DAL.Reponsitories
{
    public class HoaDonReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private Database database = new Database();
        public DataTable HienThiDSHoaDon()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachHoaDon", parameters);
        }
        public int TaoHoaDon(string maKhachHang, string tinhTrang)
        {
            //int maHoaDon = -1;

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();

            //        SqlCommand command = new SqlCommand("sp_TaoHoaDon", connection);
            //        command.CommandType = CommandType.StoredProcedure;

            //        command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
            //        command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

            //        maHoaDon = Convert.ToInt32(command.ExecuteScalar());
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Lỗi khi tạo hóa đơn: " + ex.Message);
            //    }
            //}

            //return maHoaDon;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", maKhachHang),
                new SqlParameter("@TinhTrang", tinhTrang)
            };

            return Convert.ToInt32(database.ExecuteScalar("sp_TaoHoaDon", parameters));
        }

        public void TaoChiTietHoaDon(int maHoaDon, string maSanPham, int soLuongDat, decimal thanhTien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaHoaDon", maHoaDon),
                    new SqlParameter("@MaSanPham", maSanPham),
                    new SqlParameter("@SoLuongDat", soLuongDat),
                    new SqlParameter("@ThanhTien", thanhTien)
                };

                database.ExecuteNonQuery("sp_TaoChiTietHoaDon", parameters);
            }
        }
        public string LayMaKhachHangTuTen(string tenKhachHang)
        {
            //string maKhachHang = "";

            //string query = "SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

            //    try
            //    {
            //        connection.Open();
            //        maKhachHang = (string)command.ExecuteScalar();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}

            //return maKhachHang;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenKhachHang", tenKhachHang)
            };

            return database.ExecuteScalar("SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang", parameters).ToString();
        }
        public string LayMaSanPhamTuTen(string tenSanPham)
        {
            //string maSanPham = "";

            //string query = "SELECT MaSanPham FROM SanPham WHERE TenSanPham = @TenSanPham";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@TenSanPham", tenSanPham);

            //    try
            //    {
            //        connection.Open();
            //        maSanPham = (string)command.ExecuteScalar();
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}

            //return maSanPham;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenSanPham", tenSanPham)
            };

            return database.ExecuteScalar("SELECT MaSanPham FROM SanPham WHERE TenSanPham = @TenSanPham", parameters).ToString();
        }
        public void CapNhatTrangThaiHoaDon(int maHoaDon, string tinhTrangMoi)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", maHoaDon),
                new SqlParameter("@TinhTrang", tinhTrangMoi)
            };

            database.ExecuteNonQuery("sp_CapNhatTrangThaiHoaDon", parameters);
        }
        public DataTable LayThongTinHoaDon(int maHoaDon)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("sp_LayTenKhachHang", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }
        public DataTable LayChiTietHoaDon(int maHoaDon)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", maHoaDon)
            };

            return database.ExecuteQuery("sp_LayTenKhachHang", parameters);
        }
    }
}
