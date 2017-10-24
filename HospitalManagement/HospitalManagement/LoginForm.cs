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

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler db = new DatabaseHandler();
            UserInfo user;
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;

            if (Regex.IsMatch(username, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
            {
                isPatient = true;
            }
            else
            {
                isPatient = false;
            }

            //if (!db.UserExists(username, isPatient))
            //{
            //    warningLbl.Text = "Användare finns ej.";
            //    warningLbl.Visible = true;
            //    return;
            //}
            //else
            //{
                user = db.LoadUser(username, isPatient);
                warningLbl.Text = "";
                warningLbl.Visible = false;
            //}
            

            if (!user.PasswordIsCorrect(password))
            {
                warningLbl.Text = "Felaktigt Lösenord";
                warningLbl.Visible = true;
                return;
            }
            else
            {
                if (isPatient)
                {
                    warningLbl.Text = "Patientinloggning ej implementerad.";
                    warningLbl.Visible = true;
                    //Patient userPatient = db.LoadPatient(username);
                    //Form application = new 
                }
                else
                {
                    Employee userEmployee = db.LoadEmployee(user.Identifier);
                    Form main = new MainWindow(userEmployee);
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
   



 
