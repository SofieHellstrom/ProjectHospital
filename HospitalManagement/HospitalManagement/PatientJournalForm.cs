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
    public partial class PatientJournalForm : Form
    {
        // Form for displaying the Patientjournal of the Patient. 
        PatientJournalData data;



        public PatientJournalForm(Patient patient)
        {
            data = new PatientJournalData(patient);
            InitializeComponent();
            string patientName = data.ThePatient.LastName + ", " + data.ThePatient.FirstName;
            string windowTitle = patientName + " " + data.ThePatient.Personnummer;
            this.Text = windowTitle;
            personNrTxt.Text = data.ThePatient.Personnummer;
            namnTxt.Text = data.ThePatient.LastName + ", " + data.ThePatient.FirstName;
            addressTxt.Text = data.ThePatient.Address;
            postalCodeTxt.Text = data.ThePatient.PostalCode.ToString();
            postalAreaTxt.Text = data.ThePatient.PostalArea;
            phoneTxt.Text = data.ThePatient.PhoneNr;
            eMailTxt.Text = data.ThePatient.Email;
            bloodTypeTxt.Text = data.ThePatient.BloodType;


        }

    }
}
