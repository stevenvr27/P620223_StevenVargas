using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categoria
    {//primero escribiremos las propiedades simples
        
        public int IDCategoria { get; set; }
        public string NombreCategoria { get; set; }
        
        //escribiremos las funciones y metodos 

        DataTable listar()
        {
            DataTable r = new DataTable();
            return r;
        }
    }
}
