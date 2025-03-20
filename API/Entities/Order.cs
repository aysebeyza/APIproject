namespace API.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
    }
}
