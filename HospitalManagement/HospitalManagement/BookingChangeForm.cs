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
    public partial class BookingChangeForm : Form
    {
        Bookingdata data;
        DatabaseHandler db = new DatabaseHandler();

        public BookingChangeForm(Booking booking)
        {
            InitializeComponent();
            UpdateBooking();
            
        }
        public void UpdateBooking()
        {
           // bookingPatientName.Text = data.ThePatient.FirstName;
           // bookingPersonNrBox.Text = data.ThePatient.Personnummer;
           // dateTimePicker1.Value = db;
        }

        private void bookingPersonNrBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
