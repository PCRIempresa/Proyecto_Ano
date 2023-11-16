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
            Usuarios usuarios = new Usuarios();
            Int32 CI;
            if (!Int32.TryParse(txtCI.Text, out CI))
            {
                MessageBox.Show("La CI debe tener formato numerico");
            }
            else
            {
                usuarios.Conectar = Program.Conexion;
                usuarios.ci = CI;
                usuarios.nombre = txtNombre.Text;
                usuarios.Contraseña = txtContraseña.Text;
                
                switch (usuarios.Registrar_Usuarios(btnRegistrar.Enabled))
                {
                    case 1:
                        MessageBox.Show("Ocurrio un Error, por favor ingrese nuevamente los datos");
                        break;

                    case 2:
                        MessageBox.Show("Han ocurrido problemas al intentar subir su CI");
                        break;

                    case 3:
                        MessageBox.Show("Han ocurrido problemas al intentar subir su nombre");
                        break;

                    case 4:
                        MessageBox.Show("Han ocurrido problemas al intentar subir su contraseña");
                        break;

                    case 5:
                        MessageBox.Show("Han ocurrido problemas al intentar subir sus datos, por favor comuniquese con Soporte Tequinico");
                        break;
                }
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void queHacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta ventana usted debe completar los siguientes datos para que su registro pueda ser tomado correctamente, se recomienda que complete todos los datos, la falta de de alguno de estos prodria ENLETECER o INTERRUMPIR con el trabajo del sistema haciendo que su trabajo se vuelva mas complicado");
        }

        private void label_Telefono_Click(object sender, EventArgs e)
        {

        }

        private void necesitasAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_Funcionarios frmFuncionarios = new Menu_Funcionarios();
            frmFuncionarios.Show();
            this.Close();
        }
    }
}
