namespace PantallaPrincipal
{
    partial class FacturaClienteExiste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaClienteExiste));
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dateTimeFecheAlqui = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericDiasAlquiler = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnEnviarFact = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumeroFactura.Location = new System.Drawing.Point(461, 83);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(368, 39);
            this.txtNumeroFactura.TabIndex = 22;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(461, 148);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(368, 34);
            this.txtIdCliente.TabIndex = 23;
            // 
            // dateTimeFecheAlqui
            // 
            this.dateTimeFecheAlqui.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFecheAlqui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecheAlqui.Location = new System.Drawing.Point(461, 323);
            this.dateTimeFecheAlqui.Name = "dateTimeFecheAlqui";
            this.dateTimeFecheAlqui.Size = new System.Drawing.Size(368, 34);
            this.dateTimeFecheAlqui.TabIndex = 20;
            this.dateTimeFecheAlqui.Value = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha de Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Placas del Auto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Id del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "N° De Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "FACTURA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dias de Alquiler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(293, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total:";
            // 
            // numericDiasAlquiler
            // 
            this.numericDiasAlquiler.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiasAlquiler.Location = new System.Drawing.Point(461, 393);
            this.numericDiasAlquiler.Name = "numericDiasAlquiler";
            this.numericDiasAlquiler.Size = new System.Drawing.Size(368, 34);
            this.numericDiasAlquiler.TabIndex = 19;
            this.numericDiasAlquiler.ValueChanged += new System.EventHandler(this.numericDiasAlquiler_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTotal.Location = new System.Drawing.Point(461, 458);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(368, 39);
            this.txtTotal.TabIndex = 21;
            // 
            // btnEnviarFact
            // 
            this.btnEnviarFact.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarFact.Location = new System.Drawing.Point(424, 514);
            this.btnEnviarFact.Name = "btnEnviarFact";
            this.btnEnviarFact.Size = new System.Drawing.Size(119, 51);
            this.btnEnviarFact.TabIndex = 25;
            this.btnEnviarFact.Text = "Enviar";
            this.btnEnviarFact.UseVisualStyleBackColor = true;
            this.btnEnviarFact.Click += new System.EventHandler(this.btnEnviarFact_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(461, 203);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(368, 34);
            this.txtNombre.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(177, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nombre:";
            // 
            // txtPlacas
            // 
            this.txtPlacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPlacas.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.FormattingEnabled = true;
            this.txtPlacas.Location = new System.Drawing.Point(461, 258);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(368, 40);
            this.txtPlacas.TabIndex = 28;
            // 
            // FacturaClienteExiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 661);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEnviarFact);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dateTimeFecheAlqui);
            this.Controls.Add(this.numericDiasAlquiler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturaClienteExiste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacturaClienteExiste";
            this.Load += new System.EventHandler(this.FacturaClienteExiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDiasAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.DateTimePicker dateTimeFecheAlqui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericDiasAlquiler;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnEnviarFact;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtPlacas;
    }
}