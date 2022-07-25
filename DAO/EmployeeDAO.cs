using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DAO
{
    internal class EmployeeDAO
    {
        public List<EmployeeModel> FetchEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            // Get data from employee table and assign to above list
            //using (resource)
            //{
            //    // DB Connection will use inside of this code block
            //}

            return employees;
        } 

        public void register(EmployeeModel employee)
        {
            string query_emp = "insert into [dbo].[employee] values (@nic, @fname, @lname, @houseNo, @address, @city, @zip, @dob, @age, @gender, @dateJoined, @rate);";
            string query_contact = "insert into [dbo].[contact] values (@nic, @tp, @type);";

            // get data from employee, assign them to query and exceute the query
        }

        public EmployeeModel getEmployee()
        {
            EmployeeModel employee = new EmployeeModel();

            // get data from DB and assign them to above instant of EmployeeModel

            return employee;
        }
    }
}