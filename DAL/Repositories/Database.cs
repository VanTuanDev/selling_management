using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DAL.Repositories
{
    public class Database
    {
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";

        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            SqlConnection connection = null;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
            }
        }
        public DataTable ExecuteQuery(string storedProcedureName, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;
                    command.Connection = connection;

                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
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

        public void ExecuteNonQuery(string storedProcedureName, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedureName;
                    command.Connection = connection;

                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<string> ExecuteReader(string query, string columnName)
        {
            List<string> values = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string value = reader[columnName].ToString();
                    values.Add(value);
                }

                reader.Close();
            }

            return values;
        }
        public SqlDataReader ExecuteReader(string connectionString, string storedProcedureName, SqlParameter[] parameters)
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedureName;
                command.Connection = connection;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                connection?.Close();
                return null;
            }
        }
        public string ExecuteScalarStoredProcedure(string storedProcedureName, SqlParameter[] parameters)
        {
            string result = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);

                    object scalarResult = command.ExecuteScalar();
                    if (scalarResult != null)
                    {
                        result = scalarResult.ToString();
                    }
                }
            }

            return result;
        }
    }
}