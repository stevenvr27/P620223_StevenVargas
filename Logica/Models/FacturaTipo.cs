﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class FacturaTipo
    {
        public int IDFacturaTipo { get; set; }

        public string TipoFactura { get; set; }

        DataTable listar()
        {
            DataTable r = new DataTable();
            return r;
        }
    }
}
