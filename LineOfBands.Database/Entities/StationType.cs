namespace LineOfBands.Database.Entities
{
    public class StationType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StationType() {}

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

        //LoadAndFill = 1,
        //Oven = 2,
        //Unmold = 3

    }
}
