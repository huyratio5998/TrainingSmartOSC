using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerSystem.Models
{
    [Table("AspNetUsers")]
    public class AspNetUsers : IdentityUser
    {        
        public string Image { get; set; }
        public string FullName { get; set; }
        public string TaskFrID { get; set; }
        [ForeignKey("TaskFrID")]        
        public Tasks Tasks { get; set; }
        public string ProjecFrtID { get; set; }
        [ForeignKey("ProjecFrtID")]        
        public Project Project { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AspNetUsers> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
    
}
