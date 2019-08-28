namespace LineOfBands.Database.Entities
{
    public class Operation
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public OperationType Type { get; set; }
        public bool InitPart { get; set; }
        public bool LoadMold { get; set; }
        public Station Station { get; set; }
        public StationTypeOperation StationTypeOperation { get; set; }

        public Operation() {}

        public override string ToString()
        {
            var toString = "Operación (" + Code + ") ";
            if (Type == OperationType.In)
                toString += " Entrada en " + Station + " para " + StationTypeOperation;
            else toString += " Salida de " + Station + " para " + StationTypeOperation; 
            return toString;
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

    public enum OperationType
    {
        In = 1,
        Out = 2
    }


}
