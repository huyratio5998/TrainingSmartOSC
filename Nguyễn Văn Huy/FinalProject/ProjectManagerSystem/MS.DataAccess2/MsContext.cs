using Microsoft.AspNet.Identity.EntityFramework;
using ProjectManagerSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.DataAccess
{  
        public class MsContext : IdentityDbContext
        {
            public MsContext() : base("ProjectManagerSystem")
            {

            }
            public DbSet<AspNetUsers> aspNetUsers { get; set; }
            public DbSet<Project> projects { get; set; }
            public DbSet<Status> statuses { get; set; }
            public DbSet<Tasks> tasks { get; set; }
        public static MsContext Create()
        {
            return new MsContext();
        }
    }
}
