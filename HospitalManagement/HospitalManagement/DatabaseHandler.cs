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
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(person_id_nr) FROM patient WHERE person_id_nr = :id";

                    cmd.Parameters.Add(new NpgsqlParameter("id", NpgsqlDbType.Varchar));

                    cmd.Prepare();

                    cmd.Parameters[0].Value = patientToSearchFor;

                    int result = 0;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        result = reader.GetInt32(0);
                    }
                    return Convert.ToBoolean(result);
                    /*if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }*/
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

            try
            {
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
                                    eMail = reader.GetString(5);
                                    blodTyp = reader.GetString(6);
                                    telefonNr = reader.GetString(5);

                                }
                            }

                    }

                }


            }
            catch (PostgresException e)
            {
                Console.WriteLine(e.ToString());
            }
            
            postOrt = loadPostort(postNr);
            returnPatient = new Patient(personNr, firstName, lastName, adress, postNr, postOrt, telefonNr, eMail, blodTyp);
            return returnPatient;
        }

        public bool AddPatient (Patient patientToAdd)
        {
            if (!PatientExists(patientToAdd.Personnummer))
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
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
                            return Convert.ToBoolean(recordsAffected);
                        }
                        catch (PostgresException e)
                        {
                            Console.WriteLine(e.ToString());
                            return false;
                        }

                    }
                }

            }
            else
            {
                return false;
            }

        }




        public bool UpdatePatient(Patient patientToUpdate)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = $"UPDATE patient SET first_name = '{patientToUpdate.FirstName}', last_name = '{patientToUpdate.LastName}', address = '{patientToUpdate.Address}', postal_code = {patientToUpdate.PostalCode}, phone = '{patientToUpdate.PhoneNr}', email = '{patientToUpdate.Email}', bloodtype = '{patientToUpdate.BloodType}' WHERE person_id_nr = '{patientToUpdate.Personnummer}'";
                    
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
