using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp {
    class UserDOB : IUserData {
        public string data { get; set; }
        public bool validate() {
            if(DateTime.Parse(data) < DateTime.Today) { return true; }
            return false;
        }
            
    }
}
