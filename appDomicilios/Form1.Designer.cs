namespace appDomicilios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tbpRegistro = new System.Windows.Forms.TabPage();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.rbMacho = new System.Windows.Forms.RadioButton();
            this.rbHembra = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnConsultarAnimales = new System.Windows.Forms.Button();
            this.tbpConsultar = new System.Windows.Forms.TabPage();
            this.lbmensaje2 = new System.Windows.Forms.Label();
            this.txtBuscarCod = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbMNombre = new System.Windows.Forms.Label();
            this.lbNombreAnimal = new System.Windows.Forms.Label();
            this.tbcGestion.SuspendLayout();
            this.tbpRegistro.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.tbpConsulta.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tbpConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcGestion
            // 
            this.tbcGestion.Controls.Add(this.tbpRegistro);
            this.tbcGestion.Controls.Add(this.tbpConsulta);
            this.tbcGestion.Controls.Add(this.tbpConsultar);
            this.tbcGestion.Location = new System.Drawing.Point(25, 51);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(401, 303);
            this.tbcGestion.TabIndex = 0;
            // 
            // tbpRegistro
            // 
            this.tbpRegistro.Controls.Add(this.pnlRegistro);
            this.tbpRegistro.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistro.Name = "tbpRegistro";
            this.tbpRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistro.Size = new System.Drawing.Size(393, 277);
            this.tbpRegistro.TabIndex = 0;
            this.tbpRegistro.Text = "Registro Animal";
            this.tbpRegistro.UseVisualStyleBackColor = true;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.cbxTipo);
            this.pnlRegistro.Controls.Add(this.rbMacho);
            this.pnlRegistro.Controls.Add(this.rbHembra);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.txtCod);
            this.pnlRegistro.Controls.Add(this.lbTipo);
            this.pnlRegistro.Controls.Add(this.lbGenero);
            this.pnlRegistro.Controls.Add(this.lbNombre);
            this.pnlRegistro.Controls.Add(this.lbCodigo);
            this.pnlRegistro.Controls.Add(this.lbMensaje);
            this.pnlRegistro.Location = new System.Drawing.Point(17, 26);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(336, 231);
            this.pnlRegistro.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(168, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "perro",
            "gato",
            "serpiente",
            "hamster"});
            this.cbxTipo.Location = new System.Drawing.Point(122, 169);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 9;
            // 
            // rbMacho
            // 
            this.rbMacho.AutoSize = true;
            this.rbMacho.Location = new System.Drawing.Point(185, 134);
            this.rbMacho.Name = "rbMacho";
            this.rbMacho.Size = new System.Drawing.Size(58, 17);
            this.rbMacho.TabIndex = 8;
            this.rbMacho.TabStop = true;
            this.rbMacho.Text = "Macho";
            this.rbMacho.UseVisualStyleBackColor = true;
            // 
            // rbHembra
            // 
            this.rbHembra.AutoSize = true;
            this.rbHembra.Location = new System.Drawing.Point(103, 134);
            this.rbHembra.Name = "rbHembra";
            this.rbHembra.Size = new System.Drawing.Size(62, 17);
            this.rbHembra.TabIndex = 7;
            this.rbHembra.TabStop = true;
            this.rbHembra.Text = "Hembra";
            this.rbHembra.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(89, 60);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(154, 20);
            this.txtCod.TabIndex = 5;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(29, 170);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(87, 15);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "Tipo Animal:";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.Location = new System.Drawing.Point(29, 134);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(58, 15);
            this.lbGenero.TabIndex = 3;
            this.lbGenero.Text = "Género:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(26, 100);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 15);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(23, 60);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(60, 15);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Código: ";
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(20, 26);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(205, 16);
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "Ingrese los datos del Animal";
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.pnlConsulta);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsulta.Size = new System.Drawing.Size(393, 277);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consultar Animales";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Controls.Add(this.dgvDatos);
            this.pnlConsulta.Controls.Add(this.btnConsultarAnimales);
            this.pnlConsulta.Location = new System.Drawing.Point(29, 43);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(297, 187);
            this.pnlConsulta.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(22, 55);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(258, 90);
            this.dgvDatos.TabIndex = 1;
            // 
            // btnConsultarAnimales
            // 
            this.btnConsultarAnimales.Location = new System.Drawing.Point(22, 26);
            this.btnConsultarAnimales.Name = "btnConsultarAnimales";
            this.btnConsultarAnimales.Size = new System.Drawing.Size(127, 23);
            this.btnConsultarAnimales.TabIndex = 0;
            this.btnConsultarAnimales.Text = "Consultar Animales";
            this.btnConsultarAnimales.UseVisualStyleBackColor = true;
            this.btnConsultarAnimales.Click += new System.EventHandler(this.btnConsultarAnimales_Click);
            // 
            // tbpConsultar
            // 
            this.tbpConsultar.Controls.Add(this.lbNombreAnimal);
            this.tbpConsultar.Controls.Add(this.lbMNombre);
            this.tbpConsultar.Controls.Add(this.btnBuscar);
            this.tbpConsultar.Controls.Add(this.txtBuscarCod);
            this.tbpConsultar.Controls.Add(this.lbmensaje2);
            this.tbpConsultar.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultar.Name = "tbpConsultar";
            this.tbpConsultar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsultar.Size = new System.Drawing.Size(393, 277);
            this.tbpConsultar.TabIndex = 2;
            this.tbpConsultar.Text = "Consultar";
            this.tbpConsultar.UseVisualStyleBackColor = true;
            // 
            // lbmensaje2
            // 
            this.lbmensaje2.AutoSize = true;
            this.lbmensaje2.Location = new System.Drawing.Point(23, 37);
            this.lbmensaje2.Name = "lbmensaje2";
            this.lbmensaje2.Size = new System.Drawing.Size(178, 13);
            this.lbmensaje2.TabIndex = 1;
            this.lbmensaje2.Text = "Digite el Código del animal a buscar:";
            // 
            // txtBuscarCod
            // 
            this.txtBuscarCod.Location = new System.Drawing.Point(250, 30);
            this.txtBuscarCod.Name = "txtBuscarCod";
            this.txtBuscarCod.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCod.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(275, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbMNombre
            // 
            this.lbMNombre.AutoSize = true;
            this.lbMNombre.Location = new System.Drawing.Point(26, 132);
            this.lbMNombre.Name = "lbMNombre";
            this.lbMNombre.Size = new System.Drawing.Size(47, 13);
            this.lbMNombre.TabIndex = 4;
            this.lbMNombre.Text = "Nombre:";
            // 
            // lbNombreAnimal
            // 
            this.lbNombreAnimal.AutoSize = true;
            this.lbNombreAnimal.Location = new System.Drawing.Point(97, 132);
            this.lbNombreAnimal.Name = "lbNombreAnimal";
            this.lbNombreAnimal.Size = new System.Drawing.Size(10, 13);
            this.lbNombreAnimal.TabIndex = 5;
            this.lbNombreAnimal.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::appDomicilios.Properties.Resources.veterinaria;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.tbcGestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro Animal 1.0";
            this.tbcGestion.ResumeLayout(false);
            this.tbpRegistro.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.tbpConsulta.ResumeLayout(false);
            this.pnlConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tbpConsultar.ResumeLayout(false);
            this.tbpConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.TabPage tbpRegistro;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.RadioButton rbMacho;
        private System.Windows.Forms.RadioButton rbHembra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnConsultarAnimales;
        private System.Windows.Forms.TabPage tbpConsultar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCod;
        private System.Windows.Forms.Label lbmensaje2;
        private System.Windows.Forms.Label lbNombreAnimal;
        private System.Windows.Forms.Label lbMNombre;
    }
}

