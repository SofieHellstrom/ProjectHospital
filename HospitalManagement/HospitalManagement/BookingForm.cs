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
            data = new Bookingdata(relevantpatient, currentUser);
            InitializeComponent();
            UpdateWindow();

            string patientName = data.ThePatient.LastName + ", " + data.ThePatient.FirstName;
            bookingPersonNrBox.Text = data.ThePatient.Personnummer;
            bookingPatientName.Text = patientName;
            
            
            startTime2.Text = DateTime.Now.ToShortTimeString();
            endTime2.Value = DateTime.Now.AddMinutes(15);
           // roomComboBox.DataSource = data.BookingList.Contains()
           

            doctorComboBox.DataSource = data.DoctorList;
           
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
                //int id 
                string personnummer = bookingPersonNrBox.Text;
                string patientname = bookingPatientName.Text;
                DateTime bookingdate = dateTimePicker1.Value;
                DateTime bookingtime = startTime2.Value;
                DateTime bookingtimeEnd = endTime2.Value;
                string doctor = (doctorComboBox.SelectedItem as Employee).EmployeeID;
                string purpose = purposeBox.Text;


                Booking newBooking = new Booking (purpose, bookingtime, bookingtimeEnd, doctor,patientname);
                DatabaseHandler db = new DatabaseHandler();
                Boolean success = db.AddBooking(newBooking);

                if (success)
                {
                    MessageBox.Show("Bokning sparat i databasen.");
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

