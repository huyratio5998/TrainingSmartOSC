using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ajax.Models
{
    public class StudentEntities : DbContext
    {
        public StudentEntities() : base("dbStudent")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}