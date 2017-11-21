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
    public partial class EmployeeRegistryForm : Form
    {
        AdminWindowData data;
        DatabaseHandler db = new DatabaseHandler();
        Employee employeeToEdit = null;
        Boolean editMode;

        public EmployeeRegistryForm(AdminWindowData d)
        {
            data = d;
            InitializeComponent();
            departmentComboBox.DataSource = data.DepartmentList;//.OrderBy(o => o.Name).ToList();
            departmentComboBox.SelectedIndex = -1;
            positionComboBox.SelectedIndex = -1;
            specialtyComboBox.DataSource = new BindingSource(data.SpecialtyDictionary, null);
            specialtyComboBox.DisplayMember = "Key";
            specialtyComboBox.ValueMember = "Value";
            specialtyComboBox.SelectedIndex = -1;
            editMode = false;
        }

        public EmployeeRegistryForm(AdminWindowData d, Employee emp)
        {
            data = d;
            employeeToEdit = emp;
            this.Text = "Redigera Anställd";
            InitializeComponent();
            departmentComboBox.DataSource = data.DepartmentList;//.OrderBy(o => o.Name).ToList();
            //departmentComboBox.SelectedIndex = -1;
            //positionComboBox.SelectedIndex = -1;
            specialtyComboBox.DataSource = new BindingSource(data.SpecialtyDictionary, null);
            specialtyComboBox.DisplayMember = "Key";
            specialtyComboBox.ValueMember = "Value";
            FillFieldsWithEmployee();
            employeeIdTxtBox.Enabled = false;
            saveMoreEmployeesBtn.Visible = false;
            saveOneAndCloseBtn.Text = "Uppdatera och Stäng";
            editMode = true;
        }

        private void FillFieldsWithEmployee()
        {
            DatabaseHandler db = new DatabaseHandler();
            personIdTxtBox.Text = employeeToEdit.PersonNummer;
            positionComboBox.Text = employeeToEdit.Position;
            if (employeeToEdit.Position.Equals("Läkare"))
            {
                specialtyComboBox.Text = employeeToEdit.Specialty;
            }
            employeeIdTxtBox.Text = employeeToEdit.EmployeeID;
            departmentComboBox.Text = employeeToEdit.Department;
            firstNameTxtBox.Text = employeeToEdit.FirstName;
            lastNameTxtBox.Text = employeeToEdit.LastName;
            addressTxtBox.Text = employeeToEdit.Address;
            postalCodeTxtBox.Text = employeeToEdit.PostalCode.ToString();
            postalAreaTxtBox.Text = db.LoadPostort(Convert.ToInt32(postalCodeTxtBox.Text));
            phoneNrTxtBox.Text = employeeToEdit.PhoneNr;
            emailTxtBox.Text = employeeToEdit.Email;
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
                else if (control is ComboBox)
                {
                    ComboBox combobox = control as ComboBox;
                    combobox.SelectedIndex = -1;
                    combobox.Text = "";
                }
            }
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
            if (string.IsNullOrWhiteSpace(positionComboBox.Text) | string.IsNullOrWhiteSpace(departmentComboBox.Text))
            {
                dataValid = false;
            }

            if (!editMode)
            {
                saveMoreEmployeesBtn.Enabled = dataValid;
            }
            else
            {
                dataValid = (!makeEmployeeFromFields().Equals(employeeToEdit));
            }
            
            saveOneAndCloseBtn.Enabled = dataValid;
        }

        private void personIDTxtBox_Validated(object sender, EventArgs e)
        {
            //Checks if person id matches the pattern of a swedish Personal ID number.
            if (!String.IsNullOrWhiteSpace(personIdTxtBox.Text))
            {
                if (!Regex.IsMatch(personIdTxtBox.Text, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
                {
                    errorProvider.SetError(personIdTxtBox, "Personnummer måste skrivas enligt: ÅÅMMDD-XXXX");
                    //MessageBox.Show("Personnummer måste skrivas enligt ÅÅMMDD-XXXX.");
                    personIdTxtBox.Focus();
                }
                else
                {
                    errorProvider.SetError(personIdTxtBox, "");
                    DataValidityCheck();
                }
            }
            else
            {
                errorProvider.SetError(personIdTxtBox, "");
                DataValidityCheck();
            }
            
        }

        private void postalCodeTxtBox_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.SetError(postalCodeTxtBox, "");
            postalAreaTxtBox.Text = "";
            //Checks if the content of postalCodeTxtBox is 5 digits exactly, and shows errormessage if it isn't.
            postalCodeTxtBox.Text = postalCodeTxtBox.Text.Replace(" ", String.Empty);
            if (!String.IsNullOrWhiteSpace(postalCodeTxtBox.Text))
            {
                if (!Regex.IsMatch(postalCodeTxtBox.Text, @"^\d{5}$"))
                {
                    errorProvider.SetError(postalCodeTxtBox, "Postkod måste anges med 5 siffror.");
                    //MessageBox.Show("Postnummer måste bestå av 5 siffror utan mellanslag.");
                }
                else
                {
                    errorProvider.SetError(postalCodeTxtBox, "");
                    //Gets the name of the Postort from the database and displays it in the postalAreaTxt box.
                    DatabaseHandler db = new DatabaseHandler();
                    string postOrt = db.LoadPostort(Convert.ToInt32(postalCodeTxtBox.Text));
                    postalAreaTxtBox.Text = postOrt;
                    DataValidityCheck();
                }
            }
            else
            {
                errorProvider.SetError(postalCodeTxtBox, "");
            }

        }

        private void employeeIdTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(employeeIdTxtBox.Text))
            {
                if (!Regex.IsMatch(employeeIdTxtBox.Text, @"^[^\W\d_]{3}\d{5}$"))
                {
                    errorProvider.SetError(employeeIdTxtBox, "Anställnings-Id måste skrivas: AAA#####");
                    employeeIdTxtBox.Focus();
                }
                else
                {
                    errorProvider.SetError(employeeIdTxtBox, "");
                    DataValidityCheck();
                }
            }
            else
            {
                errorProvider.SetError(employeeIdTxtBox, "");
                DataValidityCheck();
            }

        }

        private void positionComboBox_Validating(object sender, CancelEventArgs e)
        {
            positionComboboxChanges();
        }

        private void positionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            positionComboboxChanges();
        }

        private void positionComboboxChanges()
        {
            specialtyComboBox.Enabled = false;
            specialtyComboBox.SelectedIndex = -1;
            string highestUsedId = "Inget";

            if (!String.IsNullOrWhiteSpace(positionComboBox.Text))
            {
                if (positionComboBox.Text.Equals("Läkare"))
                {
                    specialtyComboBox.Enabled = true;
                    specialtyComboBox.SelectedIndex = 0;
                }
                DatabaseHandler db = new DatabaseHandler();
                highestUsedId = db.LoadHighestUsedEmployeeId(positionComboBox.Text);
            }

            suggestNewIdLbl.Text = $"Högsta Nuvarande ID: {highestUsedId}";

            DataValidityCheck();
        }

        private void postalAreaTxtBox_Enter(object sender, EventArgs e)
        {
            postalCodeTxtBox.Focus();
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            DataValidityCheck();   
        }

        private void saveOneAndCloseBtn_Click(object sender, EventArgs e)
        {
            Employee employeeToSave = makeEmployeeFromFields();
            string newUserName = employeeToSave.FirstName.ToLower() + employeeToSave.LastName.ToLower();
            string successMessage;
            bool success;
            bool userCreated;
            if (editMode)
            {
                success = employeeToSave.UpdateSelfInDB();
                successMessage = "Anställd Uppdaterad.";
                if (success)
                {
                    if (!db.EmployeeHasAccount(employeeToSave.EmployeeID))
                    {
                        userCreated = db.AddEmployeeUser(newUserName, employeeToSave.EmployeeID);
                        if (userCreated)
                        {
                            successMessage += "\nInget användarkonto. Nytt konto skapat med defaultvärden.";
                        }
                        else
                        {
                            successMessage += "\nAnvändaren har inga inloggningsuppgifter, åtgärd misslyckats. Kontakta Support.";
                        }
                    }
                } 
                
            }
            else
            {
                success = db.AddEmployee(employeeToSave);
                successMessage = "Ny Användare sparad.";
                if (success)
                {
                    userCreated = db.AddEmployeeUser(newUserName, employeeToSave.EmployeeID);
                    if (!userCreated)
                    {
                        successMessage += "\nNya inloggningsuppgifter kunde inte skapas. Kontakta support.";
                    }
                }
                
            }
            

            if (!success)
            {
                MessageBox.Show("Anställd kunde inte sparas till databasen. Kontrollera att alla värden är korrekt angivna.");
            }
            else
            {
                MessageBox.Show(successMessage);
                this.Close();
            }

        }

        private Employee makeEmployeeFromFields()
        {
            string specialty = "N/A";
            if (positionComboBox.Text.Equals("Läkare"))
            {
                specialty = specialtyComboBox.Text;
            }
            return new Employee(employeeIdTxtBox.Text, firstNameTxtBox.Text, lastNameTxtBox.Text, addressTxtBox.Text, Convert.ToInt32(postalCodeTxtBox.Text), postalAreaTxtBox.Text, phoneNrTxtBox.Text, emailTxtBox.Text, personIdTxtBox.Text, positionComboBox.Text, departmentComboBox.Text, specialty);
        }

        private void saveMoreEmployeesBtn_Click(object sender, EventArgs e)
        {
            Employee employeeToSave = makeEmployeeFromFields();
            string newUserName = employeeToSave.FirstName.ToLower() + employeeToSave.LastName.ToLower();
            string successMessage;
            Boolean success = db.AddEmployee(employeeToSave);
            
            if (!success)
            {
                MessageBox.Show("Anställd kunde inte sparas till databasen. Kontrollera att alla värden är korrekt angivna.");
            }
            else
            {
                successMessage = "Ny anställd sparad till databasen";
                bool userCreated = db.AddEmployeeUser(newUserName, employeeToSave.EmployeeID);

                if (!userCreated)
                {
                    successMessage += "\nNya inloggningsuppgifter kunde inte skapas. Kontakta support.";
                }
                MessageBox.Show(successMessage);
                this.Reset();
            }
        }

        
    }
}
