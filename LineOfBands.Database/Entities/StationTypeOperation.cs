namespace LineOfBands.Database.Entities
{
    public class StationTypeOperation
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public StationType StationType { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
