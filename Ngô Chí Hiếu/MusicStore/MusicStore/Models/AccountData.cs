using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MusicStore.Models
{
    public class AccountData : DropCreateDatabaseIfModelChanges<AccountEntities>
    {
        protected override void Seed(AccountEntities context)
        {
            var accounts = new List<Account>
            {
                new Account {UserName = "admin",Password = "admin1"},
                new Account {UserName = "guest",Password = "guest"}
            };
            var roles = new List<AccountRole>
            {
                new AccountRole {RoleName = "admin",RoleLevel = 1},
                new AccountRole {RoleName = "khach",RoleLevel = 2}
            };
        }
    }
}