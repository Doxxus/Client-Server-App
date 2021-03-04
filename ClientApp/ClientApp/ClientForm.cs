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
        private UserName name;
        private UserDOB dateOfBirth;
        private UserEmail email;
        private UserPhone phone; 

        public ClientForm() {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e) {
            name = new UserName();
            dateOfBirth = new UserDOB();
            email = new UserEmail();
            phone = new UserPhone();
        }

        private void dobCalendar_DateSelected(object sender, DateRangeEventArgs e) {
            System.Diagnostics.Debug.WriteLine(dobCalendar.SelectionRange.Start.ToString("dd MMM yyyy"));
        }

        private void clearButton_Click(object sender, EventArgs e) {
            clearInfo();
        }

        private void submitButton_Click(object sender, EventArgs e) {
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
        }

        private void collectData() {
            
        }

        private bool validateData() {
            if(!name.validate()) {
                feedbackTextBox.Text = "Invalid name - Please enter a valid name";
                return false;
            }

            if (!dateOfBirth.validate()) {
                feedbackTextBox.Text = "Invalid date of birth - Please enter a valid date of birth";
                return false;
            }

            if (!email.validate()) {
                feedbackTextBox.Text = "Invalid email address - Please enter a valid email address";
                return false;
            }

            if (!phone.validate()) {
                feedbackTextBox.Text = "Invalid phone number - Please enter a valid phone number";
                return false;
            }

            return true;
        }

        private void submitData() {

        }
    }
}
