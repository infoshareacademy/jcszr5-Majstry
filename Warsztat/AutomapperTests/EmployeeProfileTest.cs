using Warsztat_v2.Automapper;
using Warsztat_v2.ViewModels;

namespace AutomapperTests
{
    public class EmployeeProfileTest
    {
        private IMapper _mapper;
        public EmployeeProfileTest()
        {
            //_mapper = new MapperFactory().Create(new EmployeeProfile());
        }
        [Fact]
        public void ShouldMapToDto()
        {
            var employeDto = new EmployeeDto
            {
                Age = 35,
                FinishedOrder = 5,
                Name = "Arkadiusz Mróz",
                Role = "Mechanic",
                Salary = 2567.09m
            };
            //var actual = _mapper.Map()
        }
    }
}