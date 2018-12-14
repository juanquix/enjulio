using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JulioRivero.Tesis.WebMVC.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string SecondName { get; set; }
        [Display(Name = "Apellido Materno")]
        public string LastName { get; set; }
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Cedula Identidad")]
        public string Ci { get; set; }
        //public ICollection<Role> OrdenDeCompraDetalle { get; set; }
    }
}