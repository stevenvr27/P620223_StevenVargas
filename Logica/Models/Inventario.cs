﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Inventario
    {
        public int IDInventario { get; set; }

        public string NombreItem { get; set; }

        public string CodigoBarras { get; set; }


        public decimal Costo { get; set; }

        public decimal PrecioVenta { get; set; }


        public decimal CantidadEnStock { get; set; }

         public bool Activo { get; set; }

            public Empresa MiEmpresa { get; set; }

            public Categoria MiCategoria { get; set; }

            public Impuesto MiImpuesto { get; set; }

            public List<InventarioProveedor> ListadoProveedores { get; set; }
            
            public Inventario()
        {
            MiEmpresa = new Empresa();
            MiCategoria = new Categoria();
            MiImpuesto = new Impuesto();
            ListadoProveedores =new List<InventarioProveedor>();
            Activo = true;
        }

        public bool Agregar()
        {
            bool R = false;

            return R;

        }
        public bool Modificar()
        {
            bool R = false;

            return R;

        }
        public bool Eliminar()
        {
            bool R = false;

            return R;

        }
        public Inventario ConsultarPorId()
        {

            Inventario R = new Inventario();

            return R;

        }

        public bool ConsultarPorCodigoBarras(int IDEmpresa)
        {
            bool R = false;

            return R;

        }
        public  DataTable Listar(bool VerActivos=true)
        {
            DataTable R = new DataTable();

            return R;
        }
        public DataTable ListarProveedores()
        {
            DataTable R = new DataTable();

            return R;
        }
        public bool AgregarProveedor()
        {
            bool R = false;

            return R;

        }
        public bool ModificarPrecioProveedor()
        {
            bool R = false;

            return R;

        }
        public bool EliminarProveedor()
        {
            bool R = false;

            return R;

        }

    }
}
