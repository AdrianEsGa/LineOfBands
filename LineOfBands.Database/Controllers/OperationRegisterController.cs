using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;
using System;
using System.Collections.Generic;

namespace LineOfBands.Database.Controllers
{
    public static class  OperationRegisterController
    {
        public static void Register(Station station, Pallet pallet, Operation operation, Mold mold, string partReference)
        {
            if (operation.Type == OperationType.In)
            {
                StartRegisterOperation(pallet, mold, operation);              
            }
            else
            {
                if (operation.LoadMold)
                {
                    FinalizeProductionOrder(pallet);
                    CreateProductionOrder(station, pallet, mold);                 
                }

                if (operation.InitPart)
                {
                    CreatePart(pallet, partReference);                  
                }

                FinalizeRegisterOperation(pallet, operation);
            }

            station.ActiveProductionOrder = ProductionOrderController.GetActiveByPallet(pallet);
        }

        private static void FinalizeProductionOrder(Pallet pallet)
        {
            ProductionOrderRepository.ChangeStatus(ProductionOrderRepository.GetActiveByPallet(pallet), ProductionOrderStatus.Finalized); 
        }

        private static void StartRegisterOperation(Pallet pallet, Mold mold, Operation operation)
        {
            var operationRegister = new OperationRegister
            {
                Pallet = pallet,
                InitDateTime = DateTime.Now,
                Mold = mold,
                OperationIn = operation,
                Part = ProductionOrderRepository.GetActiveByPallet(pallet).ActivePart
            };

            OperationRegisterRepository.SaveOrUpdate(operationRegister);
        }

        private static void FinalizeRegisterOperation(Pallet pallet, Operation operation)
        {
            var operationRegister = OperationRegisterRepository.GetActiveByPallet(pallet);
            operationRegister.EndDateTime = DateTime.Now;
            operationRegister.OperationOut = operation;

            OperationRegisterRepository.SaveOrUpdate(operationRegister);
        }

        private static void CreatePart(Pallet pallet, string reference)
        {
            var productionOrder = ProductionOrderRepository.GetActiveByPallet(pallet);

            var part = new Part
            {
                ProductionOrder = productionOrder,
                FabricationDate = DateTime.Now,
                Reference = reference
            };

            productionOrder.ActivePart = part;
            PartRepository.SaveOrUpdate(part);
            ProductionOrderRepository.SaveOrUpdate(part.ProductionOrder);
        }

        private static void CreateProductionOrder(Station station, Pallet pallet, Mold mold)
        {
            var productionOrder = new ProductionOrder
            {
                Mold = mold,
                Pallet = pallet,
                Status = ProductionOrderStatus.Active
            };

            station.ActiveProductionOrder = productionOrder;
            ProductionOrderRepository.SaveOrUpdate(productionOrder);
        }

        public static List<OperationRegister> GetActiveOperations()
        {
            try
            {
                return OperationRegisterRepository.GetActiveOperations();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }

        public static List<OperationRegister> GetLastOperations()
        {
            try
            {
                return OperationRegisterRepository.GetLastOperations();
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
        }
    }
}
