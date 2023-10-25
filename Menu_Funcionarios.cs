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
        int ci;
        string contraseña;
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
            Registro frm = new Registro();
            frm.Show();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.conexion.Open("miodbc", txtContraseña.Text, txtCI.Text);
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            Program.conexion.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
            Program.AutorisoPermisos(txtCI.Text);
            this.Close();
        }
    }
}

