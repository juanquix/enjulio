using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class RightViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Archivo PDF")]
        public byte[] FilePdf { get; set; }
    }
}