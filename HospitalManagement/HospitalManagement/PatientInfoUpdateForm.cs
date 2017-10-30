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
    public partial class PatientInfoUpdateForm : Form
    {
        PatientJournalData data;
        public PatientInfoUpdateForm(PatientJournalData d)
        {
            InitializeComponent();

            this.data = d;
            this.bloodtypeComboBox.SelectedIndex = bloodtypeComboBox.FindStringExact(data.ThePatient.BloodType);
            this.personIdTxt.Text = data.ThePatient.Personnummer;
            this.firstNameTxt.Text = data.ThePatient.FirstName;
            this.lastNameTxt.Text = data.ThePatient.LastName;
            this.addressTxt.Text = data.ThePatient.Address;
            this.postCodeTxt.Text = data.ThePatient.PostalCode.ToString();
            PopulatePostalArea();
            this.phoneTxt.Text = data.ThePatient.PhoneNr;
            this.eMailTxt.Text = data.ThePatient.Email;
            
            saveChangesBtn.Enabled = false;
        }

        private Boolean DataValidityCheck()
        {
            //Goes through all the textboxes in the from and makes sure that they have some sort of content. 
            bool dataValid = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    bool nullorwhite = string.IsNullOrWhiteSpace(textbox.Text);
                    dataValid &= !nullorwhite;
                    if (nullorwhite)
                    {
                        textbox.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        textbox.BackColor = Color.White;
                    }
                    
                }
                if (string.IsNullOrWhiteSpace(bloodtypeComboBox.Text))
                {
                    dataValid = false;
                }
            }
            return dataValid;
        }

        private Boolean DataChangedCheck()
        {
            List<string> textBoxContent = new List<string> { firstNameTxt.Text, lastNameTxt.Text, addressTxt.Text, postCodeTxt.Text, phoneTxt.Text, eMailTxt.Text };
            List<string> currentInfo = new List<string> { data.ThePatient.FirstName, data.ThePatient.LastName, data.ThePatient.Address, data.ThePatient.PostalCode.ToString(), data.ThePatient.PhoneNr, data.ThePatient.Email };
            foreach (string i in textBoxContent)
            {
                string n = currentInfo.ElementAt(textBoxContent.IndexOf(i));
                if (!i.Equals(n))
                {
                    return true;
                }
            }
            string btb = bloodtypeComboBox.Text;
            string btp = data.ThePatient.BloodType;
            if (!bloodtypeComboBox.Text.Equals(data.ThePatient.BloodType))
            {
                return true;
            }

            return false;
        }

        private void postalAreatxt_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(postCodeTxt.Text, @"^\d{5}$"))
            {
                MessageBox.Show("Postnummer måste bestå av 5 siffror utan mellanslag.");
            }
            else
            {
                PopulatePostalArea();
            }
        }

        private void PopulatePostalArea()
        {
                //Gets the name of the Postort from the database and displays it in the postalAreaTxt box.
                DatabaseHandler db = new DatabaseHandler();
                string postOrt = db.LoadPostort(Convert.ToInt32(postCodeTxt.Text));
                postalAreatxt.Text = postOrt;
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (DataValidityCheck())
            {
                DatabaseHandler db = new DatabaseHandler();
                Patient updatePatient = new Patient(personIdTxt.Text, firstNameTxt.Text, lastNameTxt.Text, addressTxt.Text, Int32.Parse(postCodeTxt.Text), postalAreatxt.Text, phoneTxt.Text, eMailTxt.Text, bloodtypeComboBox.Text, "No Change");
                db.UpdatePatient(updatePatient);
                data.ThePatient = updatePatient;
                this.Close();
            }
        }

        private void SetSaveChangeButtonStatus()
        {
            if (DataValidityCheck())
            {
                if (DataChangedCheck())
                {
                    saveChangesBtn.Enabled = true;
                }
                else
                {
                    saveChangesBtn.Enabled = false;
                }
            }
            else
            {
                saveChangesBtn.Enabled = false;
            }
        }

        private void firstNameTxt_Validating(object sender, CancelEventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

      

        private void bloodtypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

        private void firstNameTxt_TextChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

        private void lastNameTxt_TextChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

        private void phoneTxt_TextChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

        private void eMailTxt_TextChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }

        private void postCodeTxt_TextChanged(object sender, EventArgs e)
        {
            SetSaveChangeButtonStatus();
        }
    }
}
