using System;
using System.Collections.Generic;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;

namespace LineOfBands.Database.Controllers
{
    public static class OperationController
    {

        public static Operation SaveOrUpdate(Operation pallet)
        {
            try
            {
                if (pallet.Code == 0) new Exception("El código de estación no puede ser 0");

                OperationRepository.SaveOrUpdate(pallet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pallet;
        }

        public static Operation GetByCode(int code)
        {
          
            try
            {
                return OperationRepository.GetByCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Station> GetAll()
        {
            try
            {
                return StationRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

       

        public static void Remove(Station station)
        {
            
        }

    }
}
