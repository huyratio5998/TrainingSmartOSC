using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagerSystem.Models
{
    [Table("Projects")]
    public class Project
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProjectID { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }        
        public IEnumerable<AspNetUsers> lstUser { get; set; }
        public string TaskFrID { get; set; }
        [ForeignKey("TaskFrID")]        
        public Tasks Tasks { get; set; }

    }
}
