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
    public partial class MainWindow : Form
    {
        Patient testPatient;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Patient patientToAdd = new Patient("720524-5033", "Johannes", "Svensson", "Temperaturgatan 51", 41841, "Göteborg", "0768-406023", "none@YourBusiness.com", "B-negativ");
            db.AddPatient(patientToAdd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            testPatient = db.LoadPatient("720524-5033");
            textBox1.Text = testPatient.FirstName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            db.DeletePatient("720524-5033");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Patient patientToUpdate = new Patient("720524-5033", "Anders", "Svensson", "Temperaturgatan 51", 41841, "Göteborg", "0768-406023", "none@YourBusiness.com", "B-negativ");
            db.UpdatePatient(patientToUpdate);
        }

        private void newPatientBtn_Click(object sender, EventArgs e)
        {
            Form patReg = new PatientRegistryForm();
            patReg.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            string answer = db.PatientExists("720524-5033").ToString();
            textBox1.Text = answer;
        }

        private void testPatientJournalBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            testPatient = db.LoadPatient("555555-5555");
            Form patientJournal = new PatientJournalForm(testPatient);
            patientJournal.Show();
        }
    }
}
