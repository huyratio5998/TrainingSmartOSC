using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Lab_1
{
    class Employee
    {
        public string name { get; set; }
        public int empID { get; set; }

        public Employee()
        {            
        }

        public Employee(string name, int empID)
        {
            this.name = name;
            this.empID = empID;
        }
    }
}
