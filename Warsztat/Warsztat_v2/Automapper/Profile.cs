using AutoMapper;
using Warsztat.BLL.Models;
using Warsztat_v2.ViewModels;

namespace Warsztat_v2.Automapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dto => dto.Id, expr => expr.MapFrom(source => source.Id))
                .ForMember(dto => dto.Name, expr => expr.MapFrom(source => $"{source.FirstName} {source.LastName}"))
                .ForMember(dto => dto.Age, expr => expr.MapFrom(source => (DateTime.UtcNow.AddYears(-source.DateOfBirth.Year).Year )))
                .ForMember(dto => dto.Role, expr => expr.MapFrom(source => source.Role))
                .ForMember(dto => dto.Salary, expr => expr.MapFrom(source => source.Salary))
                .ForMember(dto => dto.FinishedOrder, expr => expr.MapFrom(source => source.FinishedOrder));

            CreateMap<CreateEmployeeDto, Employee>()
                .ForMember(e => e.FirstName, expr => expr.MapFrom(c => c.FirstName))
                .ForMember(e => e.LastName, expr => expr.MapFrom(c => c.LastName))
                .ForMember(e => e.DateOfBirth, expr => expr.MapFrom(c => c.DateOfBirth))
                .ForMember(e => e.Role, expr => expr.MapFrom(c => c.Role))
                .ForMember(e => e.Salary, expr => expr.MapFrom(c => c.Salary));
            CreateMap<Employee, CreateEmployeeDto>()
                .ForMember(e => e.FirstName, expr => expr.MapFrom(c => c.FirstName))
                .ForMember(e => e.LastName, expr => expr.MapFrom(c => c.LastName))
                .ForMember(e => e.DateOfBirth, expr => expr.MapFrom(c => c.DateOfBirth))
                .ForMember(e => e.Role, expr => expr.MapFrom(c => c.Role))
                .ForMember(e => e.Salary, expr => expr.MapFrom(c => c.Salary));
        }
        
    }
}
