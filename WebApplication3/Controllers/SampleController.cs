using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Entity;
using MVCDemo.DAL;

namespace WebApplication3.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        EmployeeRepository employeeRepository = new EmployeeRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Demo()
        {
            return View();
        }
        public ActionResult ViewEmployee()
        {
            IEnumerable<Employee> employeeDetails = EmployeeRepository.Display();
            ViewBag.Details = employeeDetails;
            ViewData["Details"] = employeeDetails;
            TempData["Details"] = employeeDetails;
            return View();
        }
        [HttpGet]
        [ActionName("AddEmployee")]
        public ActionResult AddEmployee_get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("AddEmployee")]
        public ActionResult AddEmployee_post()
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                UpdateModel<Employee>(employee);
                employeeRepository.Add(employee);
                TempData["Details"] = "Employee Added";
                return RedirectToAction("ViewEmployee");
            }
            return View();
        }
        //public ActionResult AddEmployee_post()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Employee employee = new Employee();
        //        TryUpdateModel<Employee>(employee);
        //        employeeRepository.Add(employee);
        //        TempData["Details"] = "Employee Added";
        //        return RedirectToAction("ViewEmployee");
        //    }
        //    return View();
        //}
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee employee = employeeRepository.GetEmployeeById(id);
            return View(employee);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            employeeRepository.Delete(id);
            TempData["Details"] = "Employee Removed";
            return RedirectToAction("ViewEmployee");
        }
        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Update(employee);
                TempData["Details"] = "Employee Updated";
                return RedirectToAction("ViewEmployee");
            }
            return View("Edit", employee);
        }
    }
}