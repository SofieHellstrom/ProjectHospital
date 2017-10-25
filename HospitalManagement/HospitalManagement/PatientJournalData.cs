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

        public PatientJournalData(Patient patient)
        {
            this.db = new DatabaseHandler();
            this.ThePatient = patient;

        }
    }
}
