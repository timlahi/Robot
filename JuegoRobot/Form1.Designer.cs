namespace JuegoRobot
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
            this.generacion1 = new System.Windows.Forms.ListBox();
            this.diccionario1 = new System.Windows.Forms.ListBox();
            this.listageneracion2 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // generacion1
            // 
            this.generacion1.ItemHeight = 16;
            this.generacion1.Location = new System.Drawing.Point(118, 81);
            this.generacion1.Name = "generacion1";
            this.generacion1.Size = new System.Drawing.Size(276, 164);
            this.generacion1.TabIndex = 0;
            // 
            // diccionario1
            // 
            this.diccionario1.ItemHeight = 16;
            this.diccionario1.Location = new System.Drawing.Point(481, 81);
            this.diccionario1.Name = "diccionario1";
            this.diccionario1.Size = new System.Drawing.Size(276, 164);
            this.diccionario1.TabIndex = 1;
            // 
            // listageneracion2
            // 
            this.listageneracion2.ItemHeight = 16;
            this.listageneracion2.Location = new System.Drawing.Point(866, 81);
            this.listageneracion2.Name = "listageneracion2";
            this.listageneracion2.Size = new System.Drawing.Size(276, 164);
            this.listageneracion2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 702);
            this.Controls.Add(this.listageneracion2);
            this.Controls.Add(this.diccionario1);
            this.Controls.Add(this.generacion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox generacion1;
        private System.Windows.Forms.ListBox diccionario1;
        private System.Windows.Forms.ListBox listageneracion2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

