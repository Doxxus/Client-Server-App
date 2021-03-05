using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServerApp {
    class RequestHandler {
        StorageManager storageManager;

        public RequestHandler(StorageManager sm) {
            storageManager = sm;
        }

        public byte[] handleIncomingRequest(string req) {
            Console.WriteLine("Recieved Request: " + req);

            (string command, string body) = parseRequest(req);

            if (command == "submit_client_info") {
                try {
                    ClientInfo user = JsonConvert.DeserializeObject<ClientInfo>(body);

                    if(storageManager.save(user)) {
                        return System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " saved successfully.");
                    } else {
                        return System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " saved unsuccessfully");
                    }
                } catch (Exception e) {
                    return System.Text.Encoding.Unicode.GetBytes(e.ToString());
                }
            } else if (command == "send_client_info") {
                return System.Text.Encoding.Unicode.GetBytes(JsonConvert.SerializeObject(storageManager.collectClients()));
            }

            return System.Text.Encoding.Unicode.GetBytes("Invalid command.");
        }

        private Tuple<string, string> parseRequest(string req) {
            Console.WriteLine("Parsing Request.");
            int index = req.IndexOf("{");

            if (index == -1) {
                return Tuple.Create(req, "");
            }

            string command = req.Substring(0, index).Trim();
            string body = req.Substring(index, req.Length-index).Trim();

            return Tuple.Create(command, body);
        }
    }
}
