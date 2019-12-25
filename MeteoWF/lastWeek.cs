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
    public partial class lastWeek : UserControl
    {
        MeteoDBEntities context = new MeteoDBEntities();
        public lastWeek()
        {
            InitializeComponent();
            WyswietlWykresSlupkowy();
            //WyswietlWykresLiniowy();
        }

        private void lastWeek_Load(object sender, EventArgs e)
        {
            var temp = context.Pomiaries.Average(x => x.Temperatura);
            double srtemp = Math.Round((double)temp, 1);
            TempWar.Text = string.Format(srtemp.ToString() + "°C");

            var humid = context.Pomiaries.Average(x => x.Wilgotnosc);
            double srhumid = Math.Round((double)humid, 1);
            HumidWar.Text = string.Format(srhumid.ToString() + "%");

            var srednia1 = context.Pomiaries.Average(x => x.PM1);
            double sr1 = Math.Round((double)srednia1, 1);
            PM1text.Text = string.Format(sr1.ToString() + " µg/m3");

            var srednia25 = context.Pomiaries.Average(x => x.PM25);
            double sr25 = Math.Round((double)srednia25, 1);
            PM25text.Text = string.Format(sr25.ToString() + " µg/m3");
            if (sr25 <= 35)
            {
                PM25text.ForeColor = System.Drawing.Color.Green;
            }
            if (sr25 <= 75)
            {
                PM25text.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                PM25text.ForeColor = System.Drawing.Color.Red;
            }

            var srednia10 = context.Pomiaries.Average(x => x.PM10);
            double sr10 = Math.Round((double)srednia10, 1);
            PM10text.Text = string.Format(sr10.ToString() + " µg/m3");
            if (sr10 <= 50)
            {
                PM10text.ForeColor = System.Drawing.Color.Green;
            }
            if (sr10 <= 110)
            {
                PM10text.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                PM10text.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        void WyswietlWykresSlupkowy()
        {
            //chart1.Update();
            chart1.Series["PM1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["PM2.5"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["PM10"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;


            var srednia1 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Year == 2019).Average(x => x.PM1), 2);
            var srednia25 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Year == 2019).Average(x => x.PM25), 2);
            var srednia10 = Math.Round((double)context.Pomiaries.Where(x => x.DataCzas.Year == 2019).Average(x => x.PM10), 2);
            this.chart1.Series["PM1"].Points.AddXY(" ", srednia1);
            this.chart1.Series["PM2.5"].Points.AddXY(" ", srednia25);
            this.chart1.Series["PM10"].Points.AddXY(" ", srednia10);

            

        }

        

        void WyswietlWykresLiniowy()
        {
            chart1.Series["PM1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["PM2.5"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["PM10"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            var pm1 = context.Pomiaries.Select(x => x.PM1).ToArray();
            var pm25 = context.Pomiaries.Select(x => x.PM25).ToArray();
            var pm10 = context.Pomiaries.Select(x => x.PM10).ToArray();

       
            this.chart1.Series["PM1"].Points.DataBindY(pm1);
            this.chart1.Series["PM2.5"].Points.DataBindY(pm25);
            this.chart1.Series["PM10"].Points.DataBindY(pm10);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                WyswietlWykresLiniowy();
            }
            else
            {
                WyswietlWykresSlupkowy();
            }
        }

        
    }
}
