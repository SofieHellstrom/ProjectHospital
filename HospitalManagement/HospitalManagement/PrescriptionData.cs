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

        public PrescriptionData(Patient patient)
        {
            this.ThePatient = patient;
            this.MedicationList = db.LoadAllMedications();
        }
    }
}
