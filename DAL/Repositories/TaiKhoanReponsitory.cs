using DAL.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL.Entity;

namespace DAL.Reponsitories
{
    public class TaiKhoanReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private Database database = new Database();
        public DataTable HienThiDanhSachTaiKhoan()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachTaiKhoan", parameters);
        }
        public void ThemTaiKhoan(TaiKhoanEntity taiKhoan)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", taiKhoan.TenDangNhap),
                new SqlParameter("@TenDayDu", taiKhoan.TenDayDu),
                new SqlParameter("@MatKhau", taiKhoan.MatKhau),
                new SqlParameter("@MaQuyen", taiKhoan.MaQuyen)
            };
            database.ExecuteNonQuery("sp_ThemTaiKhoan", parameters);
        }

        public void CapNhatTaiKhoan(TaiKhoanEntity taiKhoan)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", taiKhoan.TenDangNhap),
                new SqlParameter("@TenDayDu", taiKhoan.TenDayDu),
                new SqlParameter("@TenQuyen", taiKhoan.MaQuyen)
            };
            database.ExecuteNonQuery("sp_SuaTaiKhoan", parameters);
        }

        public bool XoaTaiKhoan(TaiKhoanEntity taiKhoan)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", taiKhoan.TenDangNhap),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaTaiKhoan", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }
        public string DangNhap(TaiKhoanEntity taiKhoan)
        {
            string role = null;

            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@username", taiKhoan.TenDangNhap),
                    new SqlParameter("@password", taiKhoan.MatKhau)
                };

                using (SqlDataReader reader = database.ExecuteReader(connectionString, "sp_DangNhap", parameters))
                {
                    if (reader != null && reader.Read())
                    {
                        role = reader["TenQuyen"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return role;
        }
        public int ThayDoiMatKhau(TaiKhoanEntity taiKhoan)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@TenDangNhap", taiKhoan.TenDangNhap),
                    new SqlParameter("@MatKhauCu", taiKhoan.MatKhau),
                    new SqlParameter("@MatKhauMoi", taiKhoan.MatKhauMoi)
                };

                object data = database.ExecuteScalar("sp_ThayDoiMatKhau", parameters);

                if (data != null)
                {
                    return Convert.ToInt32(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return 0;
        }

        public DataTable LayDuLieuNguoiDung()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDuLieuNguoiDung", parameters);
        }
    }
}
