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
            //dateTimePicker1
            //string currentTime = DateTime.Now.ToShortTimeString();
            startTime2.Text = DateTime.Now.ToShortTimeString();
            endTime2.Value = DateTime.Now.AddMinutes(15);
           

            doctorComboBox.DataSource = data.DoctorList;
            //purposeBox.Text = data.BookingList.
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
              /*  

                string personnummer = data.ThePatient.Personnummer;
                string doctorID = data.MyUser.EmployeeID;
                string medicationID = (medicationListBox.SelectedItem as Medication).IDcode;
                string instructions = instructionTxtBox.Text;
                int uttag = int.Parse(nrOfTimesTxtBox.Text);
                string medicationName = (medicationListBox.SelectedItem as Medication).Name;


                Booking newBooking = new Booking(DateTime.Today, doctorID, personnummer, medicationID, instructions, uttag, medicationName);
                DatabaseHandler db = new DatabaseHandler();
                Boolean success = db.AddBooking(newBooking);

                if (success)
                {
                    MessageBox.Show("Bokning sparat i databasen.");
                    this.Close();
                }
                */
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

