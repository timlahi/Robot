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
            this.label1 = new System.Windows.Forms.Label();
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
            this.RE1 = new System.Windows.Forms.Label();
            this.RE2 = new System.Windows.Forms.Label();
            this.RE3 = new System.Windows.Forms.Label();
            this.RE4 = new System.Windows.Forms.Label();
            this.RE5 = new System.Windows.Forms.Label();
            this.RE6 = new System.Windows.Forms.Label();
            this.RE7 = new System.Windows.Forms.Label();
            this.RE8 = new System.Windows.Forms.Label();
            this.RE9 = new System.Windows.Forms.Label();
            this.RE10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textpuntos = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.RG7 = new System.Windows.Forms.Label();
            this.RG6 = new System.Windows.Forms.Label();
            this.RG5 = new System.Windows.Forms.Label();
            this.RG4 = new System.Windows.Forms.Label();
            this.RG3 = new System.Windows.Forms.Label();
            this.RG2 = new System.Windows.Forms.Label();
            this.RG1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.listaGX = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mutacionparcial = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // generacion1
            // 
            this.generacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generacion1.ItemHeight = 20;
            this.generacion1.Location = new System.Drawing.Point(323, 49);
            this.generacion1.Name = "generacion1";
            this.generacion1.Size = new System.Drawing.Size(276, 164);
            this.generacion1.TabIndex = 0;
            this.generacion1.SelectedIndexChanged += new System.EventHandler(this.generacion1_SelectedIndexChanged);
            this.generacion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.generacion1_KeyPress);
            // 
            // diccionario1
            // 
            this.diccionario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diccionario1.ItemHeight = 20;
            this.diccionario1.Location = new System.Drawing.Point(654, 53);
            this.diccionario1.Name = "diccionario1";
            this.diccionario1.Size = new System.Drawing.Size(276, 164);
            this.diccionario1.TabIndex = 1;
            // 
            // listageneracion2
            // 
            this.listageneracion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listageneracion2.ItemHeight = 20;
            this.listageneracion2.Location = new System.Drawing.Point(958, 53);
            this.listageneracion2.Name = "listageneracion2";
            this.listageneracion2.Size = new System.Drawing.Size(276, 164);
            this.listageneracion2.TabIndex = 2;
            // 
            // generacionX
            // 
            this.generacionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generacionX.ItemHeight = 20;
            this.generacionX.Location = new System.Drawing.Point(654, 301);
            this.generacionX.Name = "generacionX";
            this.generacionX.Size = new System.Drawing.Size(276, 164);
            this.generacionX.TabIndex = 3;
            // 
            // botonEmpezar
            // 
            this.botonEmpezar.Location = new System.Drawing.Point(99, 295);
            this.botonEmpezar.Name = "botonEmpezar";
            this.botonEmpezar.Size = new System.Drawing.Size(120, 41);
            this.botonEmpezar.TabIndex = 4;
            this.botonEmpezar.Text = "Empezar";
            this.botonEmpezar.UseVisualStyleBackColor = true;
            this.botonEmpezar.Click += new System.EventHandler(this.botonEmpezar_Click);
            // 
            // txtPI
            // 
            this.txtPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPI.Location = new System.Drawing.Point(190, 53);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(96, 27);
            this.txtPI.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Población";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Población Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(728, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Recorrido G1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1008, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "G2 Padres e Hijos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(678, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Recorrido Generation X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Evaluación";
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvaluacion.Location = new System.Drawing.Point(190, 124);
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(96, 27);
            this.txtEvaluacion.TabIndex = 14;
            // 
            // txtMutaciones
            // 
            this.txtMutaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMutaciones.Location = new System.Drawing.Point(1220, 353);
            this.txtMutaciones.Name = "txtMutaciones";
            this.txtMutaciones.Size = new System.Drawing.Size(96, 27);
            this.txtMutaciones.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(953, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número de Mutaciones";
            // 
            // numberGenerations
            // 
            this.numberGenerations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberGenerations.Location = new System.Drawing.Point(1220, 301);
            this.numberGenerations.Name = "numberGenerations";
            this.numberGenerations.Size = new System.Drawing.Size(96, 27);
            this.numberGenerations.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(953, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Número de Generaciones";
            // 
            // RE1
            // 
            this.RE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE1.Location = new System.Drawing.Point(260, 590);
            this.RE1.Name = "RE1";
            this.RE1.Size = new System.Drawing.Size(80, 80);
            this.RE1.TabIndex = 19;
            this.RE1.Text = "1";
            this.RE1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE2
            // 
            this.RE2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE2.Location = new System.Drawing.Point(369, 590);
            this.RE2.Name = "RE2";
            this.RE2.Size = new System.Drawing.Size(80, 80);
            this.RE2.TabIndex = 20;
            this.RE2.Text = "1";
            this.RE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE3
            // 
            this.RE3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE3.Location = new System.Drawing.Point(468, 590);
            this.RE3.Name = "RE3";
            this.RE3.Size = new System.Drawing.Size(80, 80);
            this.RE3.TabIndex = 21;
            this.RE3.Text = "2";
            this.RE3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE4
            // 
            this.RE4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE4.Location = new System.Drawing.Point(566, 590);
            this.RE4.Name = "RE4";
            this.RE4.Size = new System.Drawing.Size(80, 80);
            this.RE4.TabIndex = 22;
            this.RE4.Text = "3";
            this.RE4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE5
            // 
            this.RE5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE5.Location = new System.Drawing.Point(672, 590);
            this.RE5.Name = "RE5";
            this.RE5.Size = new System.Drawing.Size(80, 80);
            this.RE5.TabIndex = 23;
            this.RE5.Text = "4";
            this.RE5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE6
            // 
            this.RE6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE6.Location = new System.Drawing.Point(776, 590);
            this.RE6.Name = "RE6";
            this.RE6.Size = new System.Drawing.Size(80, 80);
            this.RE6.TabIndex = 24;
            this.RE6.Text = "5";
            this.RE6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE7
            // 
            this.RE7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE7.Location = new System.Drawing.Point(884, 590);
            this.RE7.Name = "RE7";
            this.RE7.Size = new System.Drawing.Size(80, 80);
            this.RE7.TabIndex = 25;
            this.RE7.Text = "6";
            this.RE7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE8
            // 
            this.RE8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE8.Location = new System.Drawing.Point(988, 590);
            this.RE8.Name = "RE8";
            this.RE8.Size = new System.Drawing.Size(80, 80);
            this.RE8.TabIndex = 26;
            this.RE8.Text = "1";
            this.RE8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE9
            // 
            this.RE9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE9.Location = new System.Drawing.Point(1083, 590);
            this.RE9.Name = "RE9";
            this.RE9.Size = new System.Drawing.Size(80, 80);
            this.RE9.TabIndex = 27;
            this.RE9.Text = "1";
            this.RE9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RE10
            // 
            this.RE10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RE10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RE10.Location = new System.Drawing.Point(1183, 590);
            this.RE10.Name = "RE10";
            this.RE10.Size = new System.Drawing.Size(80, 80);
            this.RE10.TabIndex = 28;
            this.RE10.Text = "7";
            this.RE10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Recorrido";
            // 
            // textpuntos
            // 
            this.textpuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpuntos.Location = new System.Drawing.Point(1098, 517);
            this.textpuntos.Name = "textpuntos";
            this.textpuntos.Size = new System.Drawing.Size(96, 27);
            this.textpuntos.TabIndex = 30;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1050, 457);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 25);
            this.label20.TabIndex = 31;
            this.label20.Text = "Puntos Obtenidos";
            // 
            // RG7
            // 
            this.RG7.BackColor = System.Drawing.Color.Aquamarine;
            this.RG7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG7.Location = new System.Drawing.Point(884, 482);
            this.RG7.Name = "RG7";
            this.RG7.Size = new System.Drawing.Size(80, 80);
            this.RG7.TabIndex = 38;
            this.RG7.Text = "0";
            this.RG7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RG6
            // 
            this.RG6.BackColor = System.Drawing.Color.Aquamarine;
            this.RG6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG6.Location = new System.Drawing.Point(776, 482);
            this.RG6.Name = "RG6";
            this.RG6.Size = new System.Drawing.Size(80, 80);
            this.RG6.TabIndex = 37;
            this.RG6.Text = "0";
            this.RG6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RG5
            // 
            this.RG5.BackColor = System.Drawing.Color.Aquamarine;
            this.RG5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG5.Location = new System.Drawing.Point(672, 482);
            this.RG5.Name = "RG5";
            this.RG5.Size = new System.Drawing.Size(80, 80);
            this.RG5.TabIndex = 36;
            this.RG5.Text = "0";
            this.RG5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RG4
            // 
            this.RG4.BackColor = System.Drawing.Color.Aquamarine;
            this.RG4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG4.Location = new System.Drawing.Point(566, 482);
            this.RG4.Name = "RG4";
            this.RG4.Size = new System.Drawing.Size(80, 80);
            this.RG4.TabIndex = 35;
            this.RG4.Text = "0";
            this.RG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RG3
            // 
            this.RG3.BackColor = System.Drawing.Color.Aquamarine;
            this.RG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG3.Location = new System.Drawing.Point(468, 482);
            this.RG3.Name = "RG3";
            this.RG3.Size = new System.Drawing.Size(80, 80);
            this.RG3.TabIndex = 34;
            this.RG3.Text = "0";
            this.RG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RG2
            // 
            this.RG2.BackColor = System.Drawing.Color.Aquamarine;
            this.RG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG2.Location = new System.Drawing.Point(369, 482);
            this.RG2.Name = "RG2";
            this.RG2.Size = new System.Drawing.Size(80, 80);
            this.RG2.TabIndex = 33;
            this.RG2.Text = "0";
            this.RG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RG1
            // 
            this.RG1.BackColor = System.Drawing.Color.Aquamarine;
            this.RG1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG1.Location = new System.Drawing.Point(260, 482);
            this.RG1.Name = "RG1";
            this.RG1.Size = new System.Drawing.Size(80, 80);
            this.RG1.TabIndex = 32;
            this.RG1.Text = "0";
            this.RG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(70, 497);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(68, 25);
            this.label28.TabIndex = 39;
            this.label28.Text = "Robot";
            // 
            // botonGenerar
            // 
            this.botonGenerar.Location = new System.Drawing.Point(75, 629);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(120, 41);
            this.botonGenerar.TabIndex = 40;
            this.botonGenerar.Text = "Generar";
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaGX
            // 
            this.listaGX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaGX.ItemHeight = 20;
            this.listaGX.Location = new System.Drawing.Point(323, 301);
            this.listaGX.Name = "listaGX";
            this.listaGX.Size = new System.Drawing.Size(276, 164);
            this.listaGX.TabIndex = 41;
            this.listaGX.SelectedIndexChanged += new System.EventHandler(this.listaGX_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 42;
            this.label10.Text = "Generation X";
            // 
            // mutacionparcial
            // 
            this.mutacionparcial.AutoSize = true;
            this.mutacionparcial.Location = new System.Drawing.Point(121, 192);
            this.mutacionparcial.Name = "mutacionparcial";
            this.mutacionparcial.Size = new System.Drawing.Size(134, 21);
            this.mutacionparcial.TabIndex = 43;
            this.mutacionparcial.Text = "Mutacion Parcial";
            this.mutacionparcial.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 755);
            this.Controls.Add(this.mutacionparcial);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listaGX);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.RG7);
            this.Controls.Add(this.RG6);
            this.Controls.Add(this.RG5);
            this.Controls.Add(this.RG4);
            this.Controls.Add(this.RG3);
            this.Controls.Add(this.RG2);
            this.Controls.Add(this.RG1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textpuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RE10);
            this.Controls.Add(this.RE9);
            this.Controls.Add(this.RE8);
            this.Controls.Add(this.RE7);
            this.Controls.Add(this.RE6);
            this.Controls.Add(this.RE5);
            this.Controls.Add(this.RE4);
            this.Controls.Add(this.RE3);
            this.Controls.Add(this.RE2);
            this.Controls.Add(this.RE1);
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
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label RE1;
        private System.Windows.Forms.Label RE2;
        private System.Windows.Forms.Label RE3;
        private System.Windows.Forms.Label RE4;
        private System.Windows.Forms.Label RE5;
        private System.Windows.Forms.Label RE6;
        private System.Windows.Forms.Label RE7;
        private System.Windows.Forms.Label RE8;
        private System.Windows.Forms.Label RE9;
        private System.Windows.Forms.Label RE10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpuntos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label RG7;
        private System.Windows.Forms.Label RG6;
        private System.Windows.Forms.Label RG5;
        private System.Windows.Forms.Label RG4;
        private System.Windows.Forms.Label RG3;
        private System.Windows.Forms.Label RG2;
        private System.Windows.Forms.Label RG1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.ListBox listaGX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox mutacionparcial;
    }
}

