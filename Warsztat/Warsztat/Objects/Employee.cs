using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Warsztat
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public int Age { get; set; }
        public double Salary { get; set; }

        
        
        public Employee(string firstName, string lastName, int age, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
            
        }
        //public abstract void AddEmployees();
        //public abstract void DeleteEmploye();
        //public abstract void EditEmploye(Employee employee);
        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Age},{Salary}";
        }
        public virtual void ShowEmployee(Employee employee)
        {
            Console.WriteLine($"Name: {FirstName} {LastName}.\n" +
                $"Age: {Age, -10}." +
                $"Salary: {Salary}.");
        }


        //public virtual void AddEmployees(Employee employee)
        //{

        //    Console.WriteLine("Name:");
        //    string firstName = Console.ReadLine();
        //    Console.WriteLine("Surname:");
        //    string lastName = Console.ReadLine();
        //    Console.WriteLine("Age");
        //    bool loop = true;
        //    int age = 0, money = 0, myInt;
        //    while (loop)
        //    {
        //        bool myBool = int.TryParse(Console.ReadLine(), out myInt);
        //        if (myBool && myInt > 15 && myInt < 128)
        //        {
        //            age = myInt;
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Enter the correct data");
        //        }
        //    }
        //    while (loop)
        //    {
        //        bool myBool = int.TryParse(Console.ReadLine(), out myInt);
        //        if (myBool && myInt > -1)
        //        {
        //            money = myInt;
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Enter the correct data");
        //        }
        //    }

        //    Employees.Add(new Mechanic(firstName, lastName, age, money));

        //}
    }
    

}
