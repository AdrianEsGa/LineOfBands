namespace LineOfBands.Database.Entities
{
    public class PartCheck
    {
        public int Id { get; private set; }
        public Part Part { get; set; }
        public Check Check { get; set; }
        public double Value { get; set; }
    }
}
