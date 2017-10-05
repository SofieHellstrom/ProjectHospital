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
    public partial class PatientRegistryForm : Form
    {
        public PatientRegistryForm()
        {
            InitializeComponent();
        }

        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            string nPersonId = personIdTxt.Text;
            string nFirstName = firstNameTxt.Text;
            string nLastName = lastNameTxt.Text;
            string nAddress = addressTxt.Text;
            int nPostCode = Convert.ToInt32(postCodeTxt.Text);
            string nPhoneNr = phoneTxt.Text;
            string nEmail = eMailTxt.Text;            
            string nBloodType = bloodtypeComboBox.Text;

            DatabaseHandler db = new DatabaseHandler();
            string nPostArea = db.loadPostort(nPostCode);
            
            Patient patientToAdd = new Patient(nPersonId, nFirstName, nLastName, nAddress, nPostCode, nPostArea, nPhoneNr, nEmail, nBloodType);
            db.AddPatient(patientToAdd);
            this.Close();
        }
    }
}
