using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace HospitalManagement
{
    public class DatabaseHandler
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=Hospital";

        #region PatientMethods

        //Methods relating to Patients and the patient table. 
        public bool PatientExists(string patientToSearchFor)
        {
            // Checks if a patient with a specific personal_id_nr exists in the database.
            // Returns True if it does and False if it doesn't.
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    //Adds the connection and SQL-query to the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(person_id_nr) FROM patient WHERE person_id_nr = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = patientToSearchFor;

                    // Gets and stores the result of the query (the number of times the personal_id_nr
                    // appears in the database, which should be zero or none, since it has a unique
                    // constraint.
                    // That value is then converted to a boolean and returned.
                    int result = 0;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader.GetInt32(0);
                    }
                    return Convert.ToBoolean(result);
                }

            }

        }

        public List<Patient> LoadAllPatients()
        {
            //Returns a list of instance of the Patient class based on the values 
            //in the patient table of the database.
            List<Patient> resultList = new List<Patient>();
            string postOrt;
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM patient";

                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string personNr;
                        string firstName;
                        string lastName;
                        string adress;
                        int postNr;
                        string telefonNr = "";
                        string eMail = "";
                        string blodTyp;
                        string room = "";

                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            personNr = reader.GetString(0);
                            firstName = reader.GetString(1);
                            lastName = reader.GetString(2);
                            adress = reader.GetString(3);
                            postNr = reader.GetInt32(4);
                            telefonNr = reader.GetString(5);
                            eMail = reader.GetString(6);
                            blodTyp = reader.GetString(7);
                            if (!reader.IsDBNull(8))
                            {
                                room = reader.GetString(8);
                            }

                            postOrt = LoadPostort(postNr); // Gets the Postort corresponding to the Postnr from the database

                            //Creates patient and adds it to the list of patients using the temporary variables.
                            Patient patientToAdd = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp, room);
                            resultList.Add(patientToAdd);
                        }
                        return resultList;

                    }
                }

            }



        }

        public Patient LoadPatient(string searchPhrase)
        {
            //Returns a new instance of a specific person based on the value of person_id_nr =>OBS (changed to searchPhrase so other values can be used)  
            //in the patient table of the database.

            //Prepares variables used in creating the patient.
            Patient returnPatient;
            string personNr = "";
            string firstName = "";
            string lastName = "";
            string adress = "";
            int postNr = 0;
            string telefonNr = "";
            string eMail = "";
            string blodTyp = "";
            string room = "";
            string postOrt = "";


            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    //Opens the connection.
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        //Configures the connection and SQL-query for the command and prepares it.
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM patient WHERE person_id_nr = :searchPhrase OR last_name = :searchPhrase";


                        cmd.Parameters.Add(new NpgsqlParameter("searchPhrase", NpgsqlDbType.Varchar));


                        cmd.Prepare();

                        cmd.Parameters[0].Value = searchPhrase;


                        using (var reader = cmd.ExecuteReader())
                            //Reads values from the database into the temporary variables.
                            while (reader.Read())
                            {
                                {
                                    personNr = reader.GetString(0);
                                    firstName = reader.GetString(1);
                                    lastName = reader.GetString(2);
                                    adress = reader.GetString(3);
                                    postNr = reader.GetInt32(4);
                                    telefonNr = reader.GetString(5);
                                    eMail = reader.GetString(6);
                                    blodTyp = reader.GetString(7);
                                    if (!reader.IsDBNull(8))
                                    {
                                        room = reader.GetString(8);
                                    }

                                }
                            }

                    }

                }


            }
            catch (PostgresException e)
            {
                Console.WriteLine(e.ToString());
            }

            //Loads the Postort connected to the Postal Code. 
            postOrt = LoadPostort(postNr);

            //Creates and returns the Patient instance.
            returnPatient = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp, room);
            return returnPatient;
        }

        public bool AddPatient(Patient patientToAdd)
        {
            //Adds a new patient to the database. 

            if (!PatientExists(patientToAdd.Personnummer))
            {
                //Checks if the personal_id_nr of the Patient to be added already exists.
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    //Opens connection.
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        // Adds connection and SQL-string to the command and executes it.
                        try
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = $"INSERT INTO patient (person_id_nr, first_name, last_name, address, postal_code, phone, email, bloodtype) VALUES ('{patientToAdd.Personnummer}', '{patientToAdd.FirstName}', '{patientToAdd.LastName}', '{patientToAdd.Address}', {patientToAdd.PostalCode},'{patientToAdd.PhoneNr}', '{patientToAdd.Email}', '{patientToAdd.BloodType}')";

                            int recordsAffected = cmd.ExecuteNonQuery();

                            //Returns a boolean which is True if any rows have been affected. 
                            return Convert.ToBoolean(recordsAffected);
                        }
                        catch (PostgresException e)
                        {
                            //Writes Exception error to Console and returns false, if a
                            //PostgresException occurs.
                            Console.WriteLine(e.ToString());
                            return false;
                        }

                    }
                }

            }
            else
            {
                // Returns false if the personal_id_nr already exists
                return false;
            }

        }

        public bool UpdatePatient(Patient patientToUpdate)
        {
            //Updates the patient in the database. 
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {

                    // Adds connection and SQL-string to the command and executes it.
                    cmd.Connection = conn;
                    if (patientToUpdate.Room.Equals("No Change"))
                    {
                        cmd.CommandText = $"UPDATE patient SET first_name = '{patientToUpdate.FirstName}', last_name = '{patientToUpdate.LastName}', address = '{patientToUpdate.Address}', postal_code = {patientToUpdate.PostalCode}, phone = '{patientToUpdate.PhoneNr}', email = '{patientToUpdate.Email}', bloodtype = '{patientToUpdate.BloodType}' WHERE person_id_nr = '{patientToUpdate.Personnummer}'";
                    }
                    else if (patientToUpdate.Room.Equals(""))
                    {
                        cmd.CommandText = $"UPDATE patient SET first_name = '{patientToUpdate.FirstName}', last_name = '{patientToUpdate.LastName}', address = '{patientToUpdate.Address}', postal_code = {patientToUpdate.PostalCode}, phone = '{patientToUpdate.PhoneNr}', email = '{patientToUpdate.Email}', bloodtype = '{patientToUpdate.BloodType}', room = null WHERE person_id_nr = '{patientToUpdate.Personnummer}'";
                    }
                    else
                    {
                        cmd.CommandText = $"UPDATE patient SET first_name = '{patientToUpdate.FirstName}', last_name = '{patientToUpdate.LastName}', address = '{patientToUpdate.Address}', postal_code = {patientToUpdate.PostalCode}, phone = '{patientToUpdate.PhoneNr}', email = '{patientToUpdate.Email}', bloodtype = '{patientToUpdate.BloodType}', room = '{patientToUpdate.Room}' WHERE person_id_nr = '{patientToUpdate.Personnummer}'";
                    }

                    int recordsAffected = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(recordsAffected); //returns 1 if there were any columns affected and 0 if there wasn't. 

                }

            }
        }

        public bool DeletePatient(string patientToDelete)
        {
            // Deletes a patient from the database, by personal_id_nr(personnummer)
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    //Adds connection and SQL-string to the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM patient WHERE person_id_nr = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = patientToDelete;

                    //Executes the command. 
                    int recordsAffected = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(recordsAffected); //returns 1 if there were any columns affected and 0 if there wasn't. 

                }

            }
        }
        #endregion  

        public string LoadPostort(int postkod)
        {
            //Gets the Postal Area corresponding to a Postal Code from the database. 
            string returnPostOrt = "Finns ej i databasen.";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT placename FROM place WHERE postal_code = :code";

                    cmd.Parameters.Add(new NpgsqlParameter("code", NpgsqlDbType.Integer));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = postkod;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnPostOrt = reader.GetString(0);
                        }
                    }
                }

            }
            return returnPostOrt;
        }

        #region EmployeeMethods
        //Methods related to Employees and interacting with the staff table.

        public bool EmployeeExists(string employeeIdToSearchFor)
        {
            // Checks if an employee with a specific employee_id exists in the database.
            // Returns True if it does and False if it doesn't.
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    //Adds the connection and SQL-query to the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(employee_id) FROM staff WHERE employee_id = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = employeeIdToSearchFor;

                    // Gets and stores the result of the query (the number of times the employee_id
                    // appears in the database, which should be zero or none, since it has unique
                    // constraint.
                    // That value is then converted to a boolean and returned.
                    int result = 0;
        NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader.GetInt32(0);
                    }
                    return Convert.ToBoolean(result);
                }

            }

        }

        public Employee LoadEmployee(string EmployeeID)
        {
            //Returns a new instance of a specific person based on the value of employee_id 
            //in the staff table of the database.

            //Prepares variables used in creating the Employee.
            Employee returnEmployee;
            string anstNr = "Test";
            string firstName = "";
            string lastName = "";
            string adress = "";
            int postNr = 0;
            string telefonNr = "";
            string eMail = "";
            string personnummer = "";
            string position = "";
            string departmentNr = "";
            string specialtyNr = "";
            string postOrt = "";
            string department = "";
            string specialty = "N/A";
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    //Opens the connection.
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        //Configures the connection and SQL-query for the command and prepares it.
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM staff WHERE employee_id = :id";

                        cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                        cmd.Prepare();

                        cmd.Parameters[0].Value = EmployeeID;

                        using (var reader = cmd.ExecuteReader())
                            //Reads values from the database into the temporary variables.
                            while (reader.Read())
                            {
                                {
                                    anstNr = reader.GetString(0);
                                    firstName = reader.GetString(1);
                                    lastName = reader.GetString(2);
                                    adress = reader.GetString(3);
                                    postNr = reader.GetInt32(4);
                                    telefonNr = reader.GetString(5);
                                    eMail = reader.GetString(6);
                                    personnummer = reader.GetString(7);
                                    departmentNr = reader.GetString(8);
                                    position = reader.GetString(9);
                                    if (!reader.IsDBNull(10))
                                    {
                                        specialtyNr = reader.GetString(10);
                                    }
                                }
                            }
                    }
                }


            }
            catch (PostgresException e)
            {

                Console.WriteLine(e.ToString());
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }

            //Loads the Postort connected to the Postal Code. 
            postOrt = LoadPostort(postNr);
            department = LoadDepartment(departmentNr);
            if (specialtyNr != "")
            {
                specialty = LoadSpecialty(specialtyNr);
            }

            //Creates and returns the Employee instance.
            returnEmployee = new Employee(anstNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, personnummer, position, department, specialty);
            return returnEmployee;

        }

        public List<Employee> LoadAllEmployees()
        {
            //Returns a list of instance of the Patient class based on the values 
            //in the patient table of the database.
            List<Employee> resultList = new List<Employee>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM staff";

                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            //Defines temporary variables and their default values.
                            string anstNr = "Test";
                            string firstName = "";
                            string lastName = "";
                            string adress = "";
                            int postNr = 0;
                            string telefonNr = "";
                            string eMail = "";
                            string personnummer = "";
                            string departmentNr = "";
                            string position = "";
                            string specialtyNr = "";
                            string postOrt = "";
                            string department = "";
                            string specialty = "N/A";

                            //Reads values from the database into the temporary variables.
                            anstNr = reader.GetString(0);
                            firstName = reader.GetString(1);
                            lastName = reader.GetString(2);
                            adress = reader.GetString(3);
                            postNr = reader.GetInt32(4);
                            telefonNr = reader.GetString(5);
                            eMail = reader.GetString(6);
                            personnummer = reader.GetString(7);
                            departmentNr = reader.GetString(8);
                            position = reader.GetString(9);
                            if (!reader.IsDBNull(10))
                            {
                                specialtyNr = reader.GetString(10);
                            }

                            postOrt = LoadPostort(postNr); // Gets the Postort corresponding to the Postnr from the database
                            department = LoadDepartment(departmentNr);
                            if (!specialtyNr.Equals(""))
                            {
                                specialty = LoadSpecialty(specialtyNr);
                            }
                            //Creates patient and adds it to the list of patients using the temporary variables.
                            Employee employeeToAdd = new Employee(anstNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, personnummer, position, department, specialty);
                            resultList.Add(employeeToAdd);
                        }
                        return resultList;

                    }
                }

            }
        }

        public bool AddEmployee(Employee employeeToAdd)
        {
            //Adds a new employee to the database. 

            if (!EmployeeExists(employeeToAdd.EmployeeID))
            {
                //Checks if the employee_id of the Patient to be added already exists.
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    //Opens connection.
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        // Adds connection and SQL-string to the command and executes it.
                        try
                        {
                            cmd.Connection = conn;
                            if (!employeeToAdd.Specialty.Equals("N/A"))
                            {
                                cmd.CommandText = $"INSERT INTO staff (employee_id, first_name, last_name, address, postal_code, phone, email, person_id_nr, department, position, specialty) VALUES ('{employeeToAdd.EmployeeID}', '{employeeToAdd.FirstName}', '{employeeToAdd.LastName}', '{employeeToAdd.Address}', {employeeToAdd.PostalCode},'{employeeToAdd.PhoneNr}', '{employeeToAdd.Email}', '{employeeToAdd.PersonNummer}', '{employeeToAdd.Department}', '{employeeToAdd.Position}', '{employeeToAdd.Specialty}' )";
                            }
                            else
                            {
                                cmd.CommandText = $"INSERT INTO staff (employee_id, first_name, last_name, address, postal_code, phone, email, person_id_nr, department, position) VALUES ('{employeeToAdd.EmployeeID}', '{employeeToAdd.FirstName}', '{employeeToAdd.LastName}', '{employeeToAdd.Address}', {employeeToAdd.PostalCode},'{employeeToAdd.PhoneNr}', '{employeeToAdd.Email}', '{employeeToAdd.PersonNummer}', '{employeeToAdd.Department}', '{employeeToAdd.Position}')";
                            }

                            int recordsAffected = cmd.ExecuteNonQuery();

                            //Returns a boolean which is True if any rows have been affected. 
                            return Convert.ToBoolean(recordsAffected);
                        }
                        catch (PostgresException e)
                        {
                            //Writes Exception error to Console and returns false, if a
                            //PostgresException occurs.
                            Console.WriteLine(e.ToString());
                            return false;
                        }

                    }
                }

            }
            else
            {
                // Returns false if the employee_id already exists
                return false;
            }
        }

        public void UpdateEmployee(Employee employeeToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee()
        {
            throw new NotImplementedException();
        }

        public string LoadHighestUsedEmployeeId(string position)
        {
            //Gets the Postal Area corresponding to a Postal Code from the database. 
            string returnId = "Not in DB";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT MAX(employee_id) FROM staff WHERE position = :pos";

                    cmd.Parameters.Add(new NpgsqlParameter("pos", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = position;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnId = reader.GetString(0);
                        }
                    }
                }

            }
            return returnId;

        }
        #endregion

        #region JournalMethods
        //Methods concerned with loading or changing data related to JournalNotes in the Database

        public List<JournalPost> LoadPatientNotes(string personnummer)
        {
            //Returns a list of instance of the prescription class based on the values 
            //in the database related to a specific patient.
            List<JournalPost> resultList = new List<JournalPost>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM journalpost WHERE patient = :patient";

                    cmd.Parameters.Add(new NpgsqlParameter("patient", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = personnummer;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        DateTime date;
                        string doctor;
                        string patient;
                        string noteType;
                        string noteText;
                        bool important;

                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            date = reader.GetDateTime(0);
                            doctor = reader.GetString(1);
                            patient = reader.GetString(2);
                            noteType = reader.GetString(3);
                            noteText = reader.GetString(4);
                            important = reader.GetBoolean(5);

                            //Creates prescription instance and adds it to the list of medications using the temporary variables.
                            JournalPost journalpostToAdd = new JournalPost(date, doctor, patient, noteType, noteText, important);
                            resultList.Add(journalpostToAdd);
                        }
                        return resultList;

                    }
                }

            }
        }

        public bool AddJournalEntry(string user, string patient, string entryType, string content, bool imp)
        {
            //This method is for saving entries in a patients journal. The variables passed to the method are the following:
            // patient = personal_id_nr of patient
            // user = employee_id of person causing the entry to be created.
            // entryType = the type of entry (registration, labresult, booking, etc)
            // content = the main text of any journal Note, results of labtest, etc
            // important = set to true if this is vital information about the patient that deserves to be highlighted in any informational displays.


            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds connection and SQL-parameters to the command and executes it.
                    try
                    {
                        cmd.Connection = conn;

                        cmd.CommandText = "Insert INTO journalpost (timestamp, staff, patient, type, text, important) VALUES (:time, :userid, :pat, :type, :info, :important)";
                        //cmd.CommandText = $"INSERT INTO journalpost (timestamp, staff, patient, type, text, important) VALUES (DateTime.Now, '{user}', '{patient}', '{entryType}', '{content}', {imp})"; 

                        cmd.Parameters.Add(new NpgsqlParameter("time", NpgsqlDbType.Timestamp));
                        cmd.Parameters.Add(new NpgsqlParameter("userid", NpgsqlDbType.Varchar));
                        cmd.Parameters.Add(new NpgsqlParameter("pat", NpgsqlDbType.Varchar));
                        cmd.Parameters.Add(new NpgsqlParameter("type", NpgsqlDbType.Varchar));
                        cmd.Parameters.Add(new NpgsqlParameter("info", NpgsqlDbType.Text));
                        cmd.Parameters.Add(new NpgsqlParameter("important", NpgsqlDbType.Boolean));

                        cmd.Prepare();

                        cmd.Parameters[0].Value = DateTime.Now;
                        cmd.Parameters[1].Value = user;
                        cmd.Parameters[2].Value = patient;
                        cmd.Parameters[3].Value = entryType;
                        cmd.Parameters[4].Value = content;
                        cmd.Parameters[5].Value = imp;


                        int recordsAffected = cmd.ExecuteNonQuery();

                        //Returns a boolean which is True if any rows have been affected. 
                        return Convert.ToBoolean(recordsAffected);
                    }
                    catch (PostgresException e)
                    {
                        //Writes Exception error to Console and returns false, if a
                        //PostgresException occurs.
                        Console.WriteLine(e.ToString());
                        return false;
                    }

                }
            }

        }

        public void DeleteJournalEntry()
        {
            //Placeholder for method to delete journalentries should we need it. Only admins should be allowed to do this.
            throw new NotImplementedException();
        }
        #endregion 

        public string LoadDepartment(string departmentID)
        {
            //Gets the Department corresponding to a department from the database. 
            string returnDepartment = "Finns ej i databasen.";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT name FROM department WHERE department_id = :code";

                    cmd.Parameters.Add(new NpgsqlParameter("code", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = departmentID;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnDepartment = reader.GetString(0);
                        }
                    }
                }
            }
            return returnDepartment;

        }

        public string LoadDepartmentIDByName(string name)
        {
            //Gets the DepartmentID corresponding to a departmentname from the database. 
            string returnDepartment = "Finns ej i databasen.";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT department_id FROM department WHERE name = :code";

                    cmd.Parameters.Add(new NpgsqlParameter("code", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = name;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnDepartment = reader.GetString(0);
                        }
                    }
                }
            }
            return returnDepartment;

        }

        public string LoadSpecialty(string specID)
        {
            //Gets the Specialty corresponding to a spec_id in specialty from the database. 
            string returnSpecialty = "Finns ej i databasen.";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT specialty FROM specialty WHERE spec_id = :code";

                    cmd.Parameters.Add(new NpgsqlParameter("code", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = specID;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnSpecialty = reader.GetString(0);
                        }
                    }
                }

            }
            return returnSpecialty;
        }

        public Dictionary<string, string> LoadSpecialtyDictionary()
        {
            //Loads all specialties from the database and puts them in a dictionary with the name as Key and the ID as value
            Dictionary<string, string> resultDictionary = new Dictionary<string, string>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM specialty";

                    using (var reader = cmd.ExecuteReader())
                    {   
                        while (reader.Read())
                        {
                            //Reads values from the database into temporary variables
                            string id = reader.GetString(0);
                            string name = reader.GetString(1);
                            
                            //Ads the values of the temporary variables to the Dictionary.
                            resultDictionary.Add(name, id);
                        }
                        return resultDictionary;

                    }
                }

            }

        }

        //Methods related to usernames and passwords from the user table.
        #region userinfoMethods

        public Boolean UserExists(string username)
        {

            // Checks if a user with with a specific username exists in the database.
            // Returns True if it does and False if it doesn't.
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    //Adds the connection and SQL-query to the command and prepares it.
                    string commandString = "";

                    cmd.Connection = conn;

                    commandString = $"SELECT COUNT (*) FROM userinfo WHERE id = '{username}'";
                    //commandString = "SELECT COUNT (*) FROM userinfo WHERE 'id' = :id";

                    cmd.CommandText = commandString;


                    //cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    //cmd.Prepare();

                    //cmd.Parameters[0].Value = username;

                    // Gets and stores the result of the query (the number of times the personal_id_nr
                    // appears in the database, which should be zero or none, since it has a unique
                    // constraint.
                    // That value is then converted to a boolean and returned.
                    int result = 0;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader.GetInt16(0);
                    }
                    //return Convert.ToBoolean(result);
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

        public UserInfo LoadUser(string username, Boolean isPatient)
        {
            //This method gets the info from the user table and creates a userinfo object 
            //that can be used by the login. 
            UserInfo returnUserInfo;

            //Prepares variables used in creating the Userinfo instance.
            string identifier = "None";
            string usename = "";
            string password = "";
            string patientid = "";
            string staffid = "";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    //Opens the connection.
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        //Configures the connection and SQL-query for the command and prepares it.
                        cmd.Connection = conn;
                        //cmd.CommandText = $"SELECT * FROM user WHERE 'user_id' = '{username}'";
                        cmd.CommandText = "SELECT * FROM userinfo WHERE id = :id";

                        cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                        cmd.Prepare();

                        cmd.Parameters[0].Value = username;

                        using (var reader = cmd.ExecuteReader())
                            //Reads values from the database into the temporary variables.
                            while (reader.Read())
                            {
                                {
                                    usename = reader.GetString(0);
                                    password = reader.GetString(1);
                                    if (!reader.IsDBNull(2))
                                    {
                                        patientid = reader.GetString(2);
                                    }
                                    if (!reader.IsDBNull(3))
                                    {
                                        staffid = reader.GetString(3);
                                    }

                                }
                            }

                        if (isPatient)
                        {
                            identifier = patientid;
                        }
                        else
                        {
                            identifier = staffid;
                        }
                        returnUserInfo = new UserInfo(identifier, usename, password);

                        return returnUserInfo;
                    }
                }


            }
            catch (PostgresException e)
            {

                Console.WriteLine(e.ToString());
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }

            //Creates and returns the UserInfo instance.
            returnUserInfo = new UserInfo(identifier, usename, password);
            return returnUserInfo;


        }

        public bool AddPatientUser(string personnummer)
        {
            //Adds a new user account to the database for a patient. 

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds relevant data to temporary variables. Mostly for debugging purposes.
                    string id = personnummer;
                    string password = "password";
                    string patient = personnummer;

                    // Adds connection and SQL-string to the command and executes it.
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"INSERT INTO userinfo (id, password, patient) VALUES ('{id}', '{password}', '{patient}')";

                        int recordsAffected = cmd.ExecuteNonQuery();

                        //Returns a boolean which is True if any rows have been affected. 
                        return Convert.ToBoolean(recordsAffected);
                    }
                    catch (PostgresException e)
                    {
                        //Writes Exception error to DebugWindow and returns false, if a
                        //PostgresException occurs.
                        System.Diagnostics.Debug.WriteLine(e.ToString());
                        return false;
                    }

                }   
            }
        }

        public bool UpdateUser(UserInfo userToUpdate, string newPassword, bool isPatient)
        {
            //Updates the userinfo in the database. Password is only updated if newPassword is not null or empty.
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {

                    // Adds connection and SQL-string to the command and executes it.
                    cmd.Connection = conn;
                    if (isPatient)
                    {
                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            cmd.CommandText = $"UPDATE userinfo SET id = '{userToUpdate.Username}', password = '{newPassword}' WHERE patient = '{userToUpdate.Identifier}'";
                        }
                        else
                        {
                            cmd.CommandText = $"UPDATE userinfo SET id = '{userToUpdate.Username}' WHERE patient = '{userToUpdate.Identifier}'";
                        }  
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(newPassword))
                        {
                            cmd.CommandText = $"UPDATE userinfo SET id = '{userToUpdate.Username}', password = '{newPassword}' WHERE staff = '{userToUpdate.Identifier}'";
                        }
                        else
                        {
                            cmd.CommandText = $"UPDATE userinfo SET id = '{userToUpdate.Username}' WHERE staff = '{userToUpdate.Identifier}'";
                        }
                    }

                    int recordsAffected = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(recordsAffected); //returns 1 if there were any columns affected and 0 if there wasn't. 

                }

            }
        }
        #endregion

        //Methods related to getting info about medication and prescriptions from the database
        #region Medication and Prescription Methods
        public List<Medication> LoadAllMedications()
        {
            //Returns a list of instance of the Medication class based on the values 
            //in the patient table of the database.
            List<Medication> resultList = new List<Medication>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM medication";

                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string medID;
                        string medName;
                        decimal price;
                        decimal wholesale;

                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            medID = reader.GetString(0);
                            medName = reader.GetString(1);
                            price = reader.GetDecimal(2);
                            wholesale = reader.GetDecimal(3);

                            //Creates medication and adds it to the list of medications using the temporary variables.
                            Medication drugToAdd = new Medication(medID, medName, price, wholesale);
                            resultList.Add(drugToAdd);
                        }
                        return resultList;

                    }
                }

            }

        }

        public String LoadMedicationName(string medicalID)
        {
            //Gets the Postal Area corresponding to a Postal Code from the database. 
            string returnMedication = "Finns ej i databasen.";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT name FROM medication WHERE medication_id = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = medicalID;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnMedication = reader.GetString(0);
                        }
                    }
                }

            }
            return returnMedication;
        }

        public List<Prescription> LoadPatientPrescriptions(string personnummer)
        {
            //Returns a list of instance of the prescription class based on the values 
            //in the database related to a specific patient.
            List<Prescription> resultList = new List<Prescription>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM prescription WHERE patient = :patient";

                    cmd.Parameters.Add(new NpgsqlParameter("patient", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = personnummer;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        DateTime date;
                        string doctor;
                        string patient;
                        string medicine;
                        string instructions;
                        int nr;
                        string medicineName;

                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            date = reader.GetDateTime(0);
                            doctor = reader.GetString(1);
                            patient = reader.GetString(2);
                            medicine = reader.GetString(3);
                            instructions = reader.GetString(4);
                            nr = reader.GetInt32(5);
                            medicineName = LoadMedicationName(medicine);

                            //Creates prescription instance and adds it to the list of medications using the temporary variables.
                            Prescription prescriptionToAdd = new Prescription(date, doctor, patient, medicine, instructions, nr, medicineName);
                            resultList.Add(prescriptionToAdd);
                        }
                        return resultList;

                    }
                }

            }
        }

        public Boolean AddPrescription(Prescription prescription)
        {
            //Adds a new prescription to the database. 
            Prescription prescriptionToAdd = prescription;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds relevant data to temporary variables. Mostly for debugging purposes.
                    DateTime dateToRegister = prescriptionToAdd.PrescribedAt;
                    string prescribingDoctor = prescriptionToAdd.PrescribedBy;
                    string receivingPatient = prescriptionToAdd.PrescribedTo;
                    string medCode = prescriptionToAdd.MedicineIDCode;
                    string instructions = prescriptionToAdd.Instructions;
                    int uttag = prescriptionToAdd.NrOfTimes;

                    // Adds connection and SQL-string to the command and executes it.
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"INSERT INTO prescription (date, doctor, patient, medicine, instructions, nr_of_times) VALUES ('{prescriptionToAdd.PrescribedAt}', '{prescriptionToAdd.PrescribedBy}', '{prescriptionToAdd.PrescribedTo}', '{prescriptionToAdd.MedicineIDCode}', '{prescriptionToAdd.Instructions}','{prescriptionToAdd.NrOfTimes}')";

                        int recordsAffected = cmd.ExecuteNonQuery();

                        //Returns a boolean which is True if any rows have been affected. 
                        return Convert.ToBoolean(recordsAffected);
                    }
                    catch (PostgresException e)
                    {
                        //Writes Exception error to DebugWindow and returns false, if a
                        //PostgresException occurs.
                        System.Diagnostics.Debug.WriteLine(e.ToString());
                        return false;
                    }

                }
            }
        }

        #endregion

        public List<Booking> LoadPatientBookings(string personnummer)
        {
            //Returns a list of instance of the booking class based on the values 
            //in the database related to a specific patient.
            List<Booking> resultList = new List<Booking>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM booking WHERE patient = :patient";

                    cmd.Parameters.Add(new NpgsqlParameter("patient", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = personnummer;
                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        int booking_id;
                        string purpose;
                        DateTime start_time;
                        DateTime end_time;
                        string staff;
                        string patient;
                        string room;
                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            booking_id = reader.GetInt32(0);
                            purpose = reader.GetString(1);
                            start_time = reader.GetDateTime(2);
                            end_time = reader.GetDateTime(3);
                            staff = reader.GetString(4);
                            patient = reader.GetString(5);
                            room = reader.GetString(6);

                            //Creates booking instance and adds it to the list of bookings using the temporary variables.
                            Booking bookingToAdd = new Booking(booking_id, purpose, start_time, end_time, staff, patient, room);
                            resultList.Add(bookingToAdd);
                        }
                        return resultList;
                    }
                }
            }
        }


        //Methods for loading info about departments

        public List<Department> LoadAllDepartments()
        {
            //Returns a list of all Departments 
            List<Department> resultList = new List<Department>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM department";

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string depName;
                        string depID;
                        TimeSpan openTime = TimeSpan.Zero;
                        TimeSpan closeTime = TimeSpan.Zero;

                        //Reads values from the database into temporary variables
                        while (reader.Read())
                        {
                            depID = reader.GetString(0);
                            depName = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                            {
                                openTime = reader.GetTimeSpan(2);
                            }
                            if (!reader.IsDBNull(3))
                            {
                                closeTime = reader.GetTimeSpan(3);
                            }

                            //Creates an instance of Department and adds it to the List.
                            Department tempDep = new Department(depID, depName, openTime, closeTime);
                            resultList.Add(tempDep);
                        }
                        return resultList;
                    }
                }

            }
        }


        public Department LoadDepartmentByID(string departmentID)
        {
            //Returns a list of all Departments 
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();
                Department result = new Department("N/A", "Not in DB", TimeSpan.Zero, TimeSpan.Zero);
                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = $"SELECT * FROM department WHERE department_id = '{departmentID}'";

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string depName = "Not in DB";
                        string depID;
                        TimeSpan openTime = TimeSpan.Zero;
                        TimeSpan closeTime = TimeSpan.Zero;

                        //Reads values from the database into temporary variables
                        while (reader.Read())
                        {
                            depID = reader.GetString(0);
                            depName = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                            {
                                openTime = reader.GetTimeSpan(2);
                            }
                            if (!reader.IsDBNull(3))
                            {
                                closeTime = reader.GetTimeSpan(3);
                            }

                            //Creates an instance of Department and returns it.
                            result = new Department(depID, depName, openTime, closeTime);
                            
                        }
                        return result;
                    }
                }

            }

        }



        //Methods for loading info about Rooms or related to Rooms

        public int LoadRoomNrOfOccupants(string roomID)
        {
            // Returns the number of signed in Patients that are assigned to a certain room.
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    //Adds the connection and SQL-query to the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(person_id_nr) FROM patient WHERE room = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = roomID;

                    // Gets and stores the result of the query (the number of times the personal_id_nr
                    // appears in the database, which should be zero or none, since it has a unique
                    // constraint.
                    // That value is then converted to a boolean and returned.
                    int result = 0;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader.GetInt32(0);
                    }
                    return result;
                }

            }
        }


        public string LoadDepartmentOfRoom (string roomID)
        {
            //Returns the departmentID that a specific room belongs to. 
            string returnDepartmentID = "";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds the connection and SQL-string to the Command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT department FROM room WHERE room_id = :id";

                    cmd.Parameters.Add(new NpgsqlParameter(":id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = roomID;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Reads the value from the database.
                        while (reader.Read())
                        {
                            returnDepartmentID = reader.GetString(0);
                        }
                    }
                }

            }
            return returnDepartmentID;

        }

        public List<Room> LoadDepartmentRooms(string departmentID)
        {
            //Returns a list of all the Rooms in a spcific Department 
            //in the database related to a specific patient.
            List<Room> resultList = new List<Room>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM room WHERE department = :dep";

                    cmd.Parameters.Add(new NpgsqlParameter("dep", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = departmentID;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string roomID;
                        string function;
                        int capacity;
                        int maxCapacity;
                        string depID;

                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            roomID = reader.GetString(0);
                            function = reader.GetString(1);
                            capacity = reader.GetInt16(2);
                            maxCapacity = reader.GetInt16(3);
                            depID = reader.GetString(4);

                            //Creates room instance and adds it to the list of rooms using the temporary variables.
                            Room roomToAdd = new Room(roomID, function, capacity, maxCapacity, depID);
                            resultList.Add(roomToAdd);
                        }
                        return resultList;

                    }
                }

            }
        }

        public Boolean AddBooking(Booking booking)
        {
            //Adds a new booking to the database. 
            Booking bookingToAdd = booking;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens connection.
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    // Adds relevant data to temporary variables. Mostly for debugging purposes.
                    int id = bookingToAdd.BookingID;
                    string purpose = bookingToAdd.BookingPurpose;
                    DateTime start = bookingToAdd.BookingStart;
                    DateTime end = bookingToAdd.BookingEnd;
                    string staff = bookingToAdd.StaffName;
                    string patient = bookingToAdd.PatientName;
                    string room = bookingToAdd.RoomNr;

                    // Adds connection and SQL-string to the command and executes it.
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = $"INSERT INTO booking (id, purpose, start, end, staff, patient, room) VALUES ('{bookingToAdd.BookingID}', '{bookingToAdd.BookingPurpose}', '{bookingToAdd.BookingStart}', '{bookingToAdd.BookingEnd}', '{bookingToAdd.StaffName}','{bookingToAdd.PatientName}','{bookingToAdd.RoomNr}')";

                        int recordsAffected = cmd.ExecuteNonQuery();

                        //Returns a boolean which is True if any rows have been affected. 
                        return Convert.ToBoolean(recordsAffected);
                    }
                    catch (PostgresException e)
                    {
                        //Writes Exception error to DebugWindow and returns false, if a
                        //PostgresException occurs.
                        System.Diagnostics.Debug.WriteLine(e.ToString());
                        return false;
                    }

                }
            }
        }

        public List<Employee> LoadDoctors(string specialty)
        {
            //Returns a list of instance of the employee class based on the values 
            //in the database 
            List<Employee> resultList = new List<Employee>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                   if (specialty == null)
                    {
                        specialty = "";
                        cmd.CommandText = "SELECT * FROM staff WHERE specialty IS NOT NULL";
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM staff WHERE specialty = :specialty";
                    }

                    cmd.Parameters.Add(new NpgsqlParameter("specialty", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = specialty;
                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string empId;
                        string firstName;
                        string lastName;
                        string address;
                        int postCode;
                        string postArea;
                        string phoneNr;
                        string eMail;
                        string persNr;
                        string position;
                        string avdelning;
                        string specialisering;
                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            empId = reader.GetString(0);
                            firstName = reader.GetString(1);
                            lastName = reader.GetString(2);
                            address = reader.GetString(3);
                            postCode = reader.GetInt32(4);
                            postArea = reader.GetString(5);
                            phoneNr = reader.GetString(6);
                            eMail = reader.GetString(7);
                            persNr = reader.GetString(8);
                            position = reader.GetString(9);
                            avdelning = reader.GetString(10);
                            specialisering = reader.GetString(10);

                            //Creates doctor instance and adds it to the list of doctors using the temporary variables.
                            Employee doctorToAdd = new Employee(empId, firstName, lastName, address, postCode, postArea, phoneNr, eMail, persNr, position, avdelning, specialisering);
                            resultList.Add(doctorToAdd);
                        }
                        return resultList;
                    }
                }
            }
        }

        public List<Room> LoadVisitationRooms(string roomfunction)
        {
            //Returns a list of all the Rooms in a spcific Department 
            //in the database related to a specific patient.
            List<Room> resultList = new List<Room>();
            
            using (var conn = new NpgsqlConnection(connectionString))
            {
                //Opens the connection to the database
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    //Configures the connection and SQL-query for the command and prepares it.
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM room WHERE function = :roomfunction";
                    
                    cmd.Parameters.Add(new NpgsqlParameter("roomfunction", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = roomfunction;

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Defines temporary variables.
                        string roomID;
                        string function;
                        int capacity;
                        int maxCapacity;
                        string depID;

                        //Reads values from the database into the temporary variables.
                        while (reader.Read())
                        {
                            roomID = reader.GetString(0);
                            function = reader.GetString(1);
                            capacity = reader.GetInt16(2);
                            maxCapacity = reader.GetInt16(3);
                            depID = reader.GetString(4);

                            //Creates room instance and adds it to the list of rooms using the temporary variables.
                            Room roomToAdd = new Room(roomID, function, capacity, maxCapacity, depID);
                            resultList.Add(roomToAdd);
                        }
                        return resultList;

                    }
                }

            }
        }


    }
}
