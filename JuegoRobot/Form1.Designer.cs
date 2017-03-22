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
            this.generacionX = new System.Windows.Forms.ListBox();
            this.botonEmpezar = new System.Windows.Forms.Button();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.txtMutaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numberGenerations = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generacion1
            // 
            this.generacion1.ItemHeight = 16;
            this.generacion1.Location = new System.Drawing.Point(356, 53);
            this.generacion1.Name = "generacion1";
            this.generacion1.Size = new System.Drawing.Size(276, 164);
            this.generacion1.TabIndex = 0;
            // 
            // diccionario1
            // 
            this.diccionario1.ItemHeight = 16;
            this.diccionario1.Location = new System.Drawing.Point(654, 53);
            this.diccionario1.Name = "diccionario1";
            this.diccionario1.Size = new System.Drawing.Size(276, 164);
            this.diccionario1.TabIndex = 1;
            // 
            // listageneracion2
            // 
            this.listageneracion2.ItemHeight = 16;
            this.listageneracion2.Location = new System.Drawing.Point(958, 53);
            this.listageneracion2.Name = "listageneracion2";
            this.listageneracion2.Size = new System.Drawing.Size(276, 164);
            this.listageneracion2.TabIndex = 2;
            // 
            // generacionX
            // 
            this.generacionX.ItemHeight = 16;
            this.generacionX.Location = new System.Drawing.Point(356, 285);
            this.generacionX.Name = "generacionX";
            this.generacionX.Size = new System.Drawing.Size(276, 164);
            this.generacionX.TabIndex = 3;
            // 
            // botonEmpezar
            // 
            this.botonEmpezar.Location = new System.Drawing.Point(86, 226);
            this.botonEmpezar.Name = "botonEmpezar";
            this.botonEmpezar.Size = new System.Drawing.Size(120, 41);
            this.botonEmpezar.TabIndex = 4;
            this.botonEmpezar.Text = "Empezar";
            this.botonEmpezar.UseVisualStyleBackColor = true;
            this.botonEmpezar.Click += new System.EventHandler(this.botonEmpezar_Click);
            // 
            // txtPI
            // 
            this.txtPI.Location = new System.Drawing.Point(190, 53);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(96, 22);
            this.txtPI.TabIndex = 5;
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(190, 122);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(96, 22);
            this.txtRecorrido.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Población";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tamaño Recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Población Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(744, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recorrido G1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1039, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "G2 Padres e Hijos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Última Generación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Evaluación";
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Location = new System.Drawing.Point(190, 185);
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(96, 22);
            this.txtEvaluacion.TabIndex = 14;
            // 
            // txtMutaciones
            // 
            this.txtMutaciones.Location = new System.Drawing.Point(971, 307);
            this.txtMutaciones.Name = "txtMutaciones";
            this.txtMutaciones.Size = new System.Drawing.Size(96, 22);
            this.txtMutaciones.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número de Mutaciones";
            // 
            // numberGenerations
            // 
            this.numberGenerations.Location = new System.Drawing.Point(971, 264);
            this.numberGenerations.Name = "numberGenerations";
            this.numberGenerations.Size = new System.Drawing.Size(96, 22);
            this.numberGenerations.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(781, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número de Generaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 702);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numberGenerations);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMutaciones);
            this.Controls.Add(this.txtEvaluacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.txtPI);
            this.Controls.Add(this.botonEmpezar);
            this.Controls.Add(this.generacionX);
            this.Controls.Add(this.listageneracion2);
            this.Controls.Add(this.diccionario1);
            this.Controls.Add(this.generacion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox generacion1;
        private System.Windows.Forms.ListBox diccionario1;
        private System.Windows.Forms.ListBox listageneracion2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox generacionX;
        private System.Windows.Forms.Button botonEmpezar;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.TextBox txtMutaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numberGenerations;
        private System.Windows.Forms.Label label9;
    }
}

