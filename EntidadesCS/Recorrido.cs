using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    public class Recorrido
    {
        protected Int32 id_recorrido;
        protected String rutas;
        protected ADODB.Connection Conexion;

        public Recorrido()
        {
            id_recorrido = 0;
            rutas = "";
            Conexion = new ADODB.Connection();
        }

        public Recorrido (Int32 id, string r, ADODB.Connection cn)
        {
            id_recorrido = id;
            rutas = r;
            Conexion = cn;
        }

        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 ID_Recorrido
        {
            set { id_recorrido = value; }
            get { return (id_recorrido); }
        }

        public String Rutas
        {
            set { rutas = value; }
            get { return (rutas); }
        }

        public byte Busqueda_Recorrido()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Recorrido, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT id_recorrido FROM Recorrido WHERE id_recorrido" + id_recorrido;
                try
                {
                    rs = Conexion.Execute(sql, out filasTabla);
                }
                catch { return (2); }//error al buscar en la tabla recorrido


                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontro
                }
                else
                {
                    sql = "SELECT rutas FROM Recorrido WHERE rutas" + rutas;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (4); }// error al buscar rutas
                }
            }
            return (resultado);
        }

        public byte SubirModificarInfo(Boolean Operacion)
        {
            string sql;
            object filasafectadas;
            byte resultado = 0;
            if (Conexion.State == 0) //conexion con base de datos cerrada
            {
                resultado = 1;
            }
            else
            {
                if (Operacion) //start transaction: se ejecutan todas o no se ejecuta ninguna. se finaliza con commit. en cada catch habria que poner _conexion.Execute("rollboard", out filasafectadas);
                {
                    sql = "UPDATE Recorrido SET rutas = '" + rutas + "', id_recorrido = '" + id_recorrido + "' WHEN id_recorrido =" + id_recorrido;
                }
                else
                {
                    sql = "INSERT INTO Recorrido (id_recorrido, rutas) VALUES('" + id_recorrido + "', '" + rutas + "' )";
                }
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return (2);
                }
                filasafectadas = null;
            }
            return (resultado);
        }

        public byte Eliminar()
        {
            byte resultado = 0;
            string sql;
            object filasafectadas;
            if (Conexion.State == 0)
            {
                resultado = 1; //conexion cerrada
            }
            else
            {
                sql = "DELETE FROM Recorrido WHERE rutas = " + rutas;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Recorrido WHERE id_recorrido = " + id_recorrido;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                
                filasafectadas = null;
            }
            return (resultado);
        }
    }
}
