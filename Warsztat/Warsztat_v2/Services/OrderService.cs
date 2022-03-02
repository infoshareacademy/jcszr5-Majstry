using Warsztat_v2.Models;
using Warsztat_v2.Repositories;

namespace Warsztat_v2.Services
{
    public class OrderService
    {
        private static int orderId = 0;
        private OrderRepository _orderRepository;

        private static List<Order> Orders = new List<Order>
        {

           //public EmployeeService employeeService = new EmployeeService();
            new Order()
            {
                Id = 1,
                OrderNumber = "sdgsdg",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(6),
                Status ="sagf",
                Fault = "sadgf",
                BrandOfCar ="sdg",
                ModelOfCar ="sdg",
                RegistrationNumber ="aefhg",
                Mechanic = "antek"

            },
                 new Order()
            {
                Id = 1,
                OrderNumber = "sdgsdg",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(6),
                Status ="sagf",
                Fault = "sadgf",
                BrandOfCar ="sdg",
                ModelOfCar ="sdg",
                RegistrationNumber ="aefhg",
                Mechanic = "antek"

            }
        };

        public Order GetById(int id)
        {
            return Orders.FirstOrDefault(o => o.Id == id);
        }

        // private OrderRepository _orderRepository;

        public List<Order> GetAll()
        {
            //List<Order> orders =  _orderRepository.ReadFromFile();
            return Orders;
        }

        public void   Create(Order order)
        {
            order.Id = GetNextId();
            Orders.Add(order);
            _orderRepository.SaveToFile(Orders);

        }
        public int GetNextId()
        {
            orderId++;
            return orderId;
        }
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
