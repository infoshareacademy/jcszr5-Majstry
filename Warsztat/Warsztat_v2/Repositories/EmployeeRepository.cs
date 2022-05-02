using Newtonsoft.Json;
using System.Diagnostics;
using Warsztat.BLL.Enums;
using Warsztat.BLL.Models;
using Warsztat_v2.Data;
using Warsztat_v2.Repositories.Interfaces;

namespace Warsztat_v2.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public ServiceContext Context { get; set; }
        public List<Employee> employees { get; set; }
        public List<Order> orders { get; set; }
        public EmployeeRepository(ServiceContext context)
        {
            Context = context;
            employees = Context.Employees.ToList();
            orders = Context.Orders.ToList();
            //var postAll = blogs.SelectMany(b => b.Posts).Select(b => b.Subject).Distinct();
            //var json1 = Newtonsoft.Json.JsonConvert.SerializeObject(postAll);
            
        }
        
        public int AddFinishedOrder()
        {
            
            var results = orders.Where(o => o.Status == Status.Finished)
                .GroupBy(o => o.MechanicId)
                .OrderByDescending(o => o.Count())
                .First().ToList().Count();
            
            //var json5 = Newtonsoft.Json.JsonConvert.SerializeObject(x);
           //Debugger.Break();
 
            return results;
        }
        public string DisplayName()
        {
            var result = orders.Where(o => o.Status == Status.Finished)
                .GroupBy(o => o.MechanicId)
                .OrderByDescending(o => o.Count())
                .FirstOrDefault()
                .Select(o => o.Mechanic.FullName)
                .Distinct()
                .FirstOrDefault()
                .ToString();
            
            return result;
        }
        public void Add(Employee employee)
        {
            Context.Employees.Add(employee);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            Context.Employees.Remove(employee);
            Context.SaveChanges();
        }

        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public void Update(Employee model)
        {
            var employee = GetById(model.Id);
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            //employee.DateOfBirth = model.DateOfBirth;
            employee.Salary = model.Salary;
            employee.Role = model.Role;
            Context.SaveChanges();
        }

       
    }

}
