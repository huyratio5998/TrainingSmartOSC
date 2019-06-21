using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MusicStore.Models
{
    public class AccountEntities : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> Roles { get; set; }
    }
}