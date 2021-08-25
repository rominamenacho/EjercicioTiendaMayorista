using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
    public class Chupin : Pantalon
    {
        public Chupin(string descripcion, Calidad calidad, decimal precioUnitario, int cantidadStock) : base(descripcion, calidad, precioUnitario, cantidadStock)
        {
        }


        public override decimal CalculatePrice()
        {
            decimal retorno = base.CalculatePrice();

            retorno = retorno+ System.Math.Round(System.Convert.ToDecimal(retorno * 0.12M), 2);

            return retorno;
        }
    }
}
