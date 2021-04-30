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
    public partial class frmMenu : Form
    {
        
        
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            VentanaComandos comandos = new VentanaComandos(2);
            comandos.ShowDialog();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            VentanaComandos comandos = new VentanaComandos(3);
            comandos.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            VentanaComandos comandos = new VentanaComandos(4);
            comandos.ShowDialog();
        }

        private void btningredientes_Click(object sender, EventArgs e)
        {
            VentanaComandos comandos = new VentanaComandos(5);
            comandos.ShowDialog();
        }

        private void picPlato_Click(object sender, EventArgs e)
        {

        }

        private void btnPlatillo_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnPlatillo, "Platillos");
        }

        private void btnCategoria_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnCategoria, "Categorias");
        }

        private void btnRecetas_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnRecetas, "Recetas");
        }

        private void btnAlmacen_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnAlmacen, "Almacen");
        }

        private void btningredientes_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btningredientes, "Ingredientes");
        }

        private void btnSalida_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnSalida, "Salida");
        }

        private void btnPlatillo_Click(object sender, EventArgs e)
        {
            VentanaComandos comandos = new VentanaComandos(1);
            comandos.ShowDialog();
        }
    }
}
