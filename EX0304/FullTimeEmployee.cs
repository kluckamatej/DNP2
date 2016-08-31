using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0304
{
    class FullTimeEmployee : Employee
    {
        private double monthSalary;

        public FullTimeEmployee(string name, double monthSalary)
            : base(name)
        {
            this.monthSalary = monthSalary;
        }
        public override double GetMonthSalary()
        {
            return monthSalary;
        }

    }
}
