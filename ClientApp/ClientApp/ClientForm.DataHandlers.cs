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
        private void collectData() {
            fname.data = fNameTextbox.Text;
            lname.data = lNameTextBox.Text;
            dateOfBirth.data = dobCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            email.data = emailTextbox.Text;
            phone.data = phoneTextbox.Text;
        }

        private void submitData() {
            clearInfo();

            tempUser.fname = fname.data;
            tempUser.lname = lname.data;
            tempUser.dateOfBirth = dateOfBirth.data;
            tempUser.email = email.data;
            tempUser.phone = phone.data;

            client.sendClientInfo(tempUser);
        }
    }
}
