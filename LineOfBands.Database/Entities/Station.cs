using LineOfBands.Opc;
using LineOfBands.Snap7.Entities;


namespace LineOfBands.Database.Entities
{

    public class Station
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public Line Line { get; set; }
        public string Name { get; set; }
        public StationType Type { get; set; }
        public string StatusDataChangeAddress { get; set; }
        public string StatusDataChangeAddressAck { get; set; }
        public string DataAddress { get; set; }

        //Snap7 Items
        public S7Item StatusChangeS7 { get; set; }
        public S7Item StatusChangeS7Ack { get; set; }
        public S7Item DataAddressS7 { get; set; }

        //OPC Items
        public Item StatusChangeOpc { get; set; }
        public Item StatusChangeOpcAck { get; set; }
        public Item DataAddressOpc { get; set; }

        //Snap7 or OPC data content
        public DataContent DataContent {get; set; }

        public Station() {}

        public override string ToString()
        {
            return "(" + Code + ") " + Name;
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
