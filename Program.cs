using System;
using CoreEscuela.Entidades;
using static System.Console;
namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Binary School", 1981, TiposEscuela.Secundaria, pais:"España", ciudad: "Fuenlabrada");

           escuela.Cursos =  new Curso[]{
                        new Curso() {
                            Nombre = "101"
                        },
                        new Curso() {
                            Nombre = "201"
                        },
                        new Curso() {
                            Nombre = "301"
                        }
            };
           
            WriteLine(escuela);
            WriteLine("****************************");
            imprimirCursosEscuela(escuela);
        }

        private static void imprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("--------------------");
            WriteLine("Cursos de la escuela");
            WriteLine("--------------------");

            if (escuela?.Cursos != null ) {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine(curso.Nombre + ",  " + curso.UniqueId);
                }
            }
       
        }
    }
}
