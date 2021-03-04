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
        public ClientForm() {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e) {

        }

        private void dobCalendar_DateSelected(object sender, DateRangeEventArgs e) {
            System.Diagnostics.Debug.WriteLine(dobCalendar.SelectionRange.Start.ToString("dd MMM yyyy"));
        }

        private void clear_button_Click(object sender, EventArgs e) {
            nameTextbox.Clear();
            dobCalendar.SelectionStart = dobCalendar.TodayDate;
            emailTextbox.Clear();
            phoneTextbox.Clear();
        }

        private void submit_button_Click(object sender, EventArgs e) {

        }
    }
}
