using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class PrescriptionData
    {
        DatabaseHandler db = new DatabaseHandler();
        public List<Medication> MedicationList {get; set;}
        public Patient ThePatient { get; set; }
        public Employee MyUser { get; set; }

        public PrescriptionData(Patient patient, Employee user)
        {
            this.ThePatient = patient;
            this.MyUser = user;
            this.MedicationList = db.LoadAllMedications();
        }
    }
}
