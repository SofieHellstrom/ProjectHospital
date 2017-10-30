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
        PatientRegistryData data;

        public PatientRegistryForm(string userID)
        {
            InitializeComponent();
            data = new PatientRegistryData(userID);
        }

        private void DataValidityCheck()
        {
            //Goes through all the textboxes in the form and makes sure that they have some sort of content. 
            bool dataValid = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    dataValid &= !string.IsNullOrWhiteSpace(textbox.Text);
                }
                if (string.IsNullOrWhiteSpace(bloodtypeComboBox.Text))
                {
                    dataValid = false;
                }
                savePatientBtn.Enabled = dataValid;
            }
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

            if (!db.PatientExists(nPersonId))
            {

                string nPostArea = db.LoadPostort(nPostCode);

                Patient patientToAdd = new Patient(nPersonId, nFirstName, nLastName, nAddress, nPostCode, nPostArea, nPhoneNr, nEmail, nBloodType, "");

                bool success = db.AddPatient(patientToAdd);
                if (success)
                {
                    db.AddJournalEntry(data.UserID, nPersonId, "System", "Patient skapad i databas", false);
                    MessageBox.Show("Ny patient tillagd i Databasen");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Patient kunde inte läggas till i databasen. \nVar god kontrollera uppgifterna.");
                }
            }
            else
            {
                MessageBox.Show("En patient med detta personnummer finns redan i databasen.");
            }
        }

        private void personIdTxt_Validating(object sender, CancelEventArgs e)
        {
            //Checks if person id matches the pattern of a swedish Personal ID number. 
            if(!Regex.IsMatch(personIdTxt.Text, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
            {
                errorProvider.SetError(personIdTxt, "Personnummer måste skrivas enligt: ÅÅMMDD-XXXX");
                //MessageBox.Show("Personnummer måste skrivas enligt ÅÅMMDD-XXXX.");
                personIdTxt.Focus();
            }
            else
            {
                errorProvider.SetError(personIdTxt, "");
                DataValidityCheck();
            }
        }

        private void postCodeTxt_Validating(object sender, CancelEventArgs e)
        {
            //Checks if the content of postCodeTxt is 5 digits exactly, and shows errormessage if it isn't.
            postCodeTxt.Text = postCodeTxt.Text.Replace(" ", String.Empty);
            if (!Regex.IsMatch(postCodeTxt.Text, @"^\d{5}$"))
            {
                errorProvider.SetError(postCodeTxt, "Postkod måste anges med 5 siffror.");
                //MessageBox.Show("Postnummer måste bestå av 5 siffror utan mellanslag.");
            }
            else
            {
                errorProvider.SetError(postCodeTxt, "");
                //Gets the name of the Postort from the database and displays it in the postalAreaTxt box.
                DatabaseHandler db = new DatabaseHandler();
                string postOrt = db.LoadPostort(Convert.ToInt32(postCodeTxt.Text));
                postalAreatxt.Text = postOrt;
                DataValidityCheck();
            }

        }

        private void firstNameTxt_Validated(object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void lastNameTxt_Validated(object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void addressTxt_Validated(object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void phoneTxt_Validated(object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void eMailTxt_Validated(object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void bloodtypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataValidityCheck();
        }
    }
}
