using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    class PatientViewData
    {
        DatabaseHandler db = new DatabaseHandler();
        public Patient Me { get; set; }
        public List<Prescription> PrescriptionList { get; set; }
        public List<JournalPost> JournalPostList { get; set; }
        //public List<JournalPost> AllergyList { get; set; }
        public List<JournalPost> NotesList { get; set; }
        public List<Booking> BookingList { get; set; }
        public DateTime LatestSignedIn { get; set; }
        public DateTime LatestSignedOut { get; set; }

        public PatientViewData(Patient patient, Employee user)
        {
            this.Me = patient;
            this.PrescriptionList = db.LoadPatientPrescriptions(this.Me.Personnummer);
            this.JournalPostList = db.LoadPatientNotes(this.Me.Personnummer);
            this.BookingList = db.LoadPatientBookings(this.Me.Personnummer);
            //SetAllergyList();
            //SetNoteList();
            //SetLatestSignedIn();
            //SetLatestSignedOut();
            this.DataUpdate();
        }

        public void DataUpdate()
        {
            PrescriptionList = db.LoadPatientPrescriptions(Me.Personnummer);
            JournalPostList = db.LoadPatientNotes(Me.Personnummer);
            BookingList = db.LoadPatientBookings(Me.Personnummer);
            //SetAllergyList();
            //SetNoteList();
            //SetLatestSignedIn();
            //SetLatestSignedOut();
        }
    }
}
