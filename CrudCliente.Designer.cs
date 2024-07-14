namespace PantallaPrincipal
{
    partial class CrudCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudCliente));
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dataTabladeusuario = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEliminar = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodigoElim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreElim = new System.Windows.Forms.TextBox();
            this.labelOpcion = new System.Windows.Forms.Label();
            this.panelAgregar = new System.Windows.Forms.Panel();
            this.txtTipoLicenciaAgre = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dateTimeFechaRegisAgre = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericEdadAgre = new System.Windows.Forms.NumericUpDown();
            this.txtLicenciaAgre = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefonoAgre = new System.Windows.Forms.MaskedTextBox();
            this.txtClasificacionAgre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdClienteAgre = new System.Windows.Forms.TextBox();
            this.txtNombreAgre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelActualizar = new System.Windows.Forms.Panel();
            this.txtTipoLicenciaActua = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtRegistroActua = new System.Windows.Forms.TextBox();
            this.txtLicenciaActua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericEdadActua = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTelefonoActua = new System.Windows.Forms.MaskedTextBox();
            this.txtClasifiActua = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIdActua = new System.Windows.Forms.TextBox();
            this.txtNombreActua = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panelBusActua = new System.Windows.Forms.Panel();
            this.btnBucar = new System.Windows.Forms.Button();
            this.txtIdBus = new System.Windows.Forms.TextBox();
            this.txtNomBus = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxOpcione = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabladeusuario)).BeginInit();
            this.panelEliminar.SuspendLayout();
            this.panelAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdadAgre)).BeginInit();
            this.panelActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdadActua)).BeginInit();
            this.panelBusActua.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 55);
            this.label4.TabIndex = 17;
            this.label4.Text = "CLIENTES";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(892, 91);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(154, 52);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dataTabladeusuario
            // 
            this.dataTabladeusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTabladeusuario.EnableHeadersVisualStyles = false;
            this.dataTabladeusuario.Location = new System.Drawing.Point(82, 513);
            this.dataTabladeusuario.Name = "dataTabladeusuario";
            this.dataTabladeusuario.ReadOnly = true;
            this.dataTabladeusuario.RowHeadersWidth = 62;
            this.dataTabladeusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTabladeusuario.Size = new System.Drawing.Size(1092, 340);
            this.dataTabladeusuario.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tabla de clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Opciones:";
            // 
            // panelEliminar
            // 
            this.panelEliminar.Controls.Add(this.btnEliminar);
            this.panelEliminar.Controls.Add(this.txtCodigoElim);
            this.panelEliminar.Controls.Add(this.label5);
            this.panelEliminar.Controls.Add(this.label2);
            this.panelEliminar.Controls.Add(this.txtNombreElim);
            this.panelEliminar.Location = new System.Drawing.Point(82, 160);
            this.panelEliminar.Name = "panelEliminar";
            this.panelEliminar.Size = new System.Drawing.Size(1120, 263);
            this.panelEliminar.TabIndex = 20;
            this.panelEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(810, 96);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 52);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtCodigoElim
            // 
            this.txtCodigoElim.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoElim.Location = new System.Drawing.Point(178, 73);
            this.txtCodigoElim.Name = "txtCodigoElim";
            this.txtCodigoElim.Size = new System.Drawing.Size(223, 39);
            this.txtCodigoElim.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre:";
            // 
            // txtNombreElim
            // 
            this.txtNombreElim.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreElim.Location = new System.Drawing.Point(178, 135);
            this.txtNombreElim.Name = "txtNombreElim";
            this.txtNombreElim.Size = new System.Drawing.Size(372, 39);
            this.txtNombreElim.TabIndex = 20;
            // 
            // labelOpcion
            // 
            this.labelOpcion.AutoSize = true;
            this.labelOpcion.ForeColor = System.Drawing.Color.IndianRed;
            this.labelOpcion.Location = new System.Drawing.Point(524, 136);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(175, 20);
            this.labelOpcion.TabIndex = 21;
            this.labelOpcion.Text = "*Seleccione una opcion";
            this.labelOpcion.Visible = false;
            // 
            // panelAgregar
            // 
            this.panelAgregar.Controls.Add(this.txtTipoLicenciaAgre);
            this.panelAgregar.Controls.Add(this.btnAgregar);
            this.panelAgregar.Controls.Add(this.dateTimeFechaRegisAgre);
            this.panelAgregar.Controls.Add(this.label14);
            this.panelAgregar.Controls.Add(this.label7);
            this.panelAgregar.Controls.Add(this.numericEdadAgre);
            this.panelAgregar.Controls.Add(this.txtLicenciaAgre);
            this.panelAgregar.Controls.Add(this.label13);
            this.panelAgregar.Controls.Add(this.label12);
            this.panelAgregar.Controls.Add(this.txtTelefonoAgre);
            this.panelAgregar.Controls.Add(this.txtClasificacionAgre);
            this.panelAgregar.Controls.Add(this.label11);
            this.panelAgregar.Controls.Add(this.label10);
            this.panelAgregar.Controls.Add(this.txtIdClienteAgre);
            this.panelAgregar.Controls.Add(this.txtNombreAgre);
            this.panelAgregar.Controls.Add(this.label8);
            this.panelAgregar.Controls.Add(this.label6);
            this.panelAgregar.Location = new System.Drawing.Point(82, 142);
            this.panelAgregar.Name = "panelAgregar";
            this.panelAgregar.Size = new System.Drawing.Size(1102, 319);
            this.panelAgregar.TabIndex = 22;
            this.panelAgregar.Visible = false;
            // 
            // txtTipoLicenciaAgre
            // 
            this.txtTipoLicenciaAgre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoLicenciaAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoLicenciaAgre.FormattingEnabled = true;
            this.txtTipoLicenciaAgre.Items.AddRange(new object[] {
            "Licencia Particular",
            "Licencia Liviana",
            "Licencia Pesada"});
            this.txtTipoLicenciaAgre.Location = new System.Drawing.Point(810, 138);
            this.txtTipoLicenciaAgre.Name = "txtTipoLicenciaAgre";
            this.txtTipoLicenciaAgre.Size = new System.Drawing.Size(269, 40);
            this.txtTipoLicenciaAgre.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(498, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 51);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dateTimeFechaRegisAgre
            // 
            this.dateTimeFechaRegisAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFechaRegisAgre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaRegisAgre.Location = new System.Drawing.Point(810, 196);
            this.dateTimeFechaRegisAgre.MinDate = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            this.dateTimeFechaRegisAgre.Name = "dateTimeFechaRegisAgre";
            this.dateTimeFechaRegisAgre.Size = new System.Drawing.Size(269, 34);
            this.dateTimeFechaRegisAgre.TabIndex = 29;
            this.dateTimeFechaRegisAgre.Value = new System.DateTime(2023, 11, 17, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(597, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 32);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tipo de licencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(597, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 32);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha de registro";
            // 
            // numericEdadAgre
            // 
            this.numericEdadAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEdadAgre.Location = new System.Drawing.Point(810, 18);
            this.numericEdadAgre.Name = "numericEdadAgre";
            this.numericEdadAgre.Size = new System.Drawing.Size(141, 39);
            this.numericEdadAgre.TabIndex = 26;
            // 
            // txtLicenciaAgre
            // 
            this.txtLicenciaAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenciaAgre.Location = new System.Drawing.Point(810, 76);
            this.txtLicenciaAgre.Mask = "0000-0000";
            this.txtLicenciaAgre.Name = "txtLicenciaAgre";
            this.txtLicenciaAgre.Size = new System.Drawing.Size(141, 39);
            this.txtLicenciaAgre.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(597, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 32);
            this.label13.TabIndex = 23;
            this.label13.Text = "Licencia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(597, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 32);
            this.label12.TabIndex = 24;
            this.label12.Text = "Edad";
            // 
            // txtTelefonoAgre
            // 
            this.txtTelefonoAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAgre.Location = new System.Drawing.Point(181, 138);
            this.txtTelefonoAgre.Mask = "0000-0000";
            this.txtTelefonoAgre.Name = "txtTelefonoAgre";
            this.txtTelefonoAgre.Size = new System.Drawing.Size(141, 39);
            this.txtTelefonoAgre.TabIndex = 18;
            // 
            // txtClasificacionAgre
            // 
            this.txtClasificacionAgre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasificacionAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasificacionAgre.Location = new System.Drawing.Point(181, 200);
            this.txtClasificacionAgre.Name = "txtClasificacionAgre";
            this.txtClasificacionAgre.Size = new System.Drawing.Size(368, 34);
            this.txtClasificacionAgre.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 32);
            this.label11.TabIndex = 15;
            this.label11.Text = "Clasificacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefono";
            // 
            // txtIdClienteAgre
            // 
            this.txtIdClienteAgre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdClienteAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdClienteAgre.Location = new System.Drawing.Point(181, 22);
            this.txtIdClienteAgre.Name = "txtIdClienteAgre";
            this.txtIdClienteAgre.ReadOnly = true;
            this.txtIdClienteAgre.Size = new System.Drawing.Size(368, 34);
            this.txtIdClienteAgre.TabIndex = 13;
            // 
            // txtNombreAgre
            // 
            this.txtNombreAgre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAgre.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAgre.Location = new System.Drawing.Point(181, 81);
            this.txtNombreAgre.Name = "txtNombreAgre";
            this.txtNombreAgre.Size = new System.Drawing.Size(368, 34);
            this.txtNombreAgre.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id del Cliente";
            // 
            // panelActualizar
            // 
            this.panelActualizar.Controls.Add(this.txtTipoLicenciaActua);
            this.panelActualizar.Controls.Add(this.btnActualizar);
            this.panelActualizar.Controls.Add(this.txtRegistroActua);
            this.panelActualizar.Controls.Add(this.txtLicenciaActua);
            this.panelActualizar.Controls.Add(this.label9);
            this.panelActualizar.Controls.Add(this.label15);
            this.panelActualizar.Controls.Add(this.numericEdadActua);
            this.panelActualizar.Controls.Add(this.label16);
            this.panelActualizar.Controls.Add(this.label17);
            this.panelActualizar.Controls.Add(this.txtTelefonoActua);
            this.panelActualizar.Controls.Add(this.txtClasifiActua);
            this.panelActualizar.Controls.Add(this.label18);
            this.panelActualizar.Controls.Add(this.label19);
            this.panelActualizar.Controls.Add(this.txtIdActua);
            this.panelActualizar.Controls.Add(this.txtNombreActua);
            this.panelActualizar.Controls.Add(this.label20);
            this.panelActualizar.Controls.Add(this.label21);
            this.panelActualizar.Location = new System.Drawing.Point(61, 165);
            this.panelActualizar.Name = "panelActualizar";
            this.panelActualizar.Size = new System.Drawing.Size(1139, 302);
            this.panelActualizar.TabIndex = 23;
            this.panelActualizar.Visible = false;
            // 
            // txtTipoLicenciaActua
            // 
            this.txtTipoLicenciaActua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoLicenciaActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoLicenciaActua.FormattingEnabled = true;
            this.txtTipoLicenciaActua.Items.AddRange(new object[] {
            "Licencia Particular",
            "Licencia Liviana",
            "Licencia Pesada"});
            this.txtTipoLicenciaActua.Location = new System.Drawing.Point(810, 120);
            this.txtTipoLicenciaActua.Name = "txtTipoLicenciaActua";
            this.txtTipoLicenciaActua.Size = new System.Drawing.Size(303, 40);
            this.txtTipoLicenciaActua.TabIndex = 32;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(498, 233);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 51);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtRegistroActua
            // 
            this.txtRegistroActua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegistroActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistroActua.Location = new System.Drawing.Point(810, 182);
            this.txtRegistroActua.Name = "txtRegistroActua";
            this.txtRegistroActua.ReadOnly = true;
            this.txtRegistroActua.Size = new System.Drawing.Size(303, 34);
            this.txtRegistroActua.TabIndex = 30;
            // 
            // txtLicenciaActua
            // 
            this.txtLicenciaActua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLicenciaActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenciaActua.Location = new System.Drawing.Point(810, 64);
            this.txtLicenciaActua.Name = "txtLicenciaActua";
            this.txtLicenciaActua.Size = new System.Drawing.Size(303, 34);
            this.txtLicenciaActua.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(597, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tipo de licencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(597, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 32);
            this.label15.TabIndex = 27;
            this.label15.Text = "Fecha de registro";
            // 
            // numericEdadActua
            // 
            this.numericEdadActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericEdadActua.Location = new System.Drawing.Point(810, 0);
            this.numericEdadActua.Name = "numericEdadActua";
            this.numericEdadActua.Size = new System.Drawing.Size(141, 39);
            this.numericEdadActua.TabIndex = 26;
            this.numericEdadActua.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(597, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 32);
            this.label16.TabIndex = 23;
            this.label16.Text = "Licencia";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(597, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 32);
            this.label17.TabIndex = 24;
            this.label17.Text = "Edad";
            // 
            // txtTelefonoActua
            // 
            this.txtTelefonoActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoActua.Location = new System.Drawing.Point(181, 120);
            this.txtTelefonoActua.Mask = "0000-0000";
            this.txtTelefonoActua.Name = "txtTelefonoActua";
            this.txtTelefonoActua.Size = new System.Drawing.Size(141, 39);
            this.txtTelefonoActua.TabIndex = 18;
            // 
            // txtClasifiActua
            // 
            this.txtClasifiActua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClasifiActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasifiActua.Location = new System.Drawing.Point(181, 182);
            this.txtClasifiActua.Name = "txtClasifiActua";
            this.txtClasifiActua.Size = new System.Drawing.Size(368, 34);
            this.txtClasifiActua.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(5, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 32);
            this.label18.TabIndex = 15;
            this.label18.Text = "Clasificacion";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 32);
            this.label19.TabIndex = 16;
            this.label19.Text = "Telefono";
            // 
            // txtIdActua
            // 
            this.txtIdActua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdActua.Location = new System.Drawing.Point(283, 6);
            this.txtIdActua.Name = "txtIdActua";
            this.txtIdActua.ReadOnly = true;
            this.txtIdActua.Size = new System.Drawing.Size(106, 34);
            this.txtIdActua.TabIndex = 13;
            // 
            // txtNombreActua
            // 
            this.txtNombreActua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreActua.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreActua.Location = new System.Drawing.Point(181, 63);
            this.txtNombreActua.Name = "txtNombreActua";
            this.txtNombreActua.Size = new System.Drawing.Size(368, 34);
            this.txtNombreActua.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(5, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 32);
            this.label20.TabIndex = 12;
            this.label20.Text = "Nombre:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(5, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(228, 32);
            this.label21.TabIndex = 11;
            this.label21.Text = "Actualizar datos de: ";
            // 
            // panelBusActua
            // 
            this.panelBusActua.Controls.Add(this.btnBucar);
            this.panelBusActua.Controls.Add(this.txtIdBus);
            this.panelBusActua.Controls.Add(this.txtNomBus);
            this.panelBusActua.Controls.Add(this.label22);
            this.panelBusActua.Controls.Add(this.label24);
            this.panelBusActua.Controls.Add(this.label23);
            this.panelBusActua.Location = new System.Drawing.Point(93, 145);
            this.panelBusActua.Name = "panelBusActua";
            this.panelBusActua.Size = new System.Drawing.Size(1109, 309);
            this.panelBusActua.TabIndex = 24;
            this.panelBusActua.Visible = false;
            // 
            // btnBucar
            // 
            this.btnBucar.Font = new System.Drawing.Font("Segoe UI Variable Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucar.Location = new System.Drawing.Point(450, 230);
            this.btnBucar.Name = "btnBucar";
            this.btnBucar.Size = new System.Drawing.Size(200, 51);
            this.btnBucar.TabIndex = 15;
            this.btnBucar.Text = "Buscar Datos";
            this.btnBucar.UseVisualStyleBackColor = true;
            this.btnBucar.Click += new System.EventHandler(this.btnBucar_Click);
            // 
            // txtIdBus
            // 
            this.txtIdBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdBus.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBus.Location = new System.Drawing.Point(529, 92);
            this.txtIdBus.Name = "txtIdBus";
            this.txtIdBus.Size = new System.Drawing.Size(368, 34);
            this.txtIdBus.TabIndex = 13;
            // 
            // txtNomBus
            // 
            this.txtNomBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomBus.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomBus.Location = new System.Drawing.Point(529, 159);
            this.txtNomBus.Name = "txtNomBus";
            this.txtNomBus.Size = new System.Drawing.Size(368, 34);
            this.txtNomBus.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(312, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 32);
            this.label22.TabIndex = 12;
            this.label22.Text = "Nombre:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(440, 28);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(234, 32);
            this.label24.TabIndex = 11;
            this.label24.Text = "Cliente a Actualizar";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(312, 94);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(156, 32);
            this.label23.TabIndex = 11;
            this.label23.Text = "Id del Cliente";
            // 
            // comboBoxOpcione
            // 
            this.comboBoxOpcione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpcione.Font = new System.Drawing.Font("Segoe UI Variable Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOpcione.FormattingEnabled = true;
            this.comboBoxOpcione.Items.AddRange(new object[] {
            "Agregar Cliente",
            "Eliminar Cliente",
            "Actualizar Datos del cliente"});
            this.comboBoxOpcione.Location = new System.Drawing.Point(495, 88);
            this.comboBoxOpcione.Name = "comboBoxOpcione";
            this.comboBoxOpcione.Size = new System.Drawing.Size(313, 40);
            this.comboBoxOpcione.TabIndex = 25;
            this.comboBoxOpcione.SelectionChangeCommitted += new System.EventHandler(this.comboBoxOpcione_SelectionChangeCommitted);
            // 
            // CrudCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1214, 944);
            this.Controls.Add(this.comboBoxOpcione);
            this.Controls.Add(this.panelActualizar);
            this.Controls.Add(this.panelBusActua);
            this.Controls.Add(this.panelAgregar);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.panelEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dataTabladeusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarCliente";
            this.Load += new System.EventHandler(this.EliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTabladeusuario)).EndInit();
            this.panelEliminar.ResumeLayout(false);
            this.panelEliminar.PerformLayout();
            this.panelAgregar.ResumeLayout(false);
            this.panelAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdadAgre)).EndInit();
            this.panelActualizar.ResumeLayout(false);
            this.panelActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdadActua)).EndInit();
            this.panelBusActua.ResumeLayout(false);
            this.panelBusActua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dataTabladeusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEliminar;
        private System.Windows.Forms.TextBox txtCodigoElim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelOpcion;
        private System.Windows.Forms.Panel panelAgregar;
        private System.Windows.Forms.TextBox txtIdClienteAgre;
        private System.Windows.Forms.TextBox txtNombreAgre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefonoAgre;
        private System.Windows.Forms.TextBox txtClasificacionAgre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericEdadAgre;
        private System.Windows.Forms.MaskedTextBox txtLicenciaAgre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimeFechaRegisAgre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericEdadActua;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtTelefonoActua;
        private System.Windows.Forms.TextBox txtClasifiActua;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIdActua;
        private System.Windows.Forms.TextBox txtNombreActua;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panelBusActua;
        private System.Windows.Forms.TextBox txtIdBus;
        private System.Windows.Forms.TextBox txtNomBus;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnBucar;
        private System.Windows.Forms.TextBox txtRegistroActua;
        private System.Windows.Forms.TextBox txtLicenciaActua;
        private System.Windows.Forms.ComboBox comboBoxOpcione;
        private System.Windows.Forms.ComboBox txtTipoLicenciaActua;
        private System.Windows.Forms.ComboBox txtTipoLicenciaAgre;
    }
}