using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUniones.Entidades
{
    public class Publicacion
    {
        public int ID_Publi { get; set; }
        public string Titulo { get; set; }
        //Enlace con la clase Autor
        public int ID_Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string LugarPublicacion { get; set; }
    }
}
