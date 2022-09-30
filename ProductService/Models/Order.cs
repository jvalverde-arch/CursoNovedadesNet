namespace ProductService.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public int ProductId { get; set; }

        public int Cantidad { get; set; }
    }
}
