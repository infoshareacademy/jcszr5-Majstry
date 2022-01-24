using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat
{
    public class Worker
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        private int seniority;

        public Worker(string firstName, string lastName, int age, double salary, int seniority)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            this.seniority = seniority;
        }

       public Worker()
        {
            // nie wiem o co z tym chodzi ale jak sie chce wywołać funkcje w innej klasie bez podawania jej parametrów to VS podpowiada Create constructor in Klasa
        }

        public string FirstName { get ;/*{ return firstName;}*/ set; }// zmodyfikowałem dodając seta na potrzeby metody AddMechanic()
        public string LastName { get; /*{ return lastName;}*/ set; } // zmodyfikowałem dodając seta na potrzeby metody AddMechanic()
        public int Age { get { return age;} } 
        public double Salary { get { return salary;} }
        public int Seniority { get { return seniority;} }


    }

}
