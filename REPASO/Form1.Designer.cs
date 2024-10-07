namespace REPASO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMostrar = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBanco = new System.Windows.Forms.RadioButton();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMostrar);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnCerrar);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.tbDireccion);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbMostrar
            // 
            this.cbMostrar.FormattingEnabled = true;
            this.cbMostrar.Location = new System.Drawing.Point(25, 240);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(121, 21);
            this.cbMostrar.TabIndex = 7;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(168, 238);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(168, 137);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(91, 49);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar Presupuesto";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(25, 137);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(83, 49);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Presupuesto";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(107, 77);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(107, 35);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIRECCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBanco);
            this.groupBox2.Controls.Add(this.rbMesa);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.tbCodigo);
            this.groupBox2.Controls.Add(this.tbLargo);
            this.groupBox2.Controls.Add(this.tbPrecio);
            this.groupBox2.Controls.Add(this.tbGrosor);
            this.groupBox2.Controls.Add(this.tbAncho);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(352, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbBanco
            // 
            this.rbBanco.AutoSize = true;
            this.rbBanco.Location = new System.Drawing.Point(22, 177);
            this.rbBanco.Name = "rbBanco";
            this.rbBanco.Size = new System.Drawing.Size(62, 17);
            this.rbBanco.TabIndex = 12;
            this.rbBanco.TabStop = true;
            this.rbBanco.Text = "BANCO";
            this.rbBanco.UseVisualStyleBackColor = true;
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(22, 154);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(55, 17);
            this.rbMesa.TabIndex = 11;
            this.rbMesa.TabStop = true;
            this.rbMesa.Text = "MESA";
            this.rbMesa.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(155, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(72, 114);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 10;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(210, 40);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(100, 20);
            this.tbLargo.TabIndex = 9;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(63, 40);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 8;
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(210, 77);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(100, 20);
            this.tbGrosor.TabIndex = 7;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(63, 77);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(100, 20);
            this.tbAncho.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Grosor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Largo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbMostrar;
        private System.Windows.Forms.RadioButton rbBanco;
        private System.Windows.Forms.RadioButton rbMesa;
    }
}

