using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServerApp {
    class RequestHandler {
        DataManager dataManager;

        public RequestHandler(DataManager dm) {
            dataManager = dm;
        }

        public byte[] handleIncomingRequest(string req) {
            Console.WriteLine("Recieved Request: " + req);

            (string command, string body) = parseRequest(req);

            //Command selector
            if (command == "submit_client_info") {
                //Submiting the client info to the dataManager and sending response
                try {
                    ClientInfo user = JsonConvert.DeserializeObject<ClientInfo>(body);

                    if(dataManager.save(user)) {
                        return System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " saved successfully.");
                    } else {
                        return System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " saved unsuccessfully");
                    }
                } catch (Exception e) {
                    return System.Text.Encoding.Unicode.GetBytes(e.Message);
                }
            } else if (command == "send_client_info") {
                //Collecting the client list from the data manager and sending it as a response
                return System.Text.Encoding.Unicode.GetBytes(JsonConvert.SerializeObject(dataManager.collectClients()));
            }

            return System.Text.Encoding.Unicode.GetBytes("Invalid command.");
        }

        private Tuple<string, string> parseRequest(string req) {
            Console.WriteLine("Parsing Request.");
            int index = req.IndexOf("{");

            if (index == -1) {
                return Tuple.Create(req, "");
            }

            //Command is sent ahead of the JSON string so we parse that accordingly
            string command = req.Substring(0, index).Trim();
            string body = req.Substring(index, req.Length-index).Trim();

            return Tuple.Create(command, body);
        }
    }
}
