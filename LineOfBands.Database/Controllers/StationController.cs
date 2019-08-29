using System;
using System.Collections.Generic;
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
                if (station.Code == 0)
                {
                    var exception = new Exception("El código de estación no puede ser 0");
                }

                return StationRepository.SaveOrUpdate(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }
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
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }        
        }
     
        public static void Remove(Station station)
        {
            try
            {
                 StationRepository.Remove(station);
            }
            catch (Exception ex)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw ex;
            }    
        }
    }
}
