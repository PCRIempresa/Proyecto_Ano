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
    public partial class Menu_Operaciones : Form
    {
        public Menu_Operaciones()
        {
            InitializeComponent();
        }

        private void Menu_Subir_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnSubirRecorrido_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalidadPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Admin frmAdministrador = new Menu_Admin();
            frmAdministrador.Show();
            this.Close();
        }

        public void btnSubirPaquete_Click(object sender, EventArgs e)
        {
            Int32 id;
            Paquetes paquetes = new Paquetes();
            paquetes.Conectar = Program.Conexion;

            if (!Int32.TryParse(txtIDPaquete.Text, out id))
            {
                MessageBox.Show("La ID debe ser numerico");
            }
            else
            {
                paquetes.ID_Paquete = id;

                txtPaqueteUbicacion.Text = "" + paquetes.UBI_Paquete;
                txtPaqueteAlmacen.Text = "" + paquetes.Almacen_Paquete;
                txtPaqueteDestino.Text = "" + paquetes.Direccion_Paquete;
                txtPaqueteNota.Text = "" + paquetes.Nota_Paquete;
                txtPaqueteIngreso.Text = "" + paquetes.FechaIngreso_Paquete;
                txtPaqueteEgreso.Text = "" + paquetes.FechaEgreso_Paquete;
                txtPaqueteTamaño.Text = "" + paquetes.Tamaño_Paquete;
                txtPaqueteEstado.Text = "" + paquetes.Estado_Paquete;

                switch (paquetes.Busqueda_Paquetes())
                {
                    case 0:
                        btnBuscarPaquete.Enabled = true;
                        Int32.TryParse(txtIDPaquete.Text, out id);
                        paquetes.ID_Paquete = id;
                        break;
                    case 2:
                        MessageBox.Show("No existe datos al repecto sobre la ID del Paquete");
                        break;
                    case 4:
                        MessageBox.Show("No existe datos al repecto sobre el Almacen de Origen del Paquete");
                        break;
                    case 5:
                        MessageBox.Show("No existe datos al repecto sobre el Destino del Paquete");
                        break;
                    case 6:
                        MessageBox.Show("No existe datos al repecto sobre la Fecah de Salida del Paquete");
                        break;
                    case 7:
                        MessageBox.Show("No existe datos al repecto sobre la algun dato extra del Paquete");
                        break;
                    case 8:
                        MessageBox.Show("No existe datos al repecto sobre la Ubicacion del Paquete");
                        break;
                    case 9:
                        MessageBox.Show("No existe datos al repecto sobre el Estado del Paquete");
                        break;
                    case 10:
                        MessageBox.Show("No existe datos al repecto sobre la el Ingreso del Paquete");
                        break;
                    case 11:
                        MessageBox.Show("No existe datos al repecto sobre el Tamaño del Paquete");
                        break;
                }
            }
        }

        private void btnModificarPaquete_Click(object sender, EventArgs e)
        {
            Paquetes paquetes = new Paquetes();
            paquetes.Conectar = Program.Conexion;
            Int32 id;
            if (!Int32.TryParse(txtIDPaquete.Text, out id))
            {
                MessageBox.Show("La ID debe tener formato numerico");
            }
            else
            {
                paquetes.Conectar = Program.Conexion; //para que trabaje con esa base de datos, la abrimos en el login y se la pasamos
                paquetes.ID_Paquete = id;
                paquetes.UBI_Paquete = txtPaqueteUbicacion.Text;
                paquetes.Almacen_Paquete = txtPaqueteAlmacen.Text;
                paquetes.Direccion_Paquete = txtPaqueteDestino.Text;
                paquetes.Nota_Paquete = txtPaqueteNota.Text;
                paquetes.FechaIngreso_Paquete = txtPaqueteIngreso.Text;
                paquetes.FechaEgreso_Paquete = txtPaqueteEgreso.Text;
                paquetes.Tamaño_Paquete = txtPaqueteTamaño.Text;
                paquetes.Estado_Paquete = txtPaqueteEstado.Text;
            }// if 
        }

        private void btnEliminarPaquete_Click(object sender, EventArgs e)
        {
            Int32 id;
            DialogResult respuesta;
            Paquetes paquetes = new Paquetes();
            if (!Int32.TryParse(txtIDPaquete.Text, out id))
            {
                MessageBox.Show("ID debe ser numerico");
            }
            else
            {
                paquetes.Conectar = Program.Conexion;
                paquetes.ID_Paquete = id;
                paquetes.UBI_Paquete = txtPaqueteUbicacion.Text;
                paquetes.Almacen_Paquete = txtPaqueteAlmacen.Text;
                paquetes.Direccion_Paquete = txtPaqueteDestino.Text;
                paquetes.Nota_Paquete = txtPaqueteNota.Text;
                paquetes.FechaIngreso_Paquete = txtPaqueteIngreso.Text;
                paquetes.FechaEgreso_Paquete = txtPaqueteEgreso.Text;
                paquetes.Tamaño_Paquete = txtPaqueteTamaño.Text;
                paquetes.Estado_Paquete = txtPaqueteEstado.Text;
                respuesta = MessageBox.Show("Esta seguro?", "Eliminara la informacion de forma permanente", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    switch (paquetes.Eliminar())
                    {
                        case 2:
                            MessageBox.Show("Ha ocurrido un error");
                            break;
                        default:
                            MessageBox.Show("Hubo errores al efectuar operacion. Reintente");
                            break;
                    }
                }
            }
        }

        private void btnBuscarLote_Click(object sender, EventArgs e)
        {

        }
    }
}
