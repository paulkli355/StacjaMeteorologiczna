using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Meteo.Models
{
    public class Parametry
    {
        [Required(ErrorMessage = "Wprowadź zakres czasu!")] 
        public Okres OkresCzasu { get; set; }
    }

    public enum Okres { 
        
        Godzina,
        Doba,
        Tydzien
    }
}