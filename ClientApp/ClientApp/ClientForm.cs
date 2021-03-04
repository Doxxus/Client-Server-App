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
        private UserDOB dateOfBirth;
        private UserEmail email;
        private UserPhone phone;
        private User tempUser;
        private Client client;

        public ClientForm() {
            fname = new UserName();
            lname = new UserName();
            dateOfBirth = new UserDOB();
            email = new UserEmail();
            phone = new UserPhone();
            tempUser = new User();
            client = new Client();
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e) {
            
        }

        private void dobCalendar_DateSelected(object sender, DateRangeEventArgs e) {
            System.Diagnostics.Debug.WriteLine(dobCalendar.SelectionRange.Start.ToString("dd MMM yyyy"));
        }

        private void clearButton_Click(object sender, EventArgs e) {
            clearInfo();
            resetColors();
        }

        private void submitButton_Click(object sender, EventArgs e) {
            feedbackTextBox.Clear();
            resetColors();
            
            collectData();

            if(validateData()) {
                submitData();
            }
        }

        private void clearInfo() {
            fNameTextbox.Clear();
            lNameTextBox.Clear();
            dobCalendar.SelectionStart = dobCalendar.TodayDate;
            emailTextbox.Clear();
            phoneTextbox.Clear();
            feedbackTextBox.Clear();
        }

        private void resetColors() {
            fNameLabel.ForeColor = System.Drawing.Color.Black;
            lNameLabel.ForeColor = System.Drawing.Color.Black;
            dobLabel.ForeColor = System.Drawing.Color.Black;
            emailLabel.ForeColor = System.Drawing.Color.Black;
            phoneLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void collectData() {
            fname.data = fNameTextbox.Text;
            lname.data = lNameTextBox.Text;
            dateOfBirth.data = dobCalendar.SelectionRange.Start.ToString("dd MMM yyyy");
            email.data = emailTextbox.Text;
            phone.data = phoneTextbox.Text;
        }

        private bool validateData() {
            bool flag = true;

            if(!fname.validate() || !lname.validate()) {
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

        private void submitData() {
            clearInfo();

            tempUser.fname = fname.data;
            tempUser.lname = lname.data;
            tempUser.dateOfBirth = dateOfBirth.data;
            tempUser.email = email.data;
            tempUser.phone = phone.data;

            byte[] response = client.sendClientInfo(tempUser);

            feedbackTextBox.Text = System.Text.Encoding.Unicode.GetString(response);
        }
    }
}
