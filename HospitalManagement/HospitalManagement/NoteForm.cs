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
    public partial class NoteForm : Form
    {
        Patient ThePatient { get; set; }
        Employee TheUser { get; set; }
        DatabaseHandler db = new DatabaseHandler();

        public NoteForm(Patient pat, Employee emp)
        {
            this.ThePatient = pat;
            this.TheUser = emp;
            InitializeComponent();
            this.Text = $"Ny anteckning på {ThePatient.ToString()} - Inloggad användare: {TheUser.ToString()}";
            switch (this.TheUser.Position)
            {
                case "Sjuksköterska":
                    String[] typeArray = { "Allergi", "Standard" };
                    typeComboBox.DataSource = typeArray;
                    break;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool success = db.AddJournalEntry(TheUser.EmployeeID, ThePatient.Personnummer, typeComboBox.Text, textBox.Text, importantCheckBox.Checked);
            if (success)
            {
                MessageBox.Show("Anteckning sparad.");
                this.Close();
            }
            
        }
    }
}
