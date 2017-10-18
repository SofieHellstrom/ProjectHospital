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

        public MainWindow()
        {
            InitializeComponent();

        }



        private void newPatientBtn_Click(object sender, EventArgs e)
        {
            Form patReg = new PatientRegistryForm();
            patReg.Show();
        }

        private void searchPatientBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            var searchTerm = searchPatientBox.Text.ToString();

            if (searchTerm.Any(char.IsDigit))
            {
                if (!Regex.IsMatch(searchTerm, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
                {
                    MessageBox.Show("Personnummer måste skrivas enligt ÅÅMMDD-XXXX.");
                }
            }

            else if (!dbHandler.PatientExists(searchTerm))
            {
                MessageBox.Show("Patienten finns inte i patientregistret.");
            }


            
            
                Form journal = new PatientJournalForm(dbHandler.LoadPatient(searchTerm));
                journal.Show();
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hospitalDataSet.patient);

        }
    }
}
