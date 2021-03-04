using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;

namespace ServerApp {
    class Program {
        static void Main(string[] args) {
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 1234);
            TcpListener listener = new TcpListener(ep);
            listener.Start();

            Console.WriteLine(@"  
            ===================================================  
                   Started listening requests at: {0}:{1}  
            ===================================================",
            ep.Address, ep.Port);

            // Run the loop continuously; this is the server.  
            while (true) {
                const int bytesize = 1024 * 1024;

                string message = null;
                byte[] buffer = new byte[bytesize];

                var sender = listener.AcceptTcpClient();
                sender.GetStream().Read(buffer, 0, bytesize);

                // Read the message and perform different actions  
                message = cleanMessage(buffer);

                // Save the data sent by the client;  
                 person = JsonConvert.DeserializeObject<Person>(message); // Deserialize  

                byte[] bytes = System.Text.Encoding.Unicode.GetBytes("Thank you for your message, " + person.Name);
                sender.GetStream().Write(bytes, 0, bytes.Length); // Send the response  
            }
        }
        private static string cleanMessage(byte[] bytes) {
            string message = System.Text.Encoding.Unicode.GetString(bytes);

            string messageToPrint = null;
            foreach (var nullChar in message) {
                if (nullChar != '\0') {
                    messageToPrint += nullChar;
                }
            }

            return messageToPrint;
        }
    }
}
