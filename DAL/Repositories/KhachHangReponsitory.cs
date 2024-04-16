using System.Data.SqlClient;
using System.Data;
using System;
using DAL.Repositories;
using DAL.Entity;
using System.Collections.Generic;

namespace DAL.Reponsitories
{
    public class KhachHangReponsitory
    {
        private Database database = new Database();

        public DataTable HienThiDanhSachKhachHang()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachKhachHang", parameters);
        }
        
        public void ThemKhachHang(KhachHangEntity khachHang, out string errorMessage)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", khachHang.MaKhachHang),
                new SqlParameter("@TenKhachHang", khachHang.TenKhachHang)
            };
            database.ExecuteNonQuery("sp_ThemKhachHang", parameters, out errorMessage);    
        }
        public void CapNhatKhachHang(KhachHangEntity khachHang)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", khachHang.MaKhachHang),
                new SqlParameter("@TenKhachHang", khachHang.TenKhachHang)
            };
            database.ExecuteNonQuery("sp_SuaKhachHang", parameters);
        }
        public bool XoaKhachHang(KhachHangEntity khachHang)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", khachHang.MaKhachHang),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaKhachHang", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }
        public List<string> LayTenKhachHang()
        {
            string query = "SELECT TenKhachHang FROM KhachHang";
            List<string> customerNames = database.ExecuteReader(query, "TenKhachHang");

            return customerNames;
        }
    }
}
