using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace HospitalManagement
{
    public  class DatabaseHandler
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=projekt;Database=Hospital";

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
                        string telefonNr;
                        string eMail;
                        string blodTyp;
                        
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

                            postOrt = LoadPostort(postNr); // Gets the Postort corresponding to the Postnr from the database

                            //Creates patient and adds it to the list of patients using the temporary variables.
                            Patient patientToAdd = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp);
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
            returnPatient = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp);
            return returnPatient;
        }

        public bool AddPatient (Patient patientToAdd)
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

                            //cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));
                            //cmd.Parameters.Add(new NpgsqlParameter("firstname", NpgsqlDbType.Varchar));
                            //cmd.Parameters.Add(new NpgsqlParameter("lastname", NpgsqlDbType.Varchar));
                            //cmd.Parameters.Add(new NpgsqlParameter("address", NpgsqlDbType.Varchar));
                            //cmd.Parameters.Add(new NpgsqlParameter("postcode", NpgsqlDbType.Integer));
                            //cmd.Parameters.Add(new NpgsqlParameter("phone", NpgsqlDbType.Varchar));
                            //cmd.Parameters.Add(new NpgsqlParameter("email", NpgsqlDbType.Varchar));
                            //cmd.Parameters.Add(new NpgsqlParameter("blood", NpgsqlDbType.Varchar));

                            //cmd.Prepare();

                            //cmd.Parameters[0].Value = patientToAdd.Personnummer;
                            //cmd.Parameters[1].Value = patientToAdd.FirstName;
                            //cmd.Parameters[2].Value = patientToAdd.LastName;
                            //cmd.Parameters[3].Value = patientToAdd.Address;
                            //cmd.Parameters[4].Value = patientToAdd.PostalCode;
                            //cmd.Parameters[5].Value = patientToAdd.PhoneNr;
                            //cmd.Parameters[5].Value = patientToAdd.Email;
                            //cmd.Parameters[6].Value = patientToAdd.BloodType;

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
                    cmd.CommandText = $"UPDATE patient SET first_name = '{patientToUpdate.FirstName}', last_name = '{patientToUpdate.LastName}', address = '{patientToUpdate.Address}', postal_code = {patientToUpdate.PostalCode}, phone = '{patientToUpdate.PhoneNr}', email = '{patientToUpdate.Email}', bloodtype = '{patientToUpdate.BloodType}' WHERE person_id_nr = '{patientToUpdate.Personnummer}'";
                    
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
    }
}
