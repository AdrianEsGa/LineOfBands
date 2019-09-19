using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{

    internal static class StationTypeRepository
    {

        public static StationType GetById(int id)
        {
            const string strSql = "SELECT Id, Name FROM StationTypes WHERE Id = @Id";
            var stationType = new StationType();

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
                                stationType.Id = Convert.ToInt32(reader["Id"]);
                                stationType.Name = reader["Name"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
              
            }

            return stationType;
        }

        internal static List<StationType> GetAll()
        {

            const string strSql = "SELECT Id, Name FROM StationTypes";
            var stationTypes = new List<StationType>();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                           
                            while (reader.Read())
                            {
                                var stationType = new StationType()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),                                 
                                    Name = reader["Name"].ToString()
                                };

                                stationTypes.Add(stationType);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return stationTypes;
        }

       
    }
}
