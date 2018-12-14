using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
    }
}