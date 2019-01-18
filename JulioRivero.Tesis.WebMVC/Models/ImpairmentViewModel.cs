using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class ImpairmentViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Tipo")]
        public string Kind { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }


        public ICollection<DeficiencyViewModel> deficiencysViewModel { get; set; }
    }
}