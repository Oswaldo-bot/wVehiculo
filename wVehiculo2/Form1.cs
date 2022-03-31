using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Nombres
/// Mariana Montoya Toro
/// Oswaldo Durán
/// Fecha: Marzo 30 del 2022
/// Descripcion:
/// </summary>

namespace wVehiculo2

{
    public partial class FrmRegistroVehiculo : MaterialSkin.Controls.MaterialForm
    {
        public FrmRegistroVehiculo()
        {
            InitializeComponent();
            IniciarFormulario();
        }

        private void IniciarFormulario()
        {
            #region[Limpiar el formulario]
            try
            {
                txtPlaca.Text = "";
                txtMarca.Text = "";
                txtColor.Text = "";
                txtModelo.Text = "";
                txtPotencia.Text = "";
                #endregion
            }
            catch (Exception Err)
            {

                MessageBox.Show(Err.Message, "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IniciarFormulario();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var buseta = new ClsCrearBuseta();

            try
            {
                if (rdbBuseta.Checked)
                {
                    //Instancio la Clase
                    var Buseta = new ClsCrearBuseta();
                    buseta.placa = txtPlaca.Text;
                    buseta.marca = txtMarca.Text;
                    buseta.color = txtColor.Text;
                    buseta.modelo = txtModelo.Text;
                    buseta.potencia = txtPotencia.Text;

                    MessageBox.Show($"Informacion de la persona\r\n Marca:{buseta.marca}\r\n Placa:{buseta.placa}\r\n Color:{buseta.color}\r\n Modelo:{buseta.modelo}\r\n Potencia:{buseta.potencia}\r\n  {buseta.placa + " " + buseta.ManejarBuseta()}");
                }
                else
                {
                    // Instancio de la clase 
                    var Taxi = new clsCrearTaxi();
                    Taxi.marca = txtMarca.Text;
                    Taxi.placa = txtPlaca.Text;
                    Taxi.color = txtColor.Text;
                    Taxi.modelo = txtModelo.Text;
                    // Mensaje de salida

                    MessageBox.Show($"Informacion de la persona\r\n Marca:{Taxi.marca}\r\n Placa:{Taxi.placa}\r\n Color:{Taxi.color}\r\n Modelo:{Taxi.modelo}\r\n  {Taxi.placa + " " + Taxi.ManejarTaxi()}");
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void rdbTaxi_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTaxi.Checked)
            {
                txtMarca.Enabled = false;
                txtPlaca.Enabled = true;
                txtColor.Enabled = false;
                txtModelo.Enabled = true;
            }
        }

        private void rdbBuseta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBuseta.Checked)
            {
                txtMarca.Enabled = false;
                txtPlaca.Enabled = true;
                txtColor.Enabled = false;
                txtModelo.Enabled = true;
                txtModelo.Enabled = true;

            }
        }
        private void FrmRegistroVehiculo_FormClosing(object sender, EventArgs e)
        {
 
        }

        private void FrmRegistroVehiculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realmente desea salir?", "confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}

     


