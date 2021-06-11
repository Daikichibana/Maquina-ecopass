namespace Maquina
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
            this.components = new System.ComponentModel.Container();
            this.camaras = new System.Windows.Forms.ComboBox();
            this.codigoQR = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnConectarCam = new System.Windows.Forms.Button();
            this.btnCargarPts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Paradas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.nombreParada = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // camaras
            // 
            this.camaras.FormattingEnabled = true;
            this.camaras.Location = new System.Drawing.Point(833, 112);
            this.camaras.Name = "camaras";
            this.camaras.Size = new System.Drawing.Size(212, 24);
            this.camaras.TabIndex = 0;
            this.camaras.SelectedIndexChanged += new System.EventHandler(this.camaras_SelectedIndexChanged);
            // 
            // codigoQR
            // 
            this.codigoQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codigoQR.Location = new System.Drawing.Point(243, 49);
            this.codigoQR.Name = "codigoQR";
            this.codigoQR.Size = new System.Drawing.Size(523, 368);
            this.codigoQR.TabIndex = 1;
            this.codigoQR.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 134);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar Viaje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConectarCam
            // 
            this.btnConectarCam.Location = new System.Drawing.Point(833, 156);
            this.btnConectarCam.Name = "btnConectarCam";
            this.btnConectarCam.Size = new System.Drawing.Size(212, 32);
            this.btnConectarCam.TabIndex = 2;
            this.btnConectarCam.Text = "Conectar Camara";
            this.btnConectarCam.UseVisualStyleBackColor = true;
            this.btnConectarCam.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCargarPts
            // 
            this.btnCargarPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCargarPts.Location = new System.Drawing.Point(12, 283);
            this.btnCargarPts.Name = "btnCargarPts";
            this.btnCargarPts.Size = new System.Drawing.Size(212, 134);
            this.btnCargarPts.TabIndex = 4;
            this.btnCargarPts.Text = "Cargar Puntos";
            this.btnCargarPts.UseVisualStyleBackColor = true;
            this.btnCargarPts.Click += new System.EventHandler(this.btnCargarPts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(876, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Configuracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(829, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Camara";
            // 
            // Paradas
            // 
            this.Paradas.FormattingEnabled = true;
            this.Paradas.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L"});
            this.Paradas.Location = new System.Drawing.Point(833, 246);
            this.Paradas.Name = "Paradas";
            this.Paradas.Size = new System.Drawing.Size(212, 24);
            this.Paradas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(830, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre Parada";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(833, 286);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(212, 32);
            this.btnCambiar.TabIndex = 10;
            this.btnCambiar.Text = "Cambiar Parada";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // nombreParada
            // 
            this.nombreParada.AutoSize = true;
            this.nombreParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nombreParada.Location = new System.Drawing.Point(1028, 433);
            this.nombreParada.Name = "nombreParada";
            this.nombreParada.Size = new System.Drawing.Size(32, 20);
            this.nombreParada.TabIndex = 11;
            this.nombreParada.Text = "NP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(903, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parada Actual:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombreParada);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Paradas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarPts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConectarCam);
            this.Controls.Add(this.codigoQR);
            this.Controls.Add(this.camaras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.codigoQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox codigoQR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreParada;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnCargarPts;
        public System.Windows.Forms.ComboBox Paradas;
        public System.Windows.Forms.Button btnCambiar;
        public System.Windows.Forms.ComboBox camaras;
        public System.Windows.Forms.Button btnConectarCam;
    }
}

