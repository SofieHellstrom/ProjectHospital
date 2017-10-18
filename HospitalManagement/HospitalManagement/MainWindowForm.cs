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
    public partial class MainWindow : Form
    {
        MainWindowData data;

        public MainWindow()
        {
            InitializeComponent();
            data = new MainWindowData();
            userIdentityLbl.Text = $"Inloggad som: {data.MyUser.LastName}, {data.MyUser.FirstName} - ({data.MyUser.EmployeeID})";

        }

       

        private void newPatientBtn_Click(object sender, EventArgs e)
        {
            Form patReg = new PatientRegistryForm(data.MyUser.EmployeeID);
            patReg.Show();
        }

        private void searchPatientBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            var personalNumber = searchPatientBox.Text.ToString();

            if (!Regex.IsMatch(personalNumber, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
            {
                MessageBox.Show("Personnummer måste skrivas enligt ÅÅMMDD-XXXX.");
            }
            else if (!dbHandler.PatientExists(personalNumber))
            {
                MessageBox.Show("Patienten finns inte i patientregistret.");
            }
            else
            {
                Form journal = new PatientJournalForm(dbHandler.LoadPatient(personalNumber));
                journal.Show();
            }
        }
    }
}
