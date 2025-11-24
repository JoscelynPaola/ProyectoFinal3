using System.Collections.Generic;
using System.Xml.Linq;

namespace ProyectoFinal3
{
    public partial class Form1 : Form
    {
        //Dictionary<string, string> estudiantes = new Dictionary<string, string>();

        public Estudiante raiz = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public void crearListaEstudiantes()
        //{
        //    //AGREGAR ELEMENTOS AL DICCIONARIO
        //    estudiantes.Add("UTP0210597", "Juan Perez");
        //    estudiantes.Add("UTP0677837", "Maria Gomez");
        //    estudiantes.Add("UTP0239874", "Carlos Sanchez");
        //    estudiantes.Add("UTP0146967", "Ana Martinez");
        //    estudiantes.Add("UTP07503298", "Luis Rodriguez");

        //    //CODIGO PARA BUSCAR UN SOLO ESTUDIANTE CON LINQ Y KEYVALUEPAIR
        //    //KeyValuePair<string, string> par = estudiantes.Where(item => item.Key == "UTP0239874").FirstOrDefault();
        //    //lbxEstudiantes.Items.Add($"Matrícula: {par.Key}, Nombre: {par.Value}");

        //    //CODIGO PARA BUSCAR EL NOMBRE DE UN ESTUDIANTE USANDO LA KEY
        //    //string nombreEstudiante = estudiantes["UTP0239874"];
        //    //lbxEstudiantes.Items.Add($"Matrícula: {"UTP0239874"}, Nombre: {nombreEstudiante}");

        //    //ELIMINAR ELEMENTO DEL DICCIONARIO
        //    //estudiantes.Remove("UTP0677837");

        //    //ORDENAMIENTO DEL DICCIONARIO
        //    //estudiantes = estudiantes.OrderBy(item => item.Key).ToDictionary();
        //    //estudiantes = estudiantes.OrderBy(item => item.Value).ToDictionary();
        //    //estudiantes = estudiantes.OrderByDescending(item => item.Value).ToDictionary();

        //    //MOSTRAR ELEMENTOS DEL DICCIONARIO
        //    foreach (KeyValuePair<string, string> par in estudiantes)
        //    {
        //        lbxEstudiantes.Items.Add($"Matrícula: {par.Key}, Nombre: {par.Value}");
        //    }
        //}

        //public void crearConjuntos()
        //{
        //    HashSet<int> A = new HashSet<int>() { 1, 2, 3 };
        //    HashSet<int> B = new HashSet<int>() { 3, 4, 5 };

        //    // Unión (valores unicos entre 2 conjuntos)
        //    HashSet<int> union = new HashSet<int>(A);
        //    union.UnionWith(B);
        //    Console.WriteLine("Unión: " + string.Join(", ", union));


        //    //ORDENAMIENTO DESCENDENTE
        //    union = union.OrderDescending().ToHashSet();


        //    // Unión2 (valores unicos entre 2 conjuntos B-a)
        //    HashSet<int> union2 = new HashSet<int>(B);
        //    union2.UnionWith(A);
        //    Console.WriteLine("Unión: " + string.Join(", ", union2));

        //    // Intersección (valores comunes entre 2 conjuntos)
        //    HashSet<int> interseccion = new HashSet<int>(A);
        //    interseccion.IntersectWith(B);
        //    Console.WriteLine("Intersección: " + string.Join(", ", interseccion));


        //    // Diferencia (los del conjunto A que no estan en el B)
        //    HashSet<int> diferencia = new HashSet<int>(A);
        //    diferencia.ExceptWith(B);
        //    Console.WriteLine("Diferencia A-B: " + string.Join(", ", diferencia));


        //    // Diferencia (los del conjunto B que no estan en el A)
        //    HashSet<int> diferenciaB = new HashSet<int>(B);
        //    diferenciaB.ExceptWith(A);
        //    Console.WriteLine("Diferencia A-B: " + string.Join(", ", diferenciaB));

        //    //List<int> numeros = new List<int>();
        //    //numeros.Add(1);
        //    //numeros.Add(2);
        //    //numeros.Add(3);

        //    //List<int> numeros2 = new List<int>();
        //    //numeros2.Add(3);
        //    //numeros2.Add(4);
        //    //numeros2.Add(5);

        //    //List<int> numerosUnion = numeros;
        //    //numerosUnion.AddRange(numeros2);

        //    //numerosUnion = numerosUnion.Distinct().ToList();

        //    //numerosUnion = numerosUnion.OrderDescending<int>().ToList();
        //}

        public void agregarEstudiante()
        {
            Estudiante nuevo = new Estudiante();
            nuevo.nombre = "Juan Perez";
            nuevo.matricula = "a1";
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                agregarEstudianteRecursivo(raiz, nuevo);
            }
        }

        public void agregarEstudianteRecursivo(Estudiante _nodo, Estudiante _nuevo)
        {
            int resultComparacionMatriculas = String.Compare(_nodo.matricula, _nuevo.matricula, StringComparison.OrdinalIgnoreCase);

            if (resultComparacionMatriculas == 0)
            {
                MessageBox.Show("Error");
                //mensaje error
            }
            else if (resultComparacionMatriculas < 0)
            {
                //a es antes que b (izquierda)
                if (_nodo.izquierdo == null)
                {
                    _nodo.izquierdo = _nuevo;
                }
                else
                {
                    agregarEstudianteRecursivo(_nodo.izquierdo, _nuevo);
                }
            }
            else
            {
                //a va despues que b (derecha)
                if (_nodo.derecho == null)
                {
                    _nodo.derecho = _nuevo;
                }
                else
                {
                    agregarEstudianteRecursivo(_nodo.derecho, _nuevo);
                }
            }
        }

        public Estudiante buscarEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.matricula = textBox1.Text;

            return buscarEstudianteRecursivo(raiz, estudiante);
        }

        public Estudiante buscarEstudianteRecursivo(Estudiante _nodo, Estudiante _buscar)
        {
            int resultComparacionMatriculas = String.Compare(_nodo.matricula, _buscar.matricula, StringComparison.OrdinalIgnoreCase);

            if (resultComparacionMatriculas == 0)
            {
                return _nodo;
            }
            else if (resultComparacionMatriculas < 0)
            {
                return buscarEstudianteRecursivo(_nodo.izquierdo, _buscar);
            }
            else
            {
                return buscarEstudianteRecursivo(_nodo.derecho, _buscar);
            }
        }

        public void asignarMateriasEstudiante(Estudiante _nodo)
        {
            _nodo.agregarMateria("Matemáticas", 8);
            _nodo.agregarMateria("Historia", 9);
        }

        public void asignarTalleresEstudiante(Estudiante _nodo, talleres taller)
        {
            _nodo.agregarTaller(taller);
        }

        public void promedioEstudiante(Estudiante _nodo)
        {
            double promedio = _nodo.promedioMaterias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante estudianteEncontrado = buscarEstudiante();
            if(estudianteEncontrado != null)
            {
                asignarMateriasEstudiante(estudianteEncontrado);
                asignarTalleresEstudiante(estudianteEncontrado, talleres.futbol);
            }
        }
    }
}
