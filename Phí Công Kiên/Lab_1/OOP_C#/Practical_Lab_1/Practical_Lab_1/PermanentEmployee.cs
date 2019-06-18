using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_1
{
    class PermanentEmployee : Employee
    {
        public float hourlyIncome { get; set; }

        public PermanentEmployee()
        {

        }
        public PermanentEmployee(float hourlyIncome, string name, int empID)
        {
            this.hourlyIncome = hourlyIncome;
            base.empID = empID;
            base.name = name;
        }

        public void calculate_the_income()
        {
            float income = 240 * 150;
            Console.WriteLine("The income: {0}", income);

        }
        public override string ToString()
        {
            return "Employee ID: " + empID + " | " + "Name: " + name + " | " + "Hourly income: " + hourlyIncome;
        }
    }
}
