using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6
{
    internal class Alumno
    {
        public string Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public float Nota { get; set; }
        public string Calificacion { get; set; }
        public Alumno(string dni, string apellidos, string nombre, float nota)
        {
            Dni = dni;
            Apellidos = apellidos;
            Nombre = nombre;
            Nota = nota;
            Calificacion = CalcularCalificacion();
        }

        private string CalcularCalificacion()
        {
            if (Nota >=0 && Nota < 5)
                return "SS";
            else if (Nota >= 5 && Nota < 7)
                return "AP";
            else if (Nota >= 7 && Nota < 9)
                return "NT";
            else if (Nota >= 9 && Nota <= 10)
                return "SB";
            else
                return "Nota ingresada no valida";
        }
        public void ActualizarCalificacion()
        {
            Calificacion = CalcularCalificacion();  // Recalcula la calificación según la nota actual
        }

        public override string ToString()
        {
            return $"{Dni} {Apellidos}, {Nombre} {Nota} {Calificacion}";
        }
    }
}
