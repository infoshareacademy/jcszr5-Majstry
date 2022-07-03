using System.ComponentModel.DataAnnotations.Schema;

namespace Warsztat_v2.ViewModels
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        public string Role { get; set; }
        public int FinishedOrder { get; set; }

    }
}
