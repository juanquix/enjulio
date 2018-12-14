using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class IntoPreventionViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tipo")]
        public string Kind { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Prevención")]
        public string Prevention { get; set; }
    }
}