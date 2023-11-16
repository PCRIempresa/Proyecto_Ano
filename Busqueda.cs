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
    public partial class Busqueda : Form
    {
        
        public Busqueda()
        {
            InitializeComponent();
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            
        }

        private void labelNumero_2_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            int id = paquetes.ID_Paquete;
            labelNumero_2.Text = id.ToString();
        }

        private void labelOrigen_2_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            string origen = paquetes.Almacen_Paquete;
            labelOrigen_2.Text = origen;
        }

        private void labelUbicacion_2_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            string ubicacion = paquetes.UBI_Paquete;
            labelUbicacion_2.Text = ubicacion;
        }

        private void labelDestino_2_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            string destino = paquetes.Direccion_Paquete;
            labelDestino_2.Text = destino;
        }

        private void labelFecha_2_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            string Fecha = paquetes.FechaEgreso_Paquete;
            labelFecha_2.Text = Fecha;
        }

        private void labelEstado_2_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            string estado = paquetes.Estado_Paquete;
            labelEstado_2.Text = estado;
        }

        private void necesitasAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactarAAtecionAlClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si la información de su pedido no aparece o es incirrecta contacte a Atencion al Clente a traves de estos numeros: 097 225 741 - 092 321 456");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Clientes frmClientes = new Menu_Clientes();
            frmClientes.Show();
            this.Close();
        }
    }
}
