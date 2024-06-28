using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAbstractDemo2
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }

        public Person(string firstName, string lastName, string job, double salary) 
        {
            FirstName = firstName;
            LastName = lastName;
            Job = job;
            Salary = salary;
        }

        public abstract double ToplamMaasHesaplama();
    }
}
