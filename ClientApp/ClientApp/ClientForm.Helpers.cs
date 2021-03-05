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

        //Some helper functions to interact with the UI elements
        private void clearInfo() {
            fNameTextbox.Clear();
            lNameTextBox.Clear();
            dobCalendar.SelectionStart = dobCalendar.TodayDate;
            emailTextbox.Clear();
            phoneTextbox.Clear();
            feedbackTextBox.Clear();
            clearList();
        }

        private void resetColors() {
            fNameLabel.ForeColor = System.Drawing.Color.Black;
            lNameLabel.ForeColor = System.Drawing.Color.Black;
            dobLabel.ForeColor = System.Drawing.Color.Black;
            emailLabel.ForeColor = System.Drawing.Color.Black;
            phoneLabel.ForeColor = System.Drawing.Color.Black;
        }

        public void setFeedback(string fb) { feedbackTextBox.Text = fb; }
        public void addToList(User user) {
            ListViewItem temp = new ListViewItem(user.fname);

            temp.SubItems.Add(user.lname);
            temp.SubItems.Add(user.dateOfBirth);
            temp.SubItems.Add(user.email);
            temp.SubItems.Add(user.phone);

            dataList.Items.Add(temp);
        }

        public void clearList() {
            dataList.Items.Clear();
        }
    }
}
