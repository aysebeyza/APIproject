using API.Dtos.EmployeeDto;
using API.Entities;
using AutoMapper;

namespace API.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Employee, ResultEmployeedTO>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
            CreateMap<Employee, GetByIdEmployeeDto>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();
          

        } 
    }
}
