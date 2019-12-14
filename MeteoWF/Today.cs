﻿using System;
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
    public partial class Today : UserControl
    {
        MeteoDBEntities context = new MeteoDBEntities();
        public Today()
        {
            InitializeComponent();
            WyswietlWykres();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Today_Load(object sender, EventArgs e)
        {
            var temp = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.Temperatura);
            double srtemp = Math.Round((double)temp, 1);
            TempWar.Text = string.Format(srtemp.ToString() + " °C");

            var humid = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.Wilgotnosc);
            double srhumid = Math.Round((double)humid, 1);
            HumidWar.Text = string.Format(srhumid.ToString() + " %");

            var srednia1 = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM1);
            double sr1 = Math.Round((double)srednia1, 1);
            PM1text.Text = string.Format(sr1.ToString() + " µg/m3");

            var srednia25 = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM25);
            double sr25 = Math.Round((double)srednia25, 1);
            PM25text.Text = string.Format(sr25.ToString() + " µg/m3");

            var srednia10 = context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM10);
            double sr10 = Math.Round((double)srednia10,1);
            PM10text.Text = string.Format(sr10.ToString() + " µg/m3");


        }

        private void TempWar_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        void WyswietlWykres()
        {
            var srednia1 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM1), 2);
            this.chart1.Series["Concentration"].Points.AddXY("PM1", srednia1);

            var srednia25 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM25), 2);
            this.chart1.Series["Concentration"].Points.AddXY("PM2,5", srednia25);

            var srednia10 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Day == (DateTime.Now).Day - 0).Average(x => x.PM10), 2);
            this.chart1.Series["Concentration"].Points.AddXY("PM10", srednia10);
        }

        
        
    }
}
