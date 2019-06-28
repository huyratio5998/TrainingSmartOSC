using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VDdemo.Models
{
    public class Student
    {

        public Student(string name, int age, string gender, string email, string phone)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Email = email;
            Phone = phone;
        }

        public int ID { get; set; }        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}