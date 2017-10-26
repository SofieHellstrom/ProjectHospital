using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Prescription
    {
        public DateTime PrescribedAt { get; set; }
        public string PrescribedBy { get; set; }
        public string PrescribedTo { get; set; }
        public string MedicineIDCode { get; set; }
        public string Instructions { get; set; }
        public int NrOfTimes { get; set; }
        public string Medication { get; set; }
    
        public Prescription(DateTime when, string doctor, string patient, string medCode, string instruct, int nr, string medicine)
        {
            this.PrescribedAt = when;
            this.PrescribedBy = doctor;
            this.PrescribedTo = patient;
            this.MedicineIDCode = medCode;
            this.Instructions = instruct;
            this.NrOfTimes = nr;
            this.Medication = medicine; 
        }
    }
}
