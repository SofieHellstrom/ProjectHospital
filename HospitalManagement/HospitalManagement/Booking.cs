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
        public string StaffName { get; set; }
        public string PatientName { get; set; }
        public string RoomNr { get; set; }

        






        public Booking(int id, string purpose, DateTime whenstart, DateTime whenend, string staff, string patient, string room)
        {
            this.BookingID = id;
            this.BookingPurpose = purpose;
            this.BookingStart = whenstart;
            this.BookingEnd = whenend;
            this.StaffName = staff;
            this.PatientName = patient;
            this.RoomNr = room;
            
            DatabaseHandler db = new DatabaseHandler();
            Employee tempEmp = db.LoadEmployee(staff);
            this.StaffName = $"{tempEmp.FirstName} {tempEmp.LastName}";
        }

      /*  public override string ToString()
        {
            DateTime date = this.BookingStart.Date;
            return $"{this.Medication}. Antal uttag: {this.NrOfTimes}. Utfärdat av: {this.PrescribedByName} {this.PrescribedAt.ToString("yyyy-MM-dd")}.";
        }*/

    }
}
