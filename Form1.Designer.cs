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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(9, 28);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 0;
            label1.Text = "Matrícula";
            // 
            // txtMatriculaBuscar
            // 
            txtMatriculaBuscar.Location = new Point(93, 26);
            txtMatriculaBuscar.Name = "txtMatriculaBuscar";
            txtMatriculaBuscar.Size = new Size(176, 23);
            txtMatriculaBuscar.TabIndex = 1;
            // 
            // btnBuscarEstudiante
            // 
            btnBuscarEstudiante.BackColor = Color.LightCyan;
            btnBuscarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEstudiante.Location = new Point(291, 25);
            btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            btnBuscarEstudiante.Size = new Size(95, 34);
            btnBuscarEstudiante.TabIndex = 2;
            btnBuscarEstudiante.Text = "Buscar";
            btnBuscarEstudiante.UseVisualStyleBackColor = false;
            btnBuscarEstudiante.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(354, 39);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 14;
            label6.Text = "Orden Estudiantes";
            // 
            // lbxEstudiantes
            // 
            lbxEstudiantes.BackColor = SystemColors.Menu;
            lbxEstudiantes.FormattingEnabled = true;
            lbxEstudiantes.ItemHeight = 15;
            lbxEstudiantes.Location = new Point(354, 89);
            lbxEstudiantes.Name = "lbxEstudiantes";
            lbxEstudiantes.Size = new Size(416, 94);
            lbxEstudiantes.TabIndex = 5;
            // 
            // cmbOrdenEstudiantes
            // 
            cmbOrdenEstudiantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenEstudiantes.FormattingEnabled = true;
            cmbOrdenEstudiantes.Location = new Point(503, 41);
            cmbOrdenEstudiantes.Name = "cmbOrdenEstudiantes";
            cmbOrdenEstudiantes.Size = new Size(176, 23);
            cmbOrdenEstudiantes.TabIndex = 13;
            cmbOrdenEstudiantes.SelectedIndexChanged += cmbOrdenEstudiantes_SelectedIndexChanged;
            // 
            // btnAgregarEstudiante
            // 
            btnAgregarEstudiante.BackColor = Color.LightCyan;
            btnAgregarEstudiante.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEstudiante.Location = new Point(131, 122);
            btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            btnAgregarEstudiante.Size = new Size(94, 33);
            btnAgregarEstudiante.TabIndex = 4;
            btnAgregarEstudiante.Text = "Agregar";
            btnAgregarEstudiante.UseVisualStyleBackColor = false;
            btnAgregarEstudiante.Click += btnAgregarEstudiante_Click;
            // 
            // txtNombreAgregar
            // 
            txtNombreAgregar.Location = new Point(99, 76);
            txtNombreAgregar.Name = "txtNombreAgregar";
            txtNombreAgregar.Size = new Size(176, 23);
            txtNombreAgregar.TabIndex = 3;
            // 
            // txtMatriculaAgregar
            // 
            txtMatriculaAgregar.Location = new Point(99, 30);
            txtMatriculaAgregar.Name = "txtMatriculaAgregar";
            txtMatriculaAgregar.Size = new Size(176, 23);
            txtMatriculaAgregar.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 70);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 28);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 0;
            label2.Text = "Matrícula";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightGray;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(578, 224);
            label9.Name = "label9";
            label9.Size = new Size(207, 38);
            label9.TabIndex = 19;
            label9.Text = "*Haga doble click en la materia\r\npara editar la calificaciòn";
            // 
            // btnAgregarMateriaEstudiante
            // 
            btnAgregarMateriaEstudiante.BackColor = Color.LightCyan;
            btnAgregarMateriaEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarMateriaEstudiante.Location = new Point(689, 168);
            btnAgregarMateriaEstudiante.Name = "btnAgregarMateriaEstudiante";
            btnAgregarMateriaEstudiante.Size = new Size(81, 32);
            btnAgregarMateriaEstudiante.TabIndex = 18;
            btnAgregarMateriaEstudiante.Text = "Agregar";
            btnAgregarMateriaEstudiante.UseVisualStyleBackColor = false;
            btnAgregarMateriaEstudiante.Click += btnAgregarMateriaEstudiante_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(411, 168);
            label8.Name = "label8";
            label8.Size = new Size(76, 42);
            label8.TabIndex = 17;
            label8.Text = "Catálogo\r\nMaterias";
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(493, 28);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(176, 23);
            txtNombreMateria.TabIndex = 16;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.BackColor = Color.LightCyan;
            btnAgregarMateria.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarMateria.Location = new Point(689, 24);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(96, 94);
            btnAgregarMateria.TabIndex = 15;
            btnAgregarMateria.Text = "Agregar al cátalogo de materias";
            btnAgregarMateria.UseVisualStyleBackColor = false;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(421, 28);
            label7.Name = "label7";
            label7.Size = new Size(66, 21);
            label7.TabIndex = 14;
            label7.Text = "Materia";
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(493, 173);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(176, 23);
            cmbMaterias.TabIndex = 13;
            // 
            // btnAgregarTallerEstudiante
            // 
            btnAgregarTallerEstudiante.BackColor = Color.LightCyan;
            btnAgregarTallerEstudiante.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarTallerEstudiante.Location = new Point(284, 168);
            btnAgregarTallerEstudiante.Name = "btnAgregarTallerEstudiante";
            btnAgregarTallerEstudiante.Size = new Size(92, 32);
            btnAgregarTallerEstudiante.TabIndex = 12;
            btnAgregarTallerEstudiante.Text = "Agregar";
            btnAgregarTallerEstudiante.UseVisualStyleBackColor = false;
            btnAgregarTallerEstudiante.Click += button1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 168);
            label5.Name = "label5";
            label5.Size = new Size(76, 42);
            label5.TabIndex = 11;
            label5.Text = "Catálogo\r\nTalleres";
            // 
            // cmbTalleres
            // 
            cmbTalleres.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTalleres.FormattingEnabled = true;
            cmbTalleres.Location = new Point(97, 177);
            cmbTalleres.Name = "cmbTalleres";
            cmbTalleres.Size = new Size(176, 23);
            cmbTalleres.TabIndex = 10;
            // 
            // lbxTalleresEstudiante
            // 
            lbxTalleresEstudiante.BackColor = SystemColors.ControlLight;
            lbxTalleresEstudiante.FormattingEnabled = true;
            lbxTalleresEstudiante.ItemHeight = 15;
            lbxTalleresEstudiante.Location = new Point(16, 224);
            lbxTalleresEstudiante.Name = "lbxTalleresEstudiante";
            lbxTalleresEstudiante.Size = new Size(176, 94);
            lbxTalleresEstudiante.TabIndex = 9;
            // 
            // lbxMateriasEstudiante
            // 
            lbxMateriasEstudiante.BackColor = SystemColors.ControlLight;
            lbxMateriasEstudiante.FormattingEnabled = true;
            lbxMateriasEstudiante.ItemHeight = 15;
            lbxMateriasEstudiante.Location = new Point(411, 224);
            lbxMateriasEstudiante.Name = "lbxMateriasEstudiante";
            lbxMateriasEstudiante.Size = new Size(164, 94);
            lbxMateriasEstudiante.TabIndex = 8;
            lbxMateriasEstudiante.DoubleClick += lbxMateriasEstudiante_DoubleClick;
            // 
            // txtNombreBuscar
            // 
            txtNombreBuscar.Location = new Point(93, 58);
            txtNombreBuscar.Name = "txtNombreBuscar";
            txtNombreBuscar.Size = new Size(176, 23);
            txtNombreBuscar.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(16, 60);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
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
            tabPage1.BackColor = Color.SeaShell;
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
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.SeaShell;
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
            // 
            // lblPromedioEstudiante
            // 
            lblPromedioEstudiante.AutoSize = true;
            lblPromedioEstudiante.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPromedioEstudiante.Location = new Point(479, 348);
            lblPromedioEstudiante.Name = "lblPromedioEstudiante";
            lblPromedioEstudiante.Size = new Size(176, 21);
            lblPromedioEstudiante.TabIndex = 21;
            lblPromedioEstudiante.Text = "lblPromedioEstudiante";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(387, 348);
            label10.Name = "label10";
            label10.Size = new Size(86, 21);
            label10.TabIndex = 20;
            label10.Text = "Promedio:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.SeaShell;
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
            // 
            // lbxDiferenciaTalleres
            // 
            lbxDiferenciaTalleres.BackColor = SystemColors.ControlLight;
            lbxDiferenciaTalleres.FormattingEnabled = true;
            lbxDiferenciaTalleres.ItemHeight = 15;
            lbxDiferenciaTalleres.Location = new Point(531, 84);
            lbxDiferenciaTalleres.Name = "lbxDiferenciaTalleres";
            lbxDiferenciaTalleres.Size = new Size(176, 94);
            lbxDiferenciaTalleres.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Azure;
            label13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label13.Location = new Point(531, 23);
            label13.Name = "label13";
            label13.Size = new Size(100, 25);
            label13.TabIndex = 13;
            label13.Text = "Diferencia";
            // 
            // lbxInterseccionTalleres
            // 
            lbxInterseccionTalleres.BackColor = SystemColors.ControlLight;
            lbxInterseccionTalleres.FormattingEnabled = true;
            lbxInterseccionTalleres.HorizontalScrollbar = true;
            lbxInterseccionTalleres.ItemHeight = 15;
            lbxInterseccionTalleres.Location = new Point(288, 84);
            lbxInterseccionTalleres.Name = "lbxInterseccionTalleres";
            lbxInterseccionTalleres.Size = new Size(176, 94);
            lbxInterseccionTalleres.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.AliceBlue;
            label12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label12.Location = new Point(288, 23);
            label12.Name = "label12";
            label12.Size = new Size(116, 25);
            label12.TabIndex = 11;
            label12.Text = "Intersección";
            // 
            // lbxUnionTalleres
            // 
            lbxUnionTalleres.BackColor = SystemColors.ControlLight;
            lbxUnionTalleres.FormattingEnabled = true;
            lbxUnionTalleres.ItemHeight = 15;
            lbxUnionTalleres.Location = new Point(35, 84);
            lbxUnionTalleres.Name = "lbxUnionTalleres";
            lbxUnionTalleres.Size = new Size(176, 94);
            lbxUnionTalleres.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Azure;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label11.Location = new Point(35, 23);
            label11.Name = "label11";
            label11.Size = new Size(63, 25);
            label11.TabIndex = 0;
            label11.Text = "Unión";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 483);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Gestión Académica";
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
