using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP_WEB_EXAM.Models
{
    public class Employee
    {
        [Key]
        public String id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public double Salary { get; set; }
        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        public virtual Department Department { get; set; }

    }
}