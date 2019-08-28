namespace LineOfBands.Database.Entities
{
    public class Line
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }

        public Line()
        {
            Id = -1;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
