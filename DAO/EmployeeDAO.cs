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
        SqlConnection conn;
        DBConnection database;

        public List<EmployeeModel> FetchEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();
            string sql_fetchEmployees = @"select e.nic, e.fname, e.lname, e.house_no, e.address, e.dob, e.age, e.gender from [dbo].[employee] e;";
            database = new DBConnection();

            try
            {
                using (conn = database.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(sql_fetchEmployees, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
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
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return employees;
        }

        public EmployeeModel GetEmployee(string nic)
        {
            EmployeeModel employee = new EmployeeModel();
            DBConnection DBConnection = new DBConnection();

            // SQL queries
            string sql_getEmp = "select e.nic, e.fname, e.lname, e.house_no, e.address, e.city, e.postal_code, e.dob, e.age, e.gender, e.joined_date, e.payrate, c.phone as mobile, (select c.phone from [dbo].[contact] c where c.nic = @nic and c.contact_type = 'home') as home from [dbo].[employee] e inner join [dbo].[contact] c on e.nic = c.nic where e.nic = @nic and c.contact_type = 'mobile';";

            try
            {
                // SQL DB Connection
                SqlConnection con = DBConnection.GetConnection();

                // SQL command
                SqlCommand cmd = new SqlCommand(sql_getEmp, con);

                // Initiate SQL variables
                cmd.Parameters.Add("@nic", System.Data.SqlDbType.VarChar).Value = nic;

                con.Open();

                // Execute query and read data
                SqlDataReader reader_emp = cmd.ExecuteReader();

                // Assign data to Employee object
                if(reader_emp.Read())
                {
                    employee.nic = reader_emp["nic"].ToString();
                    employee.fName = reader_emp["fname"].ToString();
                    employee.lName = reader_emp["lname"].ToString();
                    employee.houseNo = reader_emp["house_no"].ToString();
                    employee.address = reader_emp["address"].ToString();
                    employee.city = reader_emp["city"].ToString();
                    employee.postalCode = Convert.ToInt32(reader_emp["postal_code"]);
                    employee.dob = Convert.ToDateTime(reader_emp["dob"]).ToString("dd/MM/yyy");
                    employee.age = Convert.ToInt32(reader_emp["age"]);
                    // Assign Gender
                    string gender = reader_emp["gender"].ToString();
                    
                    if(gender.Equals("M") || gender.Equals("m"))
                    {
                        employee.gender = "male";
                    } 
                    else if(gender.Equals("F") || gender.Equals("f"))
                    {
                        employee.gender = "female";
                    }

                    employee.joinedDate = Convert.ToDateTime(reader_emp["joined_date"]).ToString("dd/MM/yyy");
                    employee.payRate = Convert.ToDouble(reader_emp["payrate"]);
                    employee.phoneNo_mobile = reader_emp["mobile"].ToString();
                    employee.phoneNo_home = reader_emp["home"].ToString();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            return employee;
        }

        public bool RemoveEmployee(string nic)
        {
            bool status = false;

            // Process

            return status;
        }
    }
}