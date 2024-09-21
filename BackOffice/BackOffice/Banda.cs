using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class Banda : Cuenta
    {
        public int idBanda { get; set; }
        // Referencia a la cuenta del administrador
        public Cuenta Admin { get; set; }
        // Referencia a la cuenta de un miembro
        public Cuenta Miembro { get; set; } 
        public string nombreBanda { get; set; }
        public bool activoBanda { get; set; }
    }
}
