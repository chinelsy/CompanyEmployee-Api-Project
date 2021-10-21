using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace EmployeesApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()

        {
            CreateMap<Company, CompanyDto>()
            .ForMember(c => c.FullAddress, opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>();

            CreateMap<CompanyForCreationDto, Company>();

            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

            CreateMap<EmployeeForUpdateDto, Employee>();

            CreateMap<CompanyForUpdateDto, Company>();
            CreateMap<UserForRegistrationDto, User>();





        }
    }
}
