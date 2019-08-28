using System;

namespace LineOfBands.Database.Entities
{
    public class OperationRegister
    {
        public int Id { get; set; }
        public Operation OperationIn { get; set; }
        public Operation OperationOut { get; set; }
        public Pallet Pallet { get; set; }
        public Mold Mold { get; set; }
        public Part Part { get; set; }
        public DateTime InitDateTime { get;  set; }
        public DateTime EndDateTime { get; set; }

        public OperationRegister()
        {
            
        }

    }
}
