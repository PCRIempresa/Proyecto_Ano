using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Año
{
    internal class Usuarios
    {
        protected Int32 _ci;
        protected String _nombre;
        protected Int32 _id_usuario;
        protected String _direccion;
        protected List<string> _telefonos;
        protected ADODB.Connection _conexion;

     public Usuarios()
        {
            _ci = 0;
            _nombre = "";
            _id_usuario = 0;
            _direccion = "";
            _telefonos = new List<string>();
            _conexion = new ADODB.Connection();
        }
        public Usuarios(Int32 c, string n, Int32 id, List<string> t, string d, ADODB.Connection cn)
        {
            _ci = c;
            _nombre = n;
            _id_usuario = id;
            _telefonos = t;
            _direccion = d;
            _conexion = cn;
        }
        public ADODB.Connection conexion
        {
            set { _conexion = value; }
            get { return (_conexion); }
        }

        public Int32 ci
        {
            set { _ci = value; }
            get { return _ci; }
        }
        public String nombre
        {
            set { _nombre = value; }
            get { return (_nombre); }
        }
        public Int32 IdUsuario
        {
            set { _id_usuario = value; }
            get { return _id_usuario; }
        }
        public List<string> telefonos
        {
            set { _telefonos = value; }
            get { return _telefonos; }
        }

        public String direccion
        {
            set { _direccion = value; }
            get { return _direccion; }
        }
       
    }
}
