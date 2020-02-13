using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDemo.Entity;

namespace MVCDemo.DAL
{
    public class EmployeeRepository
    {
        static List<Employee> employeeList = new List<Employee>();
        static EmployeeRepository()
        {
            employeeList.Add(new Employee { empId = 21, empName = "Ram" });
            employeeList.Add(new Employee { empId = 22, empName = "Ravi" });
        }
        public static IEnumerable<Employee> Display()
        {
            return employeeList;
        } 
    }
}
