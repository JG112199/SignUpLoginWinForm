using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUpLoginWinForm
{
    class DbAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public SqlTransaction DbTransaction;

        private static string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=WinFormsUsers;Trusted_Connection=True; TrustServerCertificate=True ";

        public void createConnection()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = ConnectionString;
                    connection.Open();
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void closeConnection()
        {
            connection.Close();
        }

        public int executeDataAdapter(DataTable dataTable, string strSelectSql)
        {
            try
            {
                if (connection.State == 0) createConnection();

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

                string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(dataTable);
            }
            catch (Exception ex) { throw ex; } 
        }

        public void readDataThroughAdapater(string query, DataTable dataTable)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) createConnection();

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch(Exception ex) { throw ex; }
        }

        public SqlDataReader readDataThroughReader(string query)
        {
            SqlDataReader reader;

            try
            {
                if (connection.State == ConnectionState.Closed) createConnection();

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex) { throw ex; }
        }

        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0) createConnection();

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;

                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
