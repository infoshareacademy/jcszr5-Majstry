using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warsztat.Objects
{
    internal class Service : Employee
    {
        public int breewedCoffees;


        public Service (string firstName, string lastName, int age, double salary) : base(firstName, lastName, age, salary)
        {
        }


    }
}

