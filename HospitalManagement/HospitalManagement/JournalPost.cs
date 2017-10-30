using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class JournalPost
    {
        public DateTime TimeCreated { get; set; }
        public Employee Creator { get; set; }
        public string PatientID { get; set; }
        public string NoteType { get; set; }
        public string Content { get; set; }
        public bool Important { get; set; }

        public JournalPost (DateTime whenCreated, string employeeID, string patID, string nType, string noteText, bool imp)
        {
            DatabaseHandler db = new DatabaseHandler();
            this.TimeCreated = whenCreated;
            this.Creator = db.LoadEmployee(employeeID);
            this.PatientID = patID;
            this.NoteType = nType;
            this.Content = noteText;
            this.Important = imp;
        }

        public override string ToString()
        {
            return $"{Creator.LastName} ({Creator.EmployeeID}): {Content}";
        }
    }
}
