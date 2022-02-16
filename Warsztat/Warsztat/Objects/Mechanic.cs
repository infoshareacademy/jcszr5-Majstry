using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Warsztat
{
    public class Mechanic : Employee
    {
        public int repairCount;


        public Mechanic(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age, salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;

        }

        public override void ShowEmployee(Employee employee)
        {
            
            Console.WriteLine($"Name: {FirstName} {LastName}.\n" +
                $"Age: {Age,10}.\n" +
                $"Salary: {Salary, 8}.");
        }


    }
}
