using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class Evento : Uploads
    {
        //su propia id la saca de la herencia
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }

    }
}
