using System.Collections.Generic;
using System.Configuration.Internal;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProyectoFinal3
{
    public partial class Form1 : Form
    {
        //Dictionary<string, string> estudiantes = new Dictionary<string, string>();

        public Estudiante raiz = null;

        public Estudiante estudianteEditar = null;

        public ordenListadoEstudiantes ordenEstudiantes = ordenListadoEstudiantes.inorden;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (talleres item in Enum.GetValues(typeof(talleres)))
            {
                cmbTalleres.Items.Add(item);
            }
            foreach (ordenListadoEstudiantes item in Enum.GetValues(typeof(ordenListadoEstudiantes)))
            {
                cmbOrdenEstudiantes.Items.Add(item);
            }
            cmbOrdenEstudiantes.SelectedIndex = 0;
            foreach (materias item in Enum.GetValues(typeof(materias)))
            {
                cmbMaterias.Items.Add(item);
            }
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
        //    HashSet<int> interseccion = new HashSet<int>(A);//catalogo
        //    interseccion.IntersectWith(B);//talleres estudiante
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
            nuevo.matricula = txtMatriculaAgregar.Text;
            nuevo.nombre = txtNombreAgregar.Text;

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                agregarEstudianteRecursivo(raiz, nuevo);
            }

            txtMatriculaAgregar.Text = string.Empty;
            txtNombreAgregar.Text = string.Empty;
            txtMatriculaAgregar.Focus();
            ListarEstudiantes();
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

        public void ListarEstudiantes()
        {
            lbxEstudiantes.Items.Clear();
            switch (ordenEstudiantes)
            {
                case ordenListadoEstudiantes.inorden:
                    ListarEstudiantesInordenRecursivo(raiz, lbxEstudiantes);
                    break;

                case ordenListadoEstudiantes.preorden:
                    ListarEstudiantesPreordenRecursivo(raiz, lbxEstudiantes);
                    break;

                case ordenListadoEstudiantes.posorden:
                    ListarEstudiantesPosordenRecursivo(raiz, lbxEstudiantes);
                    break;
            }
        }

        public void ListarEstudiantesInordenRecursivo(Estudiante _nodo, ListBox _lbx)
        {
            if (_nodo != null)
            {
                ListarEstudiantesInordenRecursivo(_nodo.izquierdo, _lbx);
                _lbx.Items.Insert(0, _nodo.matricula + " => " + _nodo.nombre);
                ListarEstudiantesInordenRecursivo(_nodo.derecho, _lbx);
            }
        }

        public void ListarEstudiantesPreordenRecursivo(Estudiante _nodo, ListBox _lbx)
        {
            if (_nodo != null)
            {
                _lbx.Items.Insert(0, _nodo.matricula + " => " + _nodo.nombre);
                ListarEstudiantesPreordenRecursivo(_nodo.izquierdo, _lbx);
                ListarEstudiantesPreordenRecursivo(_nodo.derecho, _lbx);
            }
        }

        public void ListarEstudiantesPosordenRecursivo(Estudiante _nodo, ListBox _lbx)
        {
            if (_nodo != null)
            {
                ListarEstudiantesPosordenRecursivo(_nodo.izquierdo, _lbx);
                ListarEstudiantesPosordenRecursivo(_nodo.derecho, _lbx);
                _lbx.Items.Insert(0, _nodo.matricula + " => " + _nodo.nombre);
            }
        }


        public void unionTalleresEstudiantes()
        {
            if (raiz != null)
            {
                lbxUnionTalleres.Items.Clear();
                HashSet<talleres> segmentoTalleres = new HashSet<talleres>();
                unionTalleresEstudiantesRecursivo(raiz, ref segmentoTalleres);
                foreach (talleres item in segmentoTalleres)
                {
                    lbxUnionTalleres.Items.Add(item);
                }
            }
        }
        public void unionTalleresEstudiantesRecursivo(Estudiante _nodo, ref HashSet<talleres> _segmentoTalleres)
        {
            _segmentoTalleres.UnionWith(_nodo.talleresInscritos);
            if (_nodo.izquierdo != null)
            {
                unionTalleresEstudiantesRecursivo(_nodo.izquierdo, ref _segmentoTalleres);
            }
            if (_nodo.derecho != null)
            {
                unionTalleresEstudiantesRecursivo(_nodo.derecho, ref _segmentoTalleres);
            }
        }

        public void InterseccionTalleresEstudiantes()
        {
            if (raiz != null)
            {
                lbxInterseccionTalleres.Items.Clear();
                HashSet<talleres> segmentoTalleres = new HashSet<talleres>();
                foreach (talleres item in Enum.GetValues(typeof(talleres)))
                {
                    segmentoTalleres.Add(item);
                }
                HashSet<talleres> segmentoTalleresInterseccion = new HashSet<talleres>();
                InterseccionTalleresEstudiantesRecursivo(raiz, segmentoTalleres, ref segmentoTalleresInterseccion);

                foreach (var item in segmentoTalleresInterseccion)
                {
                    string listadoEstudiantesTaller = string.Empty;
                    buscarEstudiantesPorTaller(raiz, item, ref listadoEstudiantesTaller);
                    lbxInterseccionTalleres.Items.Add(item + " => " + listadoEstudiantesTaller);
                }
            }
        }
        public void InterseccionTalleresEstudiantesRecursivo(Estudiante _nodo, HashSet<talleres> _segmentoTalleres, ref HashSet<talleres> _segmentoTalleresInterseccion)
        {
            _segmentoTalleresInterseccion = new HashSet<talleres>(_segmentoTalleres);
            _segmentoTalleresInterseccion.IntersectWith(_nodo.talleresInscritos);
            if (_nodo.izquierdo != null)
            {
                InterseccionTalleresEstudiantesRecursivo(_nodo.izquierdo, _segmentoTalleres, ref _segmentoTalleresInterseccion);
            }
            if (_nodo.derecho != null)
            {
                InterseccionTalleresEstudiantesRecursivo(_nodo.derecho, _segmentoTalleres, ref _segmentoTalleresInterseccion);
            }
        }


        public void DiferencTalleresEstudiantes()
        {
            if (raiz != null)
            {
                lbxDiferenciaTalleres.Items.Clear();
                HashSet<talleres> segmentoTalleres = new HashSet<talleres>();
                foreach (talleres item in Enum.GetValues(typeof(talleres)))
                {
                    segmentoTalleres.Add(item);
                }
                DiferencTalleresEstudiantesRecursivo(raiz, ref segmentoTalleres);

                foreach (talleres item in segmentoTalleres)
                {
                    lbxDiferenciaTalleres.Items.Add(item);
                }
            }
        }
        public void DiferencTalleresEstudiantesRecursivo(Estudiante _nodo, ref HashSet<talleres> _segmentoTalleres)
        {
            _segmentoTalleres.ExceptWith(_nodo.talleresInscritos);
            if (_nodo.izquierdo != null)
            {
                DiferencTalleresEstudiantesRecursivo(_nodo.izquierdo, ref _segmentoTalleres);
            }
            if (_nodo.derecho != null)
            {
                DiferencTalleresEstudiantesRecursivo(_nodo.derecho, ref _segmentoTalleres);
            }
        }

        public void buscarEstudiantesPorTaller(Estudiante _nodo, talleres _taller, ref string _listaEstudiantes)
        {
            if(_nodo.talleresInscritos.Contains(_taller))
            {
                _listaEstudiantes += _nodo.matricula + " => " + _nodo.nombre + " --- ";
            }
            if (_nodo.izquierdo != null)
            {
                buscarEstudiantesPorTaller(_nodo.izquierdo, _taller, ref _listaEstudiantes);
            }
            if (_nodo.derecho != null)
            {
                buscarEstudiantesPorTaller(_nodo.derecho, _taller, ref _listaEstudiantes);
            }
        }

        public Estudiante buscarEstudiante()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.matricula = txtMatriculaBuscar.Text;

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

        public void asignarTalleresEstudiante(Estudiante _nodo, talleres item)
        {
            _nodo.agregarTaller(item);
        }

        public void promedioEstudiante(Estudiante _nodo)
        {
            double promedio = _nodo.promedioMaterias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estudianteEditar = buscarEstudiante();
            if (estudianteEditar != null)
            {
                txtNombreBuscar.Text = estudianteEditar.nombre;
                cmbTalleres.SelectedItem = null;
                cmbMaterias.SelectedItem = null;

                ListarTalleresEstudiante();
                ListarMateriasEstudiante();
            }
        }

        public void ListarTalleresEstudiante()
        {
            lbxTalleresEstudiante.Items.Clear();
            if (estudianteEditar.talleresInscritos.Count > 0)
            {
                foreach (talleres item in estudianteEditar.talleresInscritos)
                {
                    lbxTalleresEstudiante.Items.Add(item);
                }
            }
        }

        public void ListarMateriasEstudiante()
        {
            lblPromedioEstudiante.Text = string.Empty;
            lbxMateriasEstudiante.Items.Clear();
            if (estudianteEditar.materias.Count > 0)
            {
                foreach (KeyValuePair<string, double> item in estudianteEditar.materias)
                {
                    lbxMateriasEstudiante.Items.Add(item.Key + ": " + item.Value);
                }
                lblPromedioEstudiante.Text = estudianteEditar.promedioMaterias().ToString();
            }
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            agregarEstudiante();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbTalleres.SelectedItem != null)
            {
                if (estudianteEditar != null)
                {
                    talleres item;
                    Enum.TryParse(cmbTalleres.SelectedItem.ToString(), out item);
                    estudianteEditar.agregarTaller(item);
                    ListarTalleresEstudiante();

                    unionTalleresEstudiantes();
                    InterseccionTalleresEstudiantes();
                    DiferencTalleresEstudiantes();
                }
            }
        }

        private void cmbOrdenEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(cmbOrdenEstudiantes.SelectedIndex.ToString(), out ordenEstudiantes);
            ListarEstudiantes();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            bool contieneItem = Enum.IsDefined(typeof(materias), txtNombreMateria.Text);
            if (!contieneItem)
            {
                cmbMaterias.Items.Add(txtNombreMateria.Text);
                txtNombreMateria.Text = string.Empty;
                txtNombreMateria.Focus();
            }
        }

        private void btnAgregarMateriaEstudiante_Click(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedItem != null)
            {
                if (estudianteEditar != null)
                {
                    estudianteEditar.agregarMateria(cmbMaterias.SelectedItem.ToString(), 0);
                    ListarMateriasEstudiante();
                }
            }
        }

        private void lbxMateriasEstudiante_DoubleClick(object sender, EventArgs e)
        {
            if (lbxMateriasEstudiante.SelectedItem != null)
            {
                if (estudianteEditar != null)
                {
                    string materia = lbxMateriasEstudiante.SelectedItem.ToString().Substring(0, lbxMateriasEstudiante.SelectedItem.ToString().IndexOf(":"));
                    string strCalificacion = string.Empty;
                    DialogResult decision = m_inputBox("Calificación", "Indique la calificación de la materia: " + materia, ref strCalificacion);
                    if (decision == DialogResult.OK)
                    {
                        double calificacion = 0;
                        double.TryParse(strCalificacion, out calificacion);

                        if (calificacion > 0)
                        {
                            estudianteEditar.modificarCalificacion(materia, calificacion);
                            ListarMateriasEstudiante();
                        }
                    }
                }
            }
        }



        public DialogResult m_inputBox(string _title, string _promptText, ref string _value)
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button
                buttonOk = new System.Windows.Forms.Button(),
                buttonCancel = new System.Windows.Forms.Button();
            DialogResult dialogResult;

            form.Text = _title;
            label.Text = _promptText;
            textBox.Text = _value;

            buttonOk.Text = "Aceptar";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            dialogResult = form.ShowDialog();
            _value = (!string.IsNullOrEmpty(textBox.Text)) ? textBox.Text : string.Empty;
            return dialogResult;
        }
    }
}
