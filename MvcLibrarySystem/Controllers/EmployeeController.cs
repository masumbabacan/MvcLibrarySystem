using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLibrarySystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        EmployeeManager employeeManager = new EmployeeManager(new EfEmployeeDal());
        public ActionResult Index()
        {
            var employees = employeeManager.GetAll();
            return View(employees);
        }

        [HttpGet]
        public ActionResult EmployeeAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeAdd(Employee employee)
        {
            employeeManager.Add(employee);
            return RedirectToAction("Index");
        }

        public ActionResult EmployeeDelete(int id)
        {
            var values = employeeManager.GetById(id);
            employeeManager.Delete(values);
            return RedirectToAction("Index");
        }

        public ActionResult EmployeeBring(int id)
        {
            var values = employeeManager.GetById(id);
            return View("EmployeeBring", values);
        }

        public ActionResult EmployeeUpdate(Employee employee)
        {
            employeeManager.Update(employee);
            return RedirectToAction("Index");
        }
    }
}