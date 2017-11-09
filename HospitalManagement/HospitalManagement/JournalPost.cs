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
        public string ShortDescription { get; set; }

        public JournalPost (DateTime whenCreated, string employeeID, string patID, string nType, string noteText, bool imp)
        {
            DatabaseHandler db = new DatabaseHandler();
            this.TimeCreated = whenCreated;
            this.Creator = db.LoadEmployee(employeeID);
            this.PatientID = patID;
            this.NoteType = nType;
            this.Content = noteText;
            this.Important = imp;
            this.ShortDescription = this.ToShortString();
        }

        public override string ToString()
        {
            string returnString = "";
            if (Important)
            {
                returnString += "<!>"; 
            }
            returnString += TimeCreated.ToString("yy-MM-dd HH:mm:ss");
            returnString += $" {Creator.LastName} ({Creator.EmployeeID}): {Content}"; 
            return returnString;
        }

        public string ToShortString()
        {
            return $"{Creator.LastName} ({Creator.EmployeeID}): {Content}";
        }
    }
}
