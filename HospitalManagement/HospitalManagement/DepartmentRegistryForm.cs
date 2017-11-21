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

            //Sets TimePickers to default values.
            depOpenTimePicker.Value = DateTimePicker.MinimumDateTime + new TimeSpan(8, 0, 0);
            depCloseTimePicker.Value = DateTimePicker.MinimumDateTime + new TimeSpan(16, 0, 0);
        }

        public DepartmentRegistryForm(AdminWindowData d, Department department)
        {
            data = d;
            editMode = true;
            departmentToEdit = department;

            InitializeComponent();

            //Customizes GUI to editmode
            depIDTxtBox.Enabled = false;
            saveMoreDepartmentsBtn.Visible = false;
            saveOneAndCloseBtn.Text = "Uppdatera och Stäng";
            
            //Loads the values of the passed Department to the controls.
            depIDTxtBox.Text = departmentToEdit.DepartmentID;
            depIDTxtBox.Enabled = false;
            depNameTxtBox.Text = departmentToEdit.Name;
            depOpenTimePicker.Value = DateTimePicker.MinimumDateTime + departmentToEdit.Opens;
            depCloseTimePicker.Value = DateTimePicker.MinimumDateTime + departmentToEdit.Closes;
        }

        //Creates a department instance from the content of the controls.
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

            //Sets the buttons as enabled or disabled depending on if the fields are empty or not.
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
                success = departmentToSave.UpdateSelfInDB();
                successMessage = "Avdelning Uppdaterad.";
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
