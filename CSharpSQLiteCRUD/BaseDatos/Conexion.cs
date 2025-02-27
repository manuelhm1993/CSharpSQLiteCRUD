using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------ Recursos SQL
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;

namespace CSharpSQLiteCRUD.BaseDatos
{
    public class Conexion
    {
        #region "Propiedades"
        private static string bd = "./bd_prueba.db";
        private static SQLiteConnection conn;
        #endregion

        #region "Metodos"
        public static void CrearConexion()
        {
            Conexion.conn = new SQLiteConnection();

            try
            {
                Conexion.conn.ConnectionString = $"Data Source={bd}";
            }
            catch (Exception e)
            {
                Conexion.conn = null;
                throw e;
            }
        }

        public static DataTable ProcesoConsulta(string query, string condicion = "")
        {
            CrearConexion();

            SQLiteDataReader result;
            DataTable tabla = new DataTable();
            SQLiteCommand cmd;

            try
            {
                if (String.IsNullOrEmpty(condicion)) cmd = new SQLiteCommand(query, Conexion.conn);

                else cmd = DevolverConsultaPreparada(query, condicion);

                Conexion.conn.Open();
                result = cmd.ExecuteReader();
                tabla.Load(result);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (Conexion.conn.State == ConnectionState.Open) Conexion.conn.Close();

                result = null;
            }

            return tabla;
        }

        private static SQLiteCommand DevolverConsultaPreparada(string query, string condicion)
        {
            SQLiteCommand cmd = new SQLiteCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@condicion", condicion);

            cmd.Connection = Conexion.conn;

            return cmd;
        }
        #endregion
    }
}
