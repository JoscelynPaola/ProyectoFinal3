using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal3
{
    public class Estudiante
    {
        public string nombre { get; set; }
        public string matricula { get; set; }

        public Estudiante izquierdo { get; set; }
        public Estudiante derecho { get; set; }

        public Dictionary<string, double> materias { get; set; }

        public HashSet<talleres> talleresInscritos { get; set; }

        public Estudiante()
        {
            izquierdo = null;
            derecho = null;
            materias = new Dictionary<string, double>();
            talleresInscritos = new HashSet<talleres>();            
        }
        public void agregarMateria(string nombreMateria, int calificacion)
        {
            materias.Add(nombreMateria, calificacion);
        }

        public void eliminarMateria(string nombreMateria)
        {
            materias.Remove(nombreMateria);
        }
        public void modificarCalificacion(string nombreMateria, double nuevaCalificacion)
        {
            if (materias.ContainsKey(nombreMateria))
            {
                materias[nombreMateria] = nuevaCalificacion;
            }
        }
        public void modificarNombreMateria(string nombreMateria, string nuevoNombre)
        {
            if (materias.ContainsKey(nombreMateria))
            {
                double calificacion = materias[nombreMateria];
                materias.Remove(nombreMateria);
                materias.Add(nuevoNombre, calificacion);
            }
        }
        public double promedioMaterias()
        {
            if (materias.Count == 0)
            {
                Console.WriteLine("No hay materias registradas.");
                return 0;
            }

            double promedio = materias.Values.Average();
            return promedio;
        }
        public void agregarTaller(talleres taller)
        {
            talleresInscritos.Add(taller);
        }

    }
}
