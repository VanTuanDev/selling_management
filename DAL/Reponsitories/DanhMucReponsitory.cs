using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Reponsitories
{
    public class DanhMucReponsitory
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public DataTable HienThiDanhSachDanhMuc()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "sp_LayDanhSachDanhMuc";
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
        public void ThemDanhMuc(string maDanhMuc, string tenDanhMuc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "sp_ThemDanhMuc";
                    sqlCommand.Connection = connection;

                    sqlCommand.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                    sqlCommand.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CapNhatDanhMuc(string maDanhMuc, string tenDanhMuc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_SuaDanhMuc", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                    command.Parameters.AddWithValue("@TenDanhMuc", tenDanhMuc);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool XoaDanhMuc(string maDanhMuc)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_XoaDanhMuc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
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
    }

}
