using System;
using System.Data;
using System.Data.SqlClient;

namespace LineOfBands.Common
{
    public static class SqlServer
    {
        public static string ConnectionString;

        public static SqlConnection OpenConnection()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new Exception("Connection string is not defined");

            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open) return;
            connection.Close();
            connection.Dispose();
        }

        public static SqlTransaction BeginTransaction(SqlConnection connection)
        {
            var transaction = connection.BeginTransaction();
            return transaction;
        }

    }
}
