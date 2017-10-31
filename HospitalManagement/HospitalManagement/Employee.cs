using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    public class Employee
    {
        //Properties that correspond to information about employee in the staff table
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
            this.Email = eMail;
            this.PersonNummer = persNr;
            this.Position = position;
            this.Department = avdelning;
            this.Specialty = specialisering;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}.| {Specialty}"; //Will figure how to separate specialty if needed
        }
    }
}

