using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    public class Almacen
    {
        protected Int32 id_almacen;
        protected String ubi_almacen;
        protected String capacidad;
        protected ADODB.Connection Conexion;

        public Almacen()
        {
            id_almacen = 0;
            ubi_almacen = "";
            capacidad = "";
            Conexion = new ADODB.Connection();
        }

        public Almacen(Int32 id, string ua, string c, ADODB.Connection cn)
        {
            id_almacen = id;
            ubi_almacen = ua;
            capacidad = c;
            Conexion = cn;
        }

        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 ID_Almacen
        {
            set { id_almacen = value; }
            get { return (id_almacen); }
        }

        public String UBI_Almacen
        {
            set { ubi_almacen = value; }
            get { return (ubi_almacen); }
        }

        public String Capacidad
        {
            set { capacidad = value; }
            get { return (capacidad); }
        }

        public byte Busqueda_Almacen()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Almacen, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT id_almacen FROM Almacen WHERE id_almacen" + id_almacen;
                try
                {
                    rs = Conexion.Execute(sql, out filasTabla);
                }
                catch { return (2); }//error al buscar en la id


                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontro
                }
                else
                {
                    sql = "SELECT ubi_almacen FROM Almacen WHERE ubi_almacen" + ubi_almacen;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (4); }//erro al buscar la ubi

                    sql = "SELECT capacidad FROM Almacen WHERE capacidad" + capacidad;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (5); } // error al buscar la capacidad
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
                    sql = "UPDATE Almacen SET ubi_almacen = '" + ubi_almacen + "', capacidad ='" + capacidad + "', id_alamcen ='" + id_almacen + "' WHEN id_almacen =" + id_almacen;
                }
                else
                {
                    sql = "INSERT INTO Almacen (id_almacen, ubi_almacen, capacidad) VALUES('" + id_almacen + "', '" + ubi_almacen + "', '"+ capacidad +"' )";
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
                sql = "DELETE FROM Almacen WHERE ubi_almacen = " + ubi_almacen;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Alamcen where capacidad = " + capacidad;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                sql = "DELETE FROM Alamcen where id_almacen = " + id_almacen;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 4;
                }
                filasafectadas = null;
            }
            return (resultado);
        }
    }
}
