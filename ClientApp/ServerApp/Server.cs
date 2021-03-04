using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;

namespace ServerApp {
    class Server {
        IPEndPoint ep;
        TcpListener listener;

        public void init() {
            Console.WriteLine("Starting Server...");

            ep = new IPEndPoint(IPAddress.Loopback, 3000);
            listener = new TcpListener(ep);
            listener.Start();

            Console.WriteLine(@"Listening for requests at: {0}:{1}",
            ep.Address, ep.Port);
        }

        public void run() {
            while (true) {
                const int bytesize = 1024 * 1024;

                string message = null;
                byte[] buffer = new byte[bytesize];

                var sender = listener.AcceptTcpClient();
                sender.GetStream().Read(buffer, 0, bytesize);

                message = cleanMessage(buffer);

                Console.WriteLine("Recieved Message: " + message);

                ClientInfo user = JsonConvert.DeserializeObject<ClientInfo>(message);

                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(user.fname + " " + user.lname + " logged successfully.");
                sender.GetStream().Write(bytes, 0, bytes.Length); 
            }
        }

        private static string cleanMessage(byte[] bytes) {
            Console.WriteLine("test");
            string message = System.Text.Encoding.Unicode.GetString(bytes);

            string result = null;
            foreach (var nullChar in message) {
                if (nullChar != '\0') { result += nullChar; }
            }

            return result;
        }
    }
}
