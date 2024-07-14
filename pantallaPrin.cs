using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class pantallaPrin : Form
    {
        public pantallaPrin()
        {
            InitializeComponent();
        }

        private void cambiarDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logincs logincs = new Logincs();
            logincs.Show();
            this.Close();
        }


        private void facturaConNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaNuevoCliente FacturaNuevo = new FacturaNuevoCliente();
            FacturaNuevo.Show();
        }

        private void facturaConClienteExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaClienteExiste Existe = new FacturaClienteExiste();
            Existe.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrudCliente clientes = new CrudCliente();
            clientes.Show();
            this.Close();
        }

        private void editarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaOpciones facturaOpciones = new FacturaOpciones();
            facturaOpciones.Show();
            this.Close();
        }
    }
}
