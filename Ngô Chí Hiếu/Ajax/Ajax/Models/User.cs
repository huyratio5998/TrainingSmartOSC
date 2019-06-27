using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
    }
}