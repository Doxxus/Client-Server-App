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
        private void ClientForm_Load(object sender, EventArgs e) {}

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

            if (validateData())
            {
                submitData();
            }
        }

        private void getData_Click(object sender, EventArgs e) {
            client.requestClients();
        }
    }
}
