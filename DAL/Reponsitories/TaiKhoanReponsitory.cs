using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL.Reponsitories
{
    public class TaiKhoanReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public DataTable HienThiDanhSachTaiKhoan()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_LayDanhSachTaiKhoan", connection);
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
        public void ThemTaiKhoan(string tenDangNhap, string tenDayDu, string matKhau, string maQuyen)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_ThemTaiKhoan", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@TenDayDu", tenDayDu);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    command.Parameters.AddWithValue("@MaQuyen", maQuyen);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CapNhatTaiKhoan(string tenDangNhap, string tenDayDu, string tenQuyen)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_SuaTaiKhoan", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    command.Parameters.AddWithValue("@TenDayDu", tenDayDu);
                    command.Parameters.AddWithValue("@TenQuyen", tenQuyen);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaTaiKhoan(string tendangnhap)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_XoaTaiKhoan", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TenDangNhap", tendangnhap);           
                    int rowsAffected = int.Parse(command.ExecuteScalar().ToString());

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
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
