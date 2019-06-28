using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProjectManagerSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerSystem
{
    
    public class MsContext: IdentityDbContext
    {
        public  MsContext() : base("ProjectManagerSystem"){

        }
       
        public DbSet<AspNetUsers> aspNetUsers { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Task> tasks { get; set; }

    }
}
