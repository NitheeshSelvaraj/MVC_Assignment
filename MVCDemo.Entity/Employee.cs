using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.Entity
{
    public class Employee
    {
        public int empId { get; set; }
        [Required]
        public string empName{get; set;}
        [Required]
        public string role { get; set; }
    }
}
