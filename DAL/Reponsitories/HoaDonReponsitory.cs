using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Reponsitories
{
    public class HoaDonReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public DataTable HienThiDSHoaDon()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_LayDanhSachHoaDon", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        return data;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int TaoHoaDon(string maKhachHang, string tinhTrang)
        {
            int maHoaDon = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_TaoHoaDon", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                    maHoaDon = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tạo hóa đơn: " + ex.Message);
                }
            }

            return maHoaDon;
        }

        public void TaoChiTietHoaDon(int maHoaDon, string maSanPham, int soLuongDat, decimal thanhTien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_TaoChiTietHoaDon", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    command.Parameters.AddWithValue("@SoLuongDat", soLuongDat);
                    command.Parameters.AddWithValue("@ThanhTien", thanhTien);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tạo chi tiết hóa đơn: " + ex.Message);
                }
            }
        }
        public string LayMaKhachHangTuTen(string tenKhachHang)
        {
            string maKhachHang = "";

            string query = "SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @TenKhachHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                try
                {
                    connection.Open();
                    maKhachHang = (string)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return maKhachHang;
        }
        public string LayMaSanPhamTuTen(string tenSanPham)
        {
            string maSanPham = "";

            string query = "SELECT MaSanPham FROM SanPham WHERE TenSanPham = @TenSanPham";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenSanPham", tenSanPham);

                try
                {
                    connection.Open();
                    maSanPham = (string)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return maSanPham;
        }
        public void CapNhatTrangThaiHoaDon(int maHoaDon, string tinhTrangMoi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("sp_CapNhatTrangThaiHoaDon", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    command.Parameters.AddWithValue("@TinhTrang", tinhTrangMoi);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_LayChiTietHoaDon", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
    }
}
