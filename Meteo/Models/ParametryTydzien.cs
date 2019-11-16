using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meteo.Models
{
    public class ParametryTydzien : ParametryDoba
    {
        public double SredniaTempTydzien { get; set; }
        public double SredniPylPM25Tydzien { get; set; }
        public double SredniPylPM10Tydzien { get; set; }
        public double SredniPylPM1Tydzien { get; set; }
    }
}