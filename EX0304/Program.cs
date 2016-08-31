using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX0304
{
    class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company();
            company.employNewEmployee(new FullTimeEmployee("Milan", 4500));
            company.employNewEmployee(new PartTimeEmployee("Ivan", 250, 100));
            company.employNewEmployee(new PartTimeStudent("Jozef", 200, 100, 2016));

            Console.WriteLine("Total monthly salary: {0}", company.getMonthSalaryTotal());
            Console.ReadKey();
        }


    }
}
