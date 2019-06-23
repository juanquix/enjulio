using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Ci { get; set; }
       // public ICollection<Role> OrdenDeCompraDetalle { get; set; }
    }
}
