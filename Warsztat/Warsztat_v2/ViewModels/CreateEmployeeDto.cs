using System.ComponentModel.DataAnnotations.Schema;

namespace Warsztat_v2.ViewModels
{
    public class CreateEmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        public string Role { get; set; }
        
    }
}
