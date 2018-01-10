using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reporting_practice.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("default")
        {

        }

        public System.Data.Entity.DbSet<Reporting_practice.Models.Employee> Employees { get; set; }
    }
}