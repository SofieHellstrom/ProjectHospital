using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class PatientRegistryForm : Form
    {
        public PatientRegistryForm()
        {
            InitializeComponent();
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            //Gathers all the information from the different textboxes and saves a new patient.
            string nPersonId = personIdTxt.Text;
            string nFirstName = firstNameTxt.Text;
            string nLastName = lastNameTxt.Text;
            string nAddress = addressTxt.Text;
            int nPostCode = Convert.ToInt32(postCodeTxt.Text);
            string nPhoneNr = phoneTxt.Text;
            string nEmail = eMailTxt.Text;            
            string nBloodType = bloodtypeComboBox.Text;

            DatabaseHandler db = new DatabaseHandler();
            string nPostArea = db.LoadPostort(nPostCode);
            
            Patient patientToAdd = new Patient(nPersonId, nFirstName, nLastName, nAddress, nPostCode, nPostArea, nPhoneNr, nEmail, nBloodType);
            db.AddPatient(patientToAdd);
            this.Close();
        }

        private void personIdTxt_Validating(object sender, CancelEventArgs e)
        {
            //Checks if person
            if(!Regex.IsMatch(personIdTxt.Text, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
            {
                MessageBox.Show("Personnummer måste skrivas enligt ÅÅMMDD-XXXX.");
            }
        }

        private void postCodeTxt_Validating(object sender, CancelEventArgs e)
        {
            //Checks if the content of postCodeTxt is 5 digits exactly, and shows errormessage if it isn't.
            if (!Regex.IsMatch(postCodeTxt.Text, @"^\d{5}$"))
            {
                MessageBox.Show("Postnummer måste bestå av 5 siffror utan mellanslag.");
            }
            else
            {
                //Gets the name of the Postort from the database and displays it in the postalAreaTxt box.
                DatabaseHandler db = new DatabaseHandler();
                string postOrt = db.LoadPostort(Convert.ToInt32(postCodeTxt.Text));
                postalAreatxt.Text = postOrt;
            }

        }
    }
}
