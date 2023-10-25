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
    public partial class Menu_Admin : Form
    {
        public Menu_Admin()
        {
            InitializeComponent();
        }

        private void Menu_Admin_Load(object sender, EventArgs e)
        {

            // LOS ADMINISTRADORES PUEDON ELIMINAR, MODIFICAR O AGREGAR INFORMACION DE LOS PAQUETES

            // PARA ELIMINAR USUARIO

            /* Int32 ci; DialogResult respuesta;
            Cliente c = new Cliente();
            if (!Int32.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("CI debe ser numerico");
            }
            else
            {
                c.conexion = Program.cn;
                c.ci = ci;
                respuesta = MessageBox.Show("Esta seguro?", "Eliminar cliente", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    switch (c.Eliminar())
                    {
                        case 0:
                            gbBusc.Enabled = true;
                            gbDatos.Visible = false;
                            break;
                        case 1:
                            MessageBox.Show("Debe loguearse nuevamente");
                            break;
                        default:
                            MessageBox.Show("Hubo errores al efectuar operacion. Reintente");
                            break;
                    }
                }
            } 

            PARA ELIMINAR DATOS DEL USUARIO

            byte resultado = 0;
            string sql;
            object filasafectadas;
            if(_conexion.State == 0)
            {
                resultado = 1; //conexion cerrada
            }
            else
            {
                sql = "DELETE FROM cliente_telefonos WHERE cliente = " + _ci;
                try
                {
                    _conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 2;
                }
                sql ="DELETE FROM clientes where ci=" + _ci;
                try
                {
                    _conexion.Execute(sql, out filasafectadas);
                }
                catch
                {
                    return 3;
                }
                filasafectadas = null;
            }
            return(resultado);

            */

            // PARA AGREGAR
            /* 
            string sql;
            object filasafectadas;
            byte resultado = 0; 
            if (_conexion.State == 0) //conexion con base de datos cerrada
            {
                resultado = 1;
            }
            else
            {
                if (modificacion) //start transaction: se ejecutan todas o no se ejecuta ninguna. se finaliza con commit. en cada catch habria que poner _conexion.Execute("rollboard", out filasafectadas);
                {
                    sql = "UPDATE clientes SET nombre='" + _nombre + "' WHEN ci=" + _ci;
                }
                else
                {
                    sql = "INSERT INTO clientes(ci,nombre) VALUES(" + _ci + ",'" + _nombre + "')";
                }
                try
                {
                    _conexion.Execute(sql, out filasafectadas);
                }
                catch 
                {
                    return (2);
                }
                if (modificacion)
                {
                    sql = "DELETE FROM cliente_telefonos WHERE cliente=" + _ci;
                    try
                    {
                        _conexion.Execute(sql, out filasafectadas);
                    }
                    catch
                    {
                        return (3);
                    }
                }
                foreach(string tel in _telefonos)
                {
                    sql = "INSERT INTO cliente_telefonos(cliente,telefono) VALUES(" + _ci + ",'" + tel + "')";
                    try
                    {
                        _conexion.Execute(sql, out filasafectadas);
                    }
                    catch
                    {
                        return (4);
                    }
                }
                filasafectadas = null;
            }
            return (resultado);
            */
        }
    }
}
