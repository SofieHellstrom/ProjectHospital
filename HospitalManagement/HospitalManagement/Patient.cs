using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{

    public class Patient
    {
        //Properties that correspond to information about patients in the patient table.

        public string Personnummer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string PostalArea { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }
        
        //Properties below commented out until the classes they refer to have been created.
        //There are most likely more, these are just examples.
        //public Room CurrentRoom { get; set; }
        //public list<JournalPost> myEntries { get; set; } 
        //public list<Prescription> myPrescriptions { get; set; }
        //public list<Booking> myBookings { get; set; }

        public Patient (string persNr, string firstName, string lastName, string address, int postCode, string postArea, string phoneNr, string eMail, string blood)
        {
            //Constructor with all the basic information about the patient. Will be called from a class/method
            //that loads the information from the database and creates the patient object.
            this.Personnummer = persNr;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PostalCode = postCode;
            this.PostalArea = postArea;
            this.PhoneNr = phoneNr;
            this.Email = eMail;
            this.BloodType = blood;
        }

    }
}
