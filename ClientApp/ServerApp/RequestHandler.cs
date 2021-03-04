using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServerApp {
    class RequestHandler {
        public byte[] handleIncomingRequest(string req) {
            Console.WriteLine("Recieved Request: " + req);

            (string command, string body) = parseRequest(req);

            Console.WriteLine(command);
            Console.WriteLine(body);

            try {
                ClientInfo user = JsonConvert.DeserializeObject<ClientInfo>(body);
                return System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " logged successfully.");
            } catch (Exception e) {
                return System.Text.Encoding.Unicode.GetBytes(e.ToString());
            }
        }

        private Tuple<string, string> parseRequest(string req) {
            Console.WriteLine("Parsing Request.");
            int index = req.IndexOf("{");

            string command = req.Substring(0, index).Trim();
            string body = req.Substring(index, req.Length-index).Trim();

            return Tuple.Create(command, body);
        }
    }
}
