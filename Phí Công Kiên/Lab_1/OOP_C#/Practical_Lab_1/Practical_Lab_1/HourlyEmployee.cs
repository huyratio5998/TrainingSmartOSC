using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_1
{
    class HourlyEmployee : Employee
    {
        public float hourlyIncome { get; set; }

        public HourlyEmployee()
        {

        }

        public HourlyEmployee(float hourlyIncome, string name, int empID)
        {
            this.hourlyIncome = hourlyIncome;
            base.empID = empID;
            base.name = name;
        }

        public void calculate_the_hourly_income()
        {
            float f = this.hourlyIncome * 150;
            Console.WriteLine("The hourly income: {0} * {1} = {2};", this.hourlyIncome, 150, f);
        }

        public string ToString()
        {
            return "Employee ID: " + this.empID + " | " + "Name: " + this.name + " | " + "Hourly income: " + this.hourlyIncome;
        }
    }
}
