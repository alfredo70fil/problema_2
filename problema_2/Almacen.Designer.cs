
namespace problema_2
{
    partial class Almacen
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
            this.btnver2 = new System.Windows.Forms.Button();
            this.btnsubir2 = new System.Windows.Forms.Button();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnver2
            // 
            this.btnver2.Location = new System.Drawing.Point(30, 39);
            this.btnver2.Name = "btnver2";
            this.btnver2.Size = new System.Drawing.Size(75, 23);
            this.btnver2.TabIndex = 0;
            this.btnver2.Text = "Ver tabla";
            this.btnver2.UseVisualStyleBackColor = true;
            this.btnver2.Click += new System.EventHandler(this.btnver2_Click);
            // 
            // btnsubir2
            // 
            this.btnsubir2.Location = new System.Drawing.Point(111, 39);
            this.btnsubir2.Name = "btnsubir2";
            this.btnsubir2.Size = new System.Drawing.Size(75, 23);
            this.btnsubir2.TabIndex = 1;
            this.btnsubir2.Text = "Subir datos";
            this.btnsubir2.UseVisualStyleBackColor = true;
            this.btnsubir2.Click += new System.EventHandler(this.btnsubir2_Click);
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(193, 38);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(75, 23);
            this.btnSalir2.TabIndex = 2;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 106);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.btnsubir2);
            this.Controls.Add(this.btnver2);
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnver2;
        private System.Windows.Forms.Button btnsubir2;
        private System.Windows.Forms.Button btnSalir2;
    }
}