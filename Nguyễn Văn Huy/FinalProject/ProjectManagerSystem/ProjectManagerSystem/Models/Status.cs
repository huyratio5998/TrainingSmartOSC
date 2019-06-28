using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerSystem.Models
{
    [Table("Status")]
    public class Status
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatusID { get; set; }
        public string Name { get; set; }
        public string TaskFrID { get; set; }
        [ForeignKey("TaskFrID")]        
        public Tasks Tasks { get; set; }
    }
}
