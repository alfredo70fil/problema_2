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
using System.IO;

namespace problema_2
{
    public partial class VentanaComandos : Form
    {
        SqlConnection conexion = new SqlConnection("Server=localhost;Database=CARTA;Trusted_Connection=True;");
        int opci;
        public VentanaComandos(int opcion)
        {
            InitializeComponent();
            opci = opcion;
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
                case 2:
                    txtcampo1.Show();
                    txtcampo2.Show();
                    txtcampo3.Show();
                    txtcampo4.Show();
                    lblcampo1.Text = "Id categoria:";
                    lblcampo2.Text = "Nombre:";
                    lblcampo3.Text = "Descripción:";
                    lblcampo4.Text = "Encargado:";
                    break;
                case 3:
                    txtcampo1.Show();
                    txtcampo2.Show();
                    txtcampo3.Show();
                    lblcampo1.Text = "Id receta:";
                    lblcampo2.Text = "Nombre:";
                    lblcampo3.Text = "Receta:";
                    break;
                case 4:
                    txtcampo1.Show();
                    txtcampo2.Show();
                    lblcampo1.Text = "Id Almacen:";
                    lblcampo2.Text = "Cantidad:";
                    break;
                case 5:
                    txtcampo1.Show();
                    txtcampo2.Show();
                    txtcampo3.Show();
                    txtcampo4.Show();
                    txtcampo5.Show();
                    lblcampo1.Text = "Id ingredientes:";
                    lblcampo2.Text = "Nombre:";
                    lblcampo3.Text = "Medida:";
                    lblcampo4.Text = "Cantidad:";
                    lblcampo5.Text = "idAlmacen:";
                    break;
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (opci)
            {
                case 1:
                    SqlCommand AgregarDB = new SqlCommand("insert into Plato (idPlato, Nombre, Descripcion, Foto, Precio, Dificultad, idReceta) values (@idplato, @Nombre, @Descripcion, @Foto, @Precio, @Dificultad, @idReceta)", conexion);

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    if (imgPlato.Image != null)
                    {
                        imgPlato.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        throw new ArgumentNullException("Falta fotografia", nameof(imgPlato.Image));
                    }
                    byte[] photo = ms.GetBuffer();
                    AgregarDB.Parameters.AddWithValue("@idPlato", txtcampo1.Text);
                    AgregarDB.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    AgregarDB.Parameters.AddWithValue("@Descripcion", txtcampo3.Text);
                    AgregarDB.Parameters.AddWithValue("@Foto", SqlDbType.Image).Value = photo;
                    AgregarDB.Parameters.AddWithValue("@Precio", txtcampo5.Text);
                    AgregarDB.Parameters.AddWithValue("@Dificultad", txtcampo6.Text);
                    AgregarDB.Parameters.AddWithValue("@idReceta", txtcampo7.Text);
                    conexion.Open();
                    AgregarDB.ExecuteNonQuery();
                    conexion.Close();
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo5.Text = "";
                    txtcampo6.Text = "";
                    txtcampo7.Text = "";
                    txtcampo1.Focus();
                    MessageBox.Show("Los datos se guardaron exitosamente");
                    break;
                case 2:
                    SqlCommand DB = new SqlCommand("insert into Categoria (idCategoria, Nombre, Descripcion, Encargado) values (@idCategoria, @Nombre, @Descripcion, @Encargado)", conexion);
                    DB.Parameters.AddWithValue("@idCategoria", txtcampo1.Text);
                    DB.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    DB.Parameters.AddWithValue("@Descripcion", txtcampo3.Text);
                    DB.Parameters.AddWithValue("@Encargado", txtcampo4.Text);
                    conexion.Open();
                    DB.ExecuteNonQuery();
                    conexion.Close();
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo4.Text = "";
                    txtcampo1.Focus();
                    MessageBox.Show("Los datos se guardaron exitosamente");
                    break;
                case 3:
                    SqlCommand rece = new SqlCommand("insert into Recetas (idReceta, Nombre, Receta) values (@idReceta, @Nombre, @Receta)", conexion);
                    rece.Parameters.AddWithValue("@idReceta", txtcampo1.Text);
                    rece.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    rece.Parameters.AddWithValue("@Receta", txtcampo3.Text);
                    conexion.Open();
                    rece.ExecuteNonQuery();
                    conexion.Close();
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo1.Focus();
                    MessageBox.Show("Los datos se guardaron exitosamente");
                    break;
                case 4:
                    SqlCommand Almacen = new SqlCommand("insert into Almacen (idAlmacen, Cantidad) values (@idAlmacen, @Cantidad)", conexion);
                    Almacen.Parameters.AddWithValue("@idAlmacen", txtcampo1.Text);
                    Almacen.Parameters.AddWithValue("@Cantidad", txtcampo2.Text);
                    conexion.Open();
                    Almacen.ExecuteNonQuery();
                    conexion.Close();
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo1.Focus();
                    MessageBox.Show("Los datos se guardaron exitosamente");
                    break;
                case 5:
                    SqlCommand ingre = new SqlCommand("insert into ingredientes (idIngredientes, Nombre, Medida, Cantidad, idAlmacen) values (@idIngredientes, @Nombre, @Medida, @Cantidad, @idAlmacen)", conexion);
                    ingre.Parameters.AddWithValue("@idIngredientes", txtcampo1.Text);
                    ingre.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    ingre.Parameters.AddWithValue("@Medida", txtcampo3.Text);
                    ingre.Parameters.AddWithValue("@Cantidad", txtcampo4.Text);
                    ingre.Parameters.AddWithValue("@idAlmacen", txtcampo5.Text);
                    conexion.Open();
                    ingre.ExecuteNonQuery();
                    conexion.Close();
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo4.Text = "";
                    txtcampo5.Text = "";
                    txtcampo1.Focus();
                    MessageBox.Show("Los datos se guardaron exitosamente");
                    break;
            }

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imgPlato.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (opci)
            {
                case 1:
                    conexion.Open();
                    SqlCommand cmdb = new SqlCommand("DELETE FROM Platillo WHERE idPlatillo = @idPlatillo", conexion);
                    cmdb.Parameters.Add("idPlatillo", txtcampo1.Text);
                    cmdb.ExecuteNonQuery();
                    cmdb.Dispose();
                    cmdb = null;
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo5.Text = "";
                    txtcampo6.Text = "";
                    txtcampo7.Text = "";
                    conexion.Close();
                    MessageBox.Show("Socio eliminado");
                    break;
                case 2:
                    conexion.Open();
                    SqlCommand cmdIns = new SqlCommand("DELETE FROM Categoria WHERE idCategoria = @idCategoria", conexion);
                    cmdIns.Parameters.Add("idCategoria", txtcampo1.Text);
                    cmdIns.ExecuteNonQuery();
                    cmdIns.Dispose();
                    cmdIns = null;
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo4.Text = "";
                    txtcampo1.Focus();
                    conexion.Close();
                    MessageBox.Show("Socio eliminado");
                    break;
                case 3:
                    conexion.Open();
                    SqlCommand cmda = new SqlCommand("DELETE FROM Recetas WHERE idReceta = @idReceta", conexion);
                    cmda.Parameters.Add("idReceta", txtcampo1.Text);
                    cmda.ExecuteNonQuery();
                    cmda.Dispose();
                    cmda = null;
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo1.Focus();
                    conexion.Close();
                    MessageBox.Show("Socio eliminado");
                    break;
                case 4:
                    conexion.Open();
                    SqlCommand cmdd = new SqlCommand("DELETE FROM Almacen WHERE idAlmacen = @idAlmacen", conexion);
                    cmdd.Parameters.Add("idAlmacen", txtcampo1.Text);
                    cmdd.ExecuteNonQuery();
                    cmdd.Dispose();
                    cmdd = null;
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo1.Focus();
                    conexion.Close();
                    MessageBox.Show("Socio eliminado");
                    break;
                case 5:
                    conexion.Open();
                    SqlCommand cmds = new SqlCommand("DELETE FROM Categoria WHERE idIngredientes = @idIngredientes", conexion);
                    cmds.Parameters.Add("idIngredientes", txtcampo1.Text);
                    cmds.ExecuteNonQuery();
                    cmds.Dispose();
                    cmds = null;
                    txtcampo1.Text = "";
                    txtcampo2.Text = "";
                    txtcampo3.Text = "";
                    txtcampo4.Text = "";
                    txtcampo5.Text = "";
                    txtcampo1.Focus();
                    conexion.Close();
                    MessageBox.Show("Socio eliminado");
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (opci)
            {
                case 1:
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("UPDATE Plato SET idPlato=@idPlato, Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio,Dificultad=@Dificultad,idReceta=@idReceta, Foto=@Foto " +
                        "WHERE idPlato=@idPlato", conexion);
                    comando.Parameters.AddWithValue("@idPlato", txtcampo1.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    comando.Parameters.AddWithValue("@Descripcion", txtcampo3.Text);
                    comando.Parameters.AddWithValue("@Precio", txtcampo5.Text);
                    comando.Parameters.AddWithValue("@Dificultad", txtcampo6.Text);
                    comando.Parameters.AddWithValue("@idReceta", txtcampo7.Text);
                    comando.Parameters.Add("@Foto", SqlDbType.Image);
                    MemoryStream ms = new MemoryStream();
                    imgPlato.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    comando.Parameters["@Foto"].Value = ms.GetBuffer();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("MODIFICACION COMPLETA");
                    conexion.Close();
                    break;
                case 2:
                    conexion.Open();
                    SqlCommand coman = new SqlCommand("UPDATE Categoria SET idCategoria=@idCategoria, Nombre=@Nombre, Descripcion=@Descripcion, Encargado=@Encargado WHERE idCategoria=@idCategoria", conexion);
                    coman.Parameters.AddWithValue("@idCategoria", txtcampo1.Text);
                    coman.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    coman.Parameters.AddWithValue("@Descripcion", txtcampo3.Text);
                    coman.Parameters.AddWithValue("@Encargado", txtcampo4.Text);
                    coman.ExecuteNonQuery();
                    MessageBox.Show("MODIFICACION COMPLETA");
                    conexion.Close();
                    break;
                case 3:
                    conexion.Open();
                    SqlCommand coma = new SqlCommand("UPDATE Recetas SET idReceta=@idReceta, Nombre=@Nombre, Receta=@Receta WHERE idReceta=@idReceta", conexion);
                    coma.Parameters.AddWithValue("@idReceta", txtcampo1.Text);
                    coma.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    coma.Parameters.AddWithValue("@Receta", txtcampo3.Text);
                    coma.ExecuteNonQuery();
                    MessageBox.Show("MODIFICACION COMPLETA");
                    conexion.Close();
                    break;
                case 4:
                    conexion.Open();
                    SqlCommand com = new SqlCommand("UPDATE Almacen SET idAlmacen=@idAlmacen, Cantidad=@Cantidad WHERE idAlmacen=@idAlmacen", conexion);
                    com.Parameters.AddWithValue("@idAlmacen", txtcampo1.Text);
                    com.Parameters.AddWithValue("@Cantidad", txtcampo2.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("MODIFICACION COMPLETA");
                    conexion.Close();
                    break;
                case 5:
                    conexion.Open();
                    SqlCommand co = new SqlCommand("UPDATE ingredientes SET idIngredientes=@idIngredientes, Nombre=@Nombre, Medida=@Medida, Cantidad=@Cantidad, idAlmacen=@idAlmacen WHERE idIngredientes=@idIngredientes", conexion);
                    co.Parameters.AddWithValue("@idIngredientes", txtcampo1.Text);
                    co.Parameters.AddWithValue("@Nombre", txtcampo2.Text);
                    co.Parameters.AddWithValue("@Medida", txtcampo3.Text);
                    co.Parameters.AddWithValue("@Cantidad", txtcampo4.Text);
                    co.Parameters.AddWithValue("@idAlmacen", txtcampo5.Text);
                    co.ExecuteNonQuery();
                    MessageBox.Show("MODIFICACION COMPLETA");
                    conexion.Close();
                    break;
            }
        }

        private void VentanaComandos_Load(object sender, EventArgs e)
        {
            switch (opci)
            {
                case 1:
                    SqlCommand comando = new SqlCommand("SELECT idPlato from Plato", conexion);
                    conexion.Open();
                    SqlDataReader registro = comando.ExecuteReader();
                    while (registro.Read())
                    {
                        txtconsulta.Items.Add(registro["idPlato"].ToString());
                    }
                    conexion.Close();
                    break;
                case 2:
                    SqlCommand coman = new SqlCommand("SELECT idCategoria from Categoria", conexion);
                    conexion.Open();
                    SqlDataReader registr = coman.ExecuteReader();
                    while (registr.Read())
                    {
                        txtconsulta.Items.Add(registr["idCategoria"].ToString());
                    }
                    conexion.Close();
                    break;
                case 3:
                    SqlCommand coma = new SqlCommand("SELECT idReceta from Recetas", conexion);
                    conexion.Open();
                    SqlDataReader regis = coma.ExecuteReader();
                    while (regis.Read())
                    {
                        txtconsulta.Items.Add(regis["idReceta"].ToString());
                    }
                    conexion.Close();
                    break;
                case 4:
                    SqlCommand co = new SqlCommand("SELECT idAlmacen from Almacen", conexion);
                    conexion.Open();
                    SqlDataReader regi = co.ExecuteReader();
                    while (regi.Read())
                    {
                        txtconsulta.Items.Add(regi["idAlmacen"].ToString());
                    }
                    conexion.Close();
                    break;
                case 5:
                    SqlCommand col = new SqlCommand("SELECT idIngredientes from Ingredientes", conexion);
                    conexion.Open();
                    SqlDataReader re = col.ExecuteReader();
                    while (re.Read())
                    {
                        txtconsulta.Items.Add(re["idIngredientes"].ToString());
                    }
                    conexion.Close();
                    break;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            switch(opci)
            {
                case 1:
                    
                    string query = "select * from Plato where idPlato=@idPlato";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idPlato", txtconsulta.Text);
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        txtcampo1.Text = reader[0].ToString();
                        txtcampo2.Text = reader[1].ToString();
                        txtcampo3.Text = reader[2].ToString();
                        txtcampo5.Text = reader[4].ToString();                        
                        txtcampo6.Text = reader[5].ToString();
                        txtcampo7.Text = reader[6].ToString();
                    }
                    conexion.Close(); conexion.Open();
                    SqlCommand cmd1 = new SqlCommand("select Foto from Plato where idPlato=" + txtcampo1.Text, conexion);
                    SqlDataAdapter ad = new SqlDataAdapter(cmd1);
                    DataSet ds = new DataSet();
                    ad.Fill(ds, "img");
                    byte[] datos = new byte[0];
                    DataRow dr = ds.Tables["img"].Rows[0];
                    datos = (byte[])dr["Foto"];
                    MemoryStream ms = new MemoryStream(datos);
                    imgPlato.Image = System.Drawing.Bitmap.FromStream(ms);
                    MessageBox.Show("CONSULTA COMPLETA");
                    conexion.Close();
                    break;
                case 2:
                    conexion.Open();
                    string quer = "select * from Categoria where idCategoria=@idCategoria";
                    SqlCommand cm = new SqlCommand(quer, conexion);
                    cm.Parameters.AddWithValue("@idCategoria", txtconsulta.Text);

                    SqlDataReader read = cm.ExecuteReader();
                    while (read.Read())
                    {
                        txtcampo1.Text = read[0].ToString();
                        txtcampo2.Text = read[1].ToString();
                        txtcampo3.Text = read[2].ToString();
                        txtcampo4.Text = read[3].ToString();
                    }
                    MessageBox.Show("CONSULTA COMPLETA");
                    conexion.Close();
                    break;
                case 3:
                    conexion.Open();
                    string que = "select * from Recetas where idReceta=@idReceta";
                    SqlCommand c = new SqlCommand(que, conexion);
                    c.Parameters.AddWithValue("@idReceta", txtconsulta.Text);

                    SqlDataReader rea = c.ExecuteReader();
                    while (rea.Read())
                    {
                        txtcampo1.Text = rea[0].ToString();
                        txtcampo2.Text = rea[1].ToString();
                        txtcampo3.Text = rea[2].ToString();
                    }
                    MessageBox.Show("CONSULTA COMPLETA");
                    conexion.Close();
                    break;
                case 4:
                    conexion.Open();
                    string qu = "select * from Almacen where idAlmacen=@idAlmacen";
                    SqlCommand cl = new SqlCommand(qu, conexion);
                    cl.Parameters.AddWithValue("@idAlmacen", txtconsulta.Text);

                    SqlDataReader re = cl.ExecuteReader();
                    while (re.Read())
                    {
                        txtcampo1.Text = re[0].ToString();
                        txtcampo2.Text = re[1].ToString();
                    }
                    MessageBox.Show("CONSULTA COMPLETA");
                    conexion.Close();
                    break;
                case 5:
                    conexion.Open();
                    string q = "select * from ingredientes where idIngredientes=@idIngredientes";
                    SqlCommand ck = new SqlCommand(q, conexion);
                    ck.Parameters.AddWithValue("@idIngredientes", txtconsulta.Text);

                    SqlDataReader r = ck.ExecuteReader();
                    while (r.Read())
                    {
                        txtcampo1.Text = r[0].ToString();
                        txtcampo2.Text = r[1].ToString();
                        txtcampo3.Text = r[2].ToString();
                        txtcampo4.Text = r[3].ToString();
                        txtcampo5.Text = r[4].ToString();
                    }
                    MessageBox.Show("CONSULTA COMPLETA");
                    conexion.Close();
                    break;
            }
        }
    }
}
