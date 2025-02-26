using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------ Recursos SQL
using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;

namespace CSharpSQLiteCRUD.Modelo
{
    public class Articulo
    {
        #region "Propiedades"
        private SQLiteDataReader result;
        private DataTable tabla;
        private SQLiteConnection conn;
        #endregion

        public Articulo()
        {
            this.tabla = new DataTable();
            this.conn = new SQLiteConnection();
        }

        private DataTable ProcesoConsulta(string query, string condicion = "")
        {
            try
            {
                this.conn = Conexion.conn.CrearConexion();

                SQLiteCommand cmd;

                if (String.IsNullOrEmpty(condicion)) cmd = new SQLiteCommand(query, this.conn);

                else cmd = DevolverConsultaPreparada(query, condicion);

                this.conn.Open();
                this.result = cmd.ExecuteReader();
                this.tabla.Load(result);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (this.conn.State == ConnectionState.Open) this.conn.Close();
            }

            return this.tabla;
        }

        private SQLiteCommand DevolverConsultaPreparada(string query, string condicion)
        {
            SQLiteCommand cmd = new SQLiteCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@condicion", condicion);

            cmd.Connection = this.conn;

            return cmd;
        }

        public DataTable Todos()
        {
            string query = "select * from articulos";

            DataTable dt = ProcesoConsulta(query);

            return dt;
        }

        public DataTable Todos(string condicion)
        {
            condicion = $"%{condicion.Trim()}%";

            StringBuilder query = new StringBuilder();

            query.Append("select a.id, a.descripcion, a.marca, c.descripcion as categoria_desc, m.descripcion as medida_desc, a.categoria_id, a.medida_id ");
            query.Append("from articulos a ");
            query.Append("inner join categorias c on c.id = a.categoria_id ");
            query.Append("inner join medidas m on m.id = a.medida_id ");
            query.Append("where a.descripcion like @condicion ");

            DataTable dt = ProcesoConsulta(query.ToString(), condicion);

            return dt;
        }
    }
}
