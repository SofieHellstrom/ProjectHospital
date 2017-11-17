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
    public partial class PatientViewForm : Form
    {
        PatientViewData data;
        public PatientViewForm(Patient user)
        {
            
            InitializeComponent();
            data = new PatientViewData(user);
            this.Text = $"Sjukhussystem PatientVy - {data.Me.ToString()}";
            this.nameTxtBox.Text = $"{data.Me.LastName}, {data.Me.FirstName}";
            this.addressTxtBox.Text = data.Me.Address;
            this.postNrTxtBox.Text = data.Me.PostalCode.ToString();
            this.postOrtTxtBox.Text = data.Me.PostalArea;
            this.phoneTxtBox.Text = data.Me.PhoneNr;
            this.mailTxtBox.Text = data.Me.Email;

            this.prescriptionsListBox.DataSource = data.PrescriptionList;
            this.journalpostListBox.DataSource = data.NotesList;
            this.bookingListBox.DataSource = data.BookingList;

            UpdateWindowContent();
        }

        private void PatientViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShutEverythingDown();
        }

        private void journalpostListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.DataUpdate();
            UpdateWindowContent();
            
        }

        private void UpdateWindowContent()
        {
            if (journalpostListBox.Items.Count > 0)
            {
                this.journalpostContentTxtBox.Text = (journalpostListBox.SelectedValue as JournalPost).Content;
            }
        }

        private void changePwrdBtn_Click(object sender, EventArgs e)
        {
            Form changePwrd = new ChangeUserInfoForm(data.Me);
            changePwrd.ShowDialog();
        }

        private void bookingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
