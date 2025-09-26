namespace prySilvaMenendez_SP3_EjercicioPorResolver_24._09
{
    partial class frmGestionRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionRepuestos));
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lstMarcas = new System.Windows.Forms.ComboBox();
            this.btnImportado = new System.Windows.Forms.RadioButton();
            this.btnNacional = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtCantidad);
            this.mrcDatos.Controls.Add(this.lblSigno);
            this.mrcDatos.Controls.Add(this.txtPrecio);
            this.mrcDatos.Controls.Add(this.lstMarcas);
            this.mrcDatos.Controls.Add(this.btnImportado);
            this.mrcDatos.Controls.Add(this.btnNacional);
            this.mrcDatos.Controls.Add(this.txtDescripcion);
            this.mrcDatos.Controls.Add(this.lblDescripcion);
            this.mrcDatos.Controls.Add(this.lblPrecio);
            this.mrcDatos.Controls.Add(this.lblNumero);
            this.mrcDatos.Controls.Add(this.lblOrigen);
            this.mrcDatos.Controls.Add(this.lblMarca);
            this.mrcDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcDatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mrcDatos.Location = new System.Drawing.Point(27, 68);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(534, 222);
            this.mrcDatos.TabIndex = 0;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos a Ingresar";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(171, 142);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Mask = "999999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 21);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.ValidatingType = typeof(int);
            this.txtCantidad.Click += new System.EventHandler(this.txtCantidad_Click);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(125, 184);
            this.lblSigno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(15, 15);
            this.lblSigno.TabIndex = 7;
            this.lblSigno.Text = "$";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(143, 180);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(97, 21);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // lstMarcas
            // 
            this.lstMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMarcas.FormattingEnabled = true;
            this.lstMarcas.Items.AddRange(new object[] {
            "P ( Peugeot )",
            "F ( Fiat )",
            "R ( Renault )"});
            this.lstMarcas.Location = new System.Drawing.Point(143, 36);
            this.lstMarcas.Name = "lstMarcas";
            this.lstMarcas.Size = new System.Drawing.Size(97, 23);
            this.lstMarcas.TabIndex = 0;
            // 
            // btnImportado
            // 
            this.btnImportado.AutoSize = true;
            this.btnImportado.Location = new System.Drawing.Point(143, 106);
            this.btnImportado.Name = "btnImportado";
            this.btnImportado.Size = new System.Drawing.Size(81, 19);
            this.btnImportado.TabIndex = 2;
            this.btnImportado.TabStop = true;
            this.btnImportado.Text = "Importado";
            this.btnImportado.UseVisualStyleBackColor = true;
            // 
            // btnNacional
            // 
            this.btnNacional.AutoSize = true;
            this.btnNacional.Location = new System.Drawing.Point(143, 72);
            this.btnNacional.Name = "btnNacional";
            this.btnNacional.Size = new System.Drawing.Size(74, 19);
            this.btnNacional.TabIndex = 1;
            this.btnNacional.TabStop = true;
            this.btnNacional.Text = "Nacional";
            this.btnNacional.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDescripcion.Location = new System.Drawing.Point(335, 63);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(179, 140);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.Text = "";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(349, 36);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(148, 15);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion del Repuesto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(57, 184);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 146);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(128, 15);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero del Repuesto";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(57, 90);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(44, 15);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(58, 41);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.Location = new System.Drawing.Point(113, 20);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(357, 32);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Ingrese los Datos del Repuesto";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(362, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 35);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(119, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmGestionRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(583, 351);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.mrcDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestionRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Repuestos";
            this.Load += new System.EventHandler(this.frmGestionRepuestos_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.RadioButton btnImportado;
        private System.Windows.Forms.RadioButton btnNacional;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.ComboBox lstMarcas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
    }
}

