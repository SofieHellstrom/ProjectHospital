using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class BookingForm : Form
    {
        Bookingdata data;
        int booking_id;
        static string ROOMFUNCTION_MOTTAGNING = "Mottagning";
        static string ROOMFUNCTION_LAB = "Lab";

        //Update booking
        public BookingForm(Booking booking)
        {
            DatabaseHandler db = new DatabaseHandler();
            Employee selectedDr = db.LoadEmployee(booking.Staff_ID);
            Patient relevantpatient = db.LoadPatient(booking.Patient_ID);
            data = new Bookingdata(relevantpatient, selectedDr, ROOMFUNCTION_MOTTAGNING);
            InitializeComponent();
            UpdateWindow();

            booking_id = booking.BookingID;
            this.bookingPersonNrBox.Text = booking.Patient_ID;
            this.bookingPatientName.Text = relevantpatient.LastName + ", " + relevantpatient.FirstName;
            this.dateTimePicker1.Value = booking.BookingStart.Date;
            this.startTime2.Value = booking.BookingStart;
            this.endTime2.Value = booking.BookingEnd;
            this.purposeBox.Text = booking.BookingPurpose;
            this.roomComboBox.DataSource = data.RoomList;
            //roomComboBox.SelectedIndex = data.RoomList.IndexOf(data.RoomList.FirstOrDefault(x => x.RoomID == booking.RoomNr));
            roomComboBox.SelectedItem = data.RoomList.FirstOrDefault(x => x.RoomID == booking.RoomNr);
            this.doctorComboBox.DataSource = data.DoctorList;
            doctorComboBox.SelectedItem = data.DoctorList.FirstOrDefault(x => x.EmployeeID == booking.Staff_ID);

        }

        //New booking
        public BookingForm(Patient relevantpatient, Employee currentUser)
        {

            data = new Bookingdata(relevantpatient, currentUser, ROOMFUNCTION_MOTTAGNING);
            InitializeComponent();
            UpdateWindow();

            string patientName = data.ThePatient.LastName + ", " + data.ThePatient.FirstName;
            bookingPersonNrBox.Text = data.ThePatient.Personnummer;
            bookingPatientName.Text = patientName;
            startTime2.Text = DateTime.Now.ToShortTimeString();
            endTime2.Value = DateTime.Now.AddMinutes(15);
            roomComboBox.DataSource = data.RoomList.Where(x => x.RoomFunction == ROOMFUNCTION_MOTTAGNING).ToList();
            doctorComboBox.DataSource = data.DoctorList;
            testTypeComboBox.DataSource = data.TestTypeList;
            testTypeComboBox.Enabled = false;
            TimeSpan depStartingHours = new TimeSpan(8, 0, 0);
            TimeSpan depFinalAppointmentTime = new TimeSpan(16, 45, 0);



        }

        public void UpdateWindow()
        {
            UpdateStaffList();
            // UpdateLabCheck();
        }

        public void UpdateStaffList()
        {
            List<Employee> doctorList;
            if (string.IsNullOrWhiteSpace(doctorComboBox.Text))
            {
                doctorList = data.DoctorList;
            }
            else
            {
                doctorList = (from myDoc in data.DoctorList
                              where myDoc.LastName.Contains($"{doctorComboBox.Text}") || myDoc.Specialty.Contains($"{doctorComboBox.Text}")
                              select myDoc).ToList();
            }
            doctorComboBox.DataSource = doctorList;
        }



        private void bokaBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool error = false;

            if (string.IsNullOrEmpty(purposeBox.Text))
            {
                errorProvider1.SetError(purposeBox, "Vänligen ange syfte till bokningen.");
                error = true;
            }

            if (string.IsNullOrWhiteSpace(startTime2.Text))
            {
                errorProvider1.SetError(startTime2, "Vänligen ange önskad besökstid.");
                error = true;
            }

            if (string.IsNullOrWhiteSpace(endTime2.Text))
            {
                errorProvider1.SetError(endTime2, "Vänligen ange önskad besökstid.");
                error = true;
            }

            if (string.IsNullOrWhiteSpace(doctorComboBox.Text))
            {
                errorProvider1.SetError(doctorComboBox, "Vänligen ange önskad läkare.");
                error = true;
            }

            if (!error)
            {

                int id;
                //booking_id = 0 means it's a new booking
                if (booking_id == 0) { id = Guid.NewGuid().GetHashCode(); } else { id = booking_id; }
                string personnummer = bookingPersonNrBox.Text;
                string patientname = bookingPatientName.Text;
                DateTime bookingdate = dateTimePicker1.Value;
                DateTime bookingtimeStart = dateTimePicker1.Value.Add(startTime2.Value.TimeOfDay.Duration());
                DateTime bookingtimeEnd = dateTimePicker1.Value.Add(endTime2.Value.TimeOfDay.Duration());
                string doctor = (doctorComboBox.SelectedItem as Employee).EmployeeID;
                string purpose = purposeBox.Text;
                string room = (roomComboBox.SelectedItem as Room).RoomID;
                int compareTimeValues = bookingtimeStart.CompareTo(bookingtimeEnd);

                if (compareTimeValues >= 0)
                {
                    errorProvider1.SetError(startTime2, "Vänligen ange giltig besökstid.");
                    error = true;
                }

                DatabaseHandler db = new DatabaseHandler();

                List<Booking> overlapCheck = db.TimeOverlapCheckBooking(bookingtimeStart, bookingtimeEnd);
                if (overlapCheck.Any())
                {
                    foreach (Booking booking in overlapCheck)
                    {
                        if (booking.BookingID != id)
                        {
                            if (doctor.Equals(booking.Staff_ID))
                            {
                                errorProvider1.SetError(doctorComboBox, "Läkaren har redan ett besök inbokat. Vänligen ange annan tid.");
                                error = true;
                            }
                            if (personnummer.Equals(booking.Patient_ID))
                            {
                                errorProvider1.SetError(bookingPatientName, "Patienten har redan ett besök inbokat. Vänligen ange annan tid.");
                                error = true;
                            }
                            if (room.Equals(booking.RoomNr))
                            {
                                errorProvider1.SetError(roomComboBox, "Rummet är redan upptagen vid angiven tid. Vänligen välj annat rum.");
                                error = true;
                            }
                        }
                    }
                }

                if (!error)
                {
                    Booking newBooking = new Booking(id, purpose, bookingtimeStart, bookingtimeEnd, doctor, personnummer, room);
                    Boolean success = db.AddBooking(newBooking);

                    if (success)
                    {
                        MessageBox.Show("Bokning har sparats.");
                        this.Close();
                    }
                }
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labTestCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (labTestCheckBox.Checked == true)
            {
                roomComboBox.DataSource = data.RoomList.Where(x => x.RoomFunction == ROOMFUNCTION_LAB).ToList();
                testTypeComboBox.Enabled = true;
            }
            else
            {
                roomComboBox.DataSource = data.RoomList.Where(x => x.RoomFunction == ROOMFUNCTION_MOTTAGNING).ToList();
                testTypeComboBox.Enabled = false;
            }
        }
    }


}

