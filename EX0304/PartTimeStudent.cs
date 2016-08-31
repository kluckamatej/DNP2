using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0304
{



    class PartTimeStudent : Employee, IStudent
    {

        int year = 0;
        private double hourlyWage;
        private int hoursPrMonth;

        public PartTimeStudent(string name, double hourlyWage, int hoursPrMonth, int year)
            : base(name)
        {
            this.hoursPrMonth = hoursPrMonth;
            this.hourlyWage = hourlyWage;
            this.year = year;
        }

        public override double GetMonthSalary()
        {
            return (hourlyWage * hoursPrMonth);
        }

        public virtual void Register(int year)
        {
            this.year = year;
        }

    }
}
