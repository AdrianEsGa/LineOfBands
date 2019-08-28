using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using LineOfBands.Common;
using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;

namespace LineOfBands.Database.Controllers
{
    public static class StationController
    {

        public static Station SaveOrUpdate(Station station)
        {
            try
            {
                if (station.Code == 0) new Exception("El código de estación no puede ser 0");

                StationRepository.SaveOrUpdate(station);
            }
            catch (Exception ex)
            {
               
            }

            return station;
        }

        public static Station GetByCode(int code)
        {
          
            try
            {
                return StationRepository.GetByCode(code);
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
