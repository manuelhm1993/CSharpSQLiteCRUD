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

        public static string Crear(FormArticulos vista)
        {
            string response = String.Empty;
            Articulo articulo = new Articulo();

            articulo.Descripcion = vista.DevolverTxtArt().Text.Trim();
            articulo.Marca = vista.DevolverTxtMarca().Text.Trim();
            //articulo.MedidaId = Int32.Parse(vista.DevolverTxtMedida().Text.Trim());
            //articulo.CategoriaId = Int32.Parse(vista.DevolverTxtCategoria().Text.Trim());

            response = Articulo.Insertar(articulo);

            return response;
        }
    }
}
