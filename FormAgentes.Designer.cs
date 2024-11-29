namespace GRUPO01_EF_ESTDAT_UPN
{
    partial class FormAgentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgentes));
            this.cmbAgentes = new System.Windows.Forms.ComboBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnFinalizarLlamada = new System.Windows.Forms.Button();
            this.btnLlamadaInterrumpida = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLlamadaInfo = new System.Windows.Forms.Label();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarServicio = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAgentes
            // 
            this.cmbAgentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgentes.FormattingEnabled = true;
            this.cmbAgentes.Items.AddRange(new object[] {
            "Agente 1",
            "Agente 2",
            "Agente 3",
            "Agente 4"});
            this.cmbAgentes.Location = new System.Drawing.Point(51, 74);
            this.cmbAgentes.Name = "cmbAgentes";
            this.cmbAgentes.Size = new System.Drawing.Size(256, 25);
            this.cmbAgentes.TabIndex = 0;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(213, 229);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(94, 32);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "label1";
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.Location = new System.Drawing.Point(276, 346);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(123, 40);
            this.btnSi.TabIndex = 2;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(550, 346);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(123, 40);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnFinalizarLlamada
            // 
            this.btnFinalizarLlamada.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnFinalizarLlamada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarLlamada.Location = new System.Drawing.Point(617, 517);
            this.btnFinalizarLlamada.Name = "btnFinalizarLlamada";
            this.btnFinalizarLlamada.Size = new System.Drawing.Size(237, 59);
            this.btnFinalizarLlamada.TabIndex = 4;
            this.btnFinalizarLlamada.Text = "Finalizar Llamada";
            this.btnFinalizarLlamada.UseVisualStyleBackColor = false;
            this.btnFinalizarLlamada.Click += new System.EventHandler(this.btnFinalizarLlamada_Click);
            // 
            // btnLlamadaInterrumpida
            // 
            this.btnLlamadaInterrumpida.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLlamadaInterrumpida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamadaInterrumpida.Location = new System.Drawing.Point(105, 517);
            this.btnLlamadaInterrumpida.Name = "btnLlamadaInterrumpida";
            this.btnLlamadaInterrumpida.Size = new System.Drawing.Size(237, 59);
            this.btnLlamadaInterrumpida.TabIndex = 5;
            this.btnLlamadaInterrumpida.Text = "Llamada Interrumpida";
            this.btnLlamadaInterrumpida.UseVisualStyleBackColor = false;
            this.btnLlamadaInterrumpida.Click += new System.EventHandler(this.btnLlamadaInterrumpida_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblLlamadaInfo);
            this.panel1.Controls.Add(this.lblLlamada);
            this.panel1.Controls.Add(this.cmbAgentes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 127);
            this.panel1.TabIndex = 6;
            // 
            // lblLlamadaInfo
            // 
            this.lblLlamadaInfo.AutoSize = true;
            this.lblLlamadaInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamadaInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLlamadaInfo.Location = new System.Drawing.Point(320, 74);
            this.lblLlamadaInfo.Name = "lblLlamadaInfo";
            this.lblLlamadaInfo.Size = new System.Drawing.Size(69, 23);
            this.lblLlamadaInfo.TabIndex = 3;
            this.lblLlamadaInfo.Text = "label1";
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Century Gothic", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLlamada.Location = new System.Drawing.Point(12, 9);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(430, 40);
            this.lblLlamada.TabIndex = 2;
            this.lblLlamada.Text = "ATENCIÓN DE LLAMADAS";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(425, 401);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(110, 36);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cmbServicios
            // 
            this.cmbServicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Items.AddRange(new object[] {
            "Servicio de Internet",
            "TV por Cable",
            "Telefonia Fija"});
            this.cmbServicios.Location = new System.Drawing.Point(265, 145);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(211, 29);
            this.cmbServicios.TabIndex = 8;
            // 
            // btnSeleccionarServicio
            // 
            this.btnSeleccionarServicio.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSeleccionarServicio.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarServicio.Location = new System.Drawing.Point(501, 137);
            this.btnSeleccionarServicio.Name = "btnSeleccionarServicio";
            this.btnSeleccionarServicio.Size = new System.Drawing.Size(159, 42);
            this.btnSeleccionarServicio.TabIndex = 9;
            this.btnSeleccionarServicio.Text = "Seleccionar";
            this.btnSeleccionarServicio.UseVisualStyleBackColor = false;
            this.btnSeleccionarServicio.Click += new System.EventHandler(this.btnSeleccionarServicio_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 469);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 140);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 517);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(851, 517);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // FormAgentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.btnFinalizarLlamada);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSeleccionarServicio);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLlamadaInterrumpida);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgentes";
            this.Text = "FormAgentes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAgentes;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnFinalizarLlamada;
        private System.Windows.Forms.Button btnLlamadaInterrumpida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Label lblLlamadaInfo;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Button btnSeleccionarServicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}