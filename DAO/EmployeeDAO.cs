using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DAO
{
    internal class EmployeeDAO
    {
        SqlConnection conn = null;
        DBConnection dbc;
        SqlCommand cmd;
        SqlDataReader reader;

        public List<EmployeeModel> FetchEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            string sql_fetchEmployees = @"select e.nic, e.fname, e.lname, e.house_no, e.address, e.dob, e.age, e.gender from [dbo].[employee] e;";
            dbc = new DBConnection();

            using (conn = dbc.GetConnection())
            {
                cmd = new SqlCommand(sql_fetchEmployees, conn);
                conn.Open();
                reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while (reader.Read())
                    {
                        EmployeeModel employee = new EmployeeModel();
                        employee.nic = reader.GetString(0);
                        employee.fName = reader.GetString(1);
                        employee.lName = reader.GetString(2);
                        employee.houseNo = reader.GetString(3);
                        employee.address = reader.GetString(4);
                        employee.dob = Convert.ToDateTime(reader["dob"]).ToString("dd/MM/yyy");
                        employee.age = reader.GetInt32(6);
                        employee.gender = reader.GetString(7);

                        employees.Add(employee);
                    }
                }
            }

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