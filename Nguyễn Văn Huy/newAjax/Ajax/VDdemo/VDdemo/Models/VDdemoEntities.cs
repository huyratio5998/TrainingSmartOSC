using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VDdemo.Models
{
    public class VDdemoEntities : DbContext
    {
        public VDdemoEntities() : base("VdAjax")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<User> users { get; set; }
    }
}