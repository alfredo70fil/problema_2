
namespace problema_2
{
    partial class verrecetita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cartaDataSet = new problema_2.cartaDataSet();
            this.cartaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recetasTableAdapter = new problema_2.cartaDataSetTableAdapters.RecetasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recetasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idRecetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cartaDataSet
            // 
            this.cartaDataSet.DataSetName = "cartaDataSet";
            this.cartaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartaDataSetBindingSource
            // 
            this.cartaDataSetBindingSource.DataSource = this.cartaDataSet;
            this.cartaDataSetBindingSource.Position = 0;
            // 
            // recetasBindingSource
            // 
            this.recetasBindingSource.DataMember = "Recetas";
            this.recetasBindingSource.DataSource = this.cartaDataSetBindingSource;
            // 
            // recetasTableAdapter
            // 
            this.recetasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecetaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recetasBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // recetasBindingSource1
            // 
            this.recetasBindingSource1.DataMember = "Recetas";
            this.recetasBindingSource1.DataSource = this.cartaDataSetBindingSource;
            // 
            // idRecetaDataGridViewTextBoxColumn
            // 
            this.idRecetaDataGridViewTextBoxColumn.DataPropertyName = "idReceta";
            this.idRecetaDataGridViewTextBoxColumn.HeaderText = "idReceta";
            this.idRecetaDataGridViewTextBoxColumn.Name = "idRecetaDataGridViewTextBoxColumn";
            this.idRecetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(278, 139);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // verrecetita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(371, 196);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "verrecetita";
            this.Text = "Recetas";
            this.Load += new System.EventHandler(this.verrecetita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cartaDataSetBindingSource;
        private cartaDataSet cartaDataSet;
        private System.Windows.Forms.BindingSource recetasBindingSource;
        private cartaDataSetTableAdapters.RecetasTableAdapter recetasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recetasBindingSource1;
        private System.Windows.Forms.Button btnSalir;
    }
}