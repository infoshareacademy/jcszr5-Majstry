using Warsztat.BLL.Models;
using Warsztat.BLL.Services.Interfaces;
using Warsztat_v2.Data;
using Warsztat_v2.Repositories.Interfaces;

namespace Warsztat_v2.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public ServiceContext Context { get; set; }
        public List<Order> OrderList { get; set; }

        private IOrderService _orderservice;

        public OrderRepository(ServiceContext context, IOrderService orderService)
        {
            Context = context;
            OrderList = context.Orders.ToList();
            _orderservice = orderService;
        }

        public List<Order> GetAll()
        {
            return Context.Orders.ToList();
        }

        public void Add(Order order)
        {
           
            order.StartTime = DateTime.Now;
            int orderId = Context.Orders.Count() + 1;
            order.OrderNumber = _orderservice.OrderNumberGenerator(order.RegistrationNumber,order.StartTime, orderId);
            Context.Orders.Add(order);

            Context.SaveChanges();
        }

        public void Update(Order model)
        {
            var order = GetById(model.Id);
            order.RegistrationNumber = model.RegistrationNumber;
            order.StartTime = model.StartTime;
            order.EndTime = model.EndTime;
            order.PartPcs = model.PartPcs;
            order.Status = model.Status;
            order.Client = model.Client;
            order.Fault = model.Fault;
            order.Mechanic = model.Mechanic;
            Context.SaveChanges();

        }
        public void Delete(int id)
        {
            var order = GetById(id);
            Context.Orders.Remove(order);
            Context.SaveChanges();
        }

        public Order GetById(int id)
        {
            return OrderList.FirstOrDefault(o => o.Id == id);
        }
    }
}



