using System.ComponentModel.DataAnnotations;

namespace Warsztat.BLL.Models
{
    public class Car

    {
        //Car CAR = new Car();

        [Key]
        public int Id { get; set; }

        [Display(Name = "Car Model")]
        public string Model_Name { get; set; }

        [Display(Name = "Car Mark")]
        public string MakeName { get; set; }
 
        public string FullName => MakeName + " " + Model_Name;
    }   
}   
    