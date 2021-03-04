using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void dob_calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(dob_calendar.SelectionRange.Start.ToString("dd MMM yyyy"));
        }
    }
}
