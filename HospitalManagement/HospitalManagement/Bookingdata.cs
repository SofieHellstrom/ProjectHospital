using System.Collections.Generic;

namespace HospitalManagement
{
   public class Bookingdata
    {
       DatabaseHandler db = new DatabaseHandler();
        public List<Booking> BookingList { get; set; }
        public List<Employee> DoctorList { get; set; }
        public Patient ThePatient { get; set; }
        public Employee MyUser { get; set; }

        public Bookingdata(Patient patient, Employee user)
         {
             this.ThePatient = patient;
             this.MyUser = user;
             this.BookingList = db.LoadPatientBookings(ThePatient.Personnummer);
            this.DoctorList = db.LoadDoctors(MyUser.Specialty);
         }
    }
}