using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    internal class Paquetes
    {
        protected Int32 id_paquete;
        protected String ubi_actual;
        protected String almacen_origen;
        protected String direccion_destino;
        protected String nota;
        protected String fecha_ingreso;
        protected String fecha_egreso;
        protected String tamaño;
        protected String estado_paquete;
        protected ADODB.Connection Conexion;

        public Paquetes()
        {
            id_paquete = 0;
            ubi_actual = "";
            almacen_origen = "";
            direccion_destino = "";
            nota = "";
            fecha_ingreso = "";
            fecha_egreso = "";
            tamaño = "";
            estado_paquete = "";
            Conexion = new ADODB.Connection();
        }
        public Paquetes(Int32 id, string ubi, string ao, string dd, string n, string fi, string fe, string t, string ep, ADODB.Connection cn)
        {
            id_paquete = id;
            ubi_actual = ubi;
            almacen_origen = ao;
            direccion_destino = dd;
            nota = n;
            fecha_ingreso = fi;
            fecha_egreso = fe;
            tamaño = t;
            estado_paquete = ep;
            Conexion = cn;
        }
        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 ID_Paquete
        {
            set { id_paquete = value; }
            get { return id_paquete; }
        }
        public String UBI_Paquete
        {
            set { ubi_actual = value; }
            get { return (ubi_actual); }
        }
        public String Almacen_Paquete
        {
            set { almacen_origen = value; }
            get { return almacen_origen; }
        }
        public String Direccion_Paquete
        {
            set { direccion_destino = value; }
            get { return direccion_destino; }
        }

        public String Nota_Paquete
        {
            set { nota = value; }
            get { return nota; }
        }
        public String FechaIngreso_Paquete
        {
            set { fecha_ingreso = value; }
            get { return fecha_ingreso; }
        }
       
        public String FechaEgreso_Paquete
        {
            set { fecha_egreso = value; }
            get { return fecha_egreso; }
        }
       
        public String Tamaño_Paquete
        {
            set { tamaño = value; }
            get { return tamaño; }
        }
        public String Estado_Paquete
        {
            set { estado_paquete = value; }
            get { return estado_paquete; }
        }
        public byte Busqueda_Paquetes()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Paquetes, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT id_paquete FROM Paquete WHERE id_paquete" + id_paquete;
                try
                {
                    rs = Conexion.Execute(sql, out filasTabla);
                }catch { return (2); }//error al buscar en la tabla paquetes


                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontro
                }else
                {
                    sql = "SELECT almacen_origen FROM Paquete WHERE Origen" + almacen_origen;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }catch { return (4); } // error al buscar almacen

                    sql = "SELECT direcion_destino FROM Paquete WHERE Destino" + direccion_destino;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (5); }// error al buscar direccion

                    sql = "SELECT fecha_egreso FROM Paquete WHERE Fecha" + fecha_egreso;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (6); }// error al buscar fecha

                    sql = "SELECT nota FROM Paquete WHERE nota" + nota;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (7); }// error al buscar nota

                    sql = "SELECT ubi_actual FROM Paquete WHERE Ubicacion" + ubi_actual;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (8); }// error al buscar ubi

                    sql = "SELECT estado_paquete FROM Paquete WHERE Estado" + estado_paquete;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (9); }// error al buscar estado

                    sql = "SELECT fecha_ingreso FROM Paquete WHERE fecha_ingreso" + fecha_ingreso;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (10); }// error al buscar fecha

                    sql = "SELECT tamaño FROM Paquete WHERE tamaño" + tamaño;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (11); }// error al buscar tamaño
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
                    sql = "UPDATE Paquetes SET ubi_actual = '" + ubi_actual + "', almacen_origen = '" + almacen_origen + "', direccion_destino = '" + direccion_destino + "', nota = ' " + nota + "', fecha_ingreso = ' " + fecha_ingreso + "', fecha_egreso = ' " + fecha_egreso + "', tamaño = ' " + tamaño + "', estado_paquete = ' " + estado_paquete + "', id_paquete = ' " + id_paquete + "' WHEN id_paquete =" + id_paquete;
                }
                else
                {
                    sql = "INSERT INTO Paquetes (id_paquete, ubi_actual, almacen_origen, direccion_destino, nota, fecha_ingreso, fecha_egreso, tamaño, estado_paquete) VALUES('" + id_paquete + "', '" + ubi_actual + "', '" + almacen_origen + "', '" + direccion_destino + "', '" + nota + "', '" + fecha_ingreso + "', '" + fecha_egreso + "', '" + tamaño + "', '" + estado_paquete + "')";
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
                sql = "DELETE FROM Paquetes WHERE ubi_actual = " + ubi_actual;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Paquetes WHERE almacen_origen = " + almacen_origen;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                sql = "DELETE FROM Paquetes WHERE direccion_destino = " + direccion_destino;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 4;
                }
                sql = "DELETE FROM Paquetes WHERE nota = " + nota;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 5;
                }
                sql = "DELETE FROM Paquetes WHERE fecha_ingreso = " + fecha_ingreso;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 6;
                }
                sql = "DELETE FROM Paquetes WHERE fecha_egreso = " + fecha_egreso;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 7;
                }
                sql = "DELETE FROM Paquetes WHERE tamaño = " + tamaño;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 8;
                }
                sql = "DELETE FROM Paquetes WHERE estado_paquete = " + estado_paquete;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 9;
                }
                sql = "DELETE FROM Paquetes WHERE id_paquetes = " + id_paquete;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 10;
                }
                filasafectadas = null;
            }
            return (resultado);
        }
    }
}
