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
                MessageBox.Show("Los Datos estan Incompletos");
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
    }
}
