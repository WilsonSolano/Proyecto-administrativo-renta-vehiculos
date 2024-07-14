namespace PantallaPrincipal
{
    partial class Logincs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logincs));
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.pbOcultar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lContraseña = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contraseña
            // 
            this.Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseña.Location = new System.Drawing.Point(350, 308);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(300, 35);
            this.Contraseña.TabIndex = 16;
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(350, 222);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(336, 35);
            this.Usuario.TabIndex = 15;
            // 
            // pbMostrar
            // 
            this.pbMostrar.BackColor = System.Drawing.SystemColors.Window;
            this.pbMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMostrar.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrar.Image")));
            this.pbMostrar.Location = new System.Drawing.Point(664, 315);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(30, 25);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMostrar.TabIndex = 22;
            this.pbMostrar.TabStop = false;
            this.pbMostrar.Click += new System.EventHandler(this.pbMostrar_Click);
            // 
            // pbOcultar
            // 
            this.pbOcultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbOcultar.Image = ((System.Drawing.Image)(resources.GetObject("pbOcultar.Image")));
            this.pbOcultar.Location = new System.Drawing.Point(664, 315);
            this.pbOcultar.Name = "pbOcultar";
            this.pbOcultar.Size = new System.Drawing.Size(30, 25);
            this.pbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOcultar.TabIndex = 21;
            this.pbOcultar.TabStop = false;
            this.pbOcultar.Click += new System.EventHandler(this.pbOcultar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PantallaPrincipal.Properties.Resources.JYJ_LOGO_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::PantallaPrincipal.Properties.Resources.JYJ_LOGO_1;
            this.pictureBox1.InitialImage = global::PantallaPrincipal.Properties.Resources.JYJ_LOGO_1;
            this.pictureBox1.Location = new System.Drawing.Point(324, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 24F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(334, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 67);
            this.label3.TabIndex = 17;
            // 
            // lContraseña
            // 
            this.lContraseña.AutoSize = true;
            this.lContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lContraseña.Location = new System.Drawing.Point(182, 308);
            this.lContraseña.Name = "lContraseña";
            this.lContraseña.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lContraseña.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lContraseña.Size = new System.Drawing.Size(142, 33);
            this.lContraseña.TabIndex = 14;
            this.lContraseña.Text = "Contraseña ";
            this.lContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lContraseña.UseMnemonic = false;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lUsuario.Location = new System.Drawing.Point(212, 225);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lUsuario.Size = new System.Drawing.Size(96, 33);
            this.lUsuario.TabIndex = 13;
            this.lUsuario.Text = "Usuario";
            this.lUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::PantallaPrincipal.Properties.Resources.esquema_del_boton_de_flecha_cuadrada_de_inicio_de_sesion;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.Location = new System.Drawing.Point(238, 397);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(210, 51);
            this.btnIniciar.TabIndex = 23;
            this.btnIniciar.Text = "Iniciar Sesion";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::PantallaPrincipal.Properties.Resources.cerrar;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(489, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 51);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir del Sistema";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Logincs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 532);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pbMostrar);
            this.Controls.Add(this.pbOcultar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.lContraseña);
            this.Controls.Add(this.lUsuario);
            this.Name = "Logincs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logincs";
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.PictureBox pbOcultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label lContraseña;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnSalir;
    }
}