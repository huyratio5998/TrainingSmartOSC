using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VDdemo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
    }
}