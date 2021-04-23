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
    public partial class vercategoria : Form
    {
        public vercategoria()
        {
            InitializeComponent();
        }

        private void vercategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cartaDataSet2.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.cartaDataSet2.Categoria);

        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
