﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaInventario
    {
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }

        public decimal SubTotal { get; set; }

        public decimal DescuentoTotal { get; set; }

        public decimal SubTotal2 { get; set; }
        public decimal ImpuestoTotal { get; set; }
        public decimal TotalLinea { get; set; }

        public Inventario MiInventario { get; set; }

        public FacturaInventario()
        {
            MiInventario = new Inventario(); 
        }




        public decimal TotalizarLinea()
        {
            

            SubTotal=Cantidad*PrecioVenta;

            DescuentoTotal = (SubTotal * PorcentajeDescuento) / 100;

            SubTotal2 = SubTotal - DescuentoTotal;

            ImpuestoTotal = (SubTotal2 * PorcentajeImpuesto) / 100;

            TotalLinea = SubTotal2 + ImpuestoTotal;


            return TotalLinea;
        }



    }
}
