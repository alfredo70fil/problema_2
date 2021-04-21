
namespace problema_2
{
    partial class verreceta
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
            this.btnVer3 = new System.Windows.Forms.Button();
            this.btnSubir3 = new System.Windows.Forms.Button();
            this.btnSalir3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVer3
            // 
            this.btnVer3.Location = new System.Drawing.Point(34, 48);
            this.btnVer3.Name = "btnVer3";
            this.btnVer3.Size = new System.Drawing.Size(75, 23);
            this.btnVer3.TabIndex = 0;
            this.btnVer3.Text = "Ver tabla";
            this.btnVer3.UseVisualStyleBackColor = true;
            this.btnVer3.Click += new System.EventHandler(this.btnVer3_Click);
            // 
            // btnSubir3
            // 
            this.btnSubir3.Location = new System.Drawing.Point(115, 48);
            this.btnSubir3.Name = "btnSubir3";
            this.btnSubir3.Size = new System.Drawing.Size(75, 23);
            this.btnSubir3.TabIndex = 1;
            this.btnSubir3.Text = "Subir datos";
            this.btnSubir3.UseVisualStyleBackColor = true;
            this.btnSubir3.Click += new System.EventHandler(this.btnSubir3_Click);
            // 
            // btnSalir3
            // 
            this.btnSalir3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir3.Location = new System.Drawing.Point(197, 47);
            this.btnSalir3.Name = "btnSalir3";
            this.btnSalir3.Size = new System.Drawing.Size(75, 23);
            this.btnSalir3.TabIndex = 2;
            this.btnSalir3.Text = "Salir";
            this.btnSalir3.UseVisualStyleBackColor = true;
            this.btnSalir3.Click += new System.EventHandler(this.btnSalir3_Click);
            // 
            // verreceta
            // 
            this.AcceptButton = this.btnVer3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir3;
            this.ClientSize = new System.Drawing.Size(309, 123);
            this.Controls.Add(this.btnSalir3);
            this.Controls.Add(this.btnSubir3);
            this.Controls.Add(this.btnVer3);
            this.Name = "verreceta";
            this.Text = "Recetas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVer3;
        private System.Windows.Forms.Button btnSubir3;
        private System.Windows.Forms.Button btnSalir3;
    }
}