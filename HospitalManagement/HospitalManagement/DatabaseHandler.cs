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

        public bool PatientExists(Patient patientToSearchFor)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(person_id_nr) FROM patient WHERE person_id_nr = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = patientToSearchFor.Personnummer;

                    int result = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(result);
                }

            }

        }

        public List<Patient> LoadAllPatients()
        {
            //Returns a new instance of a specific person based on the value of person_id_nr 
            //in the patient table of the database.
            List<Patient> resultList = new List<Patient>();
            string postOrt;
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM patient";

                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        string personNr;
                        string firstName;
                        string lastName;
                        string adress;
                        int postNr;
                        string telefonNr;
                        string eMail;
                        string blodTyp;
                        
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

                            postOrt = loadPostort(postNr);

                            Patient patientToAdd = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp);
                            resultList.Add(patientToAdd);
                        }
                        return resultList;
                        
                    }
                }
                
            }
            


        }

        public Patient LoadPatient(string personnr)
        {
            //Returns a new instance of a specific person based on the value of person_id_nr 
            //in the patient table of the database.
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

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM patient WHERE person_id_nr = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = personnr;

                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            {
                                personNr = reader.GetString(0);
                                firstName = reader.GetString(1);
                                lastName = reader.GetString(2);
                                adress = reader.GetString(3);
                                postNr = reader.GetInt32(4);
                                //telefonNr = reader.GetString(5) ?? "No Number";
                                eMail = reader.GetString(6);
                                blodTyp = reader.GetString(7);
                            }
                        }
                    
                }

            }
            postOrt = loadPostort(postNr);
            returnPatient = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp);
            return returnPatient;
        }

        public bool AddPatient (Patient patientToAdd)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO patient (person_id_nr, first_name, last_name, address, postal_code, email, bloodtype) VALUES (:id, :firstname, :lastname, :address, :postcode, :email, :blood )", conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("firstname", NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("lastname", NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("address", NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("postcode", NpgsqlDbType.Integer));
                    //cmd.Parameters.Add(new NpgsqlParameter("phone", NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("email", NpgsqlDbType.Varchar));
                    cmd.Parameters.Add(new NpgsqlParameter("blood", NpgsqlDbType.Varchar));
                    

                    cmd.Prepare();

                    cmd.Parameters[0].Value = patientToAdd.Personnummer;
                    cmd.Parameters[1].Value = patientToAdd.FirstName;
                    cmd.Parameters[2].Value = patientToAdd.LastName;
                    cmd.Parameters[3].Value = patientToAdd.Address;
                    cmd.Parameters[4].Value = patientToAdd.PostalCode;
                    //cmd.Parameters[5].Value = patientToAdd.PhoneNr;
                    cmd.Parameters[5].Value = patientToAdd.Email;
                    cmd.Parameters[6].Value = patientToAdd.BloodType;
                    

                    int recordsAffected = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(recordsAffected);
                }
            }
        }




        public bool UpdatePatient(Patient patientToUpdate)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("UPDATE patient SET first_name = @firstname, last_name = @lastname, address = @address, postal_code = @postcode, email = @email, bloodtype = @bloodtype WHERE person_id_nr = @id", conn))
                {
                    //cmd.Connection = conn;
                    //cmd.CommandText = "UPDATE patient SET first_name = :firstname, last_name = :lastname, address = :adress, postal_code = :postcode, email = :email, bloodtype = :bloodtype WHERE person_id_nr = :id";

                    cmd.Parameters.AddWithValue("@firstname", patientToUpdate.Personnummer);
                    cmd.Parameters.AddWithValue("@lastname", patientToUpdate.FirstName);
                    cmd.Parameters.AddWithValue("@address", patientToUpdate.Address);
                    cmd.Parameters.AddWithValue("@postcode", Convert.ToInt32(patientToUpdate.PostalCode));
                    //cmd.Parameters.AddWithValue("@phone", patientToUpdate.PhoneNr);
                    cmd.Parameters.AddWithValue("@email", patientToUpdate.Email);
                    cmd.Parameters.AddWithValue("@blood", patientToUpdate.BloodType);
                    cmd.Parameters.AddWithValue("@id", patientToUpdate.Personnummer);

                    //cmd.Prepare();

                    /*cmd.Parameters[0].Value = patientToUpdate.Personnummer;
                    cmd.Parameters[1].Value = patientToUpdate.FirstName;
                    cmd.Parameters[2].Value = patientToUpdate.LastName;
                    cmd.Parameters[3].Value = patientToUpdate.Address;
                    cmd.Parameters[4].Value = patientToUpdate.PostalCode;
                    cmd.Parameters[5].Value = patientToUpdate.PhoneNr;
                    cmd.Parameters[5].Value = patientToUpdate.Email;
                    cmd.Parameters[6].Value = patientToUpdate.BloodType;*/

                    int recordsAffected = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(recordsAffected); //returns 1 if there were any columns affected and 0 if there wasn't. 

                }

            }
        }

        public bool DeletePatient(string patientToDelete)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM patient WHERE person_id_nr = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));
                    
                    cmd.Prepare();

                    cmd.Parameters[0].Value = patientToDelete;
                    
                    int recordsAffected = cmd.ExecuteNonQuery();
                    return Convert.ToBoolean(recordsAffected); //returns 1 if there were any columns affected and 0 if there wasn't. 

                }

            }
        }

        public string loadPostort(int postkod)
        {
            string returnPostOrt = "None";
            using (var conn = new NpgsqlConnection(connectionString))
            {             
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT placename FROM place WHERE postal_code = :code";

                    cmd.Parameters.Add(new NpgsqlParameter("code", NpgsqlDbType.Integer));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = postkod;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            returnPostOrt = reader.GetString(0);
                            // returnPostOrt = "seDEDE";
                        }
                    }
                }

            }
            return returnPostOrt;
        }
    }
}
