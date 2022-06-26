using System.ComponentModel.DataAnnotations;

namespace Warsztat.BLL.Models
{
    public class Car

    {
        //Car CAR = new Car();

        [Key]
        public int Id { get; set; }

        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Display(Name = "Car Mark")]
        public string CarMark { get; set; }
 
        public string FullName => CarMark + " " + CarModel;
    }   
}   
    