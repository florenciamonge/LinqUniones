using LinqUniones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUniones.Datos
{
    public class DataPublicacion
    {
         public List<Publicacion> publicaciones = new List<Publicacion>()
        {
            new Publicacion
            {
                ID_Publi         = 1,
                Titulo           = "Songs of Innocence",
                Fecha            = new DateTime(1789, 1, 1),
                ID_Autor         = 2,
                LugarPublicacion = "Inglaterra"
            },
            new Publicacion
            {
                ID_Publi         = 2,
                Titulo           = "Soledades: poesías",
                Fecha            = new DateTime(1903, 1, 1),
                ID_Autor         = 3,
                LugarPublicacion = "España"
            },
            new Publicacion
            {
                ID_Publi         = 3,
                Titulo           = "El Romancero Gitano",
                Fecha            = new DateTime(1918, 1, 1),
                ID_Autor         = 1,
                LugarPublicacion = "España"
            },
            new Publicacion
            {
                ID_Publi         = 4,
                Titulo           = "Poeta en Nueva York",
                Fecha            = new DateTime(1930, 1, 1),
                ID_Autor         = 1,
                LugarPublicacion = "España"
            },
            new Publicacion
            {
                ID_Publi         = 5,
                Titulo           = "Páginas escogidas",
                Fecha            = new DateTime(1917, 1, 1),
                ID_Autor         = 3,
                LugarPublicacion = "España"
            }
        };
    }
}
