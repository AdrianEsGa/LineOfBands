using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;
using System;
using System.Collections.Generic;

namespace LineOfBands.Database.Controllers
{
    public static class  OperationRegisterController
    {
        public static void Register(Station station, Pallet pallet, Operation operation, Mold mold)
        {
            if (operation.Type == OperationType.In)
            {
                StartRegisterOperation(pallet, mold, operation);              
            }
            else
            {
                if (operation.LoadMold)
                {
                    CreateProductionOrder(pallet, mold);                 
                }

                if (operation.InitPart)
                {
                    CreatePart(pallet);                  
                }

                FinalizeRegisterOperation(pallet, operation);
            }
        }

        private static void StartRegisterOperation(Pallet pallet, Mold mold, Operation operation)
        {
            var operationRegister = new OperationRegister
            {
                Pallet = pallet,
                InitDateTime = DateTime.Now,
                Mold = mold,
                OperationIn = operation,
                Part = ProductionOrderRepository.GetByPallet(pallet).ActivePart
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

        private static void CreatePart(Pallet pallet)
        {
            var productionOrder = ProductionOrderRepository.GetByPallet(pallet);

            var part = new Part
            {
                ProductionOrder = productionOrder,
                FabricationDate = DateTime.Now,
                Reference = "123456565465"
            };

            productionOrder.ActivePart = part;
            PartRepository.SaveOrUpdate(part);
            ProductionOrderRepository.SaveOrUpdate(part.ProductionOrder);
        }

        private static void CreateProductionOrder(Pallet pallet, Mold mold)
        {
            pallet.Mold = mold;
            var productionOrder = new ProductionOrder
            {
                Mold = mold,
                Pallet = pallet,
            };

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
