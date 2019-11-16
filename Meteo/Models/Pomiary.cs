using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meteo.Models
{
    public class Pomiary
    {
        public int PomiarID { get; set; }
        public DateTime DataPomiaru { get; set; }
        public double Temperatura { get; set; }
        public double Cisnienie { get; set; }
        public double Wilgotnosc { get; set; }
        public double PM25 { get; set; }
        public double PM10 { get; set; }
        public double PM1 { get; set; }
    }
}