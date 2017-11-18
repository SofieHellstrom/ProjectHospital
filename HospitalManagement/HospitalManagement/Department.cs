using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Department
    {
        public string DepartmentID { get; set; }
        public string Name { get; set; }
        public TimeSpan Opens { get; set; }
        public TimeSpan Closes { get; set; }

        public Department (string id, string name, TimeSpan open, TimeSpan close)
        {
            this.DepartmentID = id;
            this.Name = name;
            this.Opens = open;
            this.Closes = close;
        }

        public Boolean UpdateSelfInDB()
        {
            DatabaseHandler db = new DatabaseHandler();
            return db.UpdateDepartment(this);
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public override bool Equals(object obj)
        {
            //Compare method for Departments.
            //Returns false if the object passe is null or not a Department
            if (!(obj is Department) || obj == null) return false;
            
            Department d = obj as Department;
            if (!d.DepartmentID.Equals(this.DepartmentID)) return false;
            if (!d.Name.Equals(this.Name)) return false;
            if (d.Opens != this.Opens) return false;
            if (d.Closes != this.Closes) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
