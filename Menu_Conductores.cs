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
    public partial class Menu_Conductores : Form
    {
        public Menu_Conductores()
        {
            InitializeComponent();
        }

        private void Menu_Conductores_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu_Funcionarios frmFuncionarios = new Menu_Funcionarios();
            frmFuncionarios.Show();
            this.Close();
        }

        private void necesitasAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como conductor tendras a dispocicion toda la informacion de los vehiculos para tu trabajo, tus recorridos y toda la informacion pertinente a ellos");
        }
    }
}
