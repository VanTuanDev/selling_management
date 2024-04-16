using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using DAL.Repositories;
using DAL.Entity;

namespace DAL.Reponsitories
{
    public class SanPhamReponsitory
    {
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

        public void ThemSanPham(SanPhamEntity sanPham, out string errorMessage)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", sanPham.MaSanPham),
                new SqlParameter("@TenSanPham", sanPham.TenSanPham),
                new SqlParameter("@MaDVT", sanPham.MaDVT),
                new SqlParameter("@MaDanhMuc", sanPham.MaDanhMuc),
                new SqlParameter("@DonGia", sanPham.DonGia)
            };

            database.ExecuteNonQuery("sp_ThemSanPham", parameters, out errorMessage);
        }

        public void SuaSanPham(SanPhamEntity sanPham)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", sanPham.MaSanPham),
                new SqlParameter("@TenSanPham", sanPham.TenSanPham),
                new SqlParameter("@TenDVT", sanPham.MaDVT),
                new SqlParameter("@TenDanhMuc", sanPham.MaDanhMuc),
                new SqlParameter("@DonGia", sanPham.DonGia)
            };

            database.ExecuteNonQuery("sp_SuaSanPham", parameters);
        }

        public bool XoaSanPham(SanPhamEntity sanPham)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", sanPham.MaSanPham),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaSanPham", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }

        public DataTable LayDanhMuc()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhMuc", parameters);
        }

        public DataTable LayDVT()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDVT", parameters);
        }

        public List<string> LayTenDanhMuc()
        {
            string query = "SELECT TenDanhMuc FROM DanhMucSanPham WHERE TrangThai = N'Còn sử dụng'";
            List<string> categoryNames = database.ExecuteReader(query, "TenDanhMuc");

            return categoryNames;
        }

        public List<string> LayTenDVT()
        {
            string query = "SELECT TenDVT FROM DonViTinh";
            List<string> unitNames = database.ExecuteReader(query, "TenDVT");

            return unitNames;
        }
    }
}
