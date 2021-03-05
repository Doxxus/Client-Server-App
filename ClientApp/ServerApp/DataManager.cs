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

namespace ServerApp {
    class DataManager {
        string storageType;
        string connectionString { get; set; }

        StorageManager storageManager;

        public void init() {
            storageType = ConfigurationManager.AppSettings.Get("storage_type");

            if (storageType == "database") {
                storageManager = new DatabaseManager();
                storageManager.init("Server=localhost;Database=master;Trusted_Connection=true");
                Console.WriteLine("SQL database storage type selected."); 
            } else if (storageType == "file") {
                storageManager = new FileManager();
                storageManager.init(".\\data\\clients.txt");
                Console.WriteLine("Flat file storage type selected.");
            } else  {
                storageType = "file";
                storageManager = new FileManager();
                storageManager.init(".\\data\\clients.txt");
                Console.WriteLine("No storage type selected - Defaulting to file.");
            }
        }

        public bool save(ClientInfo client) {
            return storageManager.save(client);
        }

        public List<ClientInfo> collectClients() {
            return storageManager.collectClients();
        }
    }
}
