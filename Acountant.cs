using System;

namespace Warstat
{
    public class Acountant : Worker
    {
        public readonly string education;
        public readonly bool certyficate;

        public Acountant(string education, bool certyficate)
        {
            this.education = education;
            this.certyficate = certyficate;
        }

        public Acountant(string firstName, string lastName, int age, double salary, int seniority, string education, bool certyficate) : base(firstName, lastName, age, salary, seniority)
        {
            
        }

    }
}

