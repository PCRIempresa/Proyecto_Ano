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

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Operaciones frmOperaciones = new Menu_Operaciones();
            frmOperaciones.Show();
            this.Close();
        }

        private void necesitasAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si eres administrador tendras hablilitado el boton BUSCAR para buscar toda la informacion que nececites utilizando la CI o ID de las entidades dentro del sistema colocandolas en sus respectivos lugares");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Funcionarios frmFuncionarios = new Menu_Funcionarios();
            frmFuncionarios.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 id_Paquete;
            Int32 id_Almacen;
            Int32 id_Localidad;
            Int32 id_Lote;
            Int32 id_Recorrido;
            Int32 Ci_Usuario;
            Int32 Matricula;
            Paquetes paquetes = new Paquetes();
            Almacen almacen = new Almacen();
            Localidad localidad = new Localidad();
            Lotes lote = new Lotes();
            Recorrido recorrido = new Recorrido();
            Usuarios usuario = new Usuarios();
            Vehiculo vehiculo = new Vehiculo();
            paquetes.Conectar = Program.Conexion;
            almacen.Conectar = Program.Conexion;
            localidad.Conectar = Program.Conexion;
            lote.Conectar = Program.Conexion;
            recorrido.Conectar = Program.Conexion;
            usuario.Conectar = Program.Conexion;
            vehiculo.Conectar = Program.Conexion;

            if (!Int32.TryParse(txtPaquetes.Text, out id_Paquete))
            {
                MessageBox.Show("La ID debe ser numerico");
            }
            else
            {
                paquetes.ID_Paquete = id_Paquete;

                listBoxAdministrador.Items.Add(paquetes.ID_Paquete);
                listBoxAdministrador.Items.Add(paquetes.Almacen_Paquete);
                listBoxAdministrador.Items.Add(paquetes.Direccion_Paquete);
                listBoxAdministrador.Items.Add(paquetes.FechaEgreso_Paquete);
                listBoxAdministrador.Items.Add(paquetes.UBI_Paquete);
                listBoxAdministrador.Items.Add(paquetes.Estado_Paquete);
                listBoxAdministrador.Items.Add(paquetes.Nota_Paquete);
                listBoxAdministrador.Items.Add(paquetes.FechaIngreso_Paquete);
                listBoxAdministrador.Items.Add(paquetes.Tamaño_Paquete);
            }
        }
    }
}
