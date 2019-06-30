using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class PreventionViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tipo")]
        public string Kind { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Visitas")]
        public int VisitCount { get; set; }
    }
}