using PantallaPrincipa;
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
    public partial class Logincs : Form
    {
        public Logincs()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            Contraseña.PasswordChar = '▽';
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            Contraseña.PasswordChar = '\0';
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            LoginClas iniciar = new LoginClas();
            iniciar.GUsuario = Usuario.Text;
            iniciar.GContraseña = Contraseña.Text;
            iniciar.inicia();

            if (iniciar.existe == true)
            {
                MessageBox.Show("Bienvenido", "Bienvenido", MessageBoxButtons.OK);
                Form ReHome = new pantallaPrin();
                ReHome.Show();
                //this.Hide(); //para que el login se OCULTE PELIGRO ERROR CON BD
            }
            else
            {
                MessageBox.Show("Contraseña o usuario invalido", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantallaPrin si = new pantallaPrin();
            si.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pantallaPrin si = new pantallaPrin();
            si.Show();
        }
    }
}
