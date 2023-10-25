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
        protected String hora_ingreso;
        protected String fecha_egreso;
        protected String hora_egreso;
        protected String tamaño;
        protected String estado_paquete;
        protected ADODB.Connection _conexion;

        public Paquetes()
        {
            id_paquete = 0;
            ubi_actual = "";
            almacen_origen = "";
            direccion_destino = "";
            nota = "";
            fecha_ingreso = "";
            hora_ingreso = "";
            fecha_egreso = "";
            hora_egreso = "";
            tamaño = "";
            estado_paquete = "";
            _conexion = new ADODB.Connection();
        }
        public Paquetes(Int32 id, string ubi, string ao, string dd, string n, string fi, string hi, string fe, string he, string t, string ep, ADODB.Connection cn)
        {
            id_paquete = id;
            ubi_actual = ubi;
            almacen_origen = ao;
            direccion_destino = dd;
            nota = n;
            fecha_ingreso = fi;
            hora_ingreso = hi;
            fecha_egreso = fe;
            hora_egreso = he;
            tamaño = t;
            estado_paquete = ep;
            _conexion = cn;
        }
        public ADODB.Connection conexion
        {
            set { _conexion = value; }
            get { return (_conexion); }
        }

        public Int32 ID
        {
            set { id_paquete = value; }
            get { return id_paquete; }
        }
        public String UBI
        {
            set { ubi_actual = value; }
            get { return (ubi_actual); }
        }
        public String Almacen
        {
            set { almacen_origen = value; }
            get { return almacen_origen; }
        }
        public String Direccion
        {
            set { direccion_destino = value; }
            get { return direccion_destino; }
        }

        public String Nota
        {
            set { nota = value; }
            get { return nota; }
        }
        public String FechaIngreso
        {
            set { fecha_ingreso = value; }
            get { return fecha_ingreso; }
        }
        public String HoraIngreso
        {
            set { hora_ingreso = value; }
            get { return hora_ingreso; }
        }
        public String FechaEgreso
        {
            set { fecha_egreso = value; }
            get { return fecha_egreso; }
        }
        public String HoraEgreso
        {
            set { hora_egreso = value; }
            get { return hora_egreso; }
        }
        public String Tamaño
        {
            set { tamaño = value; }
            get { return tamaño; }
        }
        public String EstadoPaquete
        {
            set { estado_paquete = value; }
            get { return estado_paquete; }
        }
    }
}
