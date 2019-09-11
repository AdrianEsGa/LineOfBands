using LineOfBands.Common;
using LineOfBands.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;

namespace LineOfBands.Database.Repositories
{

    public static class OperationRegisterRepository
    {

        public static OperationRegister GetById(int id)
        {
            return new OperationRegister();
        }

        public static OperationRegister SaveOrUpdate(OperationRegister operationRegister)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = operationRegister.Id == 0 ? "INSERT INTO OperationRegisters (OperationInId, OperationOutId, PalletId, MoldId, PartId, InitDateTime, EndDateTime)" +
                        " VALUES (@OperationInId, @OperationOutId, @PalletId, @MoldId, @PartId, @InitDateTime, @EndDateTime) SELECT Scope_Identity() "
                        : "UPDATE OperationRegisters SET OperationInId=@OperationInId, OperationOutId=@OperationOutId, PalletId=@PalletId, MoldId=@PalletId, PartId=@PartId, InitDateTime=@InitDateTime, EndDateTime=@EndDateTime WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@OperationInId", operationRegister.OperationIn.Id);

                        if (operationRegister.OperationOut == null)
                            command.Parameters.AddWithValue("@OperationOutId", DBNull.Value);
                        else command.Parameters.AddWithValue("@OperationOutId", operationRegister.OperationOut.Id);

                        command.Parameters.AddWithValue("@PalletId", operationRegister.Pallet.Id);
                        command.Parameters.AddWithValue("@MoldId", operationRegister.Mold.Id);

                        if(operationRegister.Part == null)
                          command.Parameters.AddWithValue("@PartId", DBNull.Value);
                        else command.Parameters.AddWithValue("@PartId", operationRegister.Part.Id);

                        command.Parameters.AddWithValue("@InitDateTime", operationRegister.InitDateTime);

                        if(operationRegister.EndDateTime == default(DateTime))
                          command.Parameters.AddWithValue("@EndDateTime", DBNull.Value);
                        else command.Parameters.AddWithValue("@EndDateTime", operationRegister.EndDateTime);


                        command.Parameters.AddWithValue("@Id", operationRegister.Id);

                        if (operationRegister.Id == 0)
                            operationRegister.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();
                       
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "StationRepository.SaveOrUpdate()", ex.Message);
            }

            return operationRegister;

        }

        public static void Remove(OperationRegister operationRegister)
        {

        }

        public static OperationRegister GetActiveByPallet(Pallet pallet)
        {
            var operationRegister = new OperationRegister();
            try
            {
              
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = "SELECT Id, OperationInId, PalletId, MoldId, PartId, InitDateTime  FROM OperationRegisters WHERE PalletId=@PalletId AND EndDateTime IS NULL" ;

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@PalletId", pallet.Id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                operationRegister.Id = int.Parse(reader["Id"].ToString());
                                operationRegister.OperationIn = OperationRepository.GetById(int.Parse(reader["OperationInId"].ToString()));
                                operationRegister.Mold = MoldRepository.GetById(int.Parse(reader["MoldId"].ToString()));
                                operationRegister.Pallet = PalletRepository.GetById(int.Parse(reader["PalletId"].ToString()));

                                if (reader["PartId"] != DBNull.Value)
                                  operationRegister.Part = PartRepository.GetById(int.Parse(reader["PartId"].ToString()));

                                operationRegister.InitDateTime = (DateTime)reader["InitDateTime"];
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                //Introducir en el futuro codigo para NLog.
            }

            return operationRegister;

        }

        public static List<OperationRegister> GetActiveOperations()
        {
            var operationRegisters = new List<OperationRegister>();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    const string strSql = "SELECT Id, OperationInId, PalletId, MoldId, PartId, InitDateTime FROM OperationRegisters WHERE EndDateTime IS NULL";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var operationRegister = new OperationRegister
                                {
                                    Id = int.Parse(reader["Id"].ToString()),
                                    OperationIn =
                                        OperationRepository.GetById(int.Parse(reader["OperationInId"].ToString())),
                                    Mold = MoldRepository.GetById(int.Parse(reader["MoldId"].ToString())),
                                    Pallet = PalletRepository.GetById(int.Parse(reader["PalletId"].ToString()))
                                };

                                if (reader["PartId"] != DBNull.Value)
                                    operationRegister.Part = PartRepository.GetById(int.Parse(reader["PartId"].ToString()));

                                operationRegister.InitDateTime = (DateTime)reader["InitDateTime"];

                                operationRegisters.Add(operationRegister);
                            }
                        }
                    }
                }

                return operationRegisters;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }      
        }

        public static List<OperationRegister> GetLastOperations()
        {
            var operationRegisters = new List<OperationRegister>();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    const string strSql = "SELECT TOP 10 Id, OperationInId, PalletId, MoldId, PartId, InitDateTime FROM OperationRegisters WHERE EndDateTime IS NOT NULL  ORDER BY EndDateTime DESC";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var operationRegister = new OperationRegister
                                {
                                    Id = int.Parse(reader["Id"].ToString()),
                                    OperationIn =
                                        OperationRepository.GetById(int.Parse(reader["OperationInId"].ToString())),
                                    Mold = MoldRepository.GetById(int.Parse(reader["MoldId"].ToString())),
                                    Pallet = PalletRepository.GetById(int.Parse(reader["PalletId"].ToString()))
                                };

                                if (reader["PartId"] != DBNull.Value)
                                    operationRegister.Part = PartRepository.GetById(int.Parse(reader["PartId"].ToString()));

                                operationRegister.InitDateTime = (DateTime)reader["InitDateTime"];

                                operationRegisters.Add(operationRegister);
                            }
                        }
                    }
                }

                return operationRegisters;
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
