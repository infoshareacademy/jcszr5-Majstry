namespace Warsztat_v2.Models
{
    public class Order
    {
        public string Status { get; set; }
        public string Fault { get; set; }
        public Carr Car { get; set; }
        public Employee Employee { get; set; }
        public Part Part { get; set; }
        
    }
}
