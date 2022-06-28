using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat.BLL.Models
{
    public class VehicleApiResponse
    {
        public Order Car { get; set; }
        public int Count { get; set; }
        public string Message { get; set; }
        public Order[] Results { get; set; }
    }
}
