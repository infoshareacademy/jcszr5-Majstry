using Warsztat_v2.Models;
using System.Text.Json;
using Warsztat_v2.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Warsztat_v2.Services
{
    public class OrderService
    {
        Order order;
        private static int orderId = 0;
        private OrderRepository _orderRepository = new OrderRepository();
        //order.OrderNumber = order.RegistrationNumber + "/" + DateTime.Now.ToString("yyyy") +"/"+ order.Id.ToString();
       
      public static  List<Order> orders;
       // public int orderId = orders.Count();


        public List<Order> GetAll()
        {
            List<Order> orders = _orderRepository.ReadFromFile();
          //  OrderNumberGenerator();
            return orders;
        }

        public Order GetById(int id)
        {
            return orders.FirstOrDefault(o => o.Id == id);
        }

        //public string OrderNumberGenerator()
        //{

        //     order.OrderNumber = order.RegistrationNumber + "/" + DateTime.Now.ToString("yyyy") + "/" + order.Id.ToString();
        //    return order.OrderNumber;
        //}

        public void Create(Order order)
        {
          
            orders = GetAll();
            order.Id = GetNextId();
           // OrderNumberGenerator();
            orders.Add(order);
           _orderRepository.SaveToFile(orders);
        }
        public int GetNextId()
        {
            orderId+=1;
            return orderId;
        }
        //public SelectList GetPartNameList()
        //{
        //    string jasonFromFile = File.ReadAllText(@"..\..\..\PartList.json");
        //    parts = JsonSerializer.Deserialize<List<Part>>(jasonFromFile);


        //  return  partsList = new SelectList(parts.Select(p => p.PartName));
  
        //}

}
}

