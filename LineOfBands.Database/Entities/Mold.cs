namespace LineOfBands.Database.Entities
{
    public class Mold
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Reference { get; set; }
        //public double High { get; set; }
        //public double Radio { get; set; }
        //public short Formulation { get; set; }
        //public short Flow { get; set; }
        //public int KeyTime { get; set; }
        //public int FilledTime { get; set; }
        //public int IncreaseInitialAmplitude { get; set; }
        //public int IncreaseFinalAmplitude { get; set; }
        //public short InitialAmplitudeCycle { get; set; }
        //public short CookingTime { get; set; }
        //public short PreheatingTime { get; set; }
        //public int RealHigh { get; set; }
        //public int ExtractionHigh { get; set; }


        public Mold() {}

        public override string ToString()
        {
            return "Molde " + Code;
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
