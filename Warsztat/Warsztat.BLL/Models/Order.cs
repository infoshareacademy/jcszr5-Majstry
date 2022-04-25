using System.ComponentModel.DataAnnotations;
using Warsztat.BLL.Enums;
namespace Warsztat.BLL.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        [Display(Name = "Start")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan WorkTime { get; set; }// czy można przypisywać wartość właściwości bezpośrednio przy ich deklaracji???        
        public Status Status { get; set; }
        public string? Fault { get; set; }
        public string Client { get; set; }
        [Display(Name = "Reg Number")]
        public string RegistrationNumber { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
        public int EmployeeId { get; set; }
        public Employee Mechanic { get; set; }
        //public int PartId { get; set; }
        public ICollection<Part> Parts { get; set; }
        [Display(Name = "Pcs")]
        public System.Nullable<int> PartPcs { get; set; }
        public float Price { get; set; }

    }

}
