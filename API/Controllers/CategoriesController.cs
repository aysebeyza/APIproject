using API.Context;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApiContext _context;

        public CategoriesController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet]// get yazmazsak 500 hata kodu döndürür
        public IActionResult GetCategory()
        {
            var result = _context.Categories.ToList();
            return Ok(result);

        }
        [HttpPost]
        public IActionResult GetCategory(Category category)
        {
            _context.Categories.Add(category);
           _context.SaveChanges();
            return Ok("Ekleme işlemi Başarılı :) ");

        }


        [HttpGet("GetByIdCategory")]
        public IActionResult GetByIdCategory(int id)
        {
            var deger = _context.Categories.Find(id);
            return Ok(deger);
        }

        [HttpPut]

        public IActionResult UpdateCategory(Category category)
        {
           
            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok("Güncelleme İşlemi Başarılı      :) " );
        }

        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var deger = _context.Categories.Find(id);
            _context.Categories.Remove(deger);
            _context.SaveChanges();
            return Ok("Başarılı bir şekilde silindi . . . ");
        }

    }
}
                             