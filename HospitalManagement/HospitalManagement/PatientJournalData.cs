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
        public List<JournalPost> JournalPostList { get; set; }
        public List<JournalPost> AllergyList { get; set; }
        public List<JournalPost> NotesList { get; set; }
        public List<Booking> BookingList { get; set; }
        public DateTime LatestSignedIn { get; set; }
        public DateTime LatestSignedOut { get; set; }

        public PatientJournalData(Patient patient, Employee user)
        {
            this.ThePatient = patient;
            this.MyUser = user;
            this.PrescriptionList = db.LoadPatientPrescriptions(this.ThePatient.Personnummer);
            this.JournalPostList = db.LoadPatientNotes(this.ThePatient.Personnummer);
            this.BookingList = db.LoadPatientBookings(this.ThePatient.Personnummer);
            SetAllergyList();
            SetNoteList();
        }

        private void SetAllergyList()
        {
            List<JournalPost> filteredList = (from myPost in JournalPostList
                               where myPost.NoteType.Equals("Allergi")
                               select myPost).ToList();

            AllergyList = filteredList;
        }

        private void SetNoteList()
        {
            List<JournalPost> filteredList = (from myPost in JournalPostList
                                              where myPost.NoteType.Equals("Diagnos") || myPost.NoteType.Equals("Standard") || myPost.NoteType.Equals("Utlåtande")
                                              select myPost).ToList();

            NotesList = filteredList;
        }

        private void SetLatestSignedIn()
        {
            List<JournalPost> workList = (from myPost in JournalPostList
                                          where myPost.NoteType.Equals("Inskrivning")
                                          select myPost).ToList();
            workList.OrderBy(myPost => myPost.TimeCreated);
            LatestSignedIn = workList.Last().TimeCreated;
        }

        private void SetLatestSignedOut()
        {
            List<JournalPost> workList = (from myPost in JournalPostList
                                          where myPost.NoteType.Equals("Utskrivning")
                                          select myPost).ToList();

            workList.OrderBy(myPost => myPost.TimeCreated);
            LatestSignedOut = workList.Last().TimeCreated;
        }

        public Boolean SignedIn()
        {
            if(LatestSignedIn >= LatestSignedOut)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update()
        {
            PrescriptionList = db.LoadPatientPrescriptions(ThePatient.Personnummer);
            JournalPostList = db.LoadPatientNotes(ThePatient.Personnummer);
            BookingList = db.LoadPatientBookings(ThePatient.Personnummer);
            SetAllergyList();
            SetNoteList();
        }
    }
}
