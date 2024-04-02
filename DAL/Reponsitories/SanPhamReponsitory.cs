using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

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
        public DataTable LayDanhMuc()
        {
            DataTable categories = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DanhMucSanPham";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(categories);
            }

            return categories;
        }
        public DataTable LayDVT()
        {
            DataTable units = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DonViTinh";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(units);
            }

            return units;
        }
        public List<string> LayTenDanhMuc()
        {
            List<string> categoryNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenDanhMuc FROM DanhMucSanPham";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = reader["TenDanhMuc"].ToString();
                    categoryNames.Add(categoryName);
                }

                reader.Close();
            }

            return categoryNames;
        }
        public List<string> LayTenDVT()
        {
            List<string> unitNames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenDVT FROM DonViTinh";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string categoryName = reader["TenDVT"].ToString();
                    unitNames.Add(categoryName);
                }

                reader.Close();
            }

            return unitNames;
        }
    }
}
