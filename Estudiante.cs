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
        public string nombre { get; set; }//Atributos de la clase estudiante
        public string matricula { get; set; }//Atributos de la clase estudiante

        public Estudiante izquierdo { get; set; }//nodo izquierdo
        public Estudiante derecho { get; set; }//nodo derecho

        public Dictionary<string, double> materias { get; set; }//Creacion del diccionario para materias y calificaciones

        public HashSet<talleres> talleresInscritos { get; set; }//Creacion del HashSet para talleres inscritos

        public Estudiante()//Constructor del estudiante
        {
            izquierdo = null;
            derecho = null;
            materias = new Dictionary<string, double>();
            talleresInscritos = new HashSet<talleres>();            
        }
        public void agregarMateria(string nombreMateria, int calificacion)//Metodo para agregar materias y calificaciones
        {
            materias.Add(nombreMateria, calificacion);
        }

        public void eliminarMateria(string nombreMateria)//Metodo para eliminar materias
        {
            materias.Remove(nombreMateria);
        }
        public void modificarCalificacion(string nombreMateria, double nuevaCalificacion)//Metodo para modificar calificaciones
        {
            if (materias.ContainsKey(nombreMateria))
            {
                materias[nombreMateria] = nuevaCalificacion;
            }
        }
        public void modificarNombreMateria(string nombreMateria, string nuevoNombre)//Metodo para modificar el nombre de una materia
        {
            if (materias.ContainsKey(nombreMateria))//Verifica si la materia existe
            {
                double calificacion = materias[nombreMateria];
                materias.Remove(nombreMateria);//Elimina la materia antigua
                materias.Add(nuevoNombre, calificacion);
            }
        }
        public double promedioMaterias()//Metodo para calcular el promedio de las materias
        {
            if (materias.Count == 0)//Verifica si hay materias registradas
            {
                Console.WriteLine("No hay materias registradas.");//Mensaje de error
                return 0;
            }

            double promedio = materias.Values.Average();//Calcula el promedio de las calificaciones
            return promedio;
        }
        public void agregarTaller(talleres taller)//Metodo para agregar talleres
        {
            talleresInscritos.Add(taller);
        }

    }
}
