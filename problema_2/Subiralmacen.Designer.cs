
namespace problema_2
{
    partial class Subiralmacen
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
            this.lblIdalmacen = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtCANT = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdalmacen
            // 
            this.lblIdalmacen.AutoSize = true;
            this.lblIdalmacen.Location = new System.Drawing.Point(66, 51);
            this.lblIdalmacen.Name = "lblIdalmacen";
            this.lblIdalmacen.Size = new System.Drawing.Size(60, 13);
            this.lblIdalmacen.TabIndex = 0;
            this.lblIdalmacen.Text = "Id Almacen";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(158, 51);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(66, 109);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Cantidad";
            // 
            // txtCANT
            // 
            this.txtCANT.Location = new System.Drawing.Point(158, 106);
            this.txtCANT.Name = "txtCANT";
            this.txtCANT.Size = new System.Drawing.Size(100, 20);
            this.txtCANT.TabIndex = 3;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(323, 51);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 23);
            this.btnSubir.TabIndex = 4;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnsalida
            // 
            this.btnsalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalida.Location = new System.Drawing.Point(323, 103);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(75, 23);
            this.btnsalida.TabIndex = 5;
            this.btnsalida.Text = "Salir";
            this.btnsalida.UseVisualStyleBackColor = true;
            this.btnsalida.Click += new System.EventHandler(this.btnsalida_Click);
            // 
            // Subiralmacen
            // 
            this.AcceptButton = this.btnSubir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnsalida;
            this.ClientSize = new System.Drawing.Size(470, 181);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.txtCANT);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblIdalmacen);
            this.Name = "Subiralmacen";
            this.Text = "Subiralmacen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdalmacen;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtCANT;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnsalida;
    }
}