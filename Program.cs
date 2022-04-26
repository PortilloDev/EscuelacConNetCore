using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Binary School", 1981, TiposEscuela.PreEscolar, pais:"España", ciudad: "Fuenlabrada");
            escuela.Ciudad = "Fuenlabrada";

        //    "Bienvenido a la escuela "  + escuela.Nombre + " .Creada el año " + escuela.AnoDeCreacion
            Console.WriteLine(escuela);
        }
    }
}
