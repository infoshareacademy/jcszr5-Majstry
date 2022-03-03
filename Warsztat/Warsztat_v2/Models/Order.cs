using Microsoft.AspNetCore.Mvc.Rendering;

namespace Warsztat_v2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }//Usunąć?

        public string Status { get; set; }
        public string Fault { get; set; }
        public string Client { get; set; }// dodac do view
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }// zrobic jeden car
        public string RegistrationNumber { get; set; }
        public string Mechanic { get; set; }
        //   public Part Part { get; set; }
        public SelectList Part;
        public int PartPcs { get; set; }
    }
}
