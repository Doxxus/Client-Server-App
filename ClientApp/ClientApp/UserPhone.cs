using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp {
    class UserPhone : IUserData {
        public string data { get; set; }
        public bool validate() {
            //validates phone number
            if (string.IsNullOrWhiteSpace(data)) { return false; }
            //Removing special characters that you would commonly see in a phone number (to just get the actual number)
            data = data.Replace(" ", "");
            data = data.Replace("-", "");
            data = data.Replace("(", "");
            data = data.Replace(")", "");

            //trying to cast the number as a double (will fail if it isn't
            try { double.Parse(data); }
            catch { return false; }

            //Testing to see if it is 10 digits long (this is localized wrt Canada, would need to globalize this if shipped to other countries)
            if (data.Length == 10) { return true; }
            else { return false; }
        }
    }
}
