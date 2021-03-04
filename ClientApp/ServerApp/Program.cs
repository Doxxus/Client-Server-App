using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace ServerApp {
    class Program {
        static void Main(string[] args) {
            Server server = new Server();

            string storageType = ConfigurationManager.AppSettings.Get("storage_type");

            if (storageType == "database") {
                Console.WriteLine("SQL database storage type selected.");
            } else if (storageType == "file") {
                Console.WriteLine("Flat file storage type selected.");
            } else {
                Console.WriteLine("No storage type selected - Defaulting to file.");
            }

            server.init();
            server.run();
        }
    }
}
