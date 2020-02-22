using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLeaveManagement.Entity
{
    //public enum Gender
    //{
        //male,
        //female
    //}
    public class Employee
    {
        [Required(ErrorMessage= "Please enter student name.")]
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public long EmployeePhoneNumber { get; set; }
        [Required(ErrorMessage = "Age is Required")]
        public short Age { get; set; }
        public string Gender { get; set; }
        public Employee()
        {

        }
        public Employee(string EmployeeName, int EmployeeId, long EmployeePhoneNumber,short Age,string Gender,string Designation)
        {
            this.EmployeeName = EmployeeName;
            this.EmployeeId = EmployeeId;
            this.EmployeePhoneNumber = EmployeePhoneNumber;
            this.Age = Age;
            this.Gender = Gender;
        }
    }
}

