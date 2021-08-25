﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorTiendaMayorista.Modelo
{
   
        abstract class ParManga
        {
            private string descripcion;

            public string Descripcion { get => descripcion; set => descripcion = value; }

            protected ParManga(string descripcion)
            {
                this.descripcion = descripcion;
            }
        }
    }
