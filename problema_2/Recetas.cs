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
    public partial class verreceta : Form
    {
        public verreceta()
        {
            InitializeComponent();
        }

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVer3_Click(object sender, EventArgs e)
        {
            verrecetita rece = new verrecetita();
            rece.ShowDialog();
        }

        private void btnSubir3_Click(object sender, EventArgs e)
        {
            Subirreceta subir = new Subirreceta();
            subir.ShowDialog();
        }
    }
}
