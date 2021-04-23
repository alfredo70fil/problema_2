using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace problema_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Categoria menutable = new Categoria();
            menutable.ShowDialog();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            verreceta recetas = new verreceta();
            recetas.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            Almacen almacen = new Almacen();
            almacen.ShowDialog();
        }

        private void btningredientes_Click(object sender, EventArgs e)
        {

        }
    }
}
