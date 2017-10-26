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
    public partial class PrescriptionForm : Form
    {
        PrescriptionData data;

        public PrescriptionForm(Patient relevantpatient)
        {
            data = new PrescriptionData(relevantpatient);
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
                                  where  myMed.Name.Contains($"{filterTxtBox.Text}")
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
    }
}
