using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using DAL.Repositories;

namespace DAL.Reponsitories
{
    public class SanPhamReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private Database database = new Database();
        public DataTable HienThiDanhSachSanPham()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachSanPham", parameters);
        }

        public DataTable HienThiDanhSachSanPhamBanHang()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachSanPhamBanHang", parameters);
        }

        public void ThemSanPham(string maSanPham, string tenSanPham, string maDonViTinh, string maDanhMuc, string donGia)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@MaDVT", maDonViTinh),
                new SqlParameter("@MaDanhMuc", maDanhMuc),
                new SqlParameter("@DonGia", donGia)
            };

            database.ExecuteNonQuery("sp_ThemSanPham", parameters);
        }

        public void SuaSanPham(string maSanPham, string tenSanPham, string tenDVT, string tenDanhMuc, decimal donGia)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@TenSanPham", tenSanPham),
                new SqlParameter("@TenDVT", tenDVT),
                new SqlParameter("@TenDanhMuc", tenDanhMuc),
                new SqlParameter("@DonGia", donGia)
            };

            database.ExecuteNonQuery("sp_SuaSanPham", parameters);
        }

        public bool XoaSanPham(string maSanPham)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", maSanPham),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaSanPham", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }

        public DataTable LayDanhMuc()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("SELECT * FROM DanhMucSanPham", parameters);
        }

        public DataTable LayDVT()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("SELECT * FROM DonViTinh", parameters);
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
