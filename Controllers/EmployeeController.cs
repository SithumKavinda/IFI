using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Vidly.Models;
using Vidly.DAO;

namespace Vidly.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Employee()
        {
            EmployeeDAO EmployeeDAO = new EmployeeDAO();
            List<EmployeeModel> empList = EmployeeDAO.FetchEmployees();
            return View("Employee", empList);
        }

        public ActionResult Details(string id)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            EmployeeModel employee = employeeDAO.GetEmployee(id);
            return View("details", employee);
        }

        public ActionResult Edit(string id)
        {
            return RedirectToAction("create");
        }

        public ActionResult create()
        {
            return View("create");
        }

        public ActionResult Close()
        {
            return RedirectToAction("Employee");
        }
    }
}