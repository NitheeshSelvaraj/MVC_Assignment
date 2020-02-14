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
            employeeList.Add(new Employee { empId = 21, empName = "Ram" ,role="Programmer"});
            employeeList.Add(new Employee { empId = 22, empName = "Ravi",role="Testing" });
            employeeList.Add(new Employee { empId = 23, empName = "Rajesh", role = "Testing" });
        }
        public static IEnumerable<Employee> Display()
        {
            return employeeList;
        } 
        public void Add(Employee employee)
        {
            employeeList.Add(employee);
        }
        public void Delete(int empId)
        {
            Employee employee = GetEmployeeById(empId);
            if (employee != null)
                employeeList.Remove(employee);
        }
        public void Update(Employee employee)
        {
            Employee employeedetail = employeeList.Find(id => id.empId == employee.empId);
            employeedetail.empName = employee.empName;
            employeedetail.role = employee.role;
        }
        public Employee GetEmployeeById(int empId)
        {
            return employeeList.Find(id => id.empId == empId);
        }

    }
}
