using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Reponsitories
{
    public class SanPhamReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public DataTable HienThiDanhSachSanPham()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_LayDanhSachSanPham", connection);
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
        public DataTable HienThiDanhSachSanPhamBanHang()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_LayDanhSachSanPhamBanHang", connection);
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
        public void ThemSanPham(string maSanPham, string tenSanPham, string maDonViTinh, string maDanhMuc, string donGia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_ThemSanPham", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    command.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                    command.Parameters.AddWithValue("@MaDVT", maDonViTinh);
                    command.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                    command.Parameters.AddWithValue("@DonGia", donGia);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SuaSanPham(string maSanPham, string tenSanPham, string tenDVT, string tenDanhMuc, decimal donGia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_SuaSanPham", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                command.Parameters.AddWithValue("@TenSanPham", tenSanPham);
                command.Parameters.AddWithValue("@TenDVT", tenDVT);
                command.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);
                command.Parameters.AddWithValue("@DonGia", donGia);

                command.ExecuteNonQuery();
            }
        }
        public void XoaSanPham(string maSanPham)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("sp_XoaSanPham", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                command.ExecuteNonQuery();
            }
        }
    }
}
