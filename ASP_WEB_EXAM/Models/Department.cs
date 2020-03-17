using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_WEB_EXAM.Models
{
    public class Department
    {
        [Key]
        public String DepartmentId { get; set; }
        [Required]
        public String DepartmentName { get; set; }

    }
}