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
    public partial class FacturaClienteExiste : Form
    {
        int precioAlquilerDia = 10;
        int total;
        public FacturaClienteExiste()
        {
            InitializeComponent();
        }

        private void numericDiasAlquiler_ValueChanged(object sender, EventArgs e)
        {
            int dias = Convert.ToInt32(numericDiasAlquiler.Value);
            total = dias * precioAlquilerDia;

            txtTotal.Text = total.ToString();
        }

        private void btnEnviarFact_Click(object sender, EventArgs e)
        {
            FacturaAgregar();
            ActuaId();
        }

        public void FacturaAgregar()
        {
            if (!String.IsNullOrEmpty(txtIdCliente.Text)&& !String.IsNullOrEmpty(txtPlacas.Text) && !String.IsNullOrEmpty(dateTimeFecheAlqui.Text)) 
            {
                ClienteClas cliente = new ClienteClas();
                FacturaClas factura = new FacturaClas();

                int id = Convert.ToInt32(txtIdCliente.Text);
                cliente.SId = id;
                cliente.SNombre = txtNombre.Text;
                cliente.BuscarCliente();
                if (cliente.existe)
                {
                    factura.SId_cliente = id;
                    factura.SId_factura = Convert.ToInt32(txtNumeroFactura.Text);
                    factura.SId_auto = txtPlacas.Text;
                    factura.SFecha = dateTimeFecheAlqui.Text;
                    factura.STotal = total;

                    factura.RegistrarFactura();
                    factura.ActualizarEstadoAuto();

                    txtIdCliente.Text = "";
                    txtPlacas.Text = "";
                    numericDiasAlquiler.Value = 0;

                    FillAuto();
                    txtPlacas.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "ERROR");
            }
        }

        public void ActuaId()
        {
            FacturaClas factura = new FacturaClas();
            factura.UltimoId();
            txtNumeroFactura.Text = (factura.SId_factura + 1).ToString();
        }

        private void FacturaClienteExiste_Load(object sender, EventArgs e)
        {
            ActuaId();
            FillAuto();
            dateTimeFecheAlqui.Value = DateTime.Now;
        }

        public void FillAuto()
        {
            FacturaClas facturaClas = new FacturaClas();
            List<string> Carros = new List<string>(facturaClas.ListarAutoLibre());
            foreach (string Carro in Carros)
            {
                txtPlacas.Items.Add(Carro);
            }
        }
    }
}
