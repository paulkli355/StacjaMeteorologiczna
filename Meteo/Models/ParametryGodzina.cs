using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meteo.Models
{
    public class ParametryGodzina : Parametry
    {
        public double SredniaTempGodzina { get; set; }
        public double SredniPylPM25Godzina { get; set; }
        public double SredniPylPM10Godzina { get; set; }
        public double SredniPylPM1Godzina { get; set; }
    }
}