using System.ComponentModel.DataAnnotations;
using Warsztat.BLL.Enums;
using Warsztat.BLL.Services;
using Warsztat.BLL.Services.Interfaces;

namespace Warsztat.BLL.Models
{
    public class Order
    {
        private string orderNumber;
        OrderService _orderService = new();

        [Key]
        public int Id { get; set; }
        //public string OrderNumber { get; set; }       
        //public string OrderNumber => _orderService.OrderNumberGenerator(RegistrationNumber,StartTime,Id);
        public string OrderNumber
        {
            get 
            {
                return orderNumber;
            }
            set
            {
                orderNumber = _orderService.OrderNumberGenerator(RegistrationNumber, StartTime, Id);
            }
        }
            
        [Display(Name = "Start")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }
        //public DateTime EndTime { get; set; }
        //public TimeSpan? WorkTime { get; set; }   
        public Status Status { get; set; }
        public string? Fault { get; set; }
        public string Client { get; set; }
        [Display(Name = "Reg Number")]
        public string RegistrationNumber { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public Employee Mechanic { get; set; }
        public int MechanicId { get; set; }
        public ICollection<Part> Parts { get; set; }
        [Display(Name = "Pcs")]
        public int? PartPcs { get; set; }
        public float Price { get; set; }

    }

}
