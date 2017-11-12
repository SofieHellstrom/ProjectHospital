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
        bool journalpostFilterOn = false;

        public PatientJournalForm(Patient patient, Employee myUser)
        {
            data = new PatientJournalData(patient, myUser);
            InitializeComponent();
            switch (data.MyUser.Position)
            {
                case "Sjuksköterska":
                    signInBtn.Visible = false;
                    signOutBtn.Visible = false;
                    createReceiptBtn.Visible = false;
                    tidsbokningBtn.Visible = false;
                    break;

                case "Receptionist":
                    createReceiptBtn.Visible = false;
                    newNotesBtn.Visible = false;
                    break;
            }
            UpdatePatientJournal();
        }

        public void UpdatePatientJournal()
        {
            data.DataUpdate();

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
            allergyListBox.ValueMember = "ShortDescription";
            bokningListbox.DataSource = data.BookingList;

            if (journalpostFilterOn)
            {
                journalPostListBox.DataSource = data.ImportantNotesList;
            }
            else
            {
                journalPostListBox.DataSource = data.NotesList;
            }

            if(journalPostListBox.Items.Count > 0)
            {
                journalpostPreviewTxtBox.Text = (journalPostListBox.SelectedValue as JournalPost).Content;
            }

            if (data.SignedIn())
            {
                signInStatusTxtBox.Text = "Inskriven";
                Department tempDep = db.LoadDepartmentByID(db.LoadDepartmentOfRoom(data.ThePatient.Room));
                signedInDepTxtBox.Text = tempDep.Name;
                signedInRoomTxtBox.Text = data.ThePatient.Room;
                signInBtn.Enabled = false;
                signOutBtn.Enabled = true;
            }
            else
            {
                signInStatusTxtBox.Text = "Utskriven";
                signedInDepTxtBox.Text = "";
                signedInRoomTxtBox.Text = "";
                signInBtn.Enabled = true;
                signOutBtn.Enabled = false;
            }

                
        }

        private void savePersonInfoChange_Click(object sender, EventArgs e)
        {
            Form updateForm = new PatientInfoUpdateForm(data);
            updateForm.Show();
        }

        private void PatientJournalForm_Activated(object sender, EventArgs e)
        {
            UpdatePatientJournal();
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
            journalpostPreviewTxtBox.Text = ((JournalPost)journalPostListBox.SelectedValue).Content;
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

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Är du säker på att du vill skriva ut {data.ThePatient.ToString()}?", "Ja Nej", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if(db.AddJournalEntry(data.MyUser.EmployeeID, data.ThePatient.Personnummer, "Utskrivning", "", false))
                {
                    data.ThePatient.Room = "";
                    data.ThePatient.UpdateSelfInDB();
                    MessageBox.Show("Patient utskriven.");
                }
                else
                {
                    MessageBox.Show("Utskrivning misslyckad.");
                }

            }
            
        }

        private void toggleFilterBtn_Click(object sender, EventArgs e)
        {
            if (journalpostFilterOn)
            {
                journalpostFilterOn = false;
                journalNotesGroupBox.Text = "Journal-anteckningar";
                UpdatePatientJournal();
            }
            else
            {
                journalpostFilterOn = true;
                journalNotesGroupBox.Text = "Journal-anteckningar - FILTER: ENDAST VIKTIGA";
                UpdatePatientJournal();
            }
        }
    }
}
