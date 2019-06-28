using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxDemov2.Models
{
    public class StudentContext : DbContext
    {

        // 1. Enable-Migrations
        // 2. Add-Migration
        // 3. Update-Database
        public StudentContext() : base("StudentDB")
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}