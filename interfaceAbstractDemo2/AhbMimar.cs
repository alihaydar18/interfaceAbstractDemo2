﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAbstractDemo2
{
    public class AhbMimar : Person, IMimar
    {
        public AhbMimar(string firstName, string lastName, string job, double salary) : base(firstName, lastName, job, salary)
        {
        }

        public override double ToplamMaasHesaplama()
        {
            return Salary + 3000;
        }
    }
}