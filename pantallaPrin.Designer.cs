namespace PantallaPrincipal
{
    partial class pantallaPrin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaConNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaConClienteExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1148, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaConNuevoClienteToolStripMenuItem,
            this.facturaConClienteExistenteToolStripMenuItem,
            this.editarFacturasToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // facturaConNuevoClienteToolStripMenuItem
            // 
            this.facturaConNuevoClienteToolStripMenuItem.Name = "facturaConNuevoClienteToolStripMenuItem";
            this.facturaConNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(421, 40);
            this.facturaConNuevoClienteToolStripMenuItem.Text = "Factura con nuevo cliente";
            this.facturaConNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.facturaConNuevoClienteToolStripMenuItem_Click);
            // 
            // facturaConClienteExistenteToolStripMenuItem
            // 
            this.facturaConClienteExistenteToolStripMenuItem.Name = "facturaConClienteExistenteToolStripMenuItem";
            this.facturaConClienteExistenteToolStripMenuItem.Size = new System.Drawing.Size(421, 40);
            this.facturaConClienteExistenteToolStripMenuItem.Text = "Factura con cliente existente";
            this.facturaConClienteExistenteToolStripMenuItem.Click += new System.EventHandler(this.facturaConClienteExistenteToolStripMenuItem_Click);
            // 
            // editarFacturasToolStripMenuItem
            // 
            this.editarFacturasToolStripMenuItem.Name = "editarFacturasToolStripMenuItem";
            this.editarFacturasToolStripMenuItem.Size = new System.Drawing.Size(421, 40);
            this.editarFacturasToolStripMenuItem.Text = "Editar Facturas";
            this.editarFacturasToolStripMenuItem.Click += new System.EventHandler(this.editarFacturasToolStripMenuItem_Click);
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeCuentaToolStripMenuItem});
            this.cuentaToolStripMenuItem.Image = global::PantallaPrincipal.Properties.Resources.usuario;
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // cambiarDeCuentaToolStripMenuItem
            // 
            this.cambiarDeCuentaToolStripMenuItem.Image = global::PantallaPrincipal.Properties.Resources.cambio;
            this.cambiarDeCuentaToolStripMenuItem.Name = "cambiarDeCuentaToolStripMenuItem";
            this.cambiarDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(323, 40);
            this.cambiarDeCuentaToolStripMenuItem.Text = "Cambiar de Cuenta";
            this.cambiarDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.cambiarDeCuentaToolStripMenuItem_Click);
            // 
            // pantallaPrin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PantallaPrincipal.Properties.Resources.JYJ_LOGO_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1148, 577);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pantallaPrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaConNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaConClienteExistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFacturasToolStripMenuItem;
    }
}

