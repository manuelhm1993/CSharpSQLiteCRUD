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
        #region "Propiedades"

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
            condicion = $"{condicion.Trim()}";

            StringBuilder query = new StringBuilder();

            query.Append("select a.id, a.descripcion, a.marca, m.descripcion as medida_desc, c.descripcion as categoria_desc , a.medida_id, a.categoria_id ");
            query.Append("from articulos a ");
            query.Append("inner join categorias c on c.id = a.categoria_id ");
            query.Append("inner join medidas m on m.id = a.medida_id ");
            query.Append("where a.descripcion like '%@condicion%' ");

            DataTable dt = Conexion.ProcesoConsulta(query.ToString(), condicion);

            return dt;
        }
        #endregion
    }
}
