using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp {
    class UserPhone : IUserData {
        public string data { get; set; }
        public bool validate() {

            if (string.IsNullOrWhiteSpace(data)) { return false; }

            data = data.Replace(" ", "");
            data = data.Replace("-", "");
            data = data.Replace("(", "");
            data = data.Replace(")", "");

            try { double.Parse(data); }
            catch { return false; }

            if (data.Length == 10) { return true; }
            else { return false; }
        }
    }
}
