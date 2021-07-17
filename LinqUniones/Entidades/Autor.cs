using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUniones.Entidades
{
    public class Autor
    {
        public int ID_Autor { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimento { get; set; }
        public string LugarNacimiento { get; set; }
    }
}
