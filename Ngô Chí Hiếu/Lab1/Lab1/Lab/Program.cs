using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        class Employee
        {
           

            public int emID { get; set; }
            public string name { get; set; }

            public Employee()
            {
                    
            }

            public Employee(int emID, string name)
            {
                this.emID = emID;
                this.name = name;
            }
        }

        class HourlyEmployee : Employee
        {
            public double hourlyIncome { get; set; }

            public HourlyEmployee()
            {

            }

            public HourlyEmployee(int emID, string name, double hourlyIncome)
            {
                this.hourlyIncome = hourlyIncome;
                base.emID = emID;
                base.name = name;
            }

            public void Calculate_the_hourly_income(double hourlyIncome)
            {
                hourlyIncome *= 140;
                Console.WriteLine("| The hourly income = {0}", hourlyIncome);
            }

            public string ToString()
            {
                return "Employee ID: " + emID + "| Name: " + name + "| Hourly income: " + hourlyIncome;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Moi nhap id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Moi nhap id: ");
            string name = Console.ReadLine();

            Console.WriteLine("Moi nhap id: ");
            double income = double.Parse(Console.ReadLine());

            HourlyEmployee h = new HourlyEmployee(id,name, income);
            Console.WriteLine(h.ToString());
            h.Calculate_the_hourly_income(h.hourlyIncome);
            Console.ReadKey();

        }
    }
}
