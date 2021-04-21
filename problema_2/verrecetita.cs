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
    public partial class verrecetita : Form
    {
        public verrecetita()
        {
            InitializeComponent();
        }

        private void verrecetita_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cartaDataSet.Recetas' Puede moverla o quitarla según sea necesario.
            this.recetasTableAdapter.Fill(this.cartaDataSet.Recetas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
