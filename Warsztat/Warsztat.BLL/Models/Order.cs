using System.ComponentModel.DataAnnotations;
using Warsztat.BLL.Enums;
using Warsztat.BLL.Services;
using Warsztat.BLL.Services.Interfaces;

namespace Warsztat.BLL.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Start")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }
        [Display(Name = "Next Step")]
        [DataType(DataType.Date)]
        public DateTime EndTime { get; set; }
        public Status Status { get; set; }
        public string? Fault { get; set; }
        public string Client { get; set; }
        [Display(Name = "Reg Number")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Vehicle Make")]
        public string MakeName { get; set; }
        [Display(Name = "Model")]
        public string Model_Name { get; set; }
        [Display(Name = "Vehicle")]
        public string CarFullName => MakeName + " " + Model_Name;
        public Employee Mechanic { get; set; }
        [Display(Name = "Mechanic")]
        public int MechanicId { get; set; }
        public Part Part { get; set; }
        [Display(Name = "Part")]
        public int PartId { get; set; }
        [Display(Name = "Part Quantity")]
        public int? PartPcs { get; set; }
        public float Price { get; set; }
        [Display(Name = "Order Number")]
        public string OrderNumber { get; set; }
    }
}
