using System;
using System.Data.SqlClient;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{

    public static class OperationRepository
    {
        public static Operation GetByCode(int code)
        {
            const string strSql = "SELECT Id, Code, OperationTypeId, InitPart, EndPart, LoadMold, StationId, StationTypeOperationId FROM Operations WHERE Code = @Code";
            var operation = new Operation();

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
                                operation.Id = Convert.ToInt32(reader["Id"]);
                                operation.Code = Convert.ToInt32(reader["Code"]);
                                operation.Type = (OperationType)Convert.ToInt16(reader["OperationTypeId"]);
                                operation.InitPart = (bool) reader["InitPart"];
                                operation.EndPart = (bool)reader["EndPart"];
                                operation.LoadMold = (bool)reader["LoadMold"];
                                operation.Station = StationRepository.GetById(Convert.ToInt16(reader["StationId"]));
                                operation.StationTypeOperation = StationTypeOperationRepository.GetById(Convert.ToInt16(reader["StationTypeOperationId"]));
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

            return operation;
        }

        public static Operation GetById(int id)
        {
            const string strSql = "SELECT Id, Code, OperationTypeId, InitPart, EndPart, LoadMold, StationId, StationTypeOperationId FROM Operations WHERE Id = @Id";
            var operation = new Operation();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                using (var command = new SqlCommand(strSql, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            operation.Id = Convert.ToInt32(reader["Id"]);
                            operation.Code = Convert.ToInt32(reader["Code"]);
                            operation.Type = (OperationType)Convert.ToInt16(reader["OperationTypeId"]);
                            operation.InitPart = (bool)reader["InitPart"];
                            operation.EndPart = (bool)reader["EndPart"];
                            operation.LoadMold = (bool)reader["LoadMold"];
                            operation.Station = StationRepository.GetById(Convert.ToInt16(reader["StationId"]));
                            operation.StationTypeOperation = StationTypeOperationRepository.GetById(Convert.ToInt16(reader["StationTypeOperationId"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }

            return operation;
        }

        public static void SaveOrUpdate(Operation pallet)
        {

        }

        public static void Remove(Operation pallet)
        {

        }
    }
}
