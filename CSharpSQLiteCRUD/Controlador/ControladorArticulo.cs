using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpSQLiteCRUD.Modelo;
using CSharpSQLiteCRUD.Vista;

namespace CSharpSQLiteCRUD.Controlador
{
    public static class ControladorArticulo
    {
        public static void Listar(FormArticulos vista)
        {
            Articulo articulo = new Articulo();

            vista.CargarDataGridView(articulo.Todos());
        }

        public static void Listar(FormArticulos vista, string condicion)
        {
            Articulo articulo = new Articulo();

            vista.CargarDataGridView(articulo.Todos(condicion));
        }
    }
}
