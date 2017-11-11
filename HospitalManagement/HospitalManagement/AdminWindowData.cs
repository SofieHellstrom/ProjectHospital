using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class AdminWindowData
    {
        DatabaseHandler db = new DatabaseHandler();
        public Employee MyUser { get; set; }
        public List<Employee> EmployeeList { get; set; }
        public List<Department> DepartmentList { get; set; }

        public AdminWindowData(Employee user)
        {
            this.MyUser = user;
            this.EmployeeList = db.LoadAllEmployees();
            this.DepartmentList = db.LoadAllDepartments();
        }
    }
}
