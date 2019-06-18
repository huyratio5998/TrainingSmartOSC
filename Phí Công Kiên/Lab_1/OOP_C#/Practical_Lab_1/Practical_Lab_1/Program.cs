using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourlyEmployee = new HourlyEmployee()
            {
                hourlyIncome = 100,
                empID = 1,
                name = "long"
            };

            Console.WriteLine(hourlyEmployee.ToString());

            hourlyEmployee.calculate_the_hourly_income();

            Console.WriteLine("\n--------------------------------------------------------------------------\n");

            PermanentEmployee permanentEmployee = new PermanentEmployee()
            {
                hourlyIncome = 150,
                name = "Vui",
                empID = 2
            };

            Console.WriteLine(permanentEmployee.ToString());
            permanentEmployee.calculate_the_income();

            Console.ReadKey();
        }
    }
}
