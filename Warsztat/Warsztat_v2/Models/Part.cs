﻿using System.ComponentModel.DataAnnotations;
namespace Warsztat_v2.Models
{
    public class Part

    {
        public int Id { get; set; }

        [Display(Name = "Part Name")]
        public string PartName { get; set; }

        [Display(Name = "Part Price")]
        public int PartPrice { get; set; }
        public int Quantity { get; set; }
    }
}