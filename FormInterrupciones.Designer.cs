namespace GRUPO01_EF_ESTDAT_UPN
{
    partial class FormInterrupciones
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
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDevolverLlamada = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Location = new System.Drawing.Point(202, 209);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(511, 305);
            this.dgvPila.TabIndex = 0;
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Century Gothic", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLlamada.Location = new System.Drawing.Point(228, 41);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(461, 40);
            this.lblLlamada.TabIndex = 1;
            this.lblLlamada.Text = "LLAMADAS INTERRUMPIDAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.lblLlamada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 121);
            this.panel1.TabIndex = 2;
            // 
            // btnDevolverLlamada
            // 
            this.btnDevolverLlamada.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDevolverLlamada.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolverLlamada.Location = new System.Drawing.Point(342, 538);
            this.btnDevolverLlamada.Name = "btnDevolverLlamada";
            this.btnDevolverLlamada.Size = new System.Drawing.Size(237, 59);
            this.btnDevolverLlamada.TabIndex = 6;
            this.btnDevolverLlamada.Text = "Devolver Llamada";
            this.btnDevolverLlamada.UseVisualStyleBackColor = false;
            this.btnDevolverLlamada.Click += new System.EventHandler(this.btnDevolverLlamada_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(265, 152);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(151, 39);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVaciar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(519, 152);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(151, 39);
            this.btnVaciar.TabIndex = 8;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // FormInterrupciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnDevolverLlamada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPila);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInterrupciones";
            this.Text = "FormInterrupciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDevolverLlamada;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnVaciar;
    }
}