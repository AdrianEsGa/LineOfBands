using System;

namespace LineOfBands.Snap7.Entities
{

    public class S7Item
    {
        public int Area { get; set; }
        public int DBNumber { get; set; }
        public int Start { get; set; }
        public int Amount { get; set; }
        public int WordLen { get; set; }

        public S7Item(string strAddress)
        {
            try
            {
                var items = strAddress.Split('|');
                Area = Convert.ToInt16(items[0]);            
                DBNumber = Convert.ToInt16(items[1]);
                Start = Convert.ToInt16(items[2]);
                Amount = Convert.ToInt16(items[3]);
                WordLen = Convert.ToInt16(items[4]);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
