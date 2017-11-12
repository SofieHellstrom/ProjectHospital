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

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
