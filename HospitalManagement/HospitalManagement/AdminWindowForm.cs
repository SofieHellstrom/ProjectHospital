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
            //BindingSource employeeBindingSource = new BindingSource();
            //employeeBindingSource.DataSource = data.EmployeeList;
            this.employeesDataGridView.DataSource = data.EmployeeList;
            this.departmentComboBox.DataSource = data.DepartmentList.OrderBy(o=>o.Name).ToList();
        }

        private void UpdateWindow()
        {
            data.UpdateData();

            employeesDataGridView.DataSource = data.EmployeeList;
            //employeesDataGridView.Refresh();
            UpdateSelectedEmployeeInfo();
        }


        private void UpdateSelectedEmployeeInfo()
        {
            if (employeesDataGridView.CurrentRow != null)
            {
                Employee selectedEmployee = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
                employeeIdTxtBox.Text = selectedEmployee.EmployeeID;
                firstNameTxtBox.Text = selectedEmployee.FirstName;
                lastNameTxtBox.Text = selectedEmployee.LastName;
                addressTxtBox.Text = selectedEmployee.Address;
                postalCodeTxtBox.Text = selectedEmployee.PostalCode.ToString();
                postalAreaTxtBox.Text = selectedEmployee.PostalArea;
                phoneNrTxtBox.Text = selectedEmployee.PhoneNr;
                emailTxtBox.Text = selectedEmployee.Email;
                personIDTxtBox.Text = selectedEmployee.PersonNummer;
                departmentComboBox.Text = selectedEmployee.Department;
                positionComboBox.Text = selectedEmployee.Position;
                specialtyComboBox.Text = selectedEmployee.Specialty;
            }
            else
            {
                ClearSelectedEmployeeInfo();
            }
        }

        private void ClearSelectedEmployeeInfo()
        {
            this.employeeIdTxtBox.Text = "";
            this.firstNameTxtBox.Text = "";
            this.lastNameTxtBox.Text = "";
            this.addressTxtBox.Text = "";
            this.postalCodeTxtBox.Text = "";
            this.postalAreaTxtBox.Text = "";
            this.phoneNrTxtBox.Text = "";
            this.emailTxtBox.Text = "";
            this.departmentComboBox.Text = "";
            this.positionComboBox.Text = "";
            this.specialtyComboBox.Text = "";
        }

        private void AdminWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShutEverythingDown();
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedEmployeeInfo();
        }

        private void employeeTabPage_Enter(object sender, EventArgs e)
        {
            addBtn.Text = "Ny Anställd";
            updateBtn.Text = "Uppdatera Anställd";
        }

        private void departmentTabPage_Enter(object sender, EventArgs e)
        {
            addBtn.Text = "Ny Avdelning";
            updateBtn.Text = "Uppdatera Avdelning";
        }

        private void employeesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data.EmployeeList.Any())
            {
                this.employeesDataGridView.Rows[0].Selected = true;
            }
            UpdateSelectedEmployeeInfo();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    Form addForm = new EmployeeRegistryForm(data);
                    addForm.ShowDialog();
                    break;

                case 1:
                    break;

                case 2:
                    break;
            }
        }

        private void AdminWindowForm_Enter(object sender, EventArgs e)
        {
            UpdateWindow();
        }

        private void AdminWindowForm_Activated(object sender, EventArgs e)
        {
            UpdateWindow();
        }
    }
}
