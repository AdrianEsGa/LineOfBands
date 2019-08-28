using System;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{

    public static class OperationRepository
    {
        public static Operation GetByCode(int code)
        {
            const string strSql = "SELECT Id, Code, OperationTypeId, InitPart, LoadMold, StationId, StationTypeOperationId FROM Operations WHERE Code = @Code";
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
                            if (!reader.HasRows)
                            {
                                Logger.Insert(LoggerType.Warning, Assembly.GetExecutingAssembly().GetName().Name,
                                    "StationRepository.GetByCode()", "Station (" + code + ") not found!");
                                return operation;
                            }

                            while (reader.Read())
                            {
                                operation.Id = Convert.ToInt32(reader["Id"]);
                                operation.Code = Convert.ToInt32(reader["Code"]);
                                operation.Type = (OperationType)Convert.ToInt16(reader["OperationTypeId"]);
                                operation.InitPart = (bool) reader["InitPart"];
                                operation.LoadMold = (bool)reader["LoadMold"];
                                operation.Station = StationRepository.GetById(Convert.ToInt16(reader["StationId"]));
                                operation.StationTypeOperation = new StationTypeOperation();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "OperationRepository.GetByCode()", ex.Message);
            }

            return operation;
        }

        public static Operation GetById(int id)
        {
            const string strSql = "SELECT Id, Code, OperationTypeId, InitPart, LoadMold, StationId, StationTypeOperationId FROM Operations WHERE Id = @Id";
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
                            operation.LoadMold = (bool)reader["LoadMold"];
                            operation.Station = StationRepository.GetById(Convert.ToInt16(reader["StationId"]));
                            operation.StationTypeOperation = new StationTypeOperation();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
