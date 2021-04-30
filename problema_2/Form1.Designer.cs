
namespace problema_2
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlatillo = new System.Windows.Forms.Button();
            this.btningredientes = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cARTADataSet = new problema_2.CARTADataSet();
            this.platoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.platoTableAdapter = new problema_2.CARTADataSetTableAdapters.PlatoTableAdapter();
            this.idPlatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dificultadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlatillo
            // 
            this.btnPlatillo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPlatillo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlatillo.Image = global::problema_2.Properties.Resources.icono_Platillo1;
            this.btnPlatillo.Location = new System.Drawing.Point(784, 10);
            this.btnPlatillo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlatillo.Name = "btnPlatillo";
            this.btnPlatillo.Size = new System.Drawing.Size(173, 185);
            this.btnPlatillo.TabIndex = 9;
            this.btnPlatillo.UseVisualStyleBackColor = true;
            this.btnPlatillo.UseWaitCursor = true;
            this.btnPlatillo.Click += new System.EventHandler(this.btnPlatillo_Click);
            this.btnPlatillo.MouseHover += new System.EventHandler(this.btnPlatillo_MouseHover);
            // 
            // btningredientes
            // 
            this.btningredientes.Image = global::problema_2.Properties.Resources.icono_Ingredientes1;
            this.btningredientes.Location = new System.Drawing.Point(785, 388);
            this.btningredientes.Name = "btningredientes";
            this.btningredientes.Size = new System.Drawing.Size(173, 185);
            this.btningredientes.TabIndex = 3;
            this.btningredientes.UseVisualStyleBackColor = true;
            this.btningredientes.Click += new System.EventHandler(this.btningredientes_Click);
            this.btningredientes.MouseHover += new System.EventHandler(this.btningredientes_MouseHover);
            // 
            // btnSalida
            // 
            this.btnSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalida.Image = global::problema_2.Properties.Resources.icono_Salir1;
            this.btnSalida.Location = new System.Drawing.Point(963, 388);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(173, 185);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            this.btnSalida.MouseHover += new System.EventHandler(this.btnSalida_MouseHover);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Image = global::problema_2.Properties.Resources.icono_Almacen1;
            this.btnAlmacen.Location = new System.Drawing.Point(963, 197);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(173, 185);
            this.btnAlmacen.TabIndex = 2;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            this.btnAlmacen.MouseHover += new System.EventHandler(this.btnAlmacen_MouseHover);
            // 
            // btnRecetas
            // 
            this.btnRecetas.Image = global::problema_2.Properties.Resources.icono_Recetas1;
            this.btnRecetas.Location = new System.Drawing.Point(785, 197);
            this.btnRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(173, 185);
            this.btnRecetas.TabIndex = 1;
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            this.btnRecetas.MouseHover += new System.EventHandler(this.btnRecetas_MouseHover);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = global::problema_2.Properties.Resources.icono_categoria1;
            this.btnCategoria.Location = new System.Drawing.Point(963, 10);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(173, 185);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnCategoria.MouseHover += new System.EventHandler(this.btnCategoria_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlatoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.precioDataGridViewTextBoxColumn,
            this.dificultadDataGridViewTextBoxColumn,
            this.idRecetaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.platoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(767, 561);
            this.dataGridView1.TabIndex = 10;
            // 
            // cARTADataSet
            // 
            this.cARTADataSet.DataSetName = "CARTADataSet";
            this.cARTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // platoBindingSource
            // 
            this.platoBindingSource.DataMember = "Plato";
            this.platoBindingSource.DataSource = this.cARTADataSet;
            // 
            // platoTableAdapter
            // 
            this.platoTableAdapter.ClearBeforeFill = true;
            // 
            // idPlatoDataGridViewTextBoxColumn
            // 
            this.idPlatoDataGridViewTextBoxColumn.DataPropertyName = "idPlato";
            this.idPlatoDataGridViewTextBoxColumn.HeaderText = "idPlato";
            this.idPlatoDataGridViewTextBoxColumn.Name = "idPlatoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // dificultadDataGridViewTextBoxColumn
            // 
            this.dificultadDataGridViewTextBoxColumn.DataPropertyName = "Dificultad";
            this.dificultadDataGridViewTextBoxColumn.HeaderText = "Dificultad";
            this.dificultadDataGridViewTextBoxColumn.Name = "dificultadDataGridViewTextBoxColumn";
            // 
            // idRecetaDataGridViewTextBoxColumn
            // 
            this.idRecetaDataGridViewTextBoxColumn.DataPropertyName = "idReceta";
            this.idRecetaDataGridViewTextBoxColumn.HeaderText = "idReceta";
            this.idRecetaDataGridViewTextBoxColumn.Name = "idRecetaDataGridViewTextBoxColumn";
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btnPlatillo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnSalida;
            this.ClientSize = new System.Drawing.Size(1139, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPlatillo);
            this.Controls.Add(this.btningredientes);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnAlmacen);
            this.Controls.Add(this.btnRecetas);
            this.Controls.Add(this.btnCategoria);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btningredientes;
        private System.Windows.Forms.Button btnPlatillo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CARTADataSet cARTADataSet;
        private System.Windows.Forms.BindingSource platoBindingSource;
        private CARTADataSetTableAdapters.PlatoTableAdapter platoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dificultadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecetaDataGridViewTextBoxColumn;
    }
}

