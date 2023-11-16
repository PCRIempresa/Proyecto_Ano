using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private string server = "127.0.0.1";
        private string database = "entrega";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public Conexion ()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;
        }

        public MySqlConnection EstablecerConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;
        }
    }
}
