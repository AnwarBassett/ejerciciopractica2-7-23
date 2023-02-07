namespace Libro
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPag = new System.Windows.Forms.TextBox();
            this.lbNpag = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chBuscar = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardarEx = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLibroReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca Mi Libro";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(59, 85);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(36, 13);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(100, 82);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(118, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtPag
            // 
            this.txtPag.Location = new System.Drawing.Point(125, 164);
            this.txtPag.Name = "txtPag";
            this.txtPag.Size = new System.Drawing.Size(93, 20);
            this.txtPag.TabIndex = 4;
            // 
            // lbNpag
            // 
            this.lbNpag.AutoSize = true;
            this.lbNpag.Location = new System.Drawing.Point(59, 168);
            this.lbNpag.Name = "lbNpag";
            this.lbNpag.Size = new System.Drawing.Size(60, 13);
            this.lbNpag.TabIndex = 3;
            this.lbNpag.Text = "N° Paginas";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(100, 138);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(118, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(59, 143);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(32, 13);
            this.lbAutor.TabIndex = 5;
            this.lbAutor.Text = "Autor";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(100, 112);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(118, 20);
            this.txtISBN.TabIndex = 8;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Location = new System.Drawing.Point(59, 115);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(35, 13);
            this.lbISBN.TabIndex = 7;
            this.lbISBN.Text = "ISBN:";
            // 
            // Tabla
            // 
            this.Tabla.AllowUserToOrderColumns = true;
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.N_Paginas,
            this.ISBN});
            this.Tabla.Enabled = false;
            this.Tabla.Location = new System.Drawing.Point(233, 105);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(442, 131);
            this.Tabla.TabIndex = 9;
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellContentClick);
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // N_Paginas
            // 
            this.N_Paginas.HeaderText = "N_Paginas";
            this.N_Paginas.Name = "N_Paginas";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(62, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chBuscar
            // 
            this.chBuscar.AutoSize = true;
            this.chBuscar.Location = new System.Drawing.Point(62, 219);
            this.chBuscar.Name = "chBuscar";
            this.chBuscar.Size = new System.Drawing.Size(59, 17);
            this.chBuscar.TabIndex = 11;
            this.chBuscar.Text = "Buscar";
            this.chBuscar.UseVisualStyleBackColor = true;
            this.chBuscar.CheckedChanged += new System.EventHandler(this.chBuscar_CheckedChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(62, 273);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(60, 299);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Limpiar Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Ordenar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardarEx
            // 
            this.btnGuardarEx.Location = new System.Drawing.Point(233, 242);
            this.btnGuardarEx.Name = "btnGuardarEx";
            this.btnGuardarEx.Size = new System.Drawing.Size(117, 24);
            this.btnGuardarEx.TabIndex = 16;
            this.btnGuardarEx.Text = "Guardar Excel";
            this.btnGuardarEx.UseVisualStyleBackColor = true;
            this.btnGuardarEx.Click += new System.EventHandler(this.btnGuardarEx_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Libro Ingresado:";
            // 
            // txtLibroReg
            // 
            this.txtLibroReg.Location = new System.Drawing.Point(323, 79);
            this.txtLibroReg.Name = "txtLibroReg";
            this.txtLibroReg.Size = new System.Drawing.Size(352, 20);
            this.txtLibroReg.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ingrese el Titulo del libro o";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "el codigo de barra";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 350);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLibroReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarEx);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.chBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lbISBN);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.txtPag);
            this.Controls.Add(this.lbNpag);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtPag;
        private System.Windows.Forms.Label lbNpag;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardarEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLibroReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

