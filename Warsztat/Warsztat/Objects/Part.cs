using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warsztat;
using System.Text.Json;

namespace Warsztat
{
    public class Part
    {
        public string PartName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Part(string partName, int price)
        {
            PartName = partName;
            Price = price;
        }
    }
}

