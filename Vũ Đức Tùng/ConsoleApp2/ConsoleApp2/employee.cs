using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Employee
    {


        public int EmpID;
        public string Name1;

        
    }
    public class hourlyEmployee:Employee
    {
        
        public  int calculate_result;
        public void calculate(string Name,int empID, int hourlyIncome)
        {
            base.Name1 = Name;
            base.EmpID = empID;
            this.calculate_result = hourlyIncome * 150;
        }
    }
    public class permanentEmployee : Employee
    {
        
        public int calculate_result;
        public void calculate(string Name, int empID, int hourlyIncome)
        {
            base.Name1 = Name;
            base.EmpID = empID;
            this.calculate_result = hourlyIncome * 150;
        }
    }
    //public class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        hourlyEmployee tung = new hourlyEmployee();
    //        tung.calculate("tung", 2028, 40);
    //        Console.WriteLine("ten la " + tung.Name1);
    //        Console.WriteLine("so ID la" + tung.EmpID);
    //        Console.WriteLine("so luong la " + tung.calculate_result);
    //        Console.ReadKey();
    //    }
    //}
}
