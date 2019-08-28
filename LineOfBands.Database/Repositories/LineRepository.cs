using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{
    public static class LineRepository
    {
        public static TransactionResult TranResult;
        public static string TranMessage;

        public static List<Line> GetAll()
        {

            const string strSql = "SELECT Id, Code, Name FROM Lines";
            var lines = new List<Line>();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Logger.Insert(LoggerType.Warning, Assembly.GetExecutingAssembly().GetName().Name,
                                    "PalletRepository.GetByCode()", "Lines not found!");
                                return lines;
                            }

                            while (reader.Read())
                            {
                                var line = new Line
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Code = Convert.ToInt32(reader["Code"]),
                                    Name = reader["Name"].ToString()
                                };

                                lines.Add(line);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "PalletRepository.GetByCode()", ex.Message);
            }

            return lines;
        }

        public static Line SaveOrUpdate(Line line)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = line.Id == -1 ? "INSERT INTO Lines (Code, Name) VALUES (@Code, @Name) SELECT Scope_Identity()"
                        : "UPDATE Lines SET Code = @Code, Name = @Name WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Code", line.Code);
                        command.Parameters.AddWithValue("@Name", line.Name);
                        command.Parameters.AddWithValue("@Id", line.Id);

                        if (line.Id == -1)
                            line.Id = Convert.ToInt32(command.ExecuteScalar());
                        else command.ExecuteNonQuery();

                        TranResult = TransactionResult.Succsesfull;
                        TranMessage = GlobalDbInfo.OperationSuccsesfull;
                    }
                }
            }
            catch (Exception ex)
            {
                TranResult = TransactionResult.NoSuccsesfull;
                TranMessage = ex.Message;
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "LineRepository.SaveOrUpdate()", ex.Message);
            }

            return line;
        }

        public static void Remove(Line line)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = "DELETE FROM Lines WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", line.Id);
                        command.ExecuteNonQuery();
                        TranResult = TransactionResult.Succsesfull;
                        TranMessage = GlobalDbInfo.OperationSuccsesfull;
                    }
                }
            }
            catch (Exception ex)
            {
                TranResult = TransactionResult.NoSuccsesfull;
                TranMessage = ex.Message;
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "LineRepository.Remove()", ex.Message);
            }
        }

        public static Line GetById(int id)
        {
            const string strSql = "SELECT Id, Code, Name FROM Lines WHERE Id = @Id";
            var line = new Line();

            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    using (var command = new SqlCommand(strSql, connection))
                    {    
                        command.Parameters.AddWithValue("@Id", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Logger.Insert(LoggerType.Warning, Assembly.GetExecutingAssembly().GetName().Name,
                                    "LineRepository.GetById()", "Line (" + id + ") not found!");
                                return line;
                            }

                            while (reader.Read())
                            {
                                line.Id = Convert.ToInt32(reader["Id"]);
                                line.Code = Convert.ToInt32(reader["Code"]);
                                line.Name = reader["Name"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "LineRepository.GetById()", ex.Message);
            }

            return line;
        }
    }
}
