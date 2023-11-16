using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    internal class Usuarios
    {
        protected Int32 CI;
        protected String nombre_usuario;
        protected List<string> Telefonos;
        protected String correo;
        protected String contraseña;
        protected String estado;
        protected String rol;

        protected Int32 id_conductor;
        protected String almacen_designado;
        protected String licencia_conducir;

        protected Int32 id_admin;
        protected ADODB.Connection Conexion;

     public Usuarios()
        {
            CI = 0;
            nombre_usuario = "";
            Telefonos = new List<string>();
            correo = "";
            contraseña = "";
            estado = "";
            rol = "";

            id_conductor = 0;
            almacen_designado = "";
            licencia_conducir = "";

            id_admin = 0;
            Conexion = new ADODB.Connection();
        }
        public Usuarios(Int32 c, string n, List<string> t, string email, string pasword, string e, string r, Int32 idc, string ad, string lc, Int32 ida, ADODB.Connection cn)
        {
            CI = c;
            nombre_usuario = n;
            Telefonos = t;
            correo = email;
            contraseña = pasword;
            estado = e;
            rol = r;

            id_conductor = idc;
            almacen_designado = ad;
            licencia_conducir = lc;

            id_admin = ida;
            Conexion = cn;
        }
        public ADODB.Connection Conectar
        {
            set { Conexion = value; }
            get { return (Conexion); }
        }

        public Int32 ci
        {
            set { CI = value; }
            get { return (CI); }
        }
        public String nombre
        {
            set { nombre_usuario = value; }
            get { return (nombre_usuario); }
        }
        public List<string> telefonos
        {
            set { Telefonos = value; }
            get { return (Telefonos); }
        }

        public String Correo
        {
            set { correo = value; }
            get { return (correo); }
        }

        public String Contraseña
        {
            set { contraseña = value; }
            get { return (contraseña); }
        }

        public String Estado
        {
            set { estado = value; }
            get { return (estado); }
        }

        public String Rol
        {
            set { rol = value; }
            get { return (rol); }
        }

        public String Almacen_Conductor
        {
            set { almacen_designado = value; }
            get { return (almacen_designado); }
        }

        public String Licencia_Conducir
        {
            set { licencia_conducir = value; }
            get { return (licencia_conducir); }
        }

        public Int32 ID_Conductor
        {
            set { id_conductor = value; }
            get { return (id_conductor); }
        }

        public Int32 ID_Administrador
        {
            set { id_admin = value; }
            get { return (id_admin); }
        }
        public byte Busqueda_Usuarios()
        {
            String sql;
            ADODB.Recordset rs;
            Object filasTabla;
            byte resultado = 0; //0 cuando encontre, 1 cuando conexion cerada, 2 cuando error al buscar en tabla Usuarios, 3 cuando no encontre
            if (Conexion.State == 0)
            {
                resultado = 1;
            }
            else
            {
                sql = "SELECT C.I FROM Usuario WHERE C.I" + CI;
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
                    sql = "SELECT nombre_usuario FROM Usuario WHERE Nombre" + nombre_usuario;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (4); }// error al buscar nombre

                    sql = "SELECT Telefonos FROM Usuario WHERE Telefono" + Telefonos;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (5); }// error al buscar telefono

                    sql = "SELECT email FROM Usuario WHERE email" + correo;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (6); }// error al buscar correo

                    sql = "SELECT contraseña FROM Usuario WHERE contraseña" + contraseña;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (7); }// error al buscar contraseña

                    sql = "SELECT estado FROM Usuario WHERE estado" + estado;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (8); }// error al buscar estado

                    sql = "SELECT rol FROM Usuario WHERE rol" + rol;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (9); }// error al buscar rol

                    sql = "SELECT almacen_designado FROM Usuario WHERE almacen_designado" + almacen_designado;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (10); }// error al buscar almacen

                    sql = "SELECT licencia_conducir FROM Usuario WHERE licencia_conducir" + licencia_conducir;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (11); }// error al buscar licencia

                    sql = "SELECT id_conductor FROM Usuario WHERE id_conductor" + id_conductor;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (12); }// error al buscar conductor

                    sql = "SELECT id_admin FROM Usuario WHERE id_admin" + id_admin;
                    try
                    {
                        rs = Conexion.Execute(sql, out filasTabla);
                    }
                    catch { return (13); }// error al buscar administrador
                }
            }
            return (resultado);
        }

        public byte Registrar_Usuarios(bool enabled)
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
                sql = "INSERT INTO Usuarios (CI,nombre_usuario,contraseña,telefono)  VALUES('"+ CI + "', '" + nombre_usuario + "', '" + contraseña + "', '" + telefonos + "', )";
                   // sql = "UPDATE Usuarios SET CI = 1 WHERE CI = 2";
                try
                {
                    Conexion.Execute(sql, out filasafectadas); // HAY CONEXION
                }
                catch { return (2); }
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
                    sql = "UPDATE Usuarios SET nombre_usuario = '" + nombre_usuario + "', Telefonos = '" + Telefonos + "', correo = '" + correo + "', contraseña = ' " + contraseña + "', estado = ' " + estado + "', rol = ' " + rol + "', id_conductor = ' " + id_conductor + "', almacen_designado = ' " + almacen_designado + "', licencia_conducir = ' " + licencia_conducir + "', id_admin = ' " + id_admin + "', CI = ' " + CI + "' WHEN CI =" + CI;
                }
                else
                {
                    sql = "INSERT INTO Usuarios (CI, nombre_usuario, Telefonos, correo, contraseña, estado, rol, id_conductor, almacen_designado, licencia_conducir, id_admin) VALUES('" + CI + "', '" + nombre + "', '" + Telefonos + "', '" + correo + "', '" + contraseña + "', '" + estado + "', '" + rol + "', '" + id_conductor + "', '" + almacen_designado + "', '" + licencia_conducir + "', '" + id_admin + ")";
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
                sql = "DELETE FROM Usuarios WHERE nombre_usuario = " + nombre_usuario;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql = "DELETE FROM Usuarios WHERE Telefonos = " + Telefonos;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                sql = "DELETE FROM Usuarios WHERE correo = " + correo;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 4;
                }
                sql = "DELETE FROM Usuarios WHERE contraseña = " + contraseña;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 5;
                }
                sql = "DELETE FROM Usuarios WHERE estado = " + estado;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 6;
                }
                sql = "DELETE FROM Usuarios WHERE rol = " + rol;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 7;
                }
                sql = "DELETE FROM Usuarios WHERE id_conductor = " + id_conductor;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 8;
                }
                sql = "DELETE FROM Usuarios WHERE almacen_designado = " + almacen_designado;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 9;
                }
                sql = "DELETE FROM Usuarios WHERE licencia_conducir = " + licencia_conducir;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 10;
                }
                sql = "DELETE FROM Usuarios WHERE id_admin = " + id_admin;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 11;
                }
                sql = "DELETE FROM Usuarios WHERE CI = " + CI;
                try
                {
                    Conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 12;
                }
                filasafectadas = null;
            }
            return (resultado);
        }
    }
}
