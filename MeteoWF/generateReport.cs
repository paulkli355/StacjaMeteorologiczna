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
        MeteoDBEntities context = new MeteoDBEntities();
        public generateReport()
        {
            InitializeComponent();
            //printPreviewDialog1.Document = printDocument1;
            //printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            //printPreviewDialog1.Show();
            //printPreviewControl1.Document = printDocument1;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void generateReport_Load(object sender, EventArgs e)
        {

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This feature is not yet available! We are working on it", "We're sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        string PrzygotowanieRaportu()
        {
            var temp = Math.Round((double)(context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.Temperatura)), 1);
            var humid = Math.Round((double)(context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.Wilgotnosc)), 1);
            var srednia1 = Math.Round((double)(context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM1)), 2);
            var srednia25 = Math.Round((double)(context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM25)), 2);
            var srednia10 = Math.Round((double)(context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM10)), 2);

            var te = Math.Round((double)(context.Pomiaries.Average(x => x.Temperatura)), 1);
            var hd = Math.Round((double)(context.Pomiaries.Average(x => x.Wilgotnosc)), 1);
            var sr1 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Year == 2019).Average(x => x.PM1), 2);
            var sr25 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Year == 2019).Average(x => x.PM25), 2);
            var sr10 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Year == 2019).Average(x => x.PM10), 2);
            string text = string.Format("AIR QUALITY REPORT OF " + DateTime.Now + '\n' + '\n' +
                "The average temperature today is " + temp + " °C, while the humidity" + '\n' + "remains at an average level of " + humid + " %." + '\n' +
                "The average concentration of suspended dust was respectively: " + '\n' +
                "- for PM1: " + srednia1 + " µg/m3," + '\n' +
                "- for PM2.5: " + srednia25 + " µg/m3," + '\n' +
                "- for PM10: " + srednia10 + " µg/m3." + '\n' + '\n' + '\n' +
                "Meanwile the average temperature during the measurements was " + '\n' + te + " °C and the humidity remained at an average level of " + hd + " %." + '\n' +
                "The average concentration of suspended dust was respectively: " + '\n' +
                "- for PM1: " + sr1 + " µg/m3," + '\n' +
                "- for PM2.5: " + sr25 + " µg/m3," + '\n' +
                "- for PM10: " + sr10 + " µg/m3." + '\n');

            return text;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string text = PrzygotowanieRaportu();
            e.Graphics.DrawString(text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
