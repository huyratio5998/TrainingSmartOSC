using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public List<Subject> listSubjects { get; set; }
        public Student()
        {
            this.listSubjects = new List<Subject>();
        }

        public override string ToString()
        {
            string detal = "";
            foreach (var item in listSubjects)
            {
                detal += item.ToString();
            }
            return " Ten: " + StudentName + " Gender: " + Gender + " Email: " + Email +"\n"+ detal;
        }
    }
}
