using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace ServerApp
{
    class DataManager {
        string storageType;
        string filePath { get; set; }
        string connectionString { get; set; }

        public void init() {
            storageType = ConfigurationManager.AppSettings.Get("storage_type");

            if (storageType == "database") {
                connectionString = "Server=localhost;Database=master;Trusted_Connection=true";
                Console.WriteLine("SQL database storage type selected.");
                
                intitializeDatabase();
            } else if (storageType == "file") {
                filePath = ".\\data\\clients.txt";
                Console.WriteLine("Flat file storage type selected.");
            } else  {
                Console.WriteLine("No storage type selected - Defaulting to file.");
                storageType = "file";
            }
        }

        public bool save(ClientInfo client) {
            if (storageType == "file") { return saveToFile(client); }
            if (storageType == "database") { return saveToDatabase(client); }

            return true;
        }

        private bool saveToFile(ClientInfo client) {
            try {

                using (StreamWriter sw = File.AppendText(filePath)) {
                    sw.WriteLine(JsonConvert.SerializeObject(client));
                }
                    
                Console.WriteLine("Entry Saved Successfully.");
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        private bool saveToDatabase(ClientInfo client) {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = connectionString;
                conn.Open();

                SqlCommand insertCommand = new SqlCommand("INSERT INTO dbo.Clients (FirstName, LastName, DateofBirth, EmailAddress, PhoneNumber) VALUES (@fn, @ln, @dob, @em, @ph)", conn);
                insertCommand.Parameters.Add("@fn", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@fn"].Value = client.fname;
                insertCommand.Parameters.Add("@ln", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@ln"].Value = client.lname;
                insertCommand.Parameters.Add("@dob", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@dob"].Value = client.dateOfBirth;
                insertCommand.Parameters.Add("@em", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@em"].Value = client.email;
                insertCommand.Parameters.Add("@ph", System.Data.SqlDbType.VarChar);
                insertCommand.Parameters["@ph"].Value = client.phone;

                try {
                    Int32 rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    return true;
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        public List<ClientInfo> collectClients() {
            if (storageType == "file") { return collectClientsFromFile();  }

            return new List<ClientInfo>();
        }

        private List<ClientInfo> collectClientsFromFile() {
            List<ClientInfo> ret = new List<ClientInfo>();
            
            try {
                using (StreamReader sr = File.OpenText(filePath)) {
                    string line;

                    while ((line = sr.ReadLine()) != null) {
                        ret.Add(JsonConvert.DeserializeObject<ClientInfo>(line));
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            return ret;
        }

        private void intitializeDatabase() {
            try {
                using (SqlConnection conn = new SqlConnection()) {
                    conn.ConnectionString = connectionString;
                    conn.Open(); 

                    Console.WriteLine("Initializing Database.");

                    try {
                        SqlCommand command = new SqlCommand("SELECT * FROM dbo.Clients", conn);

                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                Console.WriteLine(String.Format("{0}, {1}",
                                    reader[0], reader[1]));
                            }
                        }
                    } catch (Exception e) {
                        SqlCommand command = new SqlCommand("CREATE TABLE dbo.Clients(" +
                            "FirstName varchar(255)," +
                            "LastName varchar(255)," +
                            "DateofBirth varchar(255)," +
                            "EmailAddress varchar(255)," +
                            "PhoneNumber varchar(255));", conn);

                        using (SqlDataReader reader = command.ExecuteReader()) {
                            while (reader.Read()) {
                                Console.WriteLine(String.Format("{0}, {1}",
                                    reader[0], reader[1]));
                            }
                        }
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
