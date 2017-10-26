using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class PatientJournalData
    {
        DatabaseHandler db;
        public Patient ThePatient { get; set; } 
        public Employee MyUser { get; set; }

        public PatientJournalData(Patient patient, Employee user)
        {
            this.db = new DatabaseHandler();
            this.ThePatient = patient;
            this.MyUser = user;

        }
    }
}
