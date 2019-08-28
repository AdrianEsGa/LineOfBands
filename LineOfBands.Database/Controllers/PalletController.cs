using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;

namespace LineOfBands.Database.Controllers
{
    public static class PalletController
    {

        public static Pallet SaveOrUpdate(Pallet pallet)
        {
            try
            {
                if (pallet.Code == 0) new Exception("El código de estación no puede ser 0");

                PalletRepository.SaveOrUpdate(pallet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pallet;
        }

        public static Pallet GetByCode(int code)
        {
          
            try
            {
                return PalletRepository.GetByCode(code);
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
