namespace SportnaSila.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOrder { get; set; }

        public Clients Client { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
