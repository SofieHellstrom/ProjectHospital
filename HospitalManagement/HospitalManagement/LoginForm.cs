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
    public partial class LoginForm : Form
    {

        private Boolean isPatient = false;
        private UserInfo user;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();

            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            if (Regex.IsMatch(username, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
            {
                isPatient = true;
                System.Diagnostics.Debug.WriteLine("isPatient = true");
            }
            else
            {
                isPatient = false;
                System.Diagnostics.Debug.WriteLine("isPatient = false");
            }

            if (!db.UserExists(username))
            {
                errorProvider.SetError(usernameTxtBox, "Användarnamn finns ej");
                //warningLbl.Text = "Användare finns ej.";
                //warningLbl.Visible = true;
                return;
            }
            else
            {
                errorProvider.SetError(usernameTxtBox, "");
                user = db.LoadUser(username, isPatient);
                warningLbl.Text = "";
                warningLbl.Visible = false;
            }
            

            if (!user.PasswordIsCorrect(password))
            {
                errorProvider.SetError(passwordTxtBox, "Lösenord och Användarnamn matchar ej!");
                //warningLbl.Text = "Felaktigt Användarnamn/Lösenord";
                //warningLbl.Visible = true;
                return;
            }
            else
            {
                if (isPatient)
                {
                    errorProvider.SetError(passwordTxtBox, "");
                    Patient userPatient = db.LoadPatient(username);
                    Form patView = new PatientViewForm(userPatient);
                    patView.Show();
                    this.Hide();
                }
                else
                {
                    errorProvider.SetError(passwordTxtBox, "");
                    Employee userEmployee = db.LoadEmployee(user.Identifier);
                    Form main;
                    if (userEmployee.Position == "IT-Admin")
                    {
                        main = new AdminWindowForm(userEmployee);
                    }
                    else
                    {
                        main = new MainWindow(userEmployee);
                    }
                    
                    main.Show();
                    this.Hide();
                }
            }

        }

        private void snabbloginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            Employee defaultUser = db.LoadEmployee("LÄK11001");
            Form main = new MainWindow(defaultUser);
            main.Show();
            this.Hide();
        }
    }
}
   



 
