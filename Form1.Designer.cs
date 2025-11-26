namespace ProyectoFinal3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMatriculaBuscar = new TextBox();
            btnBuscarEstudiante = new Button();
            label6 = new Label();
            lbxEstudiantes = new ListBox();
            cmbOrdenEstudiantes = new ComboBox();
            btnAgregarEstudiante = new Button();
            txtNombreAgregar = new TextBox();
            txtMatriculaAgregar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            btnAgregarMateriaEstudiante = new Button();
            label8 = new Label();
            txtNombreMateria = new TextBox();
            btnAgregarMateria = new Button();
            label7 = new Label();
            cmbMaterias = new ComboBox();
            btnAgregarTallerEstudiante = new Button();
            label5 = new Label();
            cmbTalleres = new ComboBox();
            lbxTalleresEstudiante = new ListBox();
            lbxMateriasEstudiante = new ListBox();
            txtNombreBuscar = new TextBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblPromedioEstudiante = new Label();
            label10 = new Label();
            tabPage3 = new TabPage();
            lbxDiferenciaTalleres = new ListBox();
            label13 = new Label();
            lbxInterseccionTalleres = new ListBox();
            label12 = new Label();
            lbxUnionTalleres = new ListBox();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // txtMatriculaBuscar
            // 
            txtMatriculaBuscar.Location = new Point(79, 22);
            txtMatriculaBuscar.Name = "txtMatriculaBuscar";
            txtMatriculaBuscar.Size = new Size(176, 23);
            txtMatriculaBuscar.TabIndex = 1;
            // 
            // btnBuscarEstudiante
            // 
            btnBuscarEstudiante.Location = new Point(261, 22);
            btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            btnBuscarEstudiante.Size = new Size(75, 23);
            btnBuscarEstudiante.TabIndex = 2;
            btnBuscarEstudiante.Text = "Buscar";
            btnBuscarEstudiante.UseVisualStyleBackColor = true;
            btnBuscarEstudiante.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(341, 45);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 14;
            label6.Text = "Orden Estudiantes";
            // 
            // lbxEstudiantes
            // 
            lbxEstudiantes.FormattingEnabled = true;
            lbxEstudiantes.ItemHeight = 15;
            lbxEstudiantes.Location = new Point(341, 74);
            lbxEstudiantes.Name = "lbxEstudiantes";
            lbxEstudiantes.Size = new Size(416, 94);
            lbxEstudiantes.TabIndex = 5;
            // 
            // cmbOrdenEstudiantes
            // 
            cmbOrdenEstudiantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenEstudiantes.FormattingEnabled = true;
            cmbOrdenEstudiantes.Location = new Point(450, 37);
            cmbOrdenEstudiantes.Name = "cmbOrdenEstudiantes";
            cmbOrdenEstudiantes.Size = new Size(176, 23);
            cmbOrdenEstudiantes.TabIndex = 13;
            cmbOrdenEstudiantes.SelectedIndexChanged += cmbOrdenEstudiantes_SelectedIndexChanged;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.Location = new Point(260, 45);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(75, 23);
            btnAgregarEstudiante.TabIndex = 4;
            btnAgregarEstudiante.Text = "Agregar";
            btnAgregarEstudiante.UseVisualStyleBackColor = true;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.Location = new Point(78, 45);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(176, 23);
            txtNombreAgregar.TabIndex = 3;
            // 
            // txtMatriculaAgregar
            // 
            txtMatriculaAgregar.Location = new Point(78, 20);
            txtMatriculaAgregar.Name = "txtMatriculaAgregar";
            txtMatriculaAgregar.Size = new Size(176, 23);
            txtMatriculaAgregar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 53);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Matricula";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(523, 161);
            label9.Name = "label9";
            label9.Size = new Size(171, 30);
            label9.TabIndex = 19;
            label9.Text = "*Haga doble click en la materia\r\npara editar la calificaciòn";
            // 
            // btnAgregarMateriaEstudiante
            // 
            btnAgregarMateriaEstudiante.Location = new Point(598, 135);
            btnAgregarMateriaEstudiante.Name = "btnAgregarMateriaEstudiante";
            btnAgregarMateriaEstudiante.Size = new Size(75, 23);
            btnAgregarMateriaEstudiante.TabIndex = 18;
            btnAgregarMateriaEstudiante.Text = "Agregar";
            btnAgregarMateriaEstudiante.UseVisualStyleBackColor = true;
            btnAgregarMateriaEstudiante.Click += btnAgregarMateriaEstudiante_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(353, 127);
            label8.Name = "label8";
            label8.Size = new Size(55, 30);
            label8.TabIndex = 17;
            label8.Text = "Catalogo\r\nMaterias";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(414, 22);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(176, 23);
            txtNombreMateria.TabIndex = 16;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(598, 21);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(96, 54);
            btnAgregarMateria.TabIndex = 15;
            btnAgregarMateria.Text = "Agregar al catalogo de materias";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 30);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 14;
            label7.Text = "Materia";
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(414, 134);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(176, 23);
            cmbMaterias.TabIndex = 13;
            // 
            // btnAgregarTallerEstudiante
            // 
            btnAgregarTallerEstudiante.Location = new Point(259, 134);
            btnAgregarTallerEstudiante.Name = "btnAgregarTallerEstudiante";
            btnAgregarTallerEstudiante.Size = new Size(75, 23);
            btnAgregarTallerEstudiante.TabIndex = 12;
            btnAgregarTallerEstudiante.Text = "Agregar";
            btnAgregarTallerEstudiante.UseVisualStyleBackColor = true;
            btnAgregarTallerEstudiante.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 127);
            label5.Name = "label5";
            label5.Size = new Size(55, 30);
            label5.TabIndex = 11;
            label5.Text = "Catalogo\r\nTalleres";
            // 
            // cmbTalleres
            // 
            cmbTalleres.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTalleres.FormattingEnabled = true;
            cmbTalleres.Location = new Point(77, 134);
            cmbTalleres.Name = "cmbTalleres";
            cmbTalleres.Size = new Size(176, 23);
            cmbTalleres.TabIndex = 10;
            // 
            // lbxTalleresEstudiante
            // 
            lbxTalleresEstudiante.FormattingEnabled = true;
            lbxTalleresEstudiante.ItemHeight = 15;
            lbxTalleresEstudiante.Location = new Point(16, 160);
            lbxTalleresEstudiante.Name = "lbxTalleresEstudiante";
            lbxTalleresEstudiante.Size = new Size(176, 94);
            lbxTalleresEstudiante.TabIndex = 9;
            // 
            // lbxMateriasEstudiante
            // 
            lbxMateriasEstudiante.FormattingEnabled = true;
            lbxMateriasEstudiante.ItemHeight = 15;
            lbxMateriasEstudiante.Location = new Point(353, 160);
            lbxMateriasEstudiante.Name = "lbxMateriasEstudiante";
            lbxMateriasEstudiante.Size = new Size(164, 94);
            lbxMateriasEstudiante.TabIndex = 8;
            lbxMateriasEstudiante.DoubleClick += lbxMateriasEstudiante_DoubleClick;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(79, 52);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(176, 23);
            txtNombreBuscar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 60);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Nombre";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 451);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(lbxEstudiantes);
            tabPage1.Controls.Add(cmbOrdenEstudiantes);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnAgregarEstudiante);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtNombreAgregar);
            tabPage1.Controls.Add(txtMatriculaAgregar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar Estudiante";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblPromedioEstudiante);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(btnAgregarMateriaEstudiante);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(btnBuscarEstudiante);
            tabPage2.Controls.Add(txtNombreMateria);
            tabPage2.Controls.Add(txtMatriculaBuscar);
            tabPage2.Controls.Add(btnAgregarMateria);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtNombreBuscar);
            tabPage2.Controls.Add(cmbMaterias);
            tabPage2.Controls.Add(lbxMateriasEstudiante);
            tabPage2.Controls.Add(btnAgregarTallerEstudiante);
            tabPage2.Controls.Add(lbxTalleresEstudiante);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(cmbTalleres);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar Estudiantes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPromedioEstudiante
            // 
            lblPromedioEstudiante.AutoSize = true;
            lblPromedioEstudiante.Location = new Point(430, 275);
            lblPromedioEstudiante.Name = "lblPromedioEstudiante";
            lblPromedioEstudiante.Size = new Size(127, 15);
            lblPromedioEstudiante.TabIndex = 21;
            lblPromedioEstudiante.Text = "lblPromedioEstudiante";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(362, 275);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 20;
            label10.Text = "Promedio:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lbxDiferenciaTalleres);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(lbxInterseccionTalleres);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(lbxUnionTalleres);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Revisión Talleres";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbxDiferenciaTalleres
            // 
            lbxDiferenciaTalleres.FormattingEnabled = true;
            lbxDiferenciaTalleres.ItemHeight = 15;
            lbxDiferenciaTalleres.Location = new Point(531, 63);
            lbxDiferenciaTalleres.Name = "lbxDiferenciaTalleres";
            lbxDiferenciaTalleres.Size = new Size(176, 94);
            lbxDiferenciaTalleres.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(531, 35);
            label13.Name = "label13";
            label13.Size = new Size(60, 15);
            label13.TabIndex = 13;
            label13.Text = "Diferencia";
            // 
            // lbxInterseccionTalleres
            // 
            lbxInterseccionTalleres.FormattingEnabled = true;
            lbxInterseccionTalleres.ItemHeight = 15;
            lbxInterseccionTalleres.Location = new Point(288, 63);
            lbxInterseccionTalleres.Name = "lbxInterseccionTalleres";
            lbxInterseccionTalleres.Size = new Size(176, 94);
            lbxInterseccionTalleres.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(288, 35);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 11;
            label12.Text = "Interseccion";
            // 
            // lbxUnionTalleres
            // 
            lbxUnionTalleres.FormattingEnabled = true;
            lbxUnionTalleres.ItemHeight = 15;
            lbxUnionTalleres.Location = new Point(35, 63);
            lbxUnionTalleres.Name = "lbxUnionTalleres";
            lbxUnionTalleres.Size = new Size(176, 94);
            lbxUnionTalleres.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 35);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 0;
            label11.Text = "Union";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 483);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMatriculaBuscar;
        private Button btnBuscarEstudiante;
        private ListBox lbxEstudiantes;
        private Button btnAgregarEstudiante;
        private TextBox txtNombreAgregar;
        private TextBox txtMatriculaAgregar;
        private Label label3;
        private Label label2;
        private TextBox txtNombreBuscar;
        private Label label4;
        private ListBox lbxTalleresEstudiante;
        private ListBox lbxMateriasEstudiante;
        private Button btnAgregarTallerEstudiante;
        private Label label5;
        private ComboBox cmbTalleres;
        private Label label6;
        private ComboBox cmbOrdenEstudiantes;
        private Button btnAgregarMateria;
        private Label label7;
        private ComboBox cmbMaterias;
        private TextBox txtNombreMateria;
        private Label label8;
        private Button btnAgregarMateriaEstudiante;
        private Label label9;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblPromedioEstudiante;
        private Label label10;
        private TabPage tabPage3;
        private ListBox lbxDiferenciaTalleres;
        private Label label13;
        private ListBox lbxInterseccionTalleres;
        private Label label12;
        private ListBox lbxUnionTalleres;
        private Label label11;
    }
}
