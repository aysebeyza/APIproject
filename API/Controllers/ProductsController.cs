using API.Context;
using API.Dtos.ProductDtos;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ProductsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]// get yazmazsak 500 hata kodu döndürür
        public IActionResult GetProduct()
        {
            var result = _context.Products.ToList();
            return Ok(result);

        }
        [HttpPost]
        public IActionResult CreateProductDto(CreateProductDto productdto)
        {
            Product product = new Product();
            product.Name = productdto.Name;
            product.Stock = productdto.Stock;
            product.Price = productdto.Price;
            product.Image = productdto.Image;


            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok("Ekleme işlemi Başarılı :) ");

        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var deger = _context.Products.Find(id);
            _context.Products.Remove(deger);
            _context.SaveChanges();
            return Ok("Silme işlemi gerçekleşti . . . .");

        }

        [HttpGet("GetByIdProduct")]
        public IActionResult GetByIdProducts(int id)
        {
            var result = _context.Products.Find(id);
            GetByIdProductDto get = new GetByIdProductDto();
            return Ok(result);
        }

        [HttpPut]
        public IActionResult UpdateProductDto(UpdateProductDto productdto, int id)
        {
            var deger = _context.Products.Find(id);
            deger.Name = productdto.Name;
            deger.Stock = productdto.Stock;
            deger.Price = productdto.Price;
            _context.SaveChanges();
            return Ok("GÜNCELLEME işlemi Başarılı :) ");


        }
    }
}
        