using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;

namespace ClientApp {
    class Client {
        ClientForm ui;

        const int bytesize = 1024 * 1024;
        byte[] req;
        byte[] res;

        public Client(ClientForm f) {
            ui = f;
        }

        public void sendClientInfo(User user) {
            res = new byte[bytesize];

            //Sending client informatin to server
            try {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 3000);
                
                //Opening connection to server
                using (NetworkStream stream = client.GetStream()) {

                    //Serializing object into a JSON string and then into a byte array
                    req = System.Text.Encoding.Unicode.GetBytes("submit_client_info" + JsonConvert.SerializeObject(user));

                    //Sending request
                    stream.Write(req, 0, req.Length);
                    System.Diagnostics.Debug.WriteLine("Connected to the server");
                    System.Diagnostics.Debug.WriteLine("Waiting for response...");

                    //reading response
                    stream.Read(res, 0, res.Length);
                }
            }

            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            //Displaying the response to the client
            ui.setFeedback(System.Text.Encoding.Unicode.GetString(res));
        }

        public void requestClients() {
            res = new byte[bytesize];
            try {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 3000);

                //Opening connection to server
                using (NetworkStream stream = client.GetStream()) {

                    //Serializing request
                    req = System.Text.Encoding.Unicode.GetBytes("send_client_info");

                    //Sending request
                    stream.Write(req, 0, req.Length);
                    System.Diagnostics.Debug.WriteLine("Connected to the server");
                    System.Diagnostics.Debug.WriteLine("Waiting for response...");

                    //Reading response
                    stream.Read(res, 0, res.Length);
                }
            } catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            //Deserializing response
            List<User> users = JsonConvert.DeserializeObject<List<User>>(cleanMessage(res));

            //Populating UI with clients info recieved from server.
            ui.clearList();

            foreach (User u in users) {
                ui.addToList(u);
            }
        }

        //Turns a byte array into a string representation and removes any null terminator characters
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
