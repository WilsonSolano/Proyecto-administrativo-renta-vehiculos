namespace PantallaPrincipal
{
    partial class FacturaOpciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaOpciones));
            this.dataGridFacturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOpcione = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEliminar = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericIdElim = new System.Windows.Forms.NumericUpDown();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericBuscar = new System.Windows.Forms.NumericUpDown();
            this.paneActualizar = new System.Windows.Forms.Panel();
            this.btnActualiza = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.numericDiasAlquiler = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelOpcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).BeginInit();
            this.panelEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdElim)).BeginInit();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuscar)).BeginInit();
            this.paneActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFacturas
            // 
            this.dataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFacturas.Location = new System.Drawing.Point(48, 394);
            this.dataGridFacturas.Name = "dataGridFacturas";
            this.dataGridFacturas.ReadOnly = true;
            this.dataGridFacturas.RowHeadersWidth = 62;
            this.dataGridFacturas.RowTemplate.Height = 28;
            this.dataGridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFacturas.Size = new System.Drawing.Size(973, 291);
            this.dataGridFacturas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "FACTURAS";
            // 
            // comboBoxOpcione
            // 
            this.comboBoxOpcione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcione.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpcione.FormattingEnabled = true;
            this.comboBoxOpcione.Items.AddRange(new object[] {
            "Eliminar",
            "Modificar Factura"});
            this.comboBoxOpcione.Location = new System.Drawing.Point(315, 69);
            this.comboBoxOpcione.Name = "comboBoxOpcione";
            this.comboBoxOpcione.Size = new System.Drawing.Size(313, 40);
            this.comboBoxOpcione.TabIndex = 28;
            this.comboBoxOpcione.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOpcione_SelectionChangeCommitted);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(706, 60);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(154, 52);
            this.btnMenu.TabIndex = 27;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "Opciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Facturas Ingresadas";
            // 
            // panelEliminar
            // 
            this.panelEliminar.Controls.Add(this.btnActualizar);
            this.panelEliminar.Controls.Add(this.label4);
            this.panelEliminar.Controls.Add(this.numericIdElim);
            this.panelEliminar.Location = new System.Drawing.Point(12, 124);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(973, 176);
            this.panelEliminar.TabIndex = 29;
            this.panelEliminar.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(422, 114);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 51);
            this.btnActualizar.TabIndex = 32;
            this.btnActualizar.Text = "Eliminar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id de la Factura";
            // 
            // numericIdElim
            // 
            this.numericIdElim.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericIdElim.Location = new System.Drawing.Point(532, 46);
            this.numericIdElim.Name = "numericIdElim";
            this.numericIdElim.Size = new System.Drawing.Size(155, 39);
            this.numericIdElim.TabIndex = 3;
            // 
            // panelBuscar
            // 
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.label5);
            this.panelBuscar.Controls.Add(this.numericBuscar);
            this.panelBuscar.Location = new System.Drawing.Point(53, 144);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(970, 192);
            this.panelBuscar.TabIndex = 30;
            this.panelBuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(422, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 51);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 64);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id de la Factura a Buscar \r\ny Modificar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericBuscar
            // 
            this.numericBuscar.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBuscar.Location = new System.Drawing.Point(532, 35);
            this.numericBuscar.Name = "numericBuscar";
            this.numericBuscar.Size = new System.Drawing.Size(155, 39);
            this.numericBuscar.TabIndex = 3;
            // 
            // paneActualizar
            // 
            this.paneActualizar.Controls.Add(this.btnActualiza);
            this.paneActualizar.Controls.Add(this.txtTotal);
            this.paneActualizar.Controls.Add(this.numericDiasAlquiler);
            this.paneActualizar.Controls.Add(this.label6);
            this.paneActualizar.Controls.Add(this.label11);
            this.paneActualizar.Controls.Add(this.txtFecha);
            this.paneActualizar.Controls.Add(this.txtPlacas);
            this.paneActualizar.Controls.Add(this.label9);
            this.paneActualizar.Controls.Add(this.label10);
            this.paneActualizar.Controls.Add(this.txtNumeroFactura);
            this.paneActualizar.Controls.Add(this.txtIdCliente);
            this.paneActualizar.Controls.Add(this.label7);
            this.paneActualizar.Controls.Add(this.label8);
            this.paneActualizar.Location = new System.Drawing.Point(12, 124);
            this.paneActualizar.Name = "paneActualizar";
            this.paneActualizar.Size = new System.Drawing.Size(1045, 227);
            this.paneActualizar.TabIndex = 33;
            this.paneActualizar.Visible = false;
            // 
            // btnActualiza
            // 
            this.btnActualiza.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualiza.Location = new System.Drawing.Point(799, 144);
            this.btnActualiza.Name = "btnActualiza";
            this.btnActualiza.Size = new System.Drawing.Size(119, 51);
            this.btnActualiza.TabIndex = 36;
            this.btnActualiza.Text = "Actualizar";
            this.btnActualiza.UseVisualStyleBackColor = true;
            this.btnActualiza.Click += new System.EventHandler(this.btnActualiza_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTotal.Location = new System.Drawing.Point(910, 65);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(129, 39);
            this.txtTotal.TabIndex = 35;
            // 
            // numericDiasAlquiler
            // 
            this.numericDiasAlquiler.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiasAlquiler.Location = new System.Drawing.Point(910, 7);
            this.numericDiasAlquiler.Name = "numericDiasAlquiler";
            this.numericDiasAlquiler.Size = new System.Drawing.Size(129, 34);
            this.numericDiasAlquiler.TabIndex = 34;
            this.numericDiasAlquiler.ValueChanged += new System.EventHandler(this.numericDiasAlquiler_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(690, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 35);
            this.label6.TabIndex = 33;
            this.label6.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(690, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 32);
            this.label11.TabIndex = 32;
            this.label11.Text = "Dias de Alquiler";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(234, 180);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(368, 34);
            this.txtFecha.TabIndex = 31;
            // 
            // txtPlacas
            // 
            this.txtPlacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlacas.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.Location = new System.Drawing.Point(234, 124);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.ReadOnly = true;
            this.txtPlacas.Size = new System.Drawing.Size(368, 34);
            this.txtPlacas.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Fecha de Entrega";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 32);
            this.label10.TabIndex = 28;
            this.label10.Text = "Placas del Auto";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumeroFactura.Location = new System.Drawing.Point(234, 7);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(368, 39);
            this.txtNumeroFactura.TabIndex = 26;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(234, 65);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(368, 34);
            this.txtIdCliente.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "Id del Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 32);
            this.label8.TabIndex = 24;
            this.label8.Text = "N° De Factura";
            // 
            // labelOpcion
            // 
            this.labelOpcion.AutoSize = true;
            this.labelOpcion.ForeColor = System.Drawing.Color.IndianRed;
            this.labelOpcion.Location = new System.Drawing.Point(319, 116);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(175, 20);
            this.labelOpcion.TabIndex = 34;
            this.labelOpcion.Text = "*Seleccione una opcion";
            this.labelOpcion.Visible = false;
            // 
            // FacturaOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 721);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.paneActualizar);
            this.Controls.Add(this.panelEliminar);
            this.Controls.Add(this.comboBoxOpcione);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturaOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaOpciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFacturas)).EndInit();
            this.panelEliminar.ResumeLayout(false);
            this.panelEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdElim)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuscar)).EndInit();
            this.paneActualizar.ResumeLayout(false);
            this.paneActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOpcione;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericIdElim;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericBuscar;
        private System.Windows.Forms.Panel paneActualizar;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnActualiza;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.NumericUpDown numericDiasAlquiler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label labelOpcion;
    }
}