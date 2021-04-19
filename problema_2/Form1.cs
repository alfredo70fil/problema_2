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
        SqlConnection conexion = new SqlConnection("server=hikarinohakate.database.windows.net; Initial Catalog=Carta; integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand("insert into  ()");
        }
    }
}
