using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoWF
{
    public partial class generateReport : UserControl
    {
        public generateReport()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void generateReport_Load(object sender, EventArgs e)
        {

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available! We are working on it", "We're sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
