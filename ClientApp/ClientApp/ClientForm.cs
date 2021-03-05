using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp {
    public partial class ClientForm : Form {
        private UserName fname;
        private UserName lname;
        private UserEmail email;
        private UserPhone phone;
        private UserDOB dateOfBirth;
        private User tempUser;
        private Client client;

        public ClientForm() {
            fname = new UserName();
            lname = new UserName();
            dateOfBirth = new UserDOB();
            email = new UserEmail();
            phone = new UserPhone();
            tempUser = new User();
            client = new Client(this);
            InitializeComponent();
        }
    }
}
