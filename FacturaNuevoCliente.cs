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
    public partial class FacturaNuevoCliente : Form
    {
        int precioAlquilerDia = 10;
        int total;
        public FacturaNuevoCliente()
        {
            InitializeComponent();
        }

        private void btnEnviarFact_Click(object sender, EventArgs e)
        {
            Clientes();
            FacturaAgregar();
            ActuaId();
        }

        public void numericDiasAlquiler_ValueChanged(object sender, EventArgs e)
        {
            int dias = Convert.ToInt32(numericDiasAlquiler.Value);
            total = dias * precioAlquilerDia;

            txtTotal.Text = total.ToString();
        }

        public void Clientes()
        {
            if (!String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtTelefono.Text) && !String.IsNullOrEmpty(txtClasificacion.Text) && !String.IsNullOrEmpty(txtLicencia.Text) && !String.IsNullOrEmpty(txtTipoLicencia.Text))
            {
                ClienteClas cliente = new ClienteClas();

                cliente.SId = Convert.ToInt32(txtIdCliente.Text);
                cliente.SNombre = txtNombre.Text;
                cliente.STelefono = txtTelefono.Text;
                cliente.SClasificacion = txtClasificacion.Text;
                cliente.SEdad = Convert.ToInt32(numericEdad.Value);
                cliente.SLicencia = txtLicencia.Text;
                cliente.STipoLicencia = txtTipoLicencia.SelectedItem.ToString();
                cliente.SFechaRegistro = dateTimeFecheAlqui.Text;

                cliente.AgregarCliente();

                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtClasificacion.Text = "";
                txtLicencia.Text = "";
                txtTipoLicencia.Text = "";
                numericDiasAlquiler.Value = 0;
                numericEdad.Value = 18;
            }
            else
            {
                MessageBox.Show("Llene todos los datos del cliente", "ERROR");
            }

        }

        public void FacturaAgregar()
        {
            if (!String.IsNullOrEmpty(txtPlacas.Text))
            {
                FacturaClas factura = new FacturaClas();
                factura.SId_factura = Convert.ToInt32(txtNumeroFactura.Text);
                int id = Convert.ToInt32(txtIdCliente.Text);
                factura.SId_cliente = id;
                factura.SId_auto = txtPlacas.SelectedItem.ToString();
                factura.SFecha = dateTimeFecheAlqui.Text;
                factura.STotal = total;

                factura.ActualizarEstadoAuto();
                factura.RegistrarFactura();
                txtPlacas.Items.Clear();
                FillAuto();

            }
            else
            {
                MessageBox.Show("Llene todos los campos", "ERROR");
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            txtNombre.Select();
            ActuaId();
            FillAuto();
            dateTimeFecheAlqui.Value = DateTime.Now;
            numericEdad.Minimum = 18;
        }

        public void ActuaId()
        {
            FacturaClas factura = new FacturaClas();
            ClienteClas cliente = new ClienteClas();
            factura.UltimoId();
            cliente.UltimoIdCliente();
            txtIdCliente.Text = Convert.ToInt32(cliente.SId + 1).ToString();
            txtNumeroFactura.Text = (factura.SId_factura + 1).ToString();
        }

        public void FillAuto() 
        {
            FacturaClas facturaClas = new FacturaClas();
            List <string> Carros = new List<string>(facturaClas.ListarAutoLibre());
            foreach (string Carro in Carros)
            {
                txtPlacas.Items.Add(Carro);
            }
        }
    }
}
