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
    public partial class SignInForm : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        PatientJournalData data;
        List<Department> DepartmentList { get; set; }
        List<Room> RoomList { get; set; }

        
        public SignInForm(PatientJournalData dt)
        {
            data = dt; 
            InitializeComponent();
            this.DepartmentList = db.LoadAllDepartments();
            this.departmentComboBox.DataSource = DepartmentList;
            this.departmentComboBox.DisplayMember = "Name";
            this.RoomList = db.LoadDepartmentRooms((departmentComboBox.SelectedValue as Department).DepartmentID);
            this.roomComboBox.DataSource = RoomList;
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomList = db.LoadDepartmentRooms((departmentComboBox.SelectedValue as Department).DepartmentID);
            roomComboBox.DataSource = RoomList;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(!((roomComboBox.SelectedValue as Room).AvailableCapacity > 0))
            {
                MessageBox.Show("Det valda rummet har inga lediga platser.");
                return;
            }
            else
            {
                Room rummet = (roomComboBox.SelectedValue as Room);
                data.ThePatient.Room = rummet.RoomID;
                data.ThePatient.UpdateSelf();
                MessageBox.Show($"Patient inskriven. Registrerad till {rummet.RoomFunction} {rummet.RoomID} ");
                this.Close();
            }
        }
    }
}
