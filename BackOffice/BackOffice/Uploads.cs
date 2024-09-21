using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class Uploads
    {
        public int id { get; set; }
        public int id_de_cuenta { get; set; }
        public DateTime fecha_pub { get; set; }
        public int n_upvotes { get; set; }
        public string tipo { get; set; }
        public bool activo { get; set; }
    }
}

