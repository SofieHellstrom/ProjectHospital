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
        DatabaseHandler db = new DatabaseHandler();



        public PatientJournalForm(Patient patient, Employee myUser)
        {
            data = new PatientJournalData(patient, myUser);
            InitializeComponent();
            UpdateWindow();
        }

        public void UpdateWindow()
        {
            data.Update();

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

            prescriptionListBox.DataSource = data.PrescriptionList;
            allergyListBox.DataSource = data.AllergyList;
            journalPostListBox.DataSource = data.NotesList;
            bokningListbox.DataSource = data.BookingList;
            if(journalPostListBox.Items.Count > 0)
            {
                journalpostPreviewTxtBox.Text = (journalPostListBox.SelectedValue as JournalPost).Content;
            }
                
        }

        private void savePersonInfoChange_Click(object sender, EventArgs e)
        {
            Form updateForm = new PatientInfoUpdateForm(data);
            updateForm.Show();
        }

        private void PatientJournalForm_Activated(object sender, EventArgs e)
        {
            UpdateWindow();
        }

        private void createReceiptBtn_Click(object sender, EventArgs e)
        {
            Employee showUser = data.MyUser; // ONly here for debugging purposes
            Form prescribeForm = new PrescriptionForm(data.ThePatient, data.MyUser);
            prescribeForm.Show();
        }

        private void newNotesBtn_Click(object sender, EventArgs e)
        {
            Form newNote = new NoteForm(data.ThePatient, data.MyUser);
            newNote.Show();
        }

        private void journalPostListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            journalpostPreviewTxtBox.Text = (journalPostListBox.SelectedValue as JournalPost).Content;
        }

        private void journalpostPreviewTxtBox_Enter(object sender, EventArgs e)
        {
            journalPostListBox.Focus();
        }

        private void tidsbokningBtn_Click(object sender, EventArgs e)
        {
            Form booking = new BookingForm(data.ThePatient, data.MyUser);
            booking.Show();
        }
        private void signInBtn_Click(object sender, EventArgs e)
        {
            Form signIn = new SignInForm(data);
            signIn.Show();
        }
    }
}
