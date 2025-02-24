using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------------------------------ Recursos SQL
using System.Data.SqlClient;
using System.Data.SQLite;

namespace CSharpSQLiteCRUD.Modelo
{
    public class Conexion
    {
        //------------------------------------ Campos de clase
        private string bd;

        private static Conexion _conn = null;
        public static Conexion conn
        {
            get
            {
                if (_conn is null)
                {
                    _conn = new Conexion();
                }
                return _conn;
            }
        }

        //------------------------------------ Método constructor
        private Conexion()
        {
            this.bd = "./bd_prueba.db";
        }

        public SQLiteConnection CrearConexion()
        {
            SQLiteConnection conn = new SQLiteConnection();

            try
            {
                conn.ConnectionString = $"Data Source={this.bd}";
            }
            catch (Exception e)
            {
                conn = null;
                throw e;
            }

            return conn;
        }
    }
}
