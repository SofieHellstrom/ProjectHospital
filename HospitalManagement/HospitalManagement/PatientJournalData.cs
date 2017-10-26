using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class PatientJournalData
    {
        DatabaseHandler db = new DatabaseHandler();
        public Patient ThePatient { get; set; } 
        public Employee MyUser { get; set; }
        public List<Prescription> PrescriptionList { get; set; }

        public PatientJournalData(Patient patient, Employee user)
        {
            this.ThePatient = patient;
            this.MyUser = user;
            this.PrescriptionList = db.LoadPatientPrescriptions(this.ThePatient.Personnummer);
        }

        public void Update()
        {
            PrescriptionList = db.LoadPatientPrescriptions(ThePatient.Personnummer);
        }
    }
}
