using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    /// <summary>
    /// Employee Class. Keeps track of a single Employee and its properties.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Properties that correspond to information about employee in the database.
        /// </summary>
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string PostalArea { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public string PersonNummer { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Specialty { get; set; }

        //Not sure right now if we should have a doctor class that inherits from this class
        //that has a property linking to a specialty, since only doctors have that, or if we
        //should just let all staff have a link to a specialty, but keep it null if there isn't one.

        /// <summary>
        /// Constructs a new instance of Employee.
        /// </summary>
        /// <param name="empId">The Employee ID</param>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="address">Street Address</param>
        /// <param name="postCode">Swedish style postal code</param>
        /// <param name="postArea">The area corresponding to the postal code</param>
        /// <param name="phoneNr">Telephone number</param>
        /// <param name="eMail">E-mail adress</param>
        /// <param name="persNr">Swedish Personal id-number</param>
        /// <param name="position">Job-title.</param>
        /// <param name="avdelning">Department the employee is hired to work in.</param>
        /// <param name="specialisering">Specialty. Only relevant if position is "Läkare"</param>
        public Employee(string empId, string firstName, string lastName, string address, int postCode, string postArea, string phoneNr, string eMail, string persNr, string position, string avdelning, string specialisering)
        {
            //Constructor with all the basic information about the employee. Will be called from a class/method
            //that loads the information from the database and creates the patient object.
            this.EmployeeID = empId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PostalCode = postCode;
            this.PostalArea = postArea;
            this.PhoneNr = phoneNr;
            this.Email = eMail;
            this.PersonNummer = persNr;
            this.Position = position;
            this.Department = avdelning;
            this.Specialty = specialisering;
        }

        /// <summary>
        /// Tells the Employee instance to update itself in the database. Calls the UpdateEmployee Method.
        /// </summary>
        /// <returns>Boolean value. Is true if update is successful.</returns>
        public Boolean UpdateSelfInDB()
        {
    
            DatabaseHandler db = new DatabaseHandler();
            return db.UpdateEmployee(this);
        }

        /// <summary>
        /// Override of ToString method.
        /// </summary>
        /// <returns>A string contaning last name, first name and specialty if applicable.</returns>
        public override string ToString()
        {
            if (!Specialty.Equals("N/A"))
            {
                return $"{LastName}, {FirstName}  -  {Specialty}";
            }
            else
            {
                return $"{LastName}, {FirstName}";
            }
           
        }

        /// <summary>
        /// Equals method for Employees.
        /// </summary>
        /// <param name="obj">An object to compare the Employee to.</param>
        /// <returns>Returns a boolean value. True if the object is an employee instance and all Properties of the two instances are the same.</returns>
        public override bool Equals(object obj)
        {
            //Compare method for Employees.
            if (!(obj is Employee)||obj==null)
            {
                //return false if comparing object is null or not an Employee object
                return false;
            }
            Employee e = obj as Employee;

            if (!e.EmployeeID.Equals(this.EmployeeID)) return false;
            if (!e.FirstName.Equals(this.FirstName)) return false;
            if (!e.LastName.Equals(this.LastName)) return false;
            if (!e.Address.Equals(this.Address)) return false;
            if (e.PostalCode != this.PostalCode) return false;
            if (!e.PhoneNr.Equals(this.PhoneNr)) return false;
            if (!e.Email.Equals(this.Email)) return false;
            if (!e.PersonNummer.Equals(this.PersonNummer)) return false;
            if (!e.Position.Equals(this.Position)) return false;
            if (!e.Specialty.Equals(this.Specialty)) return false;
            if (!e.Specialty.Equals(this.Specialty)) return false;

            return true; 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

