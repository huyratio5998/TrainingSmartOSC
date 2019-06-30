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
    //        string a, status = "";
    //        int c, b;

    //        do
    //        {
    //            Console.WriteLine("nhap ten nhan vien");

    //            a = Convert.ToString(Console.ReadLine());
    //            Console.WriteLine("nhap id nhan vien");
    //            b = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("nhap so gio lam");
    //            c = Convert.ToInt32(Console.ReadLine());
    //            if (c < 0)
    //            {
    //                Console.WriteLine("ban nhap sai");
    //                continue;
    //            }
    //            Console.WriteLine("ban muon nhap nua khong Y/N");
    //            status = Convert.ToString(Console.ReadLine());
    //        } while ((status != "N") && (status != "n") && (status != "no") && (status != "NO"));
    //        tung.calculate(a, b, c);
    //        Console.WriteLine("ten la " + tung.Name1);
    //        Console.WriteLine("so ID la" + tung.EmpID);
    //        Console.WriteLine("so luong la " + tung.calculate_result);
    //        Console.ReadKey();
    //    }
    //}
}
