namespace wVehiculo2
{
    partial class FrmRegistroVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroVehiculo));
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gpbVehiculos = new System.Windows.Forms.GroupBox();
            this.rdoParticular = new System.Windows.Forms.RadioButton();
            this.rdoBuseta = new System.Windows.Forms.RadioButton();
            this.rdoTaxi = new System.Windows.Forms.RadioButton();
            this.gpbVehiculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(40, 131);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(40, 181);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(40, 225);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(40, 270);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(40, 318);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(49, 13);
            this.lblPotencia.TabIndex = 6;
            this.lblPotencia.Text = "Potencia";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(80, 131);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(131, 20);
            this.txtPlaca.TabIndex = 7;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(83, 178);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(131, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(95, 318);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(131, 20);
            this.txtPotencia.TabIndex = 10;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(83, 267);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(131, 20);
            this.txtModelo.TabIndex = 11;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(83, 222);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(131, 20);
            this.txtColor.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(280, 351);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 59);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(452, 354);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(131, 55);
            this.btnMostrar.TabIndex = 14;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gpbVehiculos
            // 
            this.gpbVehiculos.Controls.Add(this.rdoParticular);
            this.gpbVehiculos.Controls.Add(this.rdoBuseta);
            this.gpbVehiculos.Controls.Add(this.rdoTaxi);
            this.gpbVehiculos.Location = new System.Drawing.Point(292, 101);
            this.gpbVehiculos.Name = "gpbVehiculos";
            this.gpbVehiculos.Size = new System.Drawing.Size(200, 118);
            this.gpbVehiculos.TabIndex = 15;
            this.gpbVehiculos.TabStop = false;
            this.gpbVehiculos.Text = "Vehiculos";
            // 
            // rdoParticular
            // 
            this.rdoParticular.AutoSize = true;
            this.rdoParticular.Location = new System.Drawing.Point(19, 80);
            this.rdoParticular.Name = "rdoParticular";
            this.rdoParticular.Size = new System.Drawing.Size(69, 17);
            this.rdoParticular.TabIndex = 2;
            this.rdoParticular.TabStop = true;
            this.rdoParticular.Text = "Particular";
            this.rdoParticular.UseVisualStyleBackColor = true;
            // 
            // rdoBuseta
            // 
            this.rdoBuseta.AutoSize = true;
            this.rdoBuseta.Location = new System.Drawing.Point(19, 54);
            this.rdoBuseta.Name = "rdoBuseta";
            this.rdoBuseta.Size = new System.Drawing.Size(58, 17);
            this.rdoBuseta.TabIndex = 1;
            this.rdoBuseta.TabStop = true;
            this.rdoBuseta.Text = "Buseta";
            this.rdoBuseta.UseVisualStyleBackColor = true;
            // 
            // rdoTaxi
            // 
            this.rdoTaxi.AutoSize = true;
            this.rdoTaxi.Location = new System.Drawing.Point(19, 30);
            this.rdoTaxi.Name = "rdoTaxi";
            this.rdoTaxi.Size = new System.Drawing.Size(45, 17);
            this.rdoTaxi.TabIndex = 0;
            this.rdoTaxi.TabStop = true;
            this.rdoTaxi.Text = "Taxi";
            this.rdoTaxi.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbVehiculos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPotencia);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPlaca);
            this.Enabled = false;
            this.Name = "FrmRegistroVehiculo";
            this.Text = "Registro Vehiculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistroVehiculo_FormClosing);
            this.gpbVehiculos.ResumeLayout(false);
            this.gpbVehiculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gpbVehiculos;
        private System.Windows.Forms.RadioButton rdoParticular;
        private System.Windows.Forms.RadioButton rdoBuseta;
        private System.Windows.Forms.RadioButton rdoTaxi;
    }
}

