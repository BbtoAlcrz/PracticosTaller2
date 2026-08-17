using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class FormularioPequenio : Form
    {
        public FormularioPequenio()
        {
            InitializeComponent();
        }

        private bool VerificarVacio(string campo)
        {
            return string.IsNullOrWhiteSpace(campo);
        }

        private bool EsCampoVacio()
        {
            return ((VerificarVacio(TNombre.Text)) || VerificarVacio(TApellido.Text) || VerificarVacio(TDni.Text));
        }

        private bool EsTextoValido(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (EsCampoVacio())
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(TDni.Text, out _) || TDni.Text.Length < 7)
            {
                MessageBox.Show("El DNI debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!EsTextoValido(TNombre.Text) || !EsTextoValido(TApellido.Text))
            {
                MessageBox.Show("El nombre y/o apellido deben ser cadenas de texto válidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ask = MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            
            if(ask == DialogResult.Yes)
            {
                MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se insertó Correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = $"{TNombre.Text} {TApellido.Text}";
            }
                    
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (EsCampoVacio())
            {
                MessageBox.Show("No hay nada para eliminar", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ask = MessageBox.Show($"Está a punto de eliminar al cliente: {TNombre.Text} {TApellido.Text}", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (ask == DialogResult.Yes)
            {
                MessageBox.Show($"El Cliente: {TNombre.Text} {TApellido.Text} se eliminó Correctamente.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                LModificar.Text = "";
            }
        }
    }
}
