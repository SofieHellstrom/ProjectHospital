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
            
            //Initializing the content of the Employee Tab 
            this.employeesDataGridView.DataSource = GetSortedEmployeeDataGridList(data.EmployeeList, "EmployeeID");
            this.departmentComboBox.DataSource = data.DepartmentList.OrderBy(o=>o.Name).ToList();
            //Following line does not work for some reason. Check again if I have extra time.
            //this.employeesDataGridView.Columns[(this.employeesDataGridView.Columns["EmployeeID"].Index)].HeaderCell.SortGlyphDirection = SortOrder.Descending;

            //Initializing the content of the Department Tab
            this.departmentsDataGridView.DataSource = GetSortedDepartmentDataGridList(data.DepartmentList, "DepartmentID");

            
        }

        private List<Employee> GetSortedEmployeeDataGridList(List<Employee> listToProcess, string propertyToSortBy)
        {
            List<Employee> returnList;
            switch (propertyToSortBy)
            {
                case "EmployeeID":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.EmployeeID).ToList());
                    break;
                case "FirstName":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.FirstName).ToList());
                    break;
                case "LastName":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.LastName).ToList());
                    break;
                case "Address":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.Address).ToList());
                    break;
                case "PostalCode":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.PostalCode).ToList());
                    break;
                case "PostalArea":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.PostalArea).ToList());
                    break;
                case "PhoneNr":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.PhoneNr).ToList());
                    break;
                case "Email":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.Email).ToList());
                    break;
                case "PersonNummer":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.PersonNummer).ToList());
                    break;
                case "Department":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.Department).ToList());
                    break;
                case "Specialty":
                    returnList = new List<Employee>(data.EmployeeList.OrderBy(o => o.Specialty).ToList());
                    break;
                default:
                    returnList = new List<Employee>(listToProcess);
                    break;
            }
            return returnList;
        }

        private List<Department> GetSortedDepartmentDataGridList(List<Department> listToProcess, string propertyToSortBy)
        {
            List<Department> returnList;
            switch (propertyToSortBy)
            {
                case "DepartmentID":
                    returnList = new List<Department>(data.DepartmentList.OrderBy(o => o.DepartmentID).ToList());
                    break;
                case "Name":
                    returnList = new List<Department>(data.DepartmentList.OrderBy(o => o.Name).ToList());
                    break;
                case "Opens":
                    returnList = new List<Department>(data.DepartmentList.OrderBy(o => o.Opens).ToList());
                    break;
                case "Closes":
                    returnList = new List<Department>(data.DepartmentList.OrderBy(o => o.Closes).ToList());
                    break;
                default:
                    returnList = new List<Department>(listToProcess);
                    break;

            }
            return returnList;
        }

        private void UpdateWindow()
        {
            data.UpdateData();
            var employeeRowSelected = employeesDataGridView.Rows.IndexOf(employeesDataGridView.SelectedRows[0]);
            //Problem here? Why out of range?
            var departmentsRowSelected = departmentsDataGridView.Rows.IndexOf(departmentsDataGridView.SelectedRows[0]);

            employeesDataGridView.DataSource = GetSortedEmployeeDataGridList(data.EmployeeList, "EmployeeID");
            departmentsDataGridView.DataSource = GetSortedDepartmentDataGridList(data.DepartmentList, "DepartmentID");
            //Trying to keep rowselection when you get back to window.
            employeesDataGridView.CurrentCell = employeesDataGridView.Rows[employeeRowSelected].Cells[0];
            employeesDataGridView.Rows[employeeRowSelected].Selected = true;
            departmentsDataGridView.CurrentCell = departmentsDataGridView.Rows[departmentsRowSelected].Cells[0];
            departmentsDataGridView.Rows[departmentsRowSelected].Selected = true;
            
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

        private void UpdateSelectedDepartmentInfo()
        {
            if (departmentsDataGridView.CurrentRow != null)
            {
                Department selectedDepartment = departmentsDataGridView.CurrentRow.DataBoundItem as Department;
                depIDTxtBox.Text = selectedDepartment.DepartmentID;
                depNameTxtBox.Text = selectedDepartment.Name;
                depOpensTimePicker.Value = DateTime.Today + selectedDepartment.Opens;
                depClosesTimePicker.Value = DateTime.Today + selectedDepartment.Closes;
            }
            else
            {

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

        private void departmentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedDepartmentInfo();
        }

        private void employeeTabPage_Enter(object sender, EventArgs e)
        {
            addBtn.Text = "Ny Anställd";
            updateBtn.Text = "Uppdatera Anställd";
            editLoginInfoBtn.Text = "Användaruppgifter";
            editLoginInfoBtn.Visible = true;
        }

        private void departmentTabPage_Enter(object sender, EventArgs e)
        {
            addBtn.Text = "Ny Avdelning";
            updateBtn.Text = "Uppdatera Avdelning";
            editLoginInfoBtn.Visible = false;
        }

        private void employeesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data.EmployeeList.Any())
            {
                this.employeesDataGridView.Rows[0].Selected = true;
            }
            UpdateSelectedEmployeeInfo();
        }

        private void departmentsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (data.DepartmentList.Any())
            {
                departmentsDataGridView.Rows[0].Selected = true;
            }
            UpdateSelectedDepartmentInfo();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    Form addEmpForm = new EmployeeRegistryForm(data);
                    addEmpForm.ShowDialog();
                    break;

                case 1:
                    Form addDepForm = new DepartmentRegistryForm(data);
                    addDepForm.ShowDialog();
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
                    Form empEditForm = new EmployeeRegistryForm(data, selectedEmployee);
                    empEditForm.ShowDialog();
                    break;

                case 1:
                    Department selectedDepartment = departmentsDataGridView.CurrentRow.DataBoundItem as Department;
                    Form depEditForm = new DepartmentRegistryForm(data, selectedDepartment);
                    depEditForm.ShowDialog();
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

        private void editLoginInfoBtn_Click(object sender, EventArgs e)
        {
            Employee selectedEmployee = employeesDataGridView.CurrentRow.DataBoundItem as Employee;
            Form userEditForm = new adminEditLoginInfoForm(selectedEmployee);
            userEditForm.ShowDialog();
        }

        private void departmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedDepartmentInfo();
        }
    }
}
