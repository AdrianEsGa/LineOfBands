namespace LineOfBands.Database.Entities
{
    public class ProductionOrder
    {
        public int Id { get; set; }
        public Pallet Pallet { get; set; }
        public Mold Mold { get; set; }
        public Part ActivePart { get; set; }
        public ProductionOrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Orden de producción";
        }
    }

    public enum ProductionOrderStatus
    {
        Active = 1,
        Finalized = 2
    }
}
