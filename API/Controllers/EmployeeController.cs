using API.Context;
using API.Dtos.EmployeeDto;
using API.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApiContext _apiContext;
        private readonly IMapper _mapper;

        public EmployeeController(ApiContext apiContext, IMapper mapper)
        {
            _apiContext = apiContext;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult EmployeeList()
        {
            var sonuc = _apiContext.Employees.ToList();
            return Ok(_mapper.Map<List<ResultEmployeedTO>>(sonuc));


        }

        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            var deger = _mapper.Map<Employee>(createEmployeeDto);
            _apiContext.Employees.Add(deger);
            _apiContext.SaveChanges();
            return Ok("Ekleme işlemi başarılı oldu. . .");

        }

        [HttpGet("GetByIdEmployee")]
        public IActionResult GetByIdEmployee(int id)
        {
         
            var deger = _apiContext.Employees.Find(id);
            return Ok(_mapper.Map<GetByIdEmployeeDto>(deger));      
        }


        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var deger = _apiContext.Employees.Find(id);
            _apiContext.Employees.Remove(deger);
            _apiContext.SaveChanges();
            return Ok("Başarılı bir şekilde silindi . . . ");
        }

        //UPDATE İŞLEMİ EKSİK ÇALIŞMIYOR.
        [HttpPut]
        public IActionResult UpdateEmployee(UpdateEmployeeDto updateEmployeeDto, int id)
        {
            var deger = _apiContext.Employees.Find(id);
             deger = _mapper.Map<Employee>(updateEmployeeDto);
            _apiContext.Employees.Update(deger);
            return Ok("Başarılı ");
        }

    }
}
