using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problema_2
{
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnver2_Click(object sender, EventArgs e)
        {
            Veralmacen alma = new Veralmacen();
            alma.ShowDialog();
        }

        private void btnsubir2_Click(object sender, EventArgs e)
        {
            Subiralmacen alma = new Subiralmacen();
            alma.ShowDialog();
        }
    }
}
