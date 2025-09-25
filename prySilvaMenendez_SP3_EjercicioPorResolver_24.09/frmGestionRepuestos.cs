using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP3_EjercicioPorResolver_24._09
{
    public partial class frmGestionRepuestos : Form
    {
        public frmGestionRepuestos()
        {
            InitializeComponent();
        }

        private void lstMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrEmpty(lstMarcas.Text) ||
                btnImportado.Checked == false && btnNacional.Checked == false ||
                txtCantidad.Value == 0 ||  
                txtPrecio.Text == "" ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text)
               )
            {
                MessageBox.Show("Los Datos estan Incompletos, Por Favor Complete Todos los Campos");
            }
            else
            {
                MessageBox.Show("Datos Enviados Correctamente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.'
                && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.' || e.KeyChar == ',')
                && (txtPrecio.Text.Contains(".") || 
                txtPrecio.Text.Contains(",")))
            {
                e.Handled = true;
            }
            string Precio = txtPrecio.Text;
            if (Precio.Contains(".") || Precio.Contains(","))
            {
                int indexDecimal = Precio.IndexOf('.') >= 0 ? Precio.IndexOf('.') : Precio.IndexOf(',');

                if (Precio.Length - indexDecimal > 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            string texto = txtPrecio.Text.Replace('.', ',');

            if (!float.TryParse(texto, out float valor))
            {
                MessageBox.Show("Debe Ingresar un Número Válido (Formato Decimal)");
                txtPrecio.Focus();
            }
        }
    }
}
