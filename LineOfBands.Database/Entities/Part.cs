using System;

namespace LineOfBands.Database.Entities
{
    public class Part
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public ProductionOrder ProductionOrder { get; set; }
        public DateTime FabricationDate { get; set; }

        public Part () {}

        public override string ToString()
        {
            return "Pieza " + Reference;
        }

        public override int GetHashCode()
        {
            return (GetType() + "|" + Id).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj != null && GetHashCode() == obj.GetHashCode();
        }

    }
}
