using System;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;
using DAL.Entity;

namespace DAL.Reponsitories
{
    public class DanhMucReponsitory
    {
        private Database database = new Database();
        public DataTable HienThiDanhSachDanhMuc()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachDanhMuc", parameters);
        }
        public void ThemDanhMuc(DanhMucEntity danhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDanhMuc", danhMuc.MaDanhMuc),
                new SqlParameter("@TenDanhMuc", danhMuc.TenDanhMuc)
            };
            database.ExecuteNonQuery("sp_ThemDanhMuc", parameters);
        }
        public void CapNhatDanhMuc(DanhMucEntity danhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDanhMuc", danhMuc.MaDanhMuc),
                new SqlParameter("@TenDanhMuc", danhMuc.TenDanhMuc)
            };
            database.ExecuteNonQuery("sp_SuaDanhMuc", parameters);
        }
        public bool XoaDanhMuc(DanhMucEntity danhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDanhMuc", danhMuc.MaDanhMuc),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaDanhMuc", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }
    }
}