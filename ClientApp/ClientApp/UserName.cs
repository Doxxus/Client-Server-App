using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp {
    class UserName : IUserData {
        public bool validate(string data) {
            return true; 
        }
    }
}
