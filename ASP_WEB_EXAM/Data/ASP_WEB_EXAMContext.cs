using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_WEB_EXAM.Data
{
    public class ASP_WEB_EXAMContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ASP_WEB_EXAMContext() : base("name=ASP_WEB_EXAMContext")
        {
        }

        public System.Data.Entity.DbSet<ASP_WEB_EXAM.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ASP_WEB_EXAM.Models.Employee> Employees { get; set; }
    }
}
