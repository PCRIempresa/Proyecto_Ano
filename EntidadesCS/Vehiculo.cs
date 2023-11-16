using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    public class Vehiculo
    {
        protected Int32 matricula;
        protected String recorrido_vehiculo;
        protected String arribo_vehiculo;
        protected String partida_vehiculo;
        protected String disponibilidad;

        protected Int32 nro_camioneta;
        protected String paquete_asignado;

        protected Int32 nro_camion;
        protected String lote_asignado;
        protected ADODB.Connection Conexion;

        public Vehiculo()
        {
            matricula = 0;
            recorrido_vehiculo = "";
            arribo_vehiculo = "";
            partida_vehiculo = "";
            disponibilidad = "";

            nro_camioneta = 0;
            paquete_asignado = "";

            nro_camion = 0;
            lote_asignado = "";
            Conexion = new ADODB.Connection();
        }

        public Vehiculo (Int32 m, string rv, string av, string pv, string d, Int32 ncmta, string pa, Int32 ncmon, string la, ADODB.Connection cn)
        {
            matricula = m;
            recorrido_vehiculo = rv;
            arribo_vehiculo = av;
            partida_vehiculo = pv;
            disponibilidad = d;

            nro_camioneta = ncmta;
            paquete_asignado = pa;

            nro_camion = ncmon;
            lote_asignado = la;
            Conexion = cn;
        }

        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 Matricula
        {
            set { matricula = value; }
            get { return (matricula); }
        }

        public String Recorrido
        {
            set { recorrido_vehiculo = value; }
            get { return (recorrido_vehiculo); }
        }

        public String Arribo
        {
            set { arribo_vehiculo = value; }
            get { return (recorrido_vehiculo); }
        }

        public String Partida
        {
            set { partida_vehiculo = value; }
            get { return (partida_vehiculo); }
        }

        public String Disponibilidad
        {
            set { disponibilidad = value; }
            get { return (disponibilidad); }
        }

        public Int32 Nro_Camioneta
        {
            set { nro_camioneta = value; }
            get { return (nro_camioneta); }
        }

        public String Paquete_Asignado
        {
            set { paquete_asignado = value; }
            get { return (paquete_asignado); }
        }

        public Int32 Nro_Camion
        {
            set { nro_camion = value; }
            get { return (nro_camion); }
        }

        public String Lote_Asignado
        {
            set { lote_asignado = value; }
            get { return (lote_asignado); }
        }

        public byte Busqueda_Vehiculo()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Vehiculo, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT matricula FROM Vehiculo WHERE matricula" + matricula;
                try
                {
                    rs = Conexion.Execute(sql, out filasTabla);
                }
                catch { return (2); }//error al buscar en la tabla vehiculo


                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontro
                }
                else
                {
                    sql = "SELECT recorrido_vehiculo FROM Vehiculo WHERE recorrido_vehiculo" + recorrido_vehiculo;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (4); }// error al buscar recorrido

                    sql = "SELECT arribo_vehiculo FROM Vehiculo WHERE arribo_vehiculo" + arribo_vehiculo;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (5); }// error al buscar arribo

                    sql = "SELECT partida_vehiculo FROM Vehiculo WHERE partida_vehiculo" + partida_vehiculo;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (6); }// error al buscar partida

                    sql = "SELECT desponubilidad FROM Vehiculo WHERE disponibilidad" + disponibilidad;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (7); }// error al buscar disponibilidad

                    sql = "SELECT nro_camioneta FROM Vehiculo WHERE nro_camioneta" + nro_camioneta;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (8); }// error al buscar camioneta

                    sql = "SELECT paquete_asignado FROM Vehiculo WHERE paquete_asignado" + paquete_asignado;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (9); }// error al buscar paquete

                    sql = "SELECT nro_camion FROM Vehiculo WHERE nro_camion" + nro_camion;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (10); }// error al buscar camion

                    sql = "SELECT lote_asignado FROM Vehiculo WHERE lote_asignado" + lote_asignado;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (11); }// error al buscar lote
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
                    sql = "UPDATE Vehiculo SET recorrido_vehiculo = '" + recorrido_vehiculo + "', arribo_vehiculo = '" + arribo_vehiculo + "', partida_vehiculo = '" + partida_vehiculo + "', disponibilidad = ' " + disponibilidad + "', nro_camioneta = ' " + nro_camioneta + "', paquete_asignado = ' " + paquete_asignado + "', nro_camion = ' " + nro_camion + "', lote_asignado = ' " + lote_asignado + "', matricula = ' " + matricula + " WHEN matricula =" + matricula;
                }
                else
                {
                    sql = "INSERT INTO Vehiculo (matricula, recorrido_vehiculo, arribo_vehiculo, partida_vehiculo, disponibilidad, nro_camioneta, paquete_asignado, nro_camion, lote_asignado) VALUES('" + matricula + "', '" + recorrido_vehiculo + "', '" + arribo_vehiculo + "', '" + partida_vehiculo + "', '" + disponibilidad + "', '" + nro_camioneta + "', '" + paquete_asignado + "', '" + nro_camion + "', '" + lote_asignado + "')";
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
                sql = "DELETE FROM Vehiculo WHERE matricula = " + matricula;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Vehiculo WHERE recorrido_vehiculo = " + recorrido_vehiculo;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                sql = "DELETE FROM Vehiculo WHERE arribo_vehiculo = " + arribo_vehiculo;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 4;
                }
                sql = "DELETE FROM Vehiculo WHERE partida_vehiculo = " + partida_vehiculo;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 5;
                }
                sql = "DELETE FROM Vehiculo WHERE disponibilidad = " + disponibilidad;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 6;
                }
                sql = "DELETE FROM Vehiculo WHERE nro_camioneta = " + nro_camioneta;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 7;
                }
                sql = "DELETE FROM Vehiculo WHERE paquete_asignado = " + paquete_asignado;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 8;
                }
                sql = "DELETE FROM Vehiculo WHERE nro_camion = " + nro_camion;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 9;
                }
                sql = "DELETE FROM Vehiculo WHERE lote_asignado = " + lote_asignado;
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
