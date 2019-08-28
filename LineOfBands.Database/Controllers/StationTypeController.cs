using LineOfBands.Database.Entities;
using LineOfBands.Database.Repositories;
using System;
using System.Collections.Generic;

namespace LineOfBands.Database.Controllers
{
    public class StationTypeController
    {
        public static List<StationType> GetAll()
        {
            try
            {
                return StationTypeRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
