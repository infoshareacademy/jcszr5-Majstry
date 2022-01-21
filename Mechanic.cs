using System;


namespace Majstry
{
    public class Mechanic : Worker
    {
        public readonly string specialization;//myslalem o fiat bmw itp
        public readonly int repairMade;
        public readonly int complaints;

        public Mechanic(string specialization, int repairMade, int complaints)
        {
            this.specialization = specialization;
            this.repairMade = repairMade;
            this.complaints = complaints;
        }

        public Mechanic(string firstName, string lastName, int age, double salary, int seniority) : base(firstName,lastName,age,salary,seniority)
        {
            

        }
    }
}