using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp {
    interface IUserData { //User data interface, enforced a validate method.
        string data { get; set; }

        bool validate();
    }
}
