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
    public partial class PrescriptionForm : Form
    {
        PrescriptionData data;

        public PrescriptionForm(Patient relevantpatient, Employee currentUser)
        {
            data = new PrescriptionData(relevantpatient, currentUser);
            InitializeComponent();
            UpdateWindow();         
        }

        public void UpdateWindow()
        {
            UpdateMedList();
            UpdatePrescriptionMed();
        }

        public void UpdateMedList()
        {
            List<Medication> filteredMedList;
            if (string.IsNullOrWhiteSpace(filterTxtBox.Text))
            {
                filteredMedList = data.MedicationList;
            }
            else
            {
                filteredMedList = (from myMed in data.MedicationList
                                  where  myMed.Name.ToLower().Contains($"{filterTxtBox.Text.ToLower()}")
                                  select myMed).ToList();
            }
            medicationListBox.DataSource = filteredMedList;  
        }

        private void UpdatePrescriptionMed()
        {
            if (!(medicationListBox.SelectedItem == null))
            {
                prescriptionMedTxtBox.Text = (medicationListBox.SelectedItem as Medication).ToShortString();
            }
            else
            {
                prescriptionMedTxtBox.Text = "";
            }
        }

        private void medicationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrescriptionMed();
        }

        private void filterTxtBox_TextChanged(object sender, EventArgs e)
        {
            UpdateMedList();
        }

        private void nrOfTimesTxtBox_Validating(object sender, CancelEventArgs e)
        {
                  
        }

        private void registerPrescriptionBtn_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (string.IsNullOrEmpty(prescriptionMedTxtBox.Text))
            {
                errorProvider.SetError(prescriptionMedTxtBox, "Läkemedel måste anges.");
                error = true;

            }

            if (string.IsNullOrWhiteSpace(nrOfTimesTxtBox.Text))
            {

                errorProvider.SetError(nrOfTimesTxtBox, "Antal uttag måste anges.");
                error = true;
            }
            else
            {
                if (!Regex.IsMatch(nrOfTimesTxtBox.Text, @"^\d+$"))
                {
                    errorProvider.SetError(nrOfTimesTxtBox, "Ej siffra");
                    error = true;
                }
                else
                {
                    if (int.Parse(nrOfTimesTxtBox.Text) > 10)
                    {
                        errorProvider.SetError(nrOfTimesTxtBox, "Max antal uttag är 10");
                        error = true;
                    }
                    else
                    {
                        errorProvider.SetError(nrOfTimesTxtBox, "");
                    }
                }

            }

            if (string.IsNullOrWhiteSpace(instructionTxtBox.Text))
            {
                errorProvider.SetError(instructionTxtBox, "Instruktioner måste anges");
                error = true;
            }

            if (!error)
            {
                string personnummer = data.ThePatient.Personnummer;
                string doctorID = data.MyUser.EmployeeID;
                string medicationID = (medicationListBox.SelectedItem as Medication).IDcode;
                string instructions = instructionTxtBox.Text;
                int uttag = int.Parse(nrOfTimesTxtBox.Text);
                string medicationName = (medicationListBox.SelectedItem as Medication).Name;


                Prescription newPrescription = new Prescription(DateTime.Today, doctorID, personnummer, medicationID, instructions, uttag, medicationName);
                DatabaseHandler db = new DatabaseHandler();
                Boolean success = db.AddPrescription(newPrescription);
                
                if (success)
                {
                    MessageBox.Show("Recept sparat i databasen.");
                    this.Close();
                }
                
            }
        }
    }
}
