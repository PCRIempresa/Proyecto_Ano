using MySql.Data.MySqlClient;
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
    public partial class MenuInicio : Form
    {
     

        public MenuInicio()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void ImagenFondo_Click(object sender, EventArgs e)
        {

        }

        private class Public
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void labelRegistrate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            Program.Conexion.Open("PCRI", "marcos.bustamante", "47630602");
        }

        private void TituloPrincipal_Click(object sender, EventArgs e)
        {

        }


        private void btn_Buscar_Paquete_Click(object sender, EventArgs e)
        {
           
            Menu_Clientes frmClientes = new Menu_Clientes();
            frmClientes.Show();
           
        }

        private void btn_Funcionarios_Click(object sender, EventArgs e)
        {

            Menu_Funcionarios frmFuncionarios = new Menu_Funcionarios();
            frmFuncionarios.Show();
        }
    }
}
