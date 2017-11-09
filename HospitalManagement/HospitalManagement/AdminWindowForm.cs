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
    public partial class AdminWindowForm : Form
    {
        AdminWindowData data;

        public AdminWindowForm(Employee myUser)
        {
            data = new AdminWindowData(myUser);
            InitializeComponent();
            this.currentUserLbl.Text = $"Inloggad som: {data.MyUser.ToString()}";
        }

        private void AdminWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShutEverythingDown();
        }
    }
}
