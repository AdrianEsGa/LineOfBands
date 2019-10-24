using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;
using System;

namespace LineOfBands.Database.Controllers
{
    public static class ProductionOrderController
    {
        public static ProductionOrder GetActiveByPallet(Pallet pallet)
        {
            try
            {
                return ProductionOrderRepository.GetActiveByPallet(pallet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
