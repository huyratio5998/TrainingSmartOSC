using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Employee
    {
        private string name;
        private int empID;        
        public string Name { get { return name; } set { name = value; } }
        public int EmpID { get { return empID; } set { empID = value; } }

    }
    class HourlyEmployee: Employee
    {
        private double hourlyIncome;
        public HourlyEmployee(string Name, int EmpID, double HourlyIncome)
        {
            base.Name = Name;
            base.EmpID = EmpID;
            this.hourlyIncome = HourlyIncome;
        }
        public void calculate_the_hourly_income()
        {
            double salary = hourlyIncome * 150;
            Console.WriteLine("Salary of hourly_employee: "+salary);
        }        
    }
    class PermanentEmployee:Employee
    {
        private double hourlyIncome;
        public PermanentEmployee(string Name, int EmpID, double HourlyIncome)
        {
            base.Name = Name;
            base.EmpID = EmpID;
            hourlyIncome = HourlyIncome;
        }
        public void calculate_the_income()
        {
            double salary = 240 * 150;
            Console.WriteLine("Salary of permanentEmployee: " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee HE = new HourlyEmployee("Nguyễn Văn Huy", 2030,100);
            HE.calculate_the_hourly_income();
            PermanentEmployee PE = new PermanentEmployee("Kiều Hoàng Nghiệp", 1111, 50);
            PE.calculate_the_income();
        }
    }
}
