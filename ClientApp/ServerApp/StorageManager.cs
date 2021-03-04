using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;
using Newtonsoft.Json;

namespace ServerApp
{
    class StorageManager {
        string storageType;
        public string filePath { get; set; }

        public void init() {
            storageType = ConfigurationManager.AppSettings.Get("storage_type");

            if (storageType == "database") {
                Console.WriteLine("SQL database storage type selected.");
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

        public bool saveToFile(ClientInfo client) {
            try {
                File.AppendAllText(filePath, JsonConvert.SerializeObject(client));
                Console.WriteLine("Entry Saved Successfully.");
                return true;
            } catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public void saveToDatabase(ClientInfo client) {

        }
    }
}
