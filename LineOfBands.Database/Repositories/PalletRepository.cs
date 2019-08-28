using System;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{
    public static class PalletRepository
    {

        public static Pallet GetByCode(int code)
        {
            const string strSql = "SELECT Id, Code FROM Pallets WHERE Code = @Code";
            var pallet = new Pallet();

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
                                pallet.Id = Convert.ToInt32(reader["Id"]);
                                pallet.Code = Convert.ToInt32(reader["Code"]);     
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pallet;
        }

        public static Pallet GetById(int id)
        {

            const string strSql = "SELECT Id, Code FROM Pallets WHERE Id = @Id";
            var pallet = new Pallet();

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
                                pallet.Id = Convert.ToInt32(reader["Id"]);
                                pallet.Code = Convert.ToInt32(reader["Code"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pallet;
        }

        public static Pallet SaveOrUpdate(Pallet pallet)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = pallet.Id == -1 ? "INSERT INTO Pallets (Code, LineId) VALUES (@Code, @LineId) SELECT Scope_Identity()" 
                        : "UPDATE Pallets SET Code = @Code, LineId = @LineId WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", pallet.Code);
                        command.Parameters.AddWithValue("@LineId", pallet.Line.Id);
                        command.Parameters.AddWithValue("@Id", pallet.Id);

                        if (pallet.Id == -1)
                            pallet.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {             
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "PalletRepository.SaveOrUpdate()", ex.Message);
            }

            return pallet;
        }

        public static void Remove(Pallet pallet)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = "DELETE FROM Pallets WHERE Id = @Id";
                  
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", pallet.Id);
                        command.ExecuteNonQuery();
     
                    }
                }
            }
            catch (Exception ex)
            {
 
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "PalletRepository.SaveOrUpdate()", ex.Message);
            }
        }

    }

    public enum TransactionResult
    {
        Succsesfull = 1,
        NoSuccsesfull = 2
    }
}