namespace API.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
    }
}
