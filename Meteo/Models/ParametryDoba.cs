using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meteo.Models
{
    public class ParametryDoba : Parametry
    {
        public double SredniaTempDoba { get; set; }
        public double SredniPylPM25Doba { get; set; }
        public double SredniPylPM10Doba { get; set; }
        public double SredniPylPM1Doba { get; set; }
    }
}