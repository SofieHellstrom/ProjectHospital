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
    public partial class RoomRegistryForm : Form
    {
        DatabaseHandler db = new DatabaseHandler();
        AdminWindowData data;
        Room roomToEdit;
        List<Department> departmentList;
        Boolean editMode = false;

        public RoomRegistryForm(AdminWindowData d)
        {
            data = d;
            departmentList = data.DepartmentList;
            InitializeComponent();
            departmentComboBox.DataSource = departmentList;
            departmentComboBox.DisplayMember = Name;
            
        }

        public RoomRegistryForm(AdminWindowData d, Room r)
        {
            data = d;
            roomToEdit = r;
            departmentList = data.DepartmentList;
            editMode = true;
            InitializeComponent();
            departmentComboBox.DataSource = departmentList;
            departmentComboBox.DisplayMember = Name;
            departmentComboBox.Text = db.LoadDepartmentByID(roomToEdit.DepartmentID).Name;
            roomIdTxtBox.Text = roomToEdit.RoomID;
            roomFunctionTxtBox.Text = roomToEdit.RoomFunction;
            roomCapUpDown.Value = roomToEdit.RoomCapacity;
            roomMaxUpDown.Value = roomToEdit.RoomMaxCapacity;
            roomIdTxtBox.Enabled = false;
            saveMoreRoomsBtn.Visible = false;
            saveOneAndCloseBtn.Text = "Uppdatera och Stäng";
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

            //Sets the buttons as enabled or disabled depending on if the fields are empty or not.
            if (!editMode)
            {
                saveMoreRoomsBtn.Enabled = dataValid;
            }
            else
            {
                dataValid = (!MakeRoomFromFields().Equals(roomToEdit));
            }

            saveOneAndCloseBtn.Enabled = dataValid;
        }

        //Creates a room instance from the content of the controls.
        public Room MakeRoomFromFields()
        {
            Room roomToReturn;
            string newRoomID = roomIdTxtBox.Text;
            string newFunction = roomFunctionTxtBox.Text;
            int newCapacity = (int)roomCapUpDown.Value;
            int newMaxCapacity = (int)roomMaxUpDown.Value;
            string newDepartment = db.LoadDepartmentIDByName(departmentComboBox.Text);
            roomToReturn = new Room(newRoomID, newFunction, newCapacity, newMaxCapacity, newDepartment);

            return roomToReturn;
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
            }
            roomCapUpDown.Value = 0;
            roomMaxUpDown.Value = 0;
        }

        private void TextBoxTextChanged (object sender, EventArgs e)
        {
            DataValidityCheck();
        }

        private void saveMoreRoomsBtn_Click(object sender, EventArgs e)
        {
            Room roomToSave = MakeRoomFromFields();
            string successMessage;
            Boolean success = db.AddRoom(roomToSave);

            if (!success)
            {
                MessageBox.Show("Rum kunde inte sparas till databasen. Kontrollera att alla värden är korrekt angivna.");
            }
            else
            {
                successMessage = "Nytt rum sparat till databasen";
                MessageBox.Show(successMessage);
                this.Reset();
            }
        }

        private void saveOneAndCloseBtn_Click(object sender, EventArgs e)
        {
            Room roomToSave = MakeRoomFromFields();
            string successMessage;
            bool success;

            if (editMode)
            {
                success = roomToSave.UpdateSelfInDB();
                successMessage = "Rum Uppdaterat.";
            }
            else
            {
                success = db.AddRoom(roomToSave);
                successMessage = "Nytt Rum sparat.";
            }


            if (!success)
            {
                MessageBox.Show("Rum kunde inte sparas till databasen. Kontrollera att alla värden är korrekt angivna.");
            }
            else
            {
                MessageBox.Show(successMessage);
                this.Close();
            }
        }

        private void roomIdTxtBox_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(roomIdTxtBox.Text))
            {
                if (!Regex.IsMatch(roomIdTxtBox.Text, @"^[^\W\d_]{3}\d{5}$"))
                {
                    errorProvider.SetError(roomIdTxtBox, "Avdelnings ID måste skrivas enligt: AAA#####");
                    roomIdTxtBox.Focus();
                }
                else
                {
                    errorProvider.SetError(roomIdTxtBox, "");
                    DataValidityCheck();
                }
            }
            else
            {
                errorProvider.SetError(roomIdTxtBox, "");
                DataValidityCheck();
            }
        }
    }
}
