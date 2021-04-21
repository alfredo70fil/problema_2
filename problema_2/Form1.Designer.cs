
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
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.listTabla = new System.Windows.Forms.ListBox();
            this.picPlato = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(982, 38);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(56, 19);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(982, 78);
            this.btnRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(56, 19);
            this.btnRecetas.TabIndex = 1;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Location = new System.Drawing.Point(982, 126);
            this.btnAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(56, 19);
            this.btnAlmacen.TabIndex = 2;
            this.btnAlmacen.Text = "Almacen";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Location = new System.Drawing.Point(982, 212);
            this.btnSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(56, 19);
            this.btnSalida.TabIndex = 5;
            this.btnSalida.Text = "Salir";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // listTabla
            // 
            this.listTabla.FormattingEnabled = true;
            this.listTabla.Location = new System.Drawing.Point(9, 10);
            this.listTabla.Margin = new System.Windows.Forms.Padding(2);
            this.listTabla.Name = "listTabla";
            this.listTabla.Size = new System.Drawing.Size(773, 394);
            this.listTabla.TabIndex = 8;
            // 
            // picPlato
            // 
            this.picPlato.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picPlato.Location = new System.Drawing.Point(785, 15);
            this.picPlato.Margin = new System.Windows.Forms.Padding(2);
            this.picPlato.Name = "picPlato";
            this.picPlato.Size = new System.Drawing.Size(192, 186);
            this.picPlato.TabIndex = 5;
            this.picPlato.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(982, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picPlato);
            this.Controls.Add(this.listTabla);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnAlmacen);
            this.Controls.Add(this.btnRecetas);
            this.Controls.Add(this.btnMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPlato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.ListBox listTabla;
        private System.Windows.Forms.PictureBox picPlato;
        private System.Windows.Forms.Button button1;
    }
}

