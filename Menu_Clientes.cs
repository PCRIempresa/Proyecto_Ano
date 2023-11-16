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
            Int32 id;
            Paquetes paquetes = new Paquetes();
            paquetes.Conectar = Program.Conexion;

            if (!Int32.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("La ID debe ser numerico");
            }
            else
            {
                paquetes.ID_Paquete = id;
         
                Busqueda frmBuscar = new Busqueda();
                frmBuscar.labelNumero_2.Text = "" + paquetes.ID_Paquete;
                frmBuscar.labelOrigen_2.Text = "" + paquetes.Almacen_Paquete;
                frmBuscar.labelDestino_2.Text = "" + paquetes.Direccion_Paquete;
                frmBuscar.labelFecha_2.Text = "" + paquetes.FechaEgreso_Paquete;
                frmBuscar.labelUbicacion_2.Text = "" + paquetes.UBI_Paquete;
                frmBuscar.labelEstado_2.Text = "" + paquetes.Estado_Paquete;
                frmBuscar.Show();
                this.Close();
            }

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

        private void guiaDeLaVentanaActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted debe ingresar el codigo del producto que compro para que el sistema pueda buscar toda la informacion actualizada que usted necesita. Si no posee deicho codigo el sistema no podra ayudarlo, le recomendamos que llame a atencion al cliente para consultar por la obtencion del codigo de su producto obtenido.");
        }

        private void contactarAlSoporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En caso de un mal funcionamiento le recomendamos cerrar y volver a iniciar el programa. Si el problema perciste contacte a los siguientes numeros de Quick Carry: 095 147 896 - 098 369 874");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuInicio frmInicio = new MenuInicio();
            frmInicio.Show();
            this.Close();
            
        }
    }
}
