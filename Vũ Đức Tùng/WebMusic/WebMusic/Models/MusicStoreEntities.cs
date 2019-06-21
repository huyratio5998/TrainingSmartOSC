using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMusic.Models
{
    public class MusicStoreDb:DbContext
    {
        // 1. Enable-Migrations
        // 2. Add-Migration
        // 3. Update-Database
        public MusicStoreDb() : base("EmployeeConnectionString")
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
        public  DbSet<Artist> Artists { get; set; }
        
    }
}