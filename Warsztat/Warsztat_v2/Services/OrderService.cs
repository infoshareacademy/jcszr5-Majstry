using Warsztat_v2.Models;
using Warsztat_v2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Warsztat_v2.Enums;
using Warsztat_v2.Services;
using Warsztat_v2.Controllers;

namespace Warsztat_v2.Services
{
    public class OrderService
    {

        public OrderService orderService;

        private OrderRepository orderRepository;
        private List<Order> orders;
      //  public Order order;



        //Stworzone na potrzeby przypisania elementów do Order
        //private EmployeeService employeeService;
        //private List<Employee> mechanics;
        //private Employee mechanic;

        //public PartService partService;
        //public List<Part> parts;
        //public Part part;

        //private CarrService carrService;
        //private List<Carr> cars;
        //private Carr Car;

        public OrderService()
        {


            //  orders = new List<Order>(); //??
            orderRepository = new OrderRepository();
            //  orders = GetAll();
            // order.Id = orders.IndexOf(order);
            // order.OrderNumber = order.RegistrationNumber + "/" + order.StartTime.ToString("yyyy") + "/" + order.Id;


            ////Stworzone na potrzeby przypisania elementów do Order
            //employeeService = new EmployeeService();
            //mechanics = employeeService.GetAll();
            //mechanic = mechanics.FirstOrDefault();// wybór na próbe
            ////order.Mechanic = mechanic;

            //partService = new PartService();
            //parts = partService.GetAll();
            //part = parts.FirstOrDefault();// wybór na próbe
            //                              // order.Part = part;

            //carrService = new CarrService();
            //cars = carrService.GetAll();
            //Car = cars.FirstOrDefault();// wybór na próbe
            //                            //  order.Car=car;
        }

   



        //public List<Order> orders = new List<Order>
        //        {

        //            new Order()
        //            {
        //                Id=1,
        //                OrderNumber="2",
        //                StartTime=DateTime.Now,
        //                Status= Enums.Status.Waiting,
        //                Fault="COś",
        //                Client = "Adam Beczka",
        //                RegistrationNumber= "LLB345210",
        //                Car= null  ,//Czemu nie moge przypisać elemntu z listy cars
        //                Mechanic = null,//Czemu nie moge przypisać elemntu z listy mechanics
        //                Part = null,//Czemu nie moge przypisać elemntu z listy parts
        //                PartPcs = 1,
        //                Price=50,

        //            },
        //                 new Order()
        //            {
        //                Id=2,
        //                OrderNumber="2",
        //                StartTime=DateTime.Now,
        //                Status= Enums.Status.Waiting,
        //                Fault="COś",
        //                Client = "Adam Beczka",
        //                RegistrationNumber= "LLB36510",
        //                Car= null  ,//Czemu nie moge przypisać elemntu z listy cars
        //                Mechanic = null,//Czemu nie moge przypisać elemntu z listy mechanics
        //                Part = null,//Czemu nie moge przypisać elemntu z listy parts
        //                PartPcs = 1,
        //                Price=50,

        //            },
        //        };


        public string OrderNumberGenerator(Order order)
        {
            
            return order.RegistrationNumber + "/" + order.StartTime.ToString("yyyy") + "/" + order.Id.ToString();
        }
        private static int orderCounter;
        public List<Order> GetAll()
        {
           // orderRepository.SaveToFile(orders);// dodane żeby sformatować json
              List<Order> orders = orderRepository.ReadFromFile();
            return orders;
        }

        public Order GetById(int id)
        {
            orders = GetAll();
            return orders.FirstOrDefault(o => o.Id == id);
        }


        public void Create(Order order)
        {
             //orders = GetAll(); 
            order.Id = GetNextId();
            order.OrderNumber = OrderNumberGenerator(order);
            orders.Add(order);
            orderRepository.SaveToFile(orders);
        }
        public int GetNextId()
        {
            orders = GetAll();
            orderCounter = orders.Count() + 1;
            return orderCounter;
        }
        internal void Update(Order model)
        {
            var order =GetById(model.Id);
            order.RegistrationNumber = model.RegistrationNumber;
            order.StartTime = model.StartTime;
         //   order.Id = model.Id;
           // order.OrderNumber = model.OrderNumber;
            order.PartPcs = model.PartPcs;
            order.Status = model.Status;
            order.Car=model.Car;
            order.Client = model.Client;
            order.Price = model.Price;
            order.Part = model.Part;
            order.Fault = model.Fault;
            order.Mechanic = model.Mechanic;

            orderRepository.SaveToFile(orders);

        }
        internal void Delete(int id)
        {

            var order = GetById(id);
            orders.Remove(order);
            orderRepository.SaveToFile(orders);
            
        }
    }
}
