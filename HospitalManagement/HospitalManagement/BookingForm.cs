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
        }

        public void UpdateWindow()
        {
            string patientName = data.ThePatient.LastName + ", " + data.ThePatient.FirstName;
            bookingPersonNrBox.Text = data.ThePatient.Personnummer;
            bookingPatientName.Text = patientName;
            //dateTimePicker1
            //startTime.Text = ;
            //endTime.Text = ;
            string staffName = data.MyUser.LastName + ", " + data.MyUser.FirstName;
            doctorComboBox.Text = staffName;
            //purposeBox.Text = data.BookingList.
            
            
        }

        
    }
}
