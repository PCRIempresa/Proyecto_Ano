using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    public class Lotes
    {
        protected Int32 id_lote;
        protected String origen;
        protected String destino;
        protected String ubi_actual;
        protected Int32 cantidad_paquetes;
        protected String tipo_lote;
        protected String fecha_preparacion;
        protected String estado_lote;
        protected ADODB.Connection Conexion;

        public Lotes()
        {
            id_lote = 0;
            origen = "";
            destino = "";
            ubi_actual = "";
            cantidad_paquetes = 0;
            tipo_lote = "";
            fecha_preparacion = "";
            estado_lote = "";
            Conexion = new ADODB.Connection();
        }

        public Lotes(Int32 id, string o, string d, string ubi, Int32 cp, string tp, string fp, string el, ADODB.Connection cn)
        {
            id_lote = id;
            origen = o;
            destino = d;
            ubi_actual = ubi;
            cantidad_paquetes = cp;
            tipo_lote = tp;
            fecha_preparacion = fp;
            estado_lote = el;
            Conexion = cn;
        }

        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 ID_Lote
        {
            set { id_lote = value; }
            get { return (id_lote); }
        }

        public String Origen_Lote
        {
            set { origen = value; }
            get { return (origen); }
        }

        public String Destino
        {
            set { destino = value; }
            get { return (destino); }
        }

        public String Ubicación_Lote
        {
            set { ubi_actual = value; }
            get { return (ubi_actual); }
        }

        public Int32 Paquetes_Lotes
        {
            set { cantidad_paquetes = value; }
            get { return (cantidad_paquetes); }
        }

        public String Tipo_Lote
        {
            set { tipo_lote = value; }
            get { return (tipo_lote); }
        }

        public String Fecha_Preparación
        {
            set { fecha_preparacion = value; }
            get { return (fecha_preparacion); }
        }

        public String Estado_Lote
        {
            set { estado_lote = value; }
            get { return (estado_lote); }
        }

        public byte Busqueda_Lotes()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Lotes, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT id_lote FROM Lote WHERE ID" + id_lote;
                try
                {
                    rs = Conexion.Execute(sql, out filasTabla);
                }
                catch { return (2); }//error al buscar en la tabla paquetes


                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontro
                }
                else
                {
                    sql = "SELECT origen FROM Lote WHERE Origen" + origen;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (4); } // error al buscar origen

                    sql = "SELECT destino FROM Lote WHERE destino" + destino;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (5); } // error al buscar destino

                    sql = "SELECT ubi_actual FROM Lote WHERE ubi_actual" + ubi_actual;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (6); } // error al buscar ubi

                    sql = "SELECT cantidad_paquetes FROM Lote WHERE cantidad_paquetes" + cantidad_paquetes;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (7); } // error al buscar cantidad

                    sql = "SELECT tipo_lote FROM Lote WHERE tipo_lote" + tipo_lote;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (8); } // error al buscar tipo

                    sql = "SELECT estado_lote FROM Lote WHERE estado_lote" + estado_lote;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (9); } // error al buscar estado

                    sql = "SELECT fecha_preparacion FROM Lote WHERE fecha_preparacion" + fecha_preparacion;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (10); } // error al buscar fecha

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
                    sql = "UPDATE Lotes SET origen = '" + origen + "', destino = '" + destino + "', ubi_actual = '" + ubi_actual + "', cantidad_paquetes = ' " + cantidad_paquetes + "', tipo_lote = ' " + tipo_lote + "', fecha_preparacion = ' " + fecha_preparacion + "', estado_lote = ' " + estado_lote + "', id_lote = ' " + id_lote + "' WHEN id_lote =" + id_lote;
                }
                else
                {
                    sql = "INSERT INTO Lotes (id_lote, origen, destino, ubi_actual, cantidad_paquetes, tipo_lote, fecha_preparacion, estado_lote) VALUES('" + id_lote + "', '" + origen + "', '" + destino + "', '" + ubi_actual + "', '" + cantidad_paquetes + "', '" + tipo_lote + "', '" + fecha_preparacion + "', '" + estado_lote + "')";
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
                sql = "DELETE FROM Lotes WHERE origen = " + origen;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Lotes WHERE destino = " + destino;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                sql = "DELETE FROM Lotes WHERE ubi_actual = " + ubi_actual;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 4;
                }
                sql = "DELETE FROM Lotes WHERE cantidad_paquetes = " + cantidad_paquetes;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 5;
                }
                sql = "DELETE FROM Lotes WHERE tipo_lote = " + tipo_lote;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 6;
                }
                sql = "DELETE FROM Lotes WHERE fecha_preparacion = " + fecha_preparacion;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 7;
                }
                sql = "DELETE FROM Lotes WHERE estado_lote = " + estado_lote;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 8;
                }
                
                filasafectadas = null;
            }
            return (resultado);
        }
    }
}
