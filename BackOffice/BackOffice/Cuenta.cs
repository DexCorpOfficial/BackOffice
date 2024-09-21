using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class Cuenta
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public byte[] foto_perfil { get; set; }
        public string biografia { get; set; }
        public int seguidores { get; set; }
        public int seguidos { get; set; }
        public DateTime fecha_creacion { get; set; }
        public bool musico { get; set; }
        public bool activo { get; set; }
        public string contrasena { get; set; }
        public bool privado { get; set; }

    }

}
