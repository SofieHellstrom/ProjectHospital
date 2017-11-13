using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class AdminWindowData
    {
        DatabaseHandler db = new DatabaseHandler();
        public Employee MyUser { get; set; }
        public BindingList<Employee> EmployeeBindingList { get; set; }
        public List<Department> DepartmentList { get; set; }
        public Dictionary<string, string> SpecialtyDictionary { get; set; }

        public AdminWindowData(Employee user)
        {
            this.MyUser = user;
            UpdateData();
        }

        public void UpdateData()
        {
            this.EmployeeBindingList = new BindingList<Employee>(db.LoadAllEmployees());
            DepartmentList = db.LoadAllDepartments();
            SpecialtyDictionary = db.LoadSpecialtyDictionary();
        }
    }
}
