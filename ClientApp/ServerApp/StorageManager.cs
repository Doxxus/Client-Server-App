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
    class StorageManager {
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

        private void saveToDatabase(ClientInfo client) {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = connectionString;
                
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
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = connectionString;
                conn.Open();

                try {
                    SqlCommand command = new SqlCommand("SELECT * FROM clients", conn);
                } catch (SqlException e) {
                    Console.WriteLine(e);
                    SqlCommand command = new SqlCommand("CREATE TABLE clients (" +
                        "FirstName varchar(255)," +
                        "LastName varchar(255)," +
                        "DateofBirth varchar(255)," +
                        "EmailAddress varchar(255)," +
                        "PhoneNumber varchar(255));");
                }
            }
        }
    }
}
