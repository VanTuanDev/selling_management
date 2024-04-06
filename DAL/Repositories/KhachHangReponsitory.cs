using System.Data.SqlClient;
using System.Data;
using System;
using DAL.Repositories;

namespace DAL.Reponsitories
{
    public class KhachHangReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        private Database database = new Database();

        public DataTable HienThiDanhSachKhachHang()
        {
            SqlParameter[] parameters = null;
            return database.ExecuteQuery("sp_LayDanhSachKhachHang", parameters);
        }
        public void ThemKhachHang(string maKhachHang, string tenKhachHang)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", maKhachHang),
                new SqlParameter("@TenKhachHang", tenKhachHang)
            };
            database.ExecuteNonQuery("sp_ThemKhachHang", parameters);    
        }
        public void CapNhatKhachHang(string makhachhang, string tenkhachhang)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", makhachhang),
                new SqlParameter("@TenKhachHang", tenkhachhang)
            };
            database.ExecuteNonQuery("sp_SuaKhachHang", parameters);
        }
        public bool XoaKhachHang(string makhachhang)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", makhachhang),
                new SqlParameter("@RowsAffected", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            database.ExecuteNonQuery("sp_XoaKhachHang", parameters);

            int rowsAffected = Convert.ToInt32(parameters[1].Value);
            return rowsAffected > 0;
        }
        public string[] LayTenKhachHang(string columnName, string tableName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string[] values = null;

            try
            {
                connection.Open();
                string query = $"SELECT {columnName} FROM {tableName}"; 
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                int rowCount = 0;
                while (reader.Read())
                {
                    rowCount++;
                }

                values = new string[rowCount];
                reader.Close();

                reader = command.ExecuteReader();
                int index = 0;
                while (reader.Read())
                {
                    values[index] = reader[columnName].ToString();
                    index++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return values;
        }
    }
}
