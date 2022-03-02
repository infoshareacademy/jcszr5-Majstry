namespace Warsztat_v2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public string Fault { get; set; }
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public string RegistrationNumber { get; set; }
        public string Mechanic { get; set; }
    }
}
