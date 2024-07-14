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
    public partial class FacturaOpciones : Form
    {
        int precioAlquilerDia = 10;
        int totalNue;
        int totalBD;
        private void FillGrid()
        {
            try
            {
                FacturaClas Facturas = new FacturaClas();
                dataGridFacturas.DataSource = Facturas.ListarFacturas();
            }
            catch (Exception) { MessageBox.Show("Error en la Conexion a la Base de datos", "ERROR"); }
        }
        public FacturaOpciones()
        {
            InitializeComponent();
           FillGrid();
            labelOpcion.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pantallaPrin pantallaPrin = new pantallaPrin();
            pantallaPrin.Show();
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FacturaClas Factura = new FacturaClas();
            Factura.SId_factura = Convert.ToInt32(numericIdElim.Value);
            Factura.EliminarFactura();
            FillGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FacturaClas Buscar = new FacturaClas();
            if (Convert.ToInt32(numericBuscar.Value) != 0) 
            {
                Buscar.SId_factura = Convert.ToInt32(numericBuscar.Value);
                Buscar.BuscarFactura();
                if (Buscar.existeF)
                {
                    txtNumeroFactura.Text = Buscar.SId_factura.ToString();
                    txtIdCliente.Text = Buscar.SId_cliente.ToString();
                    txtPlacas.Text = Buscar.SId_auto;
                    txtFecha.Text = Buscar.SFecha;
                    txtTotal.Text = Buscar.STotal.ToString();
                    totalBD = Buscar.STotal;
                    panelBuscar.Visible = false;
                    paneActualizar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Factura no encontrado", "Error de busqueda", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Llene el campo ID", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void comboBoxOpcione_SelectionChangeCommitted(object sender, EventArgs e)
        {
            labelOpcion.Visible = false;
            string Seleccion = comboBoxOpcione.SelectedItem.ToString();
            switch (Seleccion)
            {
                case "Eliminar":
                    panelEliminar.Visible = true;
                    panelBuscar.Visible = false;
                    paneActualizar.Visible = false;
                    break;
                case "Modificar Factura":
                    panelBuscar.Visible = true;
                    panelEliminar.Visible=false;
                    paneActualizar.Visible = false;
                    break;
                default: 
                    break;
            }
        }

        private void numericDiasAlquiler_ValueChanged_1(object sender, EventArgs e)
        {
            int dias = Convert.ToInt32(numericDiasAlquiler.Value);
            int precioBD = Convert.ToInt32(txtTotal.Text);
            int total = dias * precioAlquilerDia;
            int TotalAnte = Convert.ToInt32(txtTotal.Text);
            if (total > TotalAnte)
            {
                totalNue = precioBD + total;
                txtTotal.Text = totalNue.ToString();
            }
            else
            {
                totalNue = totalBD + total;
                txtTotal.Text = totalNue.ToString();
            }

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            FacturaClas factura = new FacturaClas();
            factura.SId_factura = Convert.ToInt32(txtNumeroFactura.Text);
            factura.STotal = Convert.ToInt32(txtTotal.Text);
            factura.ActualizarFactura();
            FillGrid();
        }
    }
}
