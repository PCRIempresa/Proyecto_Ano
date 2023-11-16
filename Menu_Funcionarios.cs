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

    public partial class Menu_Funcionarios : Form
    {
        public Menu_Funcionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_Secion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Registro frmRegistro = new Registro();
            frmRegistro.Show();
            this.Close();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Int32 ci;
            DialogResult resultado;
            Usuarios usuarios = new Usuarios();
            usuarios.Conectar = Program.Conexion;
            string contraseña = "";
            string rol_administrador = "Administrador";
            string rol_conductor = "Conductor";

            if (!Int32.TryParse(txtCI.Text, out ci))
            {
                MessageBox.Show("La CI debe ser numerico");
            }
            else
            {
                usuarios.ci = ci;
                usuarios.Contraseña = contraseña;
                if (!String.Equals(txtContraseña.Text, contraseña))
                    {
                    MessageBox.Show("La contraceña es incorrecta");
                }
                else
                {
                    usuarios.Rol = rol_administrador;
                    if (String.Equals(usuarios.Rol, rol_administrador))
                    {
                        Menu_Admin frmAdministrador = new Menu_Admin();
                        frmAdministrador.Show();
                        this.Close();
                    }
                    else
                    {
                        usuarios.Rol = rol_conductor;
                        if (String.Equals(usuarios.Rol, rol_conductor))
                        {
                            Menu_Conductores frmConductores = new Menu_Conductores();
                            Menu_Funcionarios frmFuncionario = new Menu_Funcionarios();
                            frmConductores.Show();
                            frmFuncionario.Close();
                        }
                        else
                        {
                            MessageBox.Show("El usuario no tiene rol en esta seccion");
                        }
                    }
                    

                }
            }
        }

        private void comoIngresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escribe tu CI y Contraceña, luego has clic en Ingresar para que el sisitema te muestre tu espacio de trabajo. En caso de no tener un Usuario registrado le recomendamos que se registre");
        }

        private void comoRegistrarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para registrarce solo debe hacer clic en el boton Registrarce y llenar los datos que le pidan");
        }
    }
}

