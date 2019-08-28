using System.Data.SqlClient;

namespace LineOfBands.Common
{
    public static class Logger
    {
        public static void Insert(LoggerType type, string nameSpace, string method, string message)
        {
            var strSql = "INSERT INTO AppLogger (Type, Namespace, Method, Message)";
            strSql += "   VALUES (@Type, @Namespace, @Method, @Message)";

            using (var connection = SqlServer.OpenConnection())
            {
                using (var command = new SqlCommand(strSql, connection))
                {
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Namespace", nameSpace);
                    command.Parameters.AddWithValue("@Method", method);
                    command.Parameters.AddWithValue("@Message", message);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public enum LoggerType
    {
        Information = 1,
        Warning = 2,
        Error = 3
    }
}