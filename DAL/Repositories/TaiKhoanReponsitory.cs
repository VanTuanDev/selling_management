using DAL.Repositories;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        public void ThemTaiKhoan(string tenDangNhap, string tenDayDu, string matKhau, string maQuyen)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@TenDayDu", tenDayDu),
                new SqlParameter("@MatKhau", matKhau),
                new SqlParameter("@MaQuyen", maQuyen)
            };
            database.ExecuteNonQuery("sp_ThemTaiKhoan", parameters);
        }

        public void CapNhatTaiKhoan(string tenDangNhap, string tenDayDu, string tenQuyen)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@TenDayDu", tenDayDu),
                new SqlParameter("@TenQuyen", tenQuyen)
            };
            database.ExecuteNonQuery("sp_SuaTaiKhoan", parameters);
        }

        public bool XoaTaiKhoan(string tenDangNhap)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaTaiKhoan", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }
        public string DangNhap(string username, string password)
        {
            string role = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "sp_DangNhap";
                    sqlCommand.Connection = connection;

                    sqlCommand.Parameters.AddWithValue("@username", username);
                    sqlCommand.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader["TenQuyen"].ToString();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return role;
        }
        public int ThayDoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThayDoiMatKhau";
                sqlCommand.Connection = connection;

                sqlCommand.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                sqlCommand.Parameters.AddWithValue("@MatKhauCu", matKhauCu);
                sqlCommand.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                object data = sqlCommand.ExecuteScalar();
                connection.Close();

                return Convert.ToInt32(data);
            }
        }

        public DataTable LayDuLieuNguoiDung()
        {
            string query = "SELECT MaQuyen, TenQuyen FROM QuyenDangNhap";
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                return dataTable;
            }
        }
    }
}
