﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empresa
    {
        
        public int IDEmpresa { get; set; }
        public string CedulaEmpresa { get; set; }
        public string NombreEmpresa { get; set; }

        public string DirreccionEmpresa { get; set; }
        public string EmailEmpresa { get; set; }
        public string TelefonoEmpresa { get; set; }
        public bool Activo { get; set; }


        public DataTable Listar()

        {
             DataTable R = new DataTable();


            Conexion MiCon = new Conexion();
            R = MiCon.EjecutarSelect("SPEmpresasListar");

            return R;

        }
    }
}
