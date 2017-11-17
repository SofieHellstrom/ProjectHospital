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
    public partial class DepartmentRegistryForm : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        Department departmentToEdit = null;
        AdminWindowData data;
        bool editMode;

        public DepartmentRegistryForm(AdminWindowData d)
        {
            data = d;
            editMode = false;
  
            InitializeComponent();

            depOpenTimePicker.Value = DateTime.Today + new TimeSpan(8, 0, 0);
            depCloseTimePicker.Value = DateTime.Today + new TimeSpan(16, 0, 0);
        }

        public Department MakeDepartmentFromFields()
        {
            Department depToReturn;
            string newDepID = depIDTxtBox.Text;
            string newDepName = depNameTxtBox.Text;
            TimeSpan newDepOpens = depOpenTimePicker.Value.TimeOfDay;
            TimeSpan newDepCloses = depCloseTimePicker.Value.TimeOfDay;

            depToReturn = new Department(newDepID, newDepName, newDepOpens, newDepCloses);
            return depToReturn;
        }

        private void DataValidityCheck()
        {
            //Goes through all the textboxes in the form and makes sure that they have some sort of content. 
            bool dataValid = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    dataValid &= !string.IsNullOrWhiteSpace(textbox.Text);
                }
            }
            
            if (!editMode)
            {
                saveMoreDepartmentsBtn.Enabled = dataValid;
            }
            else
            {
                dataValid = (!MakeDepartmentFromFields().Equals(departmentToEdit));
            }

            saveOneAndCloseBtn.Enabled = dataValid;
        }

        private void depIDTxtBox_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(depIDTxtBox.Text))
            {
                if (!Regex.IsMatch(depIDTxtBox.Text, @"^[^\W\d_]{3}\d{2}$"))
                {
                    errorProvider.SetError(depIDTxtBox, "Avdelnings ID måste skrivas enligt: AAA##");
                    depIDTxtBox.Focus();
                }
                else
                {
                    errorProvider.SetError(depIDTxtBox, "");
                    DataValidityCheck();
                }
            }
            else
            {
                errorProvider.SetError(depIDTxtBox, "");
                DataValidityCheck();
            }

        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void Reset()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textbox = control as TextBox;
                    textbox.Text = "";
                }
            }
            depOpenTimePicker.Value = DateTime.Today + new TimeSpan(8, 0, 0);
            depCloseTimePicker.Value = DateTime.Today + new TimeSpan(16, 0, 0);
        }

        private void saveMoreDepartmentsBtn_Click(object sender, EventArgs e)
        {
            Department departmentToSave = MakeDepartmentFromFields();
            string successMessage;
            Boolean success = db.AddDepartment(departmentToSave);

            if (!success)
            {
                MessageBox.Show("Avdelning kunde inte sparas till databasen. Kontrollera att alla värden är korrekt angivna.");
            }
            else
            {
                successMessage = "Ny avdelning sparad till databasen";
                MessageBox.Show(successMessage);
                this.Reset();
            }
        }

        private void saveOneAndCloseBtn_Click(object sender, EventArgs e)
        {
            Department departmentToSave = MakeDepartmentFromFields();
            string successMessage;
            bool success;

            if (editMode)
            {
                /*success = departmentToSave.UpdateSelfInDB();
                if (success) successMessage = "Anställd Uppdaterad.";*/
                success = false;
                successMessage = "Used non-implemented part of method. Implement method you lazy sod!";
            }
            else
            {
                success = db.AddDepartment(departmentToSave);
                successMessage = "Ny Avdelning sparad.";
            }


            if (!success)
            {
                MessageBox.Show("Avdelning kunde inte sparas till databasen. Kontrollera att alla värden är korrekt angivna.");
            }
            else
            {
                MessageBox.Show(successMessage);
                this.Close();
            }

        }
    }
}
