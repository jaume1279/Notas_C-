using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotas
{
    class Program
    {
        static char EscapeCharacter = 'R';
        static string EscapeWord = "sed";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa de gestión de notas.");
            Console.WriteLine("\nIntroduzca las notas de los alumnos. Para acabar escribe: sed");

            var notasDeAlumnos = new List<double> { };
            var keepDoing = true;

            while (keepDoing)
            {
                Console.WriteLine($"\nNota del alumno {notasDeAlumnos.Count+1}:");
                var notaText = Console.ReadLine();

                if (notaText == EscapeWord)
                {
                    keepDoing = false;
                }
                else
                {
                    var nota = 0.0;

                    if (double.TryParse(notaText.Replace(".",","),out nota))
                    {
                        notasDeAlumnos.Add(nota);
                    }
                    else
                    {
                        Console.WriteLine("La nota introducida es incorrecta melón:"); ;
                    }
                }
            }

            var suma = 0.0;

            for (var i=0; i < notasDeAlumnos.Count; i++)
            {
                suma += notasDeAlumnos[i];
            }

            var average = suma / notasDeAlumnos.Count;

            Console.WriteLine("Escoge que quieres saber: 1:) Promedio  2.-)Nota mínima  0.-)Salir");

            string opcion;

            do
            {
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "0": Console.WriteLine("Buenas vacaciones !!!!!!"); break;

                    case "1": Console.WriteLine("El promedio de notas es: {0}", average); break;

                    case "2": Console.WriteLine("La menor nota es:{0}", notasDeAlumnos.Min()); break;

                    default: break;
                }
            }
            while (opcion != "0") ;

            Console.ReadLine();
        }
    }
}
