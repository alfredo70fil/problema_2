
namespace problema_2
{
    partial class Form1
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
            this.listTabla = new System.Windows.Forms.ListBox();
            this.btnPlatillo = new System.Windows.Forms.Button();
            this.btningredientes = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTabla
            // 
            this.listTabla.FormattingEnabled = true;
            this.listTabla.ItemHeight = 16;
            this.listTabla.Location = new System.Drawing.Point(12, 12);
            this.listTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listTabla.Name = "listTabla";
            this.listTabla.Size = new System.Drawing.Size(1014, 660);
            this.listTabla.TabIndex = 8;
            // 
            // btnPlatillo
            // 
            this.btnPlatillo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPlatillo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlatillo.Image = global::problema_2.Properties.Resources.icono_Platillo;
            this.btnPlatillo.Location = new System.Drawing.Point(1046, 12);
            this.btnPlatillo.Name = "btnPlatillo";
            this.btnPlatillo.Size = new System.Drawing.Size(231, 228);
            this.btnPlatillo.TabIndex = 9;
            this.btnPlatillo.UseVisualStyleBackColor = true;
            this.btnPlatillo.UseWaitCursor = true;
            this.btnPlatillo.MouseHover += new System.EventHandler(this.btnPlatillo_MouseHover);
            // 
            // btningredientes
            // 
            this.btningredientes.Image = global::problema_2.Properties.Resources.icono_Ingredientes;
            this.btningredientes.Location = new System.Drawing.Point(1047, 477);
            this.btningredientes.Margin = new System.Windows.Forms.Padding(4);
            this.btningredientes.Name = "btningredientes";
            this.btningredientes.Size = new System.Drawing.Size(230, 214);
            this.btningredientes.TabIndex = 3;
            this.btningredientes.Text = "Ingredientes";
            this.btningredientes.UseVisualStyleBackColor = true;
            this.btningredientes.Click += new System.EventHandler(this.btningredientes_Click);
            this.btningredientes.MouseHover += new System.EventHandler(this.btningredientes_MouseHover);
            // 
            // btnSalida
            // 
            this.btnSalida.Image = global::problema_2.Properties.Resources.icono_Salir;
            this.btnSalida.Location = new System.Drawing.Point(1284, 477);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(225, 214);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            this.btnSalida.MouseHover += new System.EventHandler(this.btnSalida_MouseHover);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Image = global::problema_2.Properties.Resources.icono_Almacen;
            this.btnAlmacen.Location = new System.Drawing.Point(1284, 243);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(225, 228);
            this.btnAlmacen.TabIndex = 2;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            this.btnAlmacen.MouseHover += new System.EventHandler(this.btnAlmacen_MouseHover);
            // 
            // btnRecetas
            // 
            this.btnRecetas.Image = global::problema_2.Properties.Resources.icono_Recetas;
            this.btnRecetas.Location = new System.Drawing.Point(1047, 243);
            this.btnRecetas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(231, 228);
            this.btnRecetas.TabIndex = 1;
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            this.btnRecetas.MouseHover += new System.EventHandler(this.btnRecetas_MouseHover);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Image = global::problema_2.Properties.Resources.icono_categoria;
            this.btnCategoria.Location = new System.Drawing.Point(1284, 12);
            this.btnCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(225, 226);
            this.btnCategoria.TabIndex = 0;
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnCategoria.MouseHover += new System.EventHandler(this.btnCategoria_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1680, 741);
            this.Controls.Add(this.btnPlatillo);
            this.Controls.Add(this.btningredientes);
            this.Controls.Add(this.listTabla);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnAlmacen);
            this.Controls.Add(this.btnRecetas);
            this.Controls.Add(this.btnCategoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.ListBox listTabla;
        private System.Windows.Forms.Button btningredientes;
        private System.Windows.Forms.Button btnPlatillo;
    }
}

