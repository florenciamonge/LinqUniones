using System;
using System.Linq;
using LinqUniones.Datos;
namespace LinqUniones
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAutor odataAutor = new DataAutor();
            DataPublicacion odataPublicacion = new DataPublicacion();

            //Sintaxis de consulta
            var joinConsulta =
                             from a in odataAutor.autores
                             join p in odataPublicacion.publicaciones
                             on a.ID_Autor equals p.ID_Autor
                             select new
                             {
                                 Autor = a.Nombre,
                                 Titulo = p.Titulo,
                                 FechaPublicacion = p.Fecha
                             };

            //Sintaxis de metodo
            var joinLambda = odataAutor.autores.Join          // Colección 1: Autores
              (
                  odataPublicacion.publicaciones,             // Colección 2 : Publicaciones
                  a => a.ID_Autor,                            // Lambda Clave Colec 1
                  p => p.ID_Autor,                            // Lambda Clave Colec 2
                  (a, p) => new
                  {                             // Lambda Colección de resultado
                    Autor = a.Nombre,
                      Titulo = p.Titulo,
                      FechaPublicacion = p.Fecha
                  }
              );

            //Imprimo Sintaxis consulta
            Console.WriteLine("Expresión de Consulta:");

            foreach (var j in joinConsulta)
            {
                Console.WriteLine("{0} - {1} - {2}", j.Autor, j.Titulo, j.FechaPublicacion); 
            }

            //Imprimo Sintaxis metodo

            Console.WriteLine();
            Console.WriteLine("Expresión Lambda:");

            foreach (var j in joinLambda)
            {
                Console.WriteLine("{0} - {1} - {2}", j.Autor, j.Titulo, j.FechaPublicacion);
            }

            Console.Read();







        }


    }
}
