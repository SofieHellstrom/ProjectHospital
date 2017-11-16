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
            this.employeesDataGridView.DataSource = GetSortedEmployeeDataGridBindingList(data.EmployeeList, "EmployeeID");
            this.departmentComboBox.DataSource = data.DepartmentList.OrderBy(o=>o.Name).ToList();
        }

        private BindingList<Employee> GetSortedEmployeeDataGridBindingList(List<Employee> listToProcess, string propertyToSortBy)
        {
            BindingList<Employee> returnList;
            switch (propertyToSortBy)
            {
                case "EmployeeID":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.EmployeeID).ToList());
                    break;
                case "FirstName":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.FirstName).ToList());
                    break;
                case "LastName":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.LastName).ToList());
                    break;
                case "Address":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.Address).ToList());
                    break;
                case "PostalCode":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.PostalCode).ToList());
                    break;
                case "PostalArea":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.PostalArea).ToList());
                    break;
                case "PhoneNr":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.PhoneNr).ToList());
                    break;
                case "Email":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.Email).ToList());
                    break;
                case "PersonNummer":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.PersonNummer).ToList());
                    break;
                case "Department":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.Department).ToList());
                    break;
                case "Specialty":
                    returnList = new BindingList<Employee>(data.EmployeeList.OrderBy(o => o.Specialty).ToList());
                    break;
                default:
                    returnList = new BindingList<Employee>(listToProcess);
                    break;
            }
            return returnList;
        }

        private void UpdateWindow()
        {
            data.UpdateData();
            var employeeRowSelected = employeesDataGridView.Rows.IndexOf(employeesDataGridView.SelectedRows[0]);
            employeesDataGridView.DataSource = GetSortedEmployeeDataGridBindingList(data.EmployeeList, "EmployeeID");
            //Trying to keep rowselection when you get back to window.
            employeesDataGridView.CurrentCell = employeesDataGridView.Rows[employeeRowSelected].Cells[0];
            employeesDataGridView.Rows[employeeRowSelected].Selected = true;
            
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    Employee selectedEmployee = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
                    Form addForm = new EmployeeRegistryForm(data, selectedEmployee);
                    addForm.ShowDialog();
                    break;

                case 1:
                    break;

                case 2:
                    break;
            }
        }

        private void AdminWindowForm_Activated(object sender, EventArgs e)
        {
            UpdateWindow();
        }

        private void AdminWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ShutEverythingDown();
        }


    }
}
