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
        private bool validateData() {
            bool flag = true;
            //validates all of the input data
            if (!fname.validate() || !lname.validate()) {
                feedbackTextBox.Text += "Invalid name. ";
                fNameLabel.ForeColor = System.Drawing.Color.Red;
                lNameLabel.ForeColor = System.Drawing.Color.Red;
                flag = false;
            }

            if (!dateOfBirth.validate()) {
                feedbackTextBox.Text += "Invalid date of birth. ";
                dobLabel.ForeColor = System.Drawing.Color.Red;
                flag = false;
            }

            if (!email.validate()) {
                feedbackTextBox.Text += "Invalid email address. ";
                emailLabel.ForeColor = System.Drawing.Color.Red;
                flag = false;
            }

            if (!phone.validate()) {
                feedbackTextBox.Text += "Invalid phone number. ";
                phoneLabel.ForeColor = System.Drawing.Color.Red;
                flag = false;
            }

            if (flag) { return true; }
            return false;
        }
    }
}
