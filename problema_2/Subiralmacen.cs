﻿using System;
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
    public partial class Subiralmacen : Form
    {
        public Subiralmacen()
        {
            InitializeComponent();
        }

        private void btnsalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=tcp:hikarinohakate.database.windows.net,1433;Initial Catalog=carta;Persist Security Info=False;User ID=alfredo60fil;Password=%25AD@Q4$%255134#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conexion.Open();
            string idalmacen = txtid.Text;
            string cantidad = txtCANT.Text;
            string cadena = "insert into Almacen(idAlmacen, Cantidad) values (" + idalmacen + "," + cantidad + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            txtid.Text = "";
            txtCANT.Text = "";
            conexion.Close();
            txtid.Focus();
        }
    }
}
