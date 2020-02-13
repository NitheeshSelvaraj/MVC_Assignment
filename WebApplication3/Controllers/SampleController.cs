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
    }
}