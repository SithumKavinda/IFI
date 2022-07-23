using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DAO
{
    public class EmployeeDAO
    {
        public List<EmployeeModel> getEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees.Add(new EmployeeModel("992993553v", "sithum", "kavinda", "58/40/a", "hiripitiya, pannipitiya", "kottawa", 10232, "1999-10-25", 23, "Male", (DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day), 2500.00));
            employees.Add(new EmployeeModel("992993553v", "sithum", "kavinda", "58/40/a", "hiripitiya, pannipitiya", "kottawa", 10232, "1999-10-25", 23, "Male", (DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day), 2500.00));
            employees.Add(new EmployeeModel("992993553v", "sithum", "kavinda", "58/40/a", "hiripitiya, pannipitiya", "kottawa", 10232, "1999-10-25", 23, "Male", (DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day), 2500.00));
            employees.Add(new EmployeeModel("992993553v", "sithum", "kavinda", "58/40/a", "hiripitiya, pannipitiya", "kottawa", 10232, "1999-10-25", 23, "Male", (DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day), 2500.00));
            employees.Add(new EmployeeModel("992993553v", "sithum", "kavinda", "58/40/a", "hiripitiya, pannipitiya", "kottawa", 10232, "1999-10-25", 23, "Male", (DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day), 2500.00));
            employees.Add(new EmployeeModel("992993553v", "sithum", "kavinda", "58/40/a", "hiripitiya, pannipitiya", "kottawa", 10232, "1999-10-25", 23, "Male", (DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day), 2500.00));

            return employees;
        } 
    }
}