using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp {
    class UserEmail : IUserData {
        public string data { get; set; }
        public bool validate() {
            return true;
        }
    }
}
