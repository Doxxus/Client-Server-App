using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;

namespace ClientApp {
    class Client {
        public byte[] sendMessage(byte[] messageBytes) {
            const int bytesize = 1024 * 1024;
            
            try {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 3000); // Create a new connection  
                NetworkStream stream = client.GetStream();

                stream.Write(messageBytes, 0, messageBytes.Length); // Write the bytes  
                Console.WriteLine("Connected to the server");
                Console.WriteLine("Waiting for response...");

                messageBytes = new byte[bytesize]; // Clear the message   

                // Receive the stream of bytes  
                stream.Read(messageBytes, 0, messageBytes.Length);

                // Clean up  
                stream.Dispose();
                client.Close();
            }

            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            return messageBytes; // Return response  
        }
    }
}
