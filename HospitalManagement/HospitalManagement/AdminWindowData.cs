using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class AdminWindowData
    {
        public Employee MyUser { get; set; }
        List<Employee> EmployeeList { get; set; }
        List<Department> DepartmentList { get; set; }

        public AdminWindowData(Employee user)
        {
            this.MyUser = user;
        }
    }
}
