using OnlineLeaveManagement.DAL;
using OnlineLeaveManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineLeaveManagementSystem.Controllers
{
   
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        [ErrorHandle()] 
        public ViewResult ErrorHandling()
        {
            throw new Exception("There should be error. Wrong Message");
        }
            
        EmployeeRepository employeeRepository;
        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }
        public ActionResult Display()
        {
            IEnumerable<Employee> employees = employeeRepository.GetEmployeeDetails();
            return View(employees);
        }
        
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.AddEmployee(employee);
                TempData["Message"] = "Employee added";
                return RedirectToAction("Display");
            }
            return View(employee);
        }


    }
}