using OnlineLeaveManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLeaveManagement.DAL
{
    public class EmployeeRepository
    {
        public static List<Employee> employeeList = new List<Employee>();
        public IEnumerable<Employee> GetEmployeeDetails()
        {
            return employeeList;
        }
        public void AddEmployee(Employee employeeDetails)
        {
            employeeList.Add(employeeDetails);
        }

    }
}
