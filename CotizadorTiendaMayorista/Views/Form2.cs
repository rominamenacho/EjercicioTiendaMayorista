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
        CotizadorController refCotizacion;
        public Form2(ref CotizadorController nuevaCotizacion)
        {
            InitializeComponent();
            refCotizacion = nuevaCotizacion;
        }
      

        private void Form2_Load(object sender, EventArgs e)
        {
            init = new InitController();
            lbNombreTienda2.Text = init.NombreTienda();
            lbDireccion2.Text = init.DireccionTienda();
            lbNombreVendedor2.Text = init.VendedorNombreApellido() + " | ID:" + init.VendedorId();
            CargarGrilla();
            label3.Text = refCotizacion.HistorialC.Count().ToString();
        }



        private void CargarGrilla() {
           
              int n = dgv1.Rows.Add();
            foreach(var i in refCotizacion.HistorialC)
            {
                dgv1.Rows[n].Cells[0].Value = i.IdVendedor;
                dgv1.Rows[n].Cells[1].Value = i.IdCotizacion;
                dgv1.Rows[n].Cells[2].Value = i.FechaHora;
                dgv1.Rows[n].Cells[3].Value = i.Prenda.GetType().Name;
                dgv1.Rows[n].Cells[4].Value = i.CantidadUnidadesCotizadas;
                dgv1.Rows[n].Cells[5].Value = i.ValorCotizacion;

            }
        }
    }
}
