using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class Post : Uploads
    {
        //su id propia la saca desde la herencia de uploads
        public string descripcion { get; set; }
        public byte[] media { get; set; }
        //en tipo de post va si es del feed o de banda
        public string tipoPost { get; set; }
        public Banda idBanda { get; set; }
    }
}
