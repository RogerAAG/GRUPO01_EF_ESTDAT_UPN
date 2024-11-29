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
            this.panel1.SuspendLayout();
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
            this.btnSi.Location = new System.Drawing.Point(301, 346);
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
            this.btnFinalizarLlamada.Location = new System.Drawing.Point(646, 517);
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
            this.btnLlamadaInterrumpida.Location = new System.Drawing.Point(70, 517);
            this.btnLlamadaInterrumpida.Name = "btnLlamadaInterrumpida";
            this.btnLlamadaInterrumpida.Size = new System.Drawing.Size(237, 59);
            this.btnLlamadaInterrumpida.TabIndex = 5;
            this.btnLlamadaInterrumpida.Text = "Llamada Interrumpida";
            this.btnLlamadaInterrumpida.UseVisualStyleBackColor = false;
            this.btnLlamadaInterrumpida.Click += new System.EventHandler(this.btnLlamadaInterrumpida_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
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
            this.lblLlamadaInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamadaInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLlamadaInfo.Location = new System.Drawing.Point(334, 78);
            this.lblLlamadaInfo.Name = "lblLlamadaInfo";
            this.lblLlamadaInfo.Size = new System.Drawing.Size(57, 21);
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
            this.btnReiniciar.Location = new System.Drawing.Point(429, 416);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(110, 36);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cmbServicios
            // 
            this.cmbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Items.AddRange(new object[] {
            "servicio de internet",
            "tv por cable",
            "telefonia fija"});
            this.cmbServicios.Location = new System.Drawing.Point(338, 142);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(197, 24);
            this.cmbServicios.TabIndex = 8;
            // 
            // btnSeleccionarServicio
            // 
            this.btnSeleccionarServicio.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSeleccionarServicio.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarServicio.Location = new System.Drawing.Point(563, 133);
            this.btnSeleccionarServicio.Name = "btnSeleccionarServicio";
            this.btnSeleccionarServicio.Size = new System.Drawing.Size(110, 36);
            this.btnSeleccionarServicio.TabIndex = 9;
            this.btnSeleccionarServicio.Text = "Seleccionar";
            this.btnSeleccionarServicio.UseVisualStyleBackColor = false;
            this.btnSeleccionarServicio.Click += new System.EventHandler(this.btnSeleccionarServicio_Click);
            // 
            // FormAgentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.btnSeleccionarServicio);
            this.Controls.Add(this.cmbServicios);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLlamadaInterrumpida);
            this.Controls.Add(this.btnFinalizarLlamada);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgentes";
            this.Text = "FormAgentes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}