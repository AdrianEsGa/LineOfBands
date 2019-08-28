using LineOfBands.Common;
using LineOfBands.Database.Entities;
using System;
using System.Data.SqlClient;
using System.Reflection;

namespace LineOfBands.Database.Repositories
{

    public static class ProductionOrderRepository
    {

        public static ProductionOrder GetById(int id)
        {

            var productionOrder = new ProductionOrder();
            try
            {

                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = "SELECT Id, PalletId, MoldId, PartId, Status FROM ProductionOrders WHERE Id=@Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productionOrder.Id = int.Parse(reader["Id"].ToString());
                                productionOrder.Pallet = PalletRepository.GetById(int.Parse(reader["PalletId"].ToString()));
                                productionOrder.Mold = MoldRepository.GetById(int.Parse(reader["MoldId"].ToString()));
                                productionOrder.ActivePart = PartRepository.GetById(int.Parse(reader["PartId"].ToString()));
                                productionOrder.Status = (ProductionOrderStatus)int.Parse(reader["Status"].ToString());
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                //Introducir en el futuro codigo para NLog.
            }

            return productionOrder;
        }

        public static ProductionOrder GetByPallet(Pallet pallet)
        {
            var productionOrder = new ProductionOrder();
            try
            {
              
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = "SELECT Id, PalletId, MoldId, PartId, Status FROM ProductionOrders WHERE PalletId=@PalletId";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@PalletId", pallet.Id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productionOrder.Id = int.Parse(reader["Id"].ToString());
                                productionOrder.Pallet = pallet;
                                productionOrder.Mold = MoldRepository.GetById(int.Parse(reader["MoldId"].ToString()));

                                if(reader["PartId"] != DBNull.Value)
                                    productionOrder.ActivePart = PartRepository.GetById(int.Parse(reader["PartId"].ToString()));

                                productionOrder.Status = (ProductionOrderStatus)int.Parse(reader["Status"].ToString());
                            }
                        }
                    }
                }
               

            }
            catch (Exception ex)
            {
        //Introducir en el futuro codigo para NLog.
            }

            return productionOrder;

        }

        public static ProductionOrder SaveOrUpdate(ProductionOrder ProductionOrder)
        {
            try
            {
                using (var connection = SqlServer.OpenConnection())
                {
                    var strSql = ProductionOrder.Id == 0 ? "INSERT INTO ProductionOrders ( PalletId, MoldId, PartId, Status )" +
                        " VALUES ( @PalletId, @MoldId, @PartId, @Status) SELECT Scope_Identity() "
                        : "UPDATE ProductionOrders SET  PalletId=@PalletId, MoldId=@PalletId, PartId=@PartId, Status=@Status WHERE Id = @Id";

                    using (var command = new SqlCommand(strSql, connection))
                    {
                        command.Parameters.AddWithValue("@PalletId", ProductionOrder.Pallet.Id);
                        command.Parameters.AddWithValue("@MoldId", ProductionOrder.Mold.Id);

                        if(ProductionOrder.ActivePart == null)
                          command.Parameters.AddWithValue("@PartId", DBNull.Value);
                        else command.Parameters.AddWithValue("@PartId", ProductionOrder.ActivePart.Id);

                        command.Parameters.AddWithValue("@Status", ProductionOrder.Status);                
                        command.Parameters.AddWithValue("@Id", ProductionOrder.Id);

                        if (ProductionOrder.Id == 0)
                            ProductionOrder.Id = Convert.ToInt32(command.ExecuteScalar());
                        // Cuado hacemos un INSERT mediante "ExecuteScalar" devuelve el Id generado en la base de datos(SELECT Scope_Identity()).
                        else command.ExecuteNonQuery();
                        // Ejecución sin resultados no devuelve nada.                 
                    }                  
                }
            }
            catch (Exception ex)
            {
                Logger.Insert(LoggerType.Error, Assembly.GetExecutingAssembly().GetName().Name,
                    "ProductionOrderRepository.SaveOrUpdate()", ex.Message);
            }

            return ProductionOrder;

        }

        public static void Remove(ProductionOrder ProductionOrder)
        {

        }
    }
}
