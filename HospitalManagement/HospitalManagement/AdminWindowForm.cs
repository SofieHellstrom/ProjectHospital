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
            this.employeesDataGridView.DataSource = data.EmployeeList;
            this.departmentComboBox.DataSource = data.DepartmentList.OrderBy(o=>o.Name).ToList();
        }

        private void UpdateSelectedEmployeeInfo()
        {
            if (employeesDataGridView.CurrentRow != null)
            {
                Employee selectedEmployee = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
                this.employeeIdTxtBox.Text = selectedEmployee.EmployeeID;
                this.firstNameTxtBox.Text = selectedEmployee.FirstName;
                this.lastNameTxtBox.Text = selectedEmployee.LastName;
                this.addressTxtBox.Text = selectedEmployee.Address;
                this.postalCodeTxtBox.Text = selectedEmployee.PostalCode.ToString();
                this.postalAreaTxtBox.Text = selectedEmployee.PostalArea;
                this.phoneNrTxtBox.Text = selectedEmployee.PhoneNr;
                this.emailTxtBox.Text = selectedEmployee.Email;
                this.departmentComboBox.Text = selectedEmployee.Department;
                this.positionComboBox.Text = selectedEmployee.Position;
                this.specialtyComboBox.Text = selectedEmployee.Specialty;
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
    }
}
