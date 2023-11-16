using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Año
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static MenuInicio frmMenuInicio;

        public static ADODB.Connection Conexion = new ADODB.Connection();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuInicio());

        }

        public static void AutorisoPermisos(string usuario)
        {
            ADODB.Recordset rs = new ADODB.Recordset();
            Object filasAfectadas;
            String sql;
        }
    }
}
