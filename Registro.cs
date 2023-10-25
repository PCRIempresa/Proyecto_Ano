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
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*Cliente c = new Cliente();
            Int32 ci;
            if (!Int32.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("La CI debe tener formato numerico");
            }
            else
            {
                c.conexion = Program.cn; //para que trabaje con esa base de datos, la abrimos en el login y se la pasamos
                c.ci = ci;
                c.nombre = txtName.Text;
                foreach (String tel in cboFono.Items)
                {
                    c.telefonos.Add(tel);
                }
                switch (c.Guardar(btnEliminar.Enabled)) //esta habilitado en la modificacion e inhabilitado en el alta
                {
                    case 0:
                        gbBusc.Enabled = true;
                        gbDatos.Visible = false;
                        break;
                    case 1:
                        MessageBox.Show("Debe ingresar nuevamente");
                        break;
                    case 2:
                        MessageBox.Show("Error 2. Si puede, comuniquese con el administrador");
                        break;
                    case 3:
                        MessageBox.Show("Error 3. Si puede, comuniquese con el administrador");
                        break;
                    case 4:
                        MessageBox.Show("Hubo errores al efectuar operacion");
                        break;
                }//switch
            }// if 
            c = null;
            */
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
