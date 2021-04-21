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
    public partial class Subircategoria : Form
    {
        public Subircategoria()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=tcp:hikarinohakate.database.windows.net,1433;Initial Catalog=carta;Persist Security Info=False;User ID=alfredo60fil;Password=%25AD@Q4$%255134#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conexion.Open();
            string id = txtcategoria.Text;
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string encargado = txtEncargado.Text;
            string cadena = "insert into Categoria(idCategoria, Nombre, Descripcion, Encargado) values (" + id + ",'" + nombre + "','" + descripcion + "', '" + encargado + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtcategoria.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtEncargado.Text = "";
            conexion.Close();
            txtcategoria.Focus();
        }
    }
}
