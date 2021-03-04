using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace ServerApp
{
    class StorageManager {
        public string getStorageType() {
            return ConfigurationManager.AppSettings.Get("storage_type");
        }

        public void init() {
            if (getStorageType() == "database") {
                Console.WriteLine("SQL database storage type selected.");
            } else if (getStorageType() == "file") {
                Console.WriteLine("Flat file storage type selected.");
            } else  {
                Console.WriteLine("No storage type selected - Defaulting to file.");
            }
        }
    }
}
