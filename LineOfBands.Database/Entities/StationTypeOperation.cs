namespace LineOfBands.Database.Entities
{
    public class StationTypeOperation
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public StationType StationType { get; set; }
    }
}
