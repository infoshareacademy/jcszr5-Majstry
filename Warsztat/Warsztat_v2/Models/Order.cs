using Microsoft.AspNetCore.Mvc.Rendering;

namespace Warsztat_v2.Models
{
    public class Order
    {
        public Order()
        {

        }
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
        public string Fault { get; set; }
        public string Client { get; set; }
        public string Car { get; set; }
        public string RegistrationNumber { get; set; }
        public string Mechanic { get; set; }
        //public Part Part { get; set; }
        public string Part { get; set; }
        public int PartPcs { get; set; }
        //public Order(int id, string orderNumber, DateTime starttime, string status, string fault, string client, string car, string registrationNumber, string mechanic, string part, int partPcs)
        //{

        //    Id = id;
        //    OrderNumber = orderNumber;
        //    StartTime = starttime;
        //    Status = status;
        //    Fault = fault;
        //    Client = client;
        //    Car = car;
        //    RegistrationNumber = registrationNumber;
        //    Mechanic = mechanic;
        //    Part = part;
        //    PartPcs = partPcs;

        //    orderNumber = registrationNumber + "/" + DateTime.Now.ToString("yyyy") + id; 

        //}
   

    }
    
}
