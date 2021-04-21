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
    public partial class Veralmacen : Form
    {
        public Veralmacen()
        {
            InitializeComponent();
        }

        private void Veralmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cartaDataSet1.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.cartaDataSet1.Almacen);

        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
