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
        const int bytesize = 1024 * 1024;
        byte[] req;
        byte[] res;

        public byte[] sendClientInfo(User user) {
            res = new byte[bytesize];
            try {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 3000); 
                NetworkStream stream = client.GetStream();


                req = System.Text.Encoding.Unicode.GetBytes("submit_client_info" + JsonConvert.SerializeObject(user));

                stream.Write(req, 0, req.Length);
                System.Diagnostics.Debug.WriteLine("Connected to the server");
                System.Diagnostics.Debug.WriteLine("Waiting for response...");

                stream.Read(res, 0, res.Length);

                stream.Dispose();
                client.Close();
            }

            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine(e.Message);
            }

            return res;
        }
    }
}
