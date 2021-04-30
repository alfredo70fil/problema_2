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
    public partial class VentanaComandos : Form
    {
        public VentanaComandos(int opcion)
        {
            InitializeComponent();
            txtcampo1.Hide();
            txtcampo2.Hide();
            txtcampo3.Hide();
            txtcampo4.Hide();
            txtcampo5.Hide();
            txtcampo6.Hide();
            txtcampo7.Hide();
            btnFoto.Hide();
            switch (opcion)
            {
                case 1:
                    txtcampo1.Show();
                    txtcampo2.Show();
                    txtcampo3.Show();
                    btnFoto.Show();
                    txtcampo5.Show();
                    txtcampo6.Show();
                    txtcampo7.Show();
                    lblcampo1.Text = "Id plato:";
                    lblcampo2.Text = "Nombre:";
                    lblcampo3.Text = "Descripción:";
                    lblcampo4.Text = "Foto:";
                    lblcampo5.Text = "Precio:";
                    lblcampo6.Text = "Dificultad:";
                    lblcampo7.Text = "Id Receta:";
                    break;
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
