using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gestion = new GestionCalificaciones();
            while (true)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Introducir alumno");
                Console.WriteLine("2. Eliminar alumno");
                Console.WriteLine("3. Consultar nota y calificación");
                Console.WriteLine("4. Modificar nota");
                Console.WriteLine("5. Mostrar alumnos suspensos");
                Console.WriteLine("6. Mostrar alumnos aprobados");
                Console.WriteLine("7. Mostrar candidatos a MH");
                Console.WriteLine("8. Modificar calificación");
                Console.WriteLine("9. Mostrar todos los alumnos");
                Console.WriteLine("0. Salir");

                var opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        gestion.IntroducirAlumno();
                        break;
                    case "2":
                        gestion.EliminarAlumno();
                        break;
                    case "3":
                        gestion.ConsultarAlumno();
                        break;
                    case "4":
                        gestion.ModificarNota();
                        break;
                    case "5":
                        gestion.MostrarAlumnosSuspensos();
                        break;
                    case "6":
                        gestion.MostrarAlumnosAprobados();
                        break;
                    case "7":
                        gestion.MostrarCandidatosMH();
                        break;
                    case "8":
                        gestion.ModificarCalificacion();
                        break;
                    case "9":
                        gestion.MostrarAlumnos();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige otra opción.");
                        break;
                }
            }
        }
    }
}
