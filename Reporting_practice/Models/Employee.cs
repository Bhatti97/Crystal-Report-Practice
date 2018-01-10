using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reporting_practice.Models
{
    public class Employee
    {
        [Key]
        public int Employee_id { get; set; }
        public string Employee_name { get; set; }
        public decimal Employee_Salary { get; set; }
        public DateTime Employee_Date_of_Join { get; set; }
    }
}