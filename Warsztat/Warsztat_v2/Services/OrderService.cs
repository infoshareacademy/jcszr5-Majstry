using Warsztat_v2.Models;
using System.Text.Json;
using Warsztat_v2.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Warsztat_v2.Services
{
    public class OrderService
    {
        private static int orderId = 0;
        private OrderRepository _orderRepository = new OrderRepository();
        public PartService partService = new PartService();
        
        List<Part> parts;
        List<Order> orders;
        public SelectList partsList;
        //public string partName;


        //private static List<Order> orders = new List<Order>
        //{

        //   //public EmployeeService employeeService = new EmployeeService();
        //    new Order()
        //    {
        //        Id = 1,
        //        OrderNumber = "sdgsdg",
        //        StartTime = DateTime.Now,
        //        EndTime = DateTime.Now.AddDays(6),
        //        Status ="sagf",
        //        Fault = "sadgf",
        //        BrandOfCar ="sdg",
        //        ModelOfCar ="sdg",
        //        RegistrationNumber ="aefhg",
        //        Mechanic = "antek"

        //    },
        //         new Order()
        //    {
        //        Id = 1,
        //        OrderNumber = "sdgsdg",
        //        StartTime = DateTime.Now,
        //        EndTime = DateTime.Now.AddDays(6),
        //        Status ="sagf",
        //        Fault = "sadgf",
        //        BrandOfCar ="sdg",
        //        ModelOfCar ="sdg",
        //        RegistrationNumber ="aefhg",
        //        Mechanic = "antek"

        //    }
        //};
        public List<Order> GetAll()
        {
            List<Order> orders = _orderRepository.ReadFromFile();

            return orders;
        }

        public Order GetById(int id)
        {
            return orders.FirstOrDefault(o => o.Id == id);
        }

        // private OrderRepository _orderRepository;

        public void Create(Order order)
        {
            GetAll();
            order.Id = GetNextId();
            orders.Add(order);
            _orderRepository.SaveToFile(orders);

        }
        public int GetNextId()
        {
            orderId++;
            return orderId;
        }
        public SelectList GetPartNameList()
        {
            string jasonFromFile = File.ReadAllText(@"..\..\..\PartList.json");
            parts = JsonSerializer.Deserialize<List<Part>>(jasonFromFile);
           // return parts.Select(p => p.PartName).ToList();
          //  parts.ConvertAll(x => x.PartName).ToHashSet();

          return  partsList = new SelectList(parts.Select(p => p.PartName));
  
        }
       

    //}
    //public List<string> GetPartNameList()
    //{
    //    string jasonFromFile = File.ReadAllText(@"..\..\..\PartList.json");
    //    parts = JsonSerializer.Deserialize<List<Part>>(jasonFromFile);
    //    return parts.Select(p => p.PartName).ToList();
    //    parts.ConvertAll(x => x.PartName).ToHashSet();

    //}

    //public List<Part> GetParts()
    //{
    //    string jasonFromFile = File.ReadAllText(@"..\..\..\PartList.json");
    //    parts = JsonSerializer.Deserialize<List<Part>>(jasonFromFile);
    //    return parts;
    //}

}
}
/*        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public string Fault { get; set; }
        public string BrandOfCar { get; set; }
        public string ModelOfCar { get; set; }
        public string RegistrationNumber { get; set; }
        public Employee Mechanic { get; set; }*/
