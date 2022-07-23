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
            List<EmployeeModel> empList = EmployeeDAO.getEmployees();
            return View("Employee", empList);
        }
        public ActionResult create()
        {
            return View();
        }

        public ActionResult save()
        {
            return RedirectToAction("employee");
        }
    }
}