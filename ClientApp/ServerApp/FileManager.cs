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
            try {
                using (StreamWriter sw = File.AppendText(connector)) {
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

            try {
                using (StreamReader sr = File.OpenText(connector))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
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
