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

            try {
                ClientInfo user = JsonConvert.DeserializeObject<ClientInfo>(req);
                return System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " logged successfully.");
            } catch (Exception e) {
                return System.Text.Encoding.Unicode.GetBytes(e.ToString());
            }
        }

    }
}
