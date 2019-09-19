using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;

namespace LineOfBands.Database.Repositories
{
    public static class PartRepository
    {
        public static Part GetByReference(int reference)
        {
            return new Part();
        }

        internal static Part GetById(int id)
        {
            const string strSql = "SELECT Id, Reference, ProductionOrderId, FabricationDate FROM Parts WHERE Id = @Id";
            var part = new Part();

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
                                part.Id = Convert.ToInt32(reader["Id"]);
                                part.Reference = reader["Reference"].ToString();
                                part.ProductionOrder = ProductionOrderRepository.GetById(Convert.ToInt32(reader["ProductionOrderId"]));
                                part.FabricationDate = Convert.ToDateTime(reader["FabricationDate"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return part;
        }

        public static Part SaveOrUpdate(Part part)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = part.Id == 0 ? "INSERT INTO Parts (Reference, ProductionOrderId, FabricationDate)" +
                        " VALUES ( @Reference, @ProductionOrderId, @FabricationDate) SELECT Scope_Identity() "
                        : "UPDATE Parts SET Reference=@Reference, ProductionOrderId=@ProductionOrderId, FabricationDate=@FabricationDate WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Reference", part.Reference);
                        command.Parameters.AddWithValue("@ProductionOrderId", part.ProductionOrder.Id);
                        command.Parameters.AddWithValue("@FabricationDate", part.FabricationDate);
                        command.Parameters.AddWithValue("@Id", part.Id);

                        if (part.Id == 0)
                            part.Id = Convert.ToInt32(command.ExecuteScalar());
                        // Cuado hacemos un INSERT mediante "ExecuteScalar" devuelve el Id generado en la base de datos(SELECT Scope_Identity()).
                        else command.ExecuteNonQuery();
                        // Ejecución sin resultados no devuelve nada.                 
                    }
                }
            }
            catch (Exception ex)
            {
             
            }

            return part;
        }

        public static void Remove(Part pallet)
        {

        }

        public static List<OperationRegister> OperationRegisters(Part part)
        {
            return new List<OperationRegister>();
        }
    }
}
