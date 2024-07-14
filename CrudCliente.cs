using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallaPrincipal
{
    public partial class CrudCliente : Form
    {
        public CrudCliente()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            try
            {
                ClienteClas ClienteData = new ClienteClas();
                ClienteData.ListarClientes();
                dataTabladeusuario.DataSource = ClienteData.ListarClientes();
            }
            catch (Exception) { MessageBox.Show("Error en la Conexion a la Base de datos", "ERROR"); }
        }

        public void ActuaId()
        {
            ClienteClas cliente = new ClienteClas();
            cliente.UltimoIdCliente();
            txtIdClienteAgre.Text = Convert.ToInt32(cliente.SId + 1).ToString();
        }

        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            labelOpcion.Visible = true;
            FillGrid();
            comboBoxOpcione.Select();
            numericEdadActua.Minimum = 18;
            numericEdadAgre.Minimum = 18;
            dateTimeFechaRegisAgre.Value = DateTime.Now;
            ActuaId();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pantallaPrin pantallaPrin = new pantallaPrin();
            pantallaPrin.Show();
            this.Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtCodigoElim.Text) && !String.IsNullOrEmpty(txtNombreElim.Text))
            {
                int id = Convert.ToInt32(txtCodigoElim.Text);
                ClienteClas clienteElim = new ClienteClas();
                clienteElim.SId = id;
                clienteElim.SNombre = txtNombreElim.Text;
                clienteElim.EliminarCliente();
                FillGrid();
                txtCodigoElim.Text = "";
                txtNombreElim.Text = "";
            }
            else
            {
                MessageBox.Show("Llene los campos Id y Nombre", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnBucar_Click(object sender, EventArgs e)                                                      
        {
            ClienteClas cliente = new ClienteClas();
            if (!String.IsNullOrEmpty(txtIdBus.Text) && !String.IsNullOrEmpty(txtNomBus.Text))
            {
                cliente.SNombre = txtNomBus.Text;
                cliente.SId = Convert.ToInt32(txtIdBus.Text);
                cliente.BuscarCliente();
                if(cliente.existe == true)
                {
                    panelActualizar.Visible=true;
                    panelBusActua.Visible=false;
                    txtIdActua.Text = cliente.SId.ToString();
                    txtNombreActua.Text= cliente.SNombre.ToString();
                    txtTelefonoActua.Text = cliente.STelefono.ToString();
                    txtClasifiActua.Text = cliente.SClasificacion.ToString();
                    numericEdadActua.Value = Convert.ToInt32(cliente.SEdad);
                    txtLicenciaActua.Text = cliente.SLicencia.ToString();
                    txtTipoLicenciaActua.Text = cliente.STipoLicencia.ToString();
                    txtRegistroActua.Text = (cliente.SFechaRegistro);
                    
                    txtIdBus.Text = "";
                    txtNomBus.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Rellene los campos Id y Nombre", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtIdClienteAgre.Text)&& !String.IsNullOrEmpty(txtNombreAgre.Text)&& !String.IsNullOrEmpty(txtTelefonoAgre.Text)&& !String.IsNullOrEmpty(txtClasificacionAgre.Text) && !String.IsNullOrEmpty(numericEdadAgre.Text) && !String.IsNullOrEmpty(txtLicenciaAgre.Text) && !String.IsNullOrEmpty(dateTimeFechaRegisAgre.Text))
            {
                ClienteClas cliente = new ClienteClas();

                cliente.SId = Convert.ToInt32(txtIdClienteAgre.Text);
                cliente.SNombre = txtNombreAgre.Text;
                cliente.STelefono = txtTelefonoAgre.Text;
                cliente.SClasificacion = txtClasificacionAgre.Text;
                cliente.SEdad = Convert.ToInt32(numericEdadAgre.Value);
                cliente.SLicencia = txtLicenciaAgre.Text;
                cliente.STipoLicencia = txtTipoLicenciaAgre.SelectedItem.ToString();
                cliente.SFechaRegistro = dateTimeFechaRegisAgre.Text;
                cliente.AgregarCliente();
                FillGrid();

                txtNombreAgre.Text = "";
                txtTelefonoAgre.Text = "";
                txtClasificacionAgre.Text = "";
                txtLicenciaAgre.Text = "";
                txtTipoLicenciaAgre.Text = "";
                numericEdadAgre.Value = 18;

                ActuaId();
            }
            else
            {
                MessageBox.Show("Llene totos los campos","ERROR");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClienteClas cliente = new ClienteClas();
            cliente.SId = Convert.ToInt32(txtIdActua.Text);
            cliente.SNombre = txtNombreActua.Text;
            cliente.STelefono = txtTelefonoActua.Text;
            cliente.SClasificacion = txtClasifiActua.Text;
            cliente.SEdad = Convert.ToInt32(numericEdadActua.Text);
            cliente.SLicencia = txtTipoLicenciaActua.SelectedItem.ToString();
            cliente.STipoLicencia = txtTipoLicenciaActua.Text;
            cliente.ActualizarCliente();
            FillGrid();

            panelBusActua.Visible = true;
            panelEliminar.Visible = false;
            panelAgregar.Visible = false;
            panelActualizar.Visible = false;
        }

        private void comboBoxOpcione_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string Seleccion = comboBoxOpcione.SelectedItem.ToString();
            labelOpcion.Visible = false;
            switch (Seleccion)
            {
                case "Eliminar Cliente":
                    panelEliminar.Visible = true;
                    panelAgregar.Visible = false;
                    panelActualizar.Visible = false;
                    panelBusActua.Visible = false;
                    break;
                case "Actualizar Datos del cliente":
                    panelBusActua.Visible = true;
                    panelEliminar.Visible = false;
                    panelAgregar.Visible = false;
                    panelActualizar.Visible = false;
                    break;
                case "Agregar Cliente":
                    panelAgregar.Visible = true;
                    panelActualizar.Visible = false;
                    panelBusActua.Visible = false;
                    panelEliminar.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}