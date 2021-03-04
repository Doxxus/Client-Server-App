using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ClientApp {
    class UserName : IUserData {
        public string data { get; set; }
        public bool validate() {
            if (string.IsNullOrWhiteSpace(data)) { return false; }
           
            if (new Regex("^[a-zA-Z ]+$").IsMatch(data)) { return true; }
            else { return false; } 
        }
    }
}
