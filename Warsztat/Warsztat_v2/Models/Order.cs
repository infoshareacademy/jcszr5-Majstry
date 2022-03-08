﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Warsztat_v2.Enum;
using Warsztat_v2.Enums;
using Warsztat_v2.Models;
namespace Warsztat_v2.Models
{
    public class Order
    {
    
        
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime StartTime { get; set; }
        public Status Status { get; set; }
        public string Fault { get; set; }
        public string Client { get; set; }
        public string RegistrationNumber { get; set; }

        public  Carr Car { get; set; }
        public Employee Mechanic { get; set; }
        public Part Part { get; set; }
        public int PartPcs { get; set; }
        public float Price { get; set; }
    }

}
//public List<Order> orders = new List<Order>
//        {

//            new Order()
//            {
//                Id=1,
//                OrderNumber="123",
//                StartTime=DateTime.Now,
//                Status= "Waiting",
//                Fault="COś",
//                Client = "Adam Beczka",
//                RegistrationNumber= "LLB36210",
//                Car=null,
//                Mechanic = null,
//                Part = null,
//                PartPcs = 1,
//                Price=50,

//            },
//        };
//public List<Order> GetAll()
//{
//    //List<Order> orders = _orderRepository.ReadFromFile();
//    return orders;
//}

//public Order GetById(int id)
//{
//    return orders.FirstOrDefault(o => o.Id == id);
//}


//public void Create(Order order)
//{

//    orders = GetAll();
//    order.Id = GetNextId();

//    orders.Add(order);
//    _orderRepository.SaveToFile(orders);
//}
//public int GetNextId()
//{
//    orderId += 1;
//    return orderId;
//}