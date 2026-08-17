namespace Practico1
{
    partial class Formulario1
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
            this.BGuardar = new System.Windows.Forms.Button();
            this.BEliminar = new System.Windows.Forms.Button();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TXNombre = new System.Windows.Forms.TextBox();
            this.TXApellido = new System.Windows.Forms.TextBox();
            this.TXConcatenado = new System.Windows.Forms.TextBox();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGuardar
            // 
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.BGuardar.Location = new System.Drawing.Point(85, 134);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 0;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BEliminar
            // 
            this.BEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BEliminar.Location = new System.Drawing.Point(166, 134);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 1;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = false;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(35, 45);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre";
            this.LNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(35, 74);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido";
            this.LApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXNombre
            // 
            this.TXNombre.Location = new System.Drawing.Point(85, 42);
            this.TXNombre.Name = "TXNombre";
            this.TXNombre.Size = new System.Drawing.Size(156, 20);
            this.TXNombre.TabIndex = 4;
            // 
            // TXApellido
            // 
            this.TXApellido.Location = new System.Drawing.Point(85, 71);
            this.TXApellido.Name = "TXApellido";
            this.TXApellido.Size = new System.Drawing.Size(156, 20);
            this.TXApellido.TabIndex = 5;
            // 
            // TXConcatenado
            // 
            this.TXConcatenado.Location = new System.Drawing.Point(268, 45);
            this.TXConcatenado.Multiline = true;
            this.TXConcatenado.Name = "TXConcatenado";
            this.TXConcatenado.Size = new System.Drawing.Size(204, 112);
            this.TXConcatenado.TabIndex = 6;
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSalir.ForeColor = System.Drawing.Color.DarkRed;
            this.BSalir.Location = new System.Drawing.Point(397, 226);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 7;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.TXConcatenado);
            this.Controls.Add(this.TXApellido);
            this.Controls.Add(this.TXNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi primer forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TXNombre;
        private System.Windows.Forms.TextBox TXApellido;
        private System.Windows.Forms.TextBox TXConcatenado;
        private System.Windows.Forms.Button BSalir;
    }
}

