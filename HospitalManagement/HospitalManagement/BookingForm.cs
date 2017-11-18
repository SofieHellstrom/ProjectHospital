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

        public BookingForm(Patient relevantpatient, Employee currentUser)
        {
            string roomfunction = "Mottagning";
            data = new Bookingdata(relevantpatient, currentUser, roomfunction);
            InitializeComponent();
            UpdateWindow();

            string patientName = data.ThePatient.LastName + ", " + data.ThePatient.FirstName;
            bookingPersonNrBox.Text = data.ThePatient.Personnummer;
            bookingPatientName.Text = patientName;
            startTime2.Text = DateTime.Now.ToShortTimeString();
            endTime2.Value = DateTime.Now.AddMinutes(15);
            roomComboBox.DataSource = data.RoomList;
            doctorComboBox.DataSource = data.DoctorList;
            TimeSpan startingHours = new TimeSpan(8, 0, 0);
            TimeSpan finalAppointmentTime = new TimeSpan(16, 45, 0);
        }

        public void UpdateWindow()
        {

            UpdateStaffList();

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
                //TODO doctor error setting
            }

            if (!error)
            {
                int id = Guid.NewGuid().GetHashCode();
                string personnummer = bookingPersonNrBox.Text;
                string patientname = bookingPatientName.Text;
                DateTime bookingdate = dateTimePicker1.Value;
                DateTime bookingtimeStart = dateTimePicker1.Value.Add(startTime2.Value.TimeOfDay.Duration());
                DateTime bookingtimeEnd = dateTimePicker1.Value.Add(endTime2.Value.TimeOfDay.Duration());
                string doctor = (doctorComboBox.SelectedItem as Employee).EmployeeID;
                string purpose = purposeBox.Text;
                string room = (roomComboBox.SelectedItem as Room).RoomID;
                //TimeSpan bookedTime = bookingtimeEnd - bookingtimeStart;
                int bookedTime = DateTime.Compare(bookingtimeStart, bookingtimeEnd);

                //if doctor - time, time - room already exist etc && bookingPersonNrBox.Text == personnummer
                //check for: doctor and starttime-endtime, room and time(duration), patient and starttime-endtime
                if (bookedTime == 0) 
                {
                    if (doctorComboBox.SelectedItem.ToString().Equals(doctor))
                    {
                        errorProvider1.SetError(doctorComboBox, "Läkaren har redan ett besök inbokat. Vänligen ange annan tid.");
                        error = true;
                    }
                    if (bookingPersonNrBox.Text.Equals(personnummer))
                    {
                        errorProvider1.SetError(bookingPatientName, "Patienten har redan ett besök inbokat. Vänligen ange annan tid.");
                        error = true;
                    }
                    if (roomComboBox.SelectedItem.ToString().Equals(room))
                    {
                        errorProvider1.SetError(roomComboBox, "Rummet är redan upptagen vid angiven tid. Vänligen välj annat rum.");
                        error = true;
                    }
                }


                Booking newBooking = new Booking(id, purpose, bookingtimeStart, bookingtimeEnd, doctor, personnummer, room);
                DatabaseHandler db = new DatabaseHandler();
                Boolean success = db.AddBooking(newBooking);

                if (success)
                {
                    MessageBox.Show("Bokning har sparats.");
                    this.Close();
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
    }


}

