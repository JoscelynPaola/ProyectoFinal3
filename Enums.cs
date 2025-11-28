using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal3
{
    public enum talleres//Enum para los talleres disponibles
    {
        futbol,
        ajedrez,
        danza,
        basquetbol,
        voleibol
    }

    public enum materias//Enum para las materias disponibles
    {
        programacion,
        ingles,
        redes
    }

    public enum ordenListadoEstudiantes//Enum para los tipos de recorrido del arbol
    {
        inorden = 0,
        preorden = 1,
        posorden = 2
    }
}
