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
    public partial class MainWindow : Form
    {
        MainWindowData data;
        DatabaseHandler db = new DatabaseHandler();

        public MainWindow(Employee user)
        {
            InitializeComponent();

            //sets searchbutton to accept enterkey input
            this.AcceptButton = searchPatientBtn;
            data = new MainWindowData(user);
            userIdentityLbl.Text = $"Inloggad som: {data.MyUser.LastName}, {data.MyUser.FirstName} - ({data.MyUser.EmployeeID})";

        }



        private void newPatientBtn_Click(object sender, EventArgs e)
        {
            Form patReg = new PatientRegistryForm(data.MyUser.EmployeeID);
            patReg.Show();
        }

        private void searchPatientBtn_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            HospitalDataSetTableAdapters.patientTableAdapter patientTableAdapter = new HospitalDataSetTableAdapters.patientTableAdapter();
            HospitalDataSet hospitalDataSet = new HospitalDataSet();
            
            var searchTerm = searchPatientBox.Text;


            if (searchTerm.Any(char.IsDigit))
            {
                if (!Regex.IsMatch(searchTerm, @"^\d{2}[01]\d[0-3]\d[-]\d{4}$"))
                {
                    MessageBox.Show("Personnummer måste skrivas enligt ÅÅMMDD-XXXX.");
                }
            }
            //if (!dbHandler.PatientExists(searchTerm))
            //{
              //  MessageBox.Show("Patienten finns inte i patientregistret.");
           // }
            //patientTableAdapter.Fill(patientTableAdapter.GetDataBySearchTerm(searchTerm));

            dataGridView1.DataSource = patientTableAdapter.GetDataBySearchTerm(searchTerm);
            this.dataGridView1.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;

            // Form journal = new PatientJournalForm(dbHandler.LoadPatient(searchTerm));
            //journal.Show();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet.patient' table. You can move, or remove it, as needed.
          //  this.patientTableAdapter.Fill(this.hospitalDataSet.patient);

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                DataRowView dataRowView = this.dataGridView1.Rows[row.Index].DataBoundItem as DataRowView;
                var dataRow = dataRowView.Row as DataRow;
                string personNumber = dataRow["person_id_nr"].ToString();
                //var test2 = test[0] as Patient;
                if (dataRowView != null)
                {
                    DatabaseHandler dbHandler = new DatabaseHandler();
                    HospitalDataSetTableAdapters.patientTableAdapter patientTableAdapter = new HospitalDataSetTableAdapters.patientTableAdapter();
                    Form journal = new PatientJournalForm(dbHandler.LoadPatient(personNumber), data.MyUser);
                    journal.Show();
                }
            }
            //Patient test = ((DataGridView)sender).DataSource as Patient;
            //Form journal = new PatientJournalForm();
            //journal.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShutEverythingDown();
        }

        
        private void patientJournalBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string personid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Patient patientToOpen = db.LoadPatient(personid);
                Employee user = data.MyUser;
                Form patjourn = new PatientJournalForm(patientToOpen, user);
                patjourn.Show();
            }
            
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet1.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.hospitalDataSet1.staff);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
