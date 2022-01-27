using System;


namespace Warstat
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
        public string FirstName { get { return firstName;} }
        public string LastName { get { return lastName;} }
        public int Age { get { return age;} }  
        public double Salary { get { return salary;} }
        public int Seniority { get { return seniority;} }


    }
}

