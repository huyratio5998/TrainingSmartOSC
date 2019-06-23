using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class AccountRole
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int RoleLevel { get; set; }
        public string UserName { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}