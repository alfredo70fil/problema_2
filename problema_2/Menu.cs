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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=tcp:hikarinohakate.database.windows.net,1433;Initial Catalog=carta;Persist Security Info=False;User ID=alfredo60fil;Password=%25AD@Q4$%255134#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conexion.Open();
        }
    }
}
