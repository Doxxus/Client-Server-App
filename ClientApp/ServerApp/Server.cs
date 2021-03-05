using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;


namespace ServerApp {
    class Server {
        IPEndPoint ep;
        TcpListener listener;
        RequestHandler handler;
        StorageManager storageManager;

        byte[] request;
        byte[] response;

        const int bytesize = 1024 * 1024;


        public void init() {
            Console.WriteLine("Starting Server...");


            ep = new IPEndPoint(IPAddress.Loopback, 3000);
            listener = new TcpListener(ep);
            storageManager = new StorageManager();
            handler = new RequestHandler(storageManager);

            storageManager.init();

            listener.Start();

            Console.WriteLine(@"Listening for requests at: {0}:{1}",
            ep.Address, ep.Port);
        }

        public void run() {
            while (true) {
                request = new byte[bytesize];

                var sender = listener.AcceptTcpClient();
                sender.GetStream().Read(request, 0, bytesize);

                response = handler.handleIncomingRequest(cleanMessage(request));

                sender.GetStream().Write(response, 0, response.Length); 
            }
        }

        private static string cleanMessage(byte[] bytes) {
            string message = System.Text.Encoding.Unicode.GetString(bytes);

            string result = null;
            foreach (var nullChar in message) {
                if (nullChar != '\0') { result += nullChar; }
            }

            return result;
        }
    }
}
