using System.ComponentModel.DataAnnotations;
namespace Warsztat_v2.Models
{
    public class Parts
    {
        [Display(Name = "Part name")]
        public string PartName { get; set; }
        [Display(Name = "Part price")]
        public int PartPrice { get; set; }
        public int Quantity { get; set; }
    }
}
