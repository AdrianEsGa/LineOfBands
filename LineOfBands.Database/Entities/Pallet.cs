namespace LineOfBands.Database.Entities
{
    public class Pallet
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public Line Line { get; set; }
        public Mold Mold { get; set; }

        public Pallet()
        {
            Id = -1;
        }

        public override string ToString()
        {
            return "Pallet " + Code;
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
