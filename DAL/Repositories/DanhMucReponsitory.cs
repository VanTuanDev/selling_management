using System;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;

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
        public void ThemDanhMuc(string maDanhMuc, string tenDanhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDanhMuc", maDanhMuc),
                new SqlParameter("@TenDanhMuc", tenDanhMuc)
            };
            database.ExecuteNonQuery("sp_ThemDanhMuc", parameters);
        }
        public void CapNhatDanhMuc(string maDanhMuc, string tenDanhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDanhMuc", maDanhMuc),
                new SqlParameter("@TenDanhMuc", tenDanhMuc)
            };
            database.ExecuteNonQuery("sp_SuaDanhMuc", parameters);
        }
        public bool XoaDanhMuc(string maDanhMuc)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaDanhMuc", maDanhMuc),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaDanhMuc", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }
    }
}