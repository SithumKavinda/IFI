using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class EmployeeModel
    {
        public string nic { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string houseNo { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public int postalCode { get; set; }
        public string dob { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string joinedDate { get; set; }
        public double payRate { get; set; }

        public EmployeeModel()
        {
        }

        public EmployeeModel(string nic, string fName, string lName, string houseNo, string address, string city, int postalCode, string dob, int age, string gender, string joinedDate, double payRate)
        {
            this.nic = nic;
            this.fName = fName;
            this.lName = lName;
            this.houseNo = houseNo;
            this.address = address;
            this.city = city;
            this.postalCode = postalCode;
            this.dob = dob;
            this.age = age;
            this.gender = gender;
            this.joinedDate = joinedDate;
            this.payRate = payRate;
        }

    }
}