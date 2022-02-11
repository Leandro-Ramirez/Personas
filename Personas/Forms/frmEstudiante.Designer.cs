namespace Forms
{
    partial class frmEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUniversidad = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblCUM = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblHorasT = new System.Windows.Forms.Label();
            this.lblHoraC = new System.Windows.Forms.Label();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtCUM = new System.Windows.Forms.TextBox();
            this.txtProyecto = new System.Windows.Forms.TextBox();
            this.txtHoraT = new System.Windows.Forms.TextBox();
            this.txtHoraC = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbUniversidad = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(355, 14);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(100, 16);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Nº de Carnet:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(321, 42);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(134, 16);
            this.lblNivel.TabIndex = 1;
            this.lblNivel.Text = "Nivel de Estudios:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Genero:";
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.AutoSize = true;
            this.lblUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniversidad.Location = new System.Drawing.Point(620, 10);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(87, 15);
            this.lblUniversidad.TabIndex = 4;
            this.lblUniversidad.Text = "Universidad:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(643, 40);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(64, 16);
            this.lblCarrera.TabIndex = 5;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.Location = new System.Drawing.Point(573, 70);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(134, 16);
            this.lblMaterias.TabIndex = 6;
            this.lblMaterias.Text = "Materias Inscritas:";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(654, 100);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(53, 16);
            this.lblNotas.TabIndex = 7;
            this.lblNotas.Text = "Notas:";
            // 
            // lblCUM
            // 
            this.lblCUM.AutoSize = true;
            this.lblCUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUM.Location = new System.Drawing.Point(662, 128);
            this.lblCUM.Name = "lblCUM";
            this.lblCUM.Size = new System.Drawing.Size(45, 16);
            this.lblCUM.TabIndex = 8;
            this.lblCUM.Text = "CUM:";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyecto.Location = new System.Drawing.Point(892, 14);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(161, 16);
            this.lblProyecto.TabIndex = 9;
            this.lblProyecto.Text = "Nombre Del Proyecto:";
            // 
            // lblHorasT
            // 
            this.lblHorasT.AutoSize = true;
            this.lblHorasT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasT.Location = new System.Drawing.Point(942, 42);
            this.lblHorasT.Name = "lblHorasT";
            this.lblHorasT.Size = new System.Drawing.Size(111, 16);
            this.lblHorasT.TabIndex = 10;
            this.lblHorasT.Text = "Horas Totales:";
            // 
            // lblHoraC
            // 
            this.lblHoraC.AutoSize = true;
            this.lblHoraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraC.Location = new System.Drawing.Point(903, 70);
            this.lblHoraC.Name = "lblHoraC";
            this.lblHoraC.Size = new System.Drawing.Size(150, 16);
            this.lblHoraC.TabIndex = 11;
            this.lblHoraC.Text = "Horas Completadas:";
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Location = new System.Drawing.Point(12, 158);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(1160, 291);
            this.dgvPersona.TabIndex = 12;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(461, 11);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(100, 22);
            this.txtCarnet.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(88, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Avanzado",
            "Experto",
            "Profesional"});
            this.cmbNivel.Location = new System.Drawing.Point(461, 39);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(100, 24);
            this.cmbNivel.TabIndex = 17;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "IngenieriaComputacion",
            "IngenieriaElectrica",
            "IngenieriaIndustrial",
            "IngenieriaMecanica",
            "IngenieriaQuimica"});
            this.cmbCarrera.Location = new System.Drawing.Point(713, 37);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(165, 24);
            this.cmbCarrera.TabIndex = 18;
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Items.AddRange(new object[] {
            "AlgebraLineal",
            "Calculo",
            "Contabilidad",
            "Filosofia",
            "Ingles",
            "Programacion",
            "RedaccionTecnica",
            "Sociologia"});
            this.cmbMaterias.Location = new System.Drawing.Point(713, 67);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(140, 24);
            this.cmbMaterias.TabIndex = 19;
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(713, 97);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(100, 22);
            this.txtNotas.TabIndex = 20;
            // 
            // txtCUM
            // 
            this.txtCUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUM.Location = new System.Drawing.Point(713, 125);
            this.txtCUM.Name = "txtCUM";
            this.txtCUM.Size = new System.Drawing.Size(100, 22);
            this.txtCUM.TabIndex = 21;
            // 
            // txtProyecto
            // 
            this.txtProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProyecto.Location = new System.Drawing.Point(1059, 11);
            this.txtProyecto.Name = "txtProyecto";
            this.txtProyecto.Size = new System.Drawing.Size(100, 22);
            this.txtProyecto.TabIndex = 22;
            // 
            // txtHoraT
            // 
            this.txtHoraT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraT.Location = new System.Drawing.Point(1059, 39);
            this.txtHoraT.Name = "txtHoraT";
            this.txtHoraT.Size = new System.Drawing.Size(100, 22);
            this.txtHoraT.TabIndex = 23;
            // 
            // txtHoraC
            // 
            this.txtHoraC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraC.Location = new System.Drawing.Point(1059, 67);
            this.txtHoraC.Name = "txtHoraC";
            this.txtHoraC.Size = new System.Drawing.Size(100, 22);
            this.txtHoraC.TabIndex = 24;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Green;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 122);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrar.Location = new System.Drawing.Point(118, 122);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 30);
            this.btnMostrar.TabIndex = 26;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "HelicopteroApacheDeCombate"});
            this.cmbGenero.Location = new System.Drawing.Point(88, 67);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(220, 24);
            this.cmbGenero.TabIndex = 27;
            // 
            // cmbUniversidad
            // 
            this.cmbUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUniversidad.FormattingEnabled = true;
            this.cmbUniversidad.Items.AddRange(new object[] {
            "UCA",
            "UNAN",
            "UNI"});
            this.cmbUniversidad.Location = new System.Drawing.Point(713, 7);
            this.cmbUniversidad.Name = "cmbUniversidad";
            this.cmbUniversidad.Size = new System.Drawing.Size(75, 24);
            this.cmbUniversidad.TabIndex = 28;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(224, 121);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbUniversidad);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtHoraC);
            this.Controls.Add(this.txtHoraT);
            this.Controls.Add(this.txtProyecto);
            this.Controls.Add(this.txtCUM);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.cmbMaterias);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.dgvPersona);
            this.Controls.Add(this.lblHoraC);
            this.Controls.Add(this.lblHorasT);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.lblCUM);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblCarnet);
            this.Name = "frmEstudiante";
            this.Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUniversidad;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblCUM;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblHorasT;
        private System.Windows.Forms.Label lblHoraC;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtCUM;
        private System.Windows.Forms.TextBox txtProyecto;
        private System.Windows.Forms.TextBox txtHoraT;
        private System.Windows.Forms.TextBox txtHoraC;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbUniversidad;
        private System.Windows.Forms.Button btnSalir;
    }
}

