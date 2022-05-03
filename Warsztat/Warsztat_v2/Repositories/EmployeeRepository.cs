﻿using Newtonsoft.Json;
using System.Diagnostics;
using Warsztat.BLL.Enums;
using Warsztat.BLL.Models;
using Warsztat_v2.Data;
using Warsztat_v2.Repositories.Interfaces;

namespace Warsztat_v2.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ServiceContext _context;

        //public List<Employee> employees { get; set; }
        //public List<Order> orders { get; set; }
        public EmployeeRepository(ServiceContext context)
        {
            _context = context;
        }
        
        public void ClearTable()
        {
            foreach (var finishedOrders in _context.Employees)
            {
                var employee = _context.Employees.First(e => e.Id == finishedOrders.Id);
                employee.FinishedOrder = 0;
            }
        }
        //public int AddFinishedOrder()
        //{
        //    var results = orders.Count();
            
        //    //var json5 = Newtonsoft.Json.JsonConvert.SerializeObject(x);
        //   //Debugger.Break();
 
        //    return results;
        //}
        //public string DisplayName()
        //{
        //    var result = orders
        //        .FirstOrDefault()
        //        .ToString();
            
        //    return result;
        //}
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Employee model)
        {
            var employee = GetById(model.Id);
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            //employee.DateOfBirth = model.DateOfBirth;
            employee.Salary = model.Salary;
            employee.Role = model.Role;
            _context.SaveChanges();
        }

       
    }

}
