using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string BookingPurpose { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }
        public string Staff_ID { get; set; }
        public string Patient_ID { get; set; }
        public string RoomNr { get; set; }


        public Booking(int id, string purpose, DateTime whenstart, DateTime whenend, string staff, string patient, string room)
        {
            this.BookingID = id;
            this.BookingPurpose = purpose;
            this.BookingStart = whenstart;
            this.BookingEnd = whenend;
            this.Staff_ID = staff;
            this.Patient_ID = patient;
            this.RoomNr = room;

            DatabaseHandler db = new DatabaseHandler();
            Employee tempEmp = db.LoadEmployee(staff);
            this.Staff_ID = $"{tempEmp.FirstName} {tempEmp.LastName}";
        }

        public override string ToString()
        {
            return $"Besökstid bokat {BookingStart.ToString("g")} hos {Staff_ID} i rum {RoomNr}. Anledning: {BookingPurpose}";
        }


    }
}
