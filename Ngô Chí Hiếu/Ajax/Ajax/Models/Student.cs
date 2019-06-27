using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class Student
    {


        public int ID { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


        public Student(string name, int age, string gender, string email, string phone)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Email = email;
            this.Phone = phone;
        }
    }
}