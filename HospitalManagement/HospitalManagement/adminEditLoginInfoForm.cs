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
    public partial class adminEditLoginInfoForm : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        UserInfo userToEdit;
        public adminEditLoginInfoForm(Employee emp)
        {
            this.userToEdit = db.LoadUserByID(emp.EmployeeID, false);
            InitializeComponent();
            userNameTxtBox.Text = userToEdit.Username;
            this.Text = $"Användarinfo för {emp.EmployeeID}";
        }

        private void doItBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            bool correct = true;
            string newPassword = null;

            if (!(userNameTxtBox.Text.Count() > 5))
            {
                errorProvider.SetError(userNameTxtBox, "Användarnamn måste bestå av minst 6 tecken.");
                correct = false;
            }
            if (!String.IsNullOrEmpty(passwordTextBox.Text))
            {
                if (!(passwordTextBox.Text.Count() > 7))
                {
                    errorProvider.SetError(passwordTextBox, "Lösenord måste bestå av minst 8 tecken.");
                    correct = false;
                }
                else
                {
                    newPassword = passwordTextBox.Text;
                }
            }
            if (correct)
            {
                userToEdit.Username = userNameTxtBox.Text;
                bool success = db.UpdateUser(userToEdit, newPassword, false);
                if (!success)
                {
                    MessageBox.Show("Uppdatering Misslyckad.");
                }
                else
                {
                    MessageBox.Show("Användarinfo uppdaterad");
                    this.Close();
                }
            }
        }

        private void ActivateButtonIfChanged(object sender, EventArgs e)
        {
            doItBtn.Enabled = false;
            passwordWarningLbl.Visible = false;

            if (!userNameTxtBox.Text.Equals(userToEdit.Username) || !String.IsNullOrEmpty(passwordTextBox.Text))
            {
                doItBtn.Enabled = true;
            }
            if (!String.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordWarningLbl.Visible = true;
            }
        }
    }
}
