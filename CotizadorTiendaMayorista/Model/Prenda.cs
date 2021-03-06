namespace CotizadorTiendaMayorista.Modelo
{
  public  abstract class Prenda
    {
        private Calidad calidad;
        private decimal precioUnitario;
        private int cantidad;

        public decimal PrecioUnitario { get => precioUnitario;  }
        public int CantidadStock { get => cantidad;  }
        public Calidad Calidad { get => calidad;  }

        public Prenda( bool calidadStandard, decimal precioUnitario, int cantidad)
        {
            if (calidadStandard)
            {
                this.calidad = new Standard("Standard");
            }
            else
            {
                this.calidad = new Premium("Premium");
            }
         

            this.precioUnitario = precioUnitario;
            this.cantidad = cantidad;

        }

        public virtual decimal CalculatePrice() {
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