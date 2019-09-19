using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;


namespace LineOfBands.Database.Repositories
{
    internal static class StationRepository
    {

        internal static Station GetById(int id)
        {
            const string strSql = "SELECT Id, Code, Name, StationTypeId, StatusDataChangeAddress, StatusDataChangeAddressAck, DataAddress FROM Stations WHERE Id = @Id";
            var station = new Station();

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
                                station.Id = Convert.ToInt32(reader["Id"]);
                                station.Code = Convert.ToInt32(reader["Code"]);
                                station.Name = reader["Name"].ToString();
                                station.Type = StationTypeRepository.GetById(Convert.ToInt32(reader["StationTypeId"]));
                                station.StatusDataChangeAddress = reader["StatusDataChangeAddress"].ToString();
                                station.StatusDataChangeAddressAck = reader["StatusDataChangeAddressAck"].ToString();
                                station.DataAddress = reader["DataAddress"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return station;
        }

        internal static Station GetByCode(int code)
        {
            const string strSql = "SELECT Id, Code, Name, StationTypeId, OpcStatusDataChangeAddress, OpcPalletCodeAddress, OpcOperationCodeAddress, OpcMoldCodeAddress, OpcAlarmCodeAddress, OpcResultCodeAddress FROM Stations WHERE Code = @Code";
            var station = new Station();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", code);

                        using (var reader = command.ExecuteReader())
                        {
              

                            while (reader.Read())
                            {
                                station.Id = Convert.ToInt32(reader["Id"]);
                                station.Code = Convert.ToInt32(reader["Code"]);
                                station.Name = reader["Name"].ToString();
                                station.StatusDataChangeAddress = reader["OpcStatusDataChangeAddress"].ToString();
                                station.Type = StationTypeRepository.GetById(Convert.ToInt32(reader["StationTypeId"]));

                           }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
             
            }

            return station;
        }

        internal static List<Station> GetAll()
        {

            const string strSql = "SELECT Id, Code, Name, StationTypeId, StatusDataChangeAddress, StatusDataChangeAddressAck, DataAddress FROM Stations";
            var stations = new List<Station>();

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
                                stations.Add(new Station()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),                               
                                    Name = reader["Name"].ToString(),
                                    Type = StationTypeRepository.GetById(Convert.ToInt32(reader["StationTypeId"])),
                                    StatusDataChangeAddress = reader["StatusDataChangeAddress"].ToString(),
                                    StatusDataChangeAddressAck = reader["StatusDataChangeAddressAck"].ToString(),
                                    DataAddress = reader["DataAddress"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return stations;
        }

        internal static Station SaveOrUpdate(Station station)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = station.Id == 0 ? "INSERT INTO Stations (Code, Name, StationTypeId) VALUES (@Code, @Name, @StationTypeId) SELECT Scope_Identity()"
                        : "UPDATE Stations SET Code = @Code, Name = @Name, StationTypeId = @StationTypeId WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", station.Code);
                        command.Parameters.AddWithValue("@Name", station.Name);
                        command.Parameters.AddWithValue("@StationTypeId", station.Type.Id);
                        command.Parameters.AddWithValue("@Id", station.Id);

                        if (station.Id == 0)
                            station.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return station;
        }

        internal static void Remove(Station station)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = "DELETE FROM Stations WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", station.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
