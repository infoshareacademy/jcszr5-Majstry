using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public abstract class Employee
    {
        public string FirstName { get; set; }// zmodyfikowałem dodając seta na potrzeby metody AddMechanic()
        public string LastName { get; set; } // zmodyfikowałem dodając seta na potrzeby metody AddMechanic()
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, int age, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
    }

}
