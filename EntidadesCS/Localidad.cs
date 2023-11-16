using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    public class Localidad
    {
        protected Int32 id_localidad;
        protected String nombre;
        protected String departamento;
        protected String pais;
        protected String ciudad;
        protected String calle;
        protected String esquina;
        protected ADODB.Connection Conexion;

        public Localidad ()
        {
            id_localidad = 0;
            nombre = "";
            departamento = "";
            pais = "";
            ciudad = "";
            calle = "";
            esquina = "";
            Conexion = new ADODB.Connection();
        }

        public Localidad (Int32 id, string n, string d, string p, string ci, string ca, string e, ADODB.Connection cn)
        {
            id_localidad = id;
            nombre = n;
            departamento = d;
            pais = p;
            ciudad = ci;
            calle = ca;
            esquina = e;
            Conexion = cn;
        }

        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 ID_Local
        {
            set { id_localidad = value; }
            get { return (id_localidad); }
        }

        public String Nombre
        {
            set { nombre = value; }
            get { return (nombre); }
        }

        public String  Pais
        {
            set { pais = value; }
            get { return (pais); }
        }

        public String Ciudad
        {
            set { calle = value; }
            get { return (calle); }
        }

        public String Calle
        {
            set { calle = value; }
            get { return (calle); }
        }

        public String Esquina
        {
            set { calle = value; }
            get { return (calle); }
        }

        public byte Busqueda_Localidad()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Localidad, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT id_localidad FROM Localidad WHERE id_localidad" + id_localidad;
                try
                {
                    rs = Conexion.Execute(sql, out filasTabla);
                }
                catch { return (2); }//error al buscar en la tabla localidad


                if (rs.RecordCount == 0)
                {
                    resultado = 3; //no encontro
                }
                else
                {
                    sql = "SELECT nombre FROM Localidad WHERE nombre" + nombre;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (4); } // error al buscar nombre

                    sql = "SELECT departamento FROM Localidad WHERE departamento" + departamento;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (5); } // error al buscar departamento

                    sql = "SELECT pais FROM Localidad WHERE pais" + pais;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (6); } // error al buscar pais

                    sql = "SELECT ciudad FROM Localidad WHERE ciudad" + ciudad;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (7); } // error al buscar ciudad

                    sql = "SELECT calle FROM Localidad WHERE calle" + calle;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (8); } // error al buscar calle

                    sql = "SELECT esquina FROM Localidad WHERE esquina" + esquina;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (9); } // error al buscar esquina
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
                    sql = "UPDATE Localidad SET nombre = '" + nombre + "', departamento = '" + departamento + "', pais = '" + pais + "', ciudad = ' " + ciudad + "', calle = ' " + calle + "', esquina = ' " + esquina + "', id_localidad = ' " + id_localidad + "' WHEN id_localidad =" + id_localidad;
                }
                else
                {
                    sql = "INSERT INTO Localidad (id_localidad, nombre, departamento, pais, ciudad, calle, esquina) VALUES('" + id_localidad + "', '" + nombre + "', '" + departamento + "', '" + pais + "', '" + ciudad + "', '" + calle + "', '" + esquina + "')";
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
                sql = "DELETE FROM Localidad WHERE nombre = " + nombre;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Localidad WHERE departamento = " + departamento;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                sql = "DELETE FROM Localidad WHERE pais = " + pais;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 4;
                }
                sql = "DELETE FROM Localidad WHERE ciudad = " + ciudad;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 5;
                }
                sql = "DELETE FROM Localidad WHERE calle = " + calle;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 6;
                }
                sql = "DELETE FROM Localidad WHERE esquina = " + esquina;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 7;
                }
                sql = "DELETE FROM Localidad WHERE id_localidad = " + id_localidad;
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
