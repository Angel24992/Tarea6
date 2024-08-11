using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    public class GestionCalificaciones
    {
        private Dictionary<string, Alumno> alumnos = new Dictionary<string, Alumno>();

        public void IntroducirAlumno()
        {
            Console.Write("Introduce el DNI del alumno: ");
            var dni = Console.ReadLine();
            if (alumnos.ContainsKey(dni))
            {
                Console.WriteLine("El alumno con este DNI ya existe.");
                return;
            }

            Console.Write("Introduce los apellidos del alumno: ");
            var apellidos = Console.ReadLine();
            Console.Write("Introduce el nombre del alumno: ");
            var nombre = Console.ReadLine();

            int nota;
            while (true)
            {
                Console.Write("Introduce la nota del alumno (de 0 a 10): ");
                if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10) break;
                Console.WriteLine("Nota no válida. Debe ser un número entre 1 y 10.");
            }
            

            alumnos[dni] = new Alumno(dni, apellidos, nombre, nota);
        }

        public void EliminarAlumno()
        {
            Console.Write("Introduce el DNI del alumno a eliminar: ");
            var dni = Console.ReadLine();
            if (alumnos.Remove(dni))
            {
                Console.WriteLine("Alumno eliminado.");
            }
            else
            {
                Console.WriteLine("No se encontró el alumno con el DNI proporcionado.");
            }
        }

        public void ConsultarAlumno()
        {
            Console.Write("Introduce el DNI del alumno a consultar: ");
            var dni = Console.ReadLine();
            if (alumnos.TryGetValue(dni, out var alumno))
            {
                Console.WriteLine($"Nota: {alumno.Nota}, Calificación: {alumno.Calificacion}");
            }
            else
            {
                Console.WriteLine("No se encontró el alumno con el DNI proporcionado.");
            }
        }

        public void ModificarNota()
        {
            Console.Write("Introduce el DNI del alumno cuya nota deseas modificar: ");
            var dni = Console.ReadLine();
            if (alumnos.TryGetValue(dni, out var alumno))
            {
                Console.Write("Introduce la nueva nota: ");
                alumno.Nota = float.Parse(Console.ReadLine());
                alumno.ActualizarCalificacion();
                // La calificación se actualiza automáticamente al imprimir.
                Console.WriteLine("Nota modificada.");
            }
            else
            {
                Console.WriteLine("No se encontró el alumno con el DNI proporcionado.");
            }
        }

        public void MostrarAlumnosSuspensos()
        {
            foreach (var alumno in alumnos.Values.Where(a => a.Nota < 5))
            {
                Console.WriteLine(alumno);
            }
        }

        public void MostrarAlumnosAprobados()
        {
            foreach (var alumno in alumnos.Values.Where(a => a.Nota >= 5 && a.Nota <= 10))
            {
                Console.WriteLine(alumno);
            }
        }

        public void MostrarCandidatosMH()
        {
            foreach (var alumno in alumnos.Values.Where(a => a.Nota == 10))
            {
                Console.WriteLine(alumno);
            }
        }

        public void ModificarCalificacion()
        {
            Console.Write("Introduce el DNI del alumno cuya calificación deseas modificar: ");
            var dni = Console.ReadLine();
            if (alumnos.TryGetValue(dni, out var alumno))
            {
                Console.Write("Introduce la nueva calificación (SS, AP, NT, SB): ");
                var nuevaCalificacion = Console.ReadLine().ToUpper();
                if (new[] { "SS", "AP", "NT", "SB" }.Contains(nuevaCalificacion))
                {
                    alumno.Calificacion = nuevaCalificacion;
                    Console.WriteLine("Calificación modificada.");
                }
                else
                {
                    Console.WriteLine("Calificación no válida. Debe ser SS, AP, NT o SB.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró el alumno con el DNI proporcionado.");
            }

        }

        public void MostrarAlumnos()
        {
            foreach (var alumno in alumnos.Values)
            {
                Console.WriteLine(alumno);
            }
        }
    }
}
