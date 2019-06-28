using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AjaxDemov2.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [StringLength(255)] // độ dài cột
        [Column(TypeName = "nvarchar")] // kiểu
        [Required] // bắt buộc phải ghi
        public string Name { get; set; }
        public string Local { get; set; }
        public string StudentClass { get; set; }
    }
}