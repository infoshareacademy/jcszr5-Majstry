using System.ComponentModel.DataAnnotations;
namespace Warsztat_v2.Models
{
    public class Carr

    {
        public int Id { get; set; }

        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Display(Name = "Car Mark")]
        public string CarMark { get; set; }

        [Display(Name = "Production Year")]
        public int YearProduction1 { get; set; }
    }
}