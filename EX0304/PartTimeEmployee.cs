using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0304
{
    class PartTimeEmployee : Employee
    {
        private double hourlyWage;
        private int hoursPrMonth;

        public PartTimeEmployee(string name, double hourlyWage, int hoursPrMonth)
            : base(name)
        {
            this.hoursPrMonth = hoursPrMonth;
            this.hourlyWage = hourlyWage;
        }
        public override double GetMonthSalary()
        {
            return (hourlyWage * hoursPrMonth);
        }
    }
}
