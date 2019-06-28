using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerSystem.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        //   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]-- Không cần, vì khi set là Key thì auto tự tăng.
        [Key]
        public string TaskID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<AspNetUsers> Assignee { get; set; }
        public ICollection<Status> Status { get; set; }
    }
}
