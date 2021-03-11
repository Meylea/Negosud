namespace Negosud_Client.Models
{
    public class ClientCommandLine
    {
        
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public int ItemId { get; set; }

        public Item Item { get; set; }
    }
}
