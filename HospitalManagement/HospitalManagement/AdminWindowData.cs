using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class AdminWindowData
    {
        Employee MyUser;
        List<Employee> EmployeList;
        List<Department> DepartmentList;

        AdminWindowData(Employee user)
        {
            this.MyUser = user;
        }
    }
}
