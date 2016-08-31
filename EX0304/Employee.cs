using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0304
{
    abstract class Employee
    {
        private string name;

        public Employee(String name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract double GetMonthSalary();
    }
}
