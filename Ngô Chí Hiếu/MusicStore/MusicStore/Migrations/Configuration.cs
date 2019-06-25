namespace MusicStore.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using MusicStore.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Diagnostics;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<MusicStore.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MusicStore.Models.ApplicationDbContext context)
        {

            //if (context.Users.Count() == 0)
            //{
            //    var user = new ApplicationUser()
            //    {
            //        UserName = "Hieu",
            //        Email = "Admin@gmail.com", 
            //        PasswordHash = "Hieu123456&"
            //    };

            //    context.Users.Add(user);



            //    context.SaveChanges();


            //}
            var user = new ApplicationUser()
            {
                UserName = "AdminAdmin",
                Email = "AdminAdmin@gmail.com",
                PasswordHash = "Hieu!23456"
            };
        }
    }
}
