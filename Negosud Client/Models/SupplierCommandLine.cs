namespace Negosud_Client.Models
{
    public class SupplierCommandLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ItemId { get; set; }
        public int SupplierCommandId { get; set; }

        public Item Item { get; set; }
        public SupplierCommand SupplierCommand { get; set; }
    }
}
