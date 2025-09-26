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
        int indice = 0;
        struct Repuesto
        {
            public char marca;
            public char origen;  
            public int numeroRepuesto;
            public float precio;
            public string descripcion;
        }
        Repuesto[] vecRepuestos = new Repuesto[100];
        public frmGestionRepuestos()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lstMarcas.Text) ||
                (btnImportado.Checked == false && btnNacional.Checked == false) ||
                !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad == 0 ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Los Datos están Incompletos, Por Favor Complete Todos los Campos");
            }
            else
            {
                vecRepuestos[indice].marca = lstMarcas.Text[0];
                vecRepuestos[indice].origen = btnImportado.Checked ? 'I' : 'N';
                vecRepuestos[indice].precio = float.Parse(txtPrecio.Text.Replace(',', '.'));
                vecRepuestos[indice].numeroRepuesto = int.Parse(txtCantidad.Text);
                vecRepuestos[indice].descripcion = txtDescripcion.Text;
                indice++;
                MessageBox.Show("Datos Enviados Correctamente");
                txtCantidad.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                lstMarcas.SelectedIndex = -1;
                btnImportado.Checked = false;
                btnNacional.Checked = false;
                lstMarcas.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (!texto.Contains(","))
            {
                MessageBox.Show("Debe Ingresar el Número con Decimales");
                txtPrecio.Focus();
                return;
            }
            int indexDecimal = texto.IndexOf(',');
            if (indexDecimal == texto.Length - 1 || texto.Length - indexDecimal - 1 < 2)
            {
                MessageBox.Show("Debe Ingresar el Número con Dos Decimales");
                txtPrecio.Focus();
                return;
            }
            if (!float.TryParse(texto, out float valor))
            {
                MessageBox.Show("Debe Ingresar un Número Válido (Decimal)");
                txtPrecio.Focus();
            }
        }
        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Select(0, 0);
        }
        private void txtCantidad_Click(object sender, EventArgs e)
        {
            txtCantidad.Select(0, 0);
        }

        private void frmGestionRepuestos_Load(object sender, EventArgs e)
        {

        }
    }
}
