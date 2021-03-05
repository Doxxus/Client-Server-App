using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ServerApp {
    class FileManager : StorageManager {
        public override void init(string arg) { connector = arg; }

        public override bool save(ClientInfo client) {
            //Opening file
            try {
                using (StreamWriter sw = File.AppendText(connector)) {
                    //Writing to file
                    sw.WriteLine(JsonConvert.SerializeObject(client));
                }

                Console.WriteLine("Entry saved to file successfully.");
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e);
                return false;
            }
        }

        public override List<ClientInfo> collectClients() {
            List<ClientInfo> ret = new List<ClientInfo>();

            //Opening file
            try {
                using (StreamReader sr = File.OpenText(connector)) {
                    string line;

                    while ((line = sr.ReadLine()) != null) {
                        //Reading line from file, deserializing the JSON and then adding the resulting object to the return object.
                        ret.Add(JsonConvert.DeserializeObject<ClientInfo>(line));
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

            return ret;
        }
    }
}
