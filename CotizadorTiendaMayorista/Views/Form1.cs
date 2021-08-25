using CotizadorTiendaMayorista.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizadorTiendaMayorista
{
    public partial class Formulario : Form
    {
        InitController init;
        CotizadorController nuevaCotizacion;
        public Formulario()
        {
            InitializeComponent();
               
    }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            init = new InitController();
            lbNombreTienda.Text = init.Tienda.Nombre;
            lbDireccion.Text = init.Tienda.Direccion;
            lbNombreVendedor.Text = init.Vendedor.Nombre + init.Vendedor.Apellido + " | ID:" + init.Vendedor.IdVendedor;
            rbCamisa.Checked = true;
            cbChupin.Enabled = false;
        }

      

        private void rbCamisa_CheckedChanged(object sender, EventArgs e)
        {
            rbPantalon.Checked = false;
            cbChupin.Enabled = false;
            cbCuelloMao.Enabled = true;
            cbMangaCorta.Enabled = true;
        }

        private void rbPantalon_CheckedChanged(object sender, EventArgs e)
        {
            cbChupin.Enabled = true;
            cbCuelloMao.Enabled = false;
            cbMangaCorta.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio.BackColor = Color.White;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //solo 1 decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCant.BackColor = Color.White;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void btCotizar_Click(object sender, EventArgs e)
        {
            
            if (validar(this.groupBox3)) {
             nuevaCotizacion = new CotizadorController(init, rbCamisa.Checked, cbMangaCorta.Checked,
                cbCuelloMao.Checked, rbPantalon.Checked, cbChupin.Checked, rbCalidadStandard.Checked, rbCalidadPremium.Checked,
                txtPrecio.Text, txtCant.Text);


             decimal retorno=  nuevaCotizacion.CrearCotizacion();
              

                if (retorno < 0)
                {
                    MessageBox.Show("No es posible hacer una cotización debido a stock insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                ActualizarLabelStock();
                ActualizarValorCotizacion( retorno);
                }
            }
            

        }

     
        private void linkHistorialCotizaciones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 segundoFrom = new Form2(ref nuevaCotizacion);
            segundoFrom.ShowDialog();
           
        }

        private void ActualizarLabelStock()
        {
            labelstock.Text = init.LabelStock; 
        }

        private void ActualizarValorCotizacion(decimal value) {
            lbPrecioCotizacion.Text = value.ToString();
        }

        private bool validar(GroupBox gb)
        {
             bool camposVacios= false;

            foreach (Control oControls in gb.Controls)
            {
                if (oControls is TextBox & oControls.Text == String.Empty) 
                {
                    camposVacios = true;
                    oControls.BackColor = Color.Tomato;
                   
                }
             }

            if (camposVacios)
            {               
                MessageBox.Show("Por favor debe completar todos los campos.");
                return false;
            }
            else
            {
                return true;
            }
        }
    
   
    }
    
}



