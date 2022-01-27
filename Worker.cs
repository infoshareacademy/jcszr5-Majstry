using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Warstat
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public int Seniority { get; set; }
        public List<Worker> Workers { get; set; };

        public Worker(string firstName, string lastName, int age, double salary, int seniority)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            this.seniority = seniority;
        }

        

        public List<Worker> AddWorker()
        {
            Console.WriteLine("Enter name");
            Console.Line()
            System.Console.WriteLine("Enter lastname");

            Worker worker = new Worker()

                Workers.Add(worker);
                return Workers;
        }


    }
}

