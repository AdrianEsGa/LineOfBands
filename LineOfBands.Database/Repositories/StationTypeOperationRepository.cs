using System;
using System.Data.SqlClient;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{

    internal static class StationTypeOperationRepository
    {

        public static StationTypeOperation GetById(int id)
        {
            const string strSql = "SELECT Id, Name FROM StationTypeOperations WHERE Id = @Id";
            var stationTypeOperation = new StationTypeOperation();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                stationTypeOperation.Id = Convert.ToInt32(reader["Id"]);
                                stationTypeOperation.Name = reader["Name"].ToString();
                            }
                        }
                    }
                }

                return stationTypeOperation;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }  
    }
}
