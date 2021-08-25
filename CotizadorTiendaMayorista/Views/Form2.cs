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
    public partial class Form2 : Form
    {
        InitController init;
        public Form2(ref InitController i)
        {
            InitializeComponent();
            init = i;
        }
      

        private void Form2_Load(object sender, EventArgs e)
        {
            lbNombreTienda2.Text = init.Vendedor.Tienda.Nombre;
            lbDireccion2.Text = init.Vendedor.Tienda.Direccion;
            lbNombreVendedor2.Text = init.Vendedor.Nombre + init.Vendedor.Apellido + " | ID:" + init.Vendedor.IdVendedor;
            CargarGrilla();
           
        }



        private void CargarGrilla() {
            if (init.Vendedor.HistorialCotizaciones != null && init.Vendedor.HistorialCotizaciones.Count > 0)
            {
              
                foreach (var i in init.Vendedor.HistorialCotizaciones)
                {
                    int n = dgv1.Rows.Add();
                    dgv1.Rows[n].Cells[0].Value = i.IdVendedor;
                    dgv1.Rows[n].Cells[1].Value = i.IdCotizacion;
                    dgv1.Rows[n].Cells[2].Value = i.FechaHora;
                    dgv1.Rows[n].Cells[3].Value = i.Prenda.GetType().Name;
                    dgv1.Rows[n].Cells[4].Value = i.CantidadUnidadesCotizadas;
                    dgv1.Rows[n].Cells[5].Value = i.ValorCotizacion;

                }
            }
            else {
               
                MessageBox.Show("No hay historial de cotizaciones");
            }
           
        }
    }
}
