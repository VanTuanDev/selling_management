using System.Data.SqlClient;
using System.Data;
using System;

namespace DAL.Reponsitories
{
    public class KhachHangReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public DataTable HienThiDanhSachKhachHang()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "sp_LayDanhSachKhachHang";
                    sqlCommand.Connection = connection;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void ThemKhachHang(string maKhachHang, string tenKhachHang)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "sp_ThemKhachHang";
                    sqlCommand.Connection = connection;

                    sqlCommand.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                    sqlCommand.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }       
        }
        public void CapNhatKhachHang(string makhachhang, string tenkhachhang)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_SuaKhachHang", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaKhachHang", makhachhang);
                    command.Parameters.AddWithValue("@TenKhachHang", tenkhachhang);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaKhachHang(string makhachhang)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_XoaKhachHang", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaKhachHang", makhachhang);
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
