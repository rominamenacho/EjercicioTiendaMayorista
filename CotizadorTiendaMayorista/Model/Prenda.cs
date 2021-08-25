namespace CotizadorTiendaMayorista.Modelo
{
  public  abstract class Prenda
    {
        private Calidad calidad;
        private decimal precioUnitario;
        private int cantidadStock;

        public decimal PrecioUnitario { get => precioUnitario;  }
        public int CantidadStock { get => cantidadStock;  }
        public Calidad Calidad { get => calidad;  }

        public Prenda( Calidad calidad, decimal precioUnitario, int cantidadStock)
        {
            this.calidad = calidad;
            this.precioUnitario = precioUnitario;
            this.cantidadStock = cantidadStock;

        }

        public virtual decimal CalcularPrecio() {
            decimal retorno = 0;

            if(calidad is Premium)
            {
                retorno = System.Math.Round(System.Convert.ToDecimal(PrecioUnitario * 1.30M), 2);
                
            }
            else
            {
                retorno = PrecioUnitario;
            }

            return retorno;
        }

      


        
    }
}