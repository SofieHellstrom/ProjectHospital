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
    public partial class ChangeUserInfoForm : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        UserInfo user;
        public ChangeUserInfoForm(Patient patient)
        {
            this.user = db.LoadUser(patient.Personnummer, true);
            InitializeComponent();
        }

        private void doItBtn_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!user.PasswordIsCorrect(oldPasswordTxtBox.Text))
            {
                errorProvider.SetError(oldPasswordTxtBox, "Felaktigt Lösenord!");
            }
            else
            {
                if (!(newPasswordTxtBox.Text.Equals(repeatPasswordTxtBox.Text)))
                {
                    errorProvider.SetError(newPasswordTxtBox, "Matchar ej!");
                    errorProvider.SetError(repeatPasswordTxtBox, "Matchar ej!");
                }
                else
                {
                    if(!(newPasswordTxtBox.Text.Count() > 7))
                    {
                        errorProvider.SetError(newPasswordTxtBox, "Lösenord måste innehålla minst 8 tecken.");
                    }
                    else
                    {
                        bool success = db.UpdateUser(user, newPasswordTxtBox.Text, true);
                        if (!success)
                        {
                            MessageBox.Show("Ändring misslyckades! Kontakta administratör.");
                        }
                        else
                        {
                            MessageBox.Show("Lösenordet är ändrat.");
                            this.Close();
                        }
                    }
                }

            }
        }
    }
}
