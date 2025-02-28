using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------ Recursos SQL
using System.Data.SqlClient;
using System.Data;
using CSharpSQLiteCRUD.BaseDatos;

namespace CSharpSQLiteCRUD.Modelo
{
    public class Articulo
    {
        private static int medidaId = 0;
        private static int categoriaId = 0;

        #region "Propiedades"
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int MedidaId { get; set; }
        public int CategoriaId { get; set; }
        #endregion

        #region "Metodos"
        public Articulo()
        {
            
        }

        public DataTable Todos()
        {
            string query = "select * from articulos";

            DataTable dt = Conexion.ProcesoConsulta(query);

            return dt;
        }

        public DataTable Todos(string condicion)
        {
            condicion = $"%{condicion.Trim()}%";

            StringBuilder query = new StringBuilder();

            query.Append("select a.id, a.descripcion, a.marca, m.descripcion as medida_desc, c.descripcion as categoria_desc , a.medida_id, a.categoria_id ");
            query.Append("from articulos a ");
            query.Append("inner join categorias c on c.id = a.categoria_id ");
            query.Append("inner join medidas m on m.id = a.medida_id ");
            query.Append("where a.descripcion like @condicion ");

            DataTable dt = Conexion.ProcesoConsulta(query.ToString(), condicion);

            return dt;
        }

        public static string Insertar(Articulo articulo)
        {
            medidaId++;
            categoriaId++;

            articulo.MedidaId = medidaId;
            articulo.CategoriaId = categoriaId;

            StringBuilder query = new StringBuilder();

            string descripcion = articulo.Descripcion;
            string marca = articulo.Marca;
            int medida_id = articulo.MedidaId;
            int categoria_id = articulo.CategoriaId;

            query.Append("insert into articulos ");
            query.Append("(descripcion, marca, medida_id, categoria_id) ");
            query.Append("values ");
            query.Append("(@descripcion, @marca, @medida_id, @categoria_id ) ");

            return Conexion.ProcesoConsulta(query.ToString(), articulo);
        }
        #endregion
    }
}
