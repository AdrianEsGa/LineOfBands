using LineOfBands.Opc;

namespace LineOfBands.Database.Entities
{
    public class Check
    {
        public int Id {get; set; }
        public string Name { get; set; }
        public Station Station { get; set; }
        public string OpcAddress { get; set; }
        public Item OpcItem { get; set; }

        public override string ToString()
        {
            return Name;
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