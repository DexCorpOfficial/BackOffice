using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    class Comentario : Uploads
    {
        //su id propia la saca de uploads con la herencia
        //con la instancia de abajo puedo usar los atributos de post
        //esto me sirve para usar la id de post, necesaria para saber donde esta el comentario
        public Post post { get; set; }
        public string contenido { get; set; }
        
        
        
    }
}
