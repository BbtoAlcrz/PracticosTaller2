namespace Practico3
{
    partial class PequeñoFormulario
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
            this.LNyA = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LModificar = new System.Windows.Forms.Label();
            this.TDni = new System.Windows.Forms.TextBox();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChMastercard = new System.Windows.Forms.CheckBox();
            this.ChVisa = new System.Windows.Forms.CheckBox();
            this.ChNaranja = new System.Windows.Forms.CheckBox();
            this.LTipoTarjeta = new System.Windows.Forms.Label();
            this.TTelefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNuevoCliente = new System.Windows.Forms.Label();
            this.ChHombre = new System.Windows.Forms.RadioButton();
            this.ChMujer = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.ImgPerfil = new System.Windows.Forms.PictureBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // LNyA
            // 
            this.LNyA.AutoSize = true;
            this.LNyA.CausesValidation = false;
            this.LNyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNyA.Location = new System.Drawing.Point(35, 33);
            this.LNyA.Name = "LNyA";
            this.LNyA.Size = new System.Drawing.Size(140, 16);
            this.LNyA.TabIndex = 0;
            this.LNyA.Text = "Nombre y Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(35, 127);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(56, 16);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(35, 170);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(57, 16);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.CausesValidation = false;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(36, 89);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(30, 16);
            this.LDni.TabIndex = 3;
            this.LDni.Text = "DNI";
            // 
            // LModificar
            // 
            this.LModificar.AutoSize = true;
            this.LModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModificar.ForeColor = System.Drawing.Color.Firebrick;
            this.LModificar.Location = new System.Drawing.Point(181, 33);
            this.LModificar.Name = "LModificar";
            this.LModificar.Size = new System.Drawing.Size(71, 16);
            this.LModificar.TabIndex = 4;
            this.LModificar.Text = "Modificar";
            this.LModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TDni
            // 
            this.TDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDni.Location = new System.Drawing.Point(123, 86);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(171, 22);
            this.TDni.TabIndex = 1;
            // 
            // TNombre
            // 
            this.TNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombre.Location = new System.Drawing.Point(123, 124);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(171, 22);
            this.TNombre.TabIndex = 2;
            // 
            // TApellido
            // 
            this.TApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TApellido.Location = new System.Drawing.Point(123, 167);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(171, 22);
            this.TApellido.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.ChMastercard);
            this.panel1.Controls.Add(this.ChVisa);
            this.panel1.Controls.Add(this.ChNaranja);
            this.panel1.Controls.Add(this.LTipoTarjeta);
            this.panel1.Controls.Add(this.TTelefono);
            this.panel1.Controls.Add(this.LTelefono);
            this.panel1.Controls.Add(this.TApellido);
            this.panel1.Controls.Add(this.TNombre);
            this.panel1.Controls.Add(this.TDni);
            this.panel1.Controls.Add(this.LModificar);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LNyA);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 365);
            this.panel1.TabIndex = 6;
            // 
            // ChMastercard
            // 
            this.ChMastercard.AutoSize = true;
            this.ChMastercard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ChMastercard.Location = new System.Drawing.Point(158, 324);
            this.ChMastercard.Name = "ChMastercard";
            this.ChMastercard.Size = new System.Drawing.Size(96, 20);
            this.ChMastercard.TabIndex = 9;
            this.ChMastercard.Text = "MasterCard";
            this.ChMastercard.UseVisualStyleBackColor = true;
            // 
            // ChVisa
            // 
            this.ChVisa.AutoSize = true;
            this.ChVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ChVisa.Location = new System.Drawing.Point(158, 298);
            this.ChVisa.Name = "ChVisa";
            this.ChVisa.Size = new System.Drawing.Size(53, 20);
            this.ChVisa.TabIndex = 8;
            this.ChVisa.Text = "Visa";
            this.ChVisa.UseVisualStyleBackColor = true;
            // 
            // ChNaranja
            // 
            this.ChNaranja.AutoSize = true;
            this.ChNaranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ChNaranja.Location = new System.Drawing.Point(158, 272);
            this.ChNaranja.Name = "ChNaranja";
            this.ChNaranja.Size = new System.Drawing.Size(74, 20);
            this.ChNaranja.TabIndex = 7;
            this.ChNaranja.Text = "Naranja";
            this.ChNaranja.UseVisualStyleBackColor = true;
            // 
            // LTipoTarjeta
            // 
            this.LTipoTarjeta.AutoSize = true;
            this.LTipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LTipoTarjeta.Location = new System.Drawing.Point(36, 253);
            this.LTipoTarjeta.Name = "LTipoTarjeta";
            this.LTipoTarjeta.Size = new System.Drawing.Size(116, 16);
            this.LTipoTarjeta.TabIndex = 6;
            this.LTipoTarjeta.Text = "Tarjeta de crédito:";
            // 
            // TTelefono
            // 
            this.TTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTelefono.Location = new System.Drawing.Point(123, 210);
            this.TTelefono.Name = "TTelefono";
            this.TTelefono.Size = new System.Drawing.Size(171, 22);
            this.TTelefono.TabIndex = 5;
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(35, 213);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(61, 16);
            this.LTelefono.TabIndex = 5;
            this.LTelefono.Text = "Teléfono";
            // 
            // LNuevoCliente
            // 
            this.LNuevoCliente.AutoSize = true;
            this.LNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNuevoCliente.ForeColor = System.Drawing.Color.SteelBlue;
            this.LNuevoCliente.Location = new System.Drawing.Point(244, 28);
            this.LNuevoCliente.Name = "LNuevoCliente";
            this.LNuevoCliente.Size = new System.Drawing.Size(178, 29);
            this.LNuevoCliente.TabIndex = 12;
            this.LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // ChHombre
            // 
            this.ChHombre.AutoSize = true;
            this.ChHombre.Checked = true;
            this.ChHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ChHombre.Location = new System.Drawing.Point(395, 295);
            this.ChHombre.Name = "ChHombre";
            this.ChHombre.Size = new System.Drawing.Size(74, 20);
            this.ChHombre.TabIndex = 10;
            this.ChHombre.TabStop = true;
            this.ChHombre.Text = "Hombre";
            this.ChHombre.UseVisualStyleBackColor = true;
            this.ChHombre.CheckedChanged += new System.EventHandler(this.ChHombre_CheckedChanged);
            // 
            // ChMujer
            // 
            this.ChMujer.AutoSize = true;
            this.ChMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ChMujer.Location = new System.Drawing.Point(493, 295);
            this.ChMujer.Name = "ChMujer";
            this.ChMujer.Size = new System.Drawing.Size(58, 20);
            this.ChMujer.TabIndex = 11;
            this.ChMujer.Text = "Mujer";
            this.ChMujer.UseVisualStyleBackColor = true;
            this.ChMujer.CheckedChanged += new System.EventHandler(this.ChMujer_CheckedChanged);
            // 
            // BSalir
            // 
            this.BSalir.Image = global::Practico3.Properties.Resources.salir;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(533, 453);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(90, 42);
            this.BSalir.TabIndex = 22;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // ImgPerfil
            // 
            this.ImgPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.ImgPerfil.BackColor = System.Drawing.Color.Transparent;
            this.ImgPerfil.Image = global::Practico3.Properties.Resources.hombre;
            this.ImgPerfil.Location = new System.Drawing.Point(395, 80);
            this.ImgPerfil.Name = "ImgPerfil";
            this.ImgPerfil.Size = new System.Drawing.Size(200, 200);
            this.ImgPerfil.TabIndex = 13;
            this.ImgPerfil.TabStop = false;
            // 
            // BEliminar
            // 
            this.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.Image = global::Practico3.Properties.Resources.eliminar;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(135, 453);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(90, 42);
            this.BEliminar.TabIndex = 21;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BGuardar.Image = global::Practico3.Properties.Resources.guardar;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(262, 453);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BGuardar.Size = new System.Drawing.Size(90, 42);
            this.BGuardar.TabIndex = 20;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // PequeñoFormulario
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 507);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.ChMujer);
            this.Controls.Add(this.ChHombre);
            this.Controls.Add(this.ImgPerfil);
            this.Controls.Add(this.LNuevoCliente);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BGuardar);
            this.Name = "PequeñoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pequeño Formulario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNyA;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LModificar;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TTelefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LTipoTarjeta;
        private System.Windows.Forms.CheckBox ChMastercard;
        private System.Windows.Forms.CheckBox ChVisa;
        private System.Windows.Forms.CheckBox ChNaranja;
        private System.Windows.Forms.Label LNuevoCliente;
        private System.Windows.Forms.PictureBox ImgPerfil;
        private System.Windows.Forms.RadioButton ChHombre;
        private System.Windows.Forms.RadioButton ChMujer;
        private System.Windows.Forms.Button BSalir;
    }
}

