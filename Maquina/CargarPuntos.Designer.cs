namespace Maquina
{
    partial class CargarPuntos
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
            this.reconocimientoBotellas = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.camaras = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reconocimientoBotellas)).BeginInit();
            this.SuspendLayout();
            // 
            // reconocimientoBotellas
            // 
            this.reconocimientoBotellas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reconocimientoBotellas.Location = new System.Drawing.Point(73, 44);
            this.reconocimientoBotellas.Name = "reconocimientoBotellas";
            this.reconocimientoBotellas.Size = new System.Drawing.Size(523, 368);
            this.reconocimientoBotellas.TabIndex = 2;
            this.reconocimientoBotellas.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(925, 422);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 35);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(713, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cuenta:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblUsuario.Location = new System.Drawing.Point(820, 40);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(48, 29);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "NA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(715, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Puntos:";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPuntos.Location = new System.Drawing.Point(820, 113);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(48, 29);
            this.lblPuntos.TabIndex = 9;
            this.lblPuntos.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(774, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "id:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblID.Location = new System.Drawing.Point(820, 182);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(48, 29);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "NA";
            // 
            // camaras
            // 
            this.camaras.FormattingEnabled = true;
            this.camaras.Location = new System.Drawing.Point(73, 422);
            this.camaras.Name = "camaras";
            this.camaras.Size = new System.Drawing.Size(165, 24);
            this.camaras.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CargarPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.camaras);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.reconocimientoBotellas);
            this.Name = "CargarPuntos";
            this.Text = "CargarPuntos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CargarPuntos_FormClosing);
            this.Load += new System.EventHandler(this.CargarPuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reconocimientoBotellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox reconocimientoBotellas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox camaras;
        private System.Windows.Forms.Button button1;
    }
}