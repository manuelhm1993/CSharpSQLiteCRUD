using CSharpSQLiteCRUD.Modelo;
using CSharpSQLiteCRUD.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSQLiteCRUD.Controlador
{
    public static class ControladorArticulo
    {
        public static DataTable Listar()
        {
            Articulo articulo = new Articulo();

            return articulo.Todos();
        }

        public static DataTable Listar(string condicion)
        {
            Articulo articulo = new Articulo();

            return articulo.Todos(condicion);
        }
    }
}
