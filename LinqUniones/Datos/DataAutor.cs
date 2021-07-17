using LinqUniones.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LinqUniones.Datos
{
    public class DataAutor
    {   
        //Lista de objetos Autores como fuente de datos
        public List<Autor> autores = new List<Autor>()
        {
            new Autor {
                        ID_Autor        = 1,
                        Nombre          = "Federico García Lorca",
                        FechaNacimento  = new DateTime(1898, 6, 5),
                        LugarNacimiento = "España"
                        },
            new Autor {
                        ID_Autor        = 2,
                        Nombre          = "William Blake",
                        FechaNacimento  = new DateTime(1757,12, 8),
                        LugarNacimiento = "Inglaterra"
                        },
            new Autor {
                        ID_Autor        = 3,
                        Nombre          = "Antonio Machado Ruiz",
                        FechaNacimento  = new DateTime(1875, 7, 26),
                        LugarNacimiento = "España"
                        }
        };

    }
}
