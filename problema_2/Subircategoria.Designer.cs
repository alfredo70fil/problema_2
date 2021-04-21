
namespace problema_2
{
    partial class Subircategoria
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(65, 60);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(64, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id Categoria";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(147, 60);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(100, 20);
            this.txtcategoria.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(65, 97);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(65, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 139);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Location = new System.Drawing.Point(65, 183);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(59, 13);
            this.lblEncargado.TabIndex = 6;
            this.lblEncargado.Text = "Encargado";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(147, 176);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtEncargado.TabIndex = 7;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(67, 220);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 23);
            this.btnSubir.TabIndex = 8;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(172, 220);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Subircategoria
            // 
            this.AcceptButton = this.btnSubir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(306, 290);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.lblEncargado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.lblid);
            this.Name = "Subircategoria";
            this.Text = "Subircategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnCerrar;
    }
}