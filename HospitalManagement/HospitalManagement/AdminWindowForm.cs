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
        public AdminWindowForm(Employee myUser)
        {
            InitializeComponent();
        }

        private void AdminWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShutEverythingDown();
        }
    }
}
