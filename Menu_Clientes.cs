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
    public partial class Menu_Clientes : Form
    {
        public Menu_Clientes()
        {
            InitializeComponent();
        }

        private void necesitasAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ID_Paquete = txtID.Text;
            if (!Int32.TryParse(txtID.Text, out id_paquetes))
            {
                MessageBox.Show("La ID debe ser numerico");
            }

            Busqueda frm = new Busqueda();
            frm.Show();


            ////////////////////////////////////////////
            /*Int32 ci;
            DialogResult respuesta;
            Cliente c = new Cliente();
            c.conexion = Program.cn;
            if (!Int32.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("La ci debe ser numerica");
            }
            else
            {
                c.ci = ci;
                switch (c.Buscar())
                {
                    case 0: //encontro
                        gbBusc.Enabled = false;
                        gbDatos.Visible = true;
                        btnEliminar.Enabled = true;
                        txtName.Text = c.nombre;
                        cboFono.Items.Clear();
                        foreach (string tel in c.telefonos)
                        {
                            cboFono.Items.Add(tel);
                        }
                        break;
                    case 1: //conexion cerrada
                        MessageBox.Show("Debe logearse nuevamente");
                        break;
                    case 2://error al buscar cliente
                        MessageBox.Show("Error al buscar datos en tabla de clientes");
                        break;
                    case 3://no encontro
                        respuesta = MessageBox.Show("Desea efectuar alta?", "alta de cliente", MessageBoxButtons.YesNo);
                        if (respuesta == DialogResult.Yes)
                        {
                            gbDatos.Visible = true;
                            gbBusc.Enabled = false;
                            btnEliminar.Enabled = false;
                            txtName.Clear();
                            cboFono.Items.Clear();
                        }
                        break;
                    case 4:
                        MessageBox.Show("Error al buscar telefonos");
                        break;

                }//switch
            }//if
            c = null;//destruyo el objeto de la clase clientes
        }*/
        ///////////////////////////////////////////////////////////
    }

        private void Menu_Clientes_Load(object sender, EventArgs e)
        {

        }

        private void label_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
