namespace GRUPO01_EF_ESTDAT_UPN
{
    partial class FormTransferencias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferencias));
            this.lblLlamada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGrafo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUltimaLlamadaInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTiempoTransferencia = new System.Windows.Forms.Label();
            this.timerTransferencia = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Century Gothic", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLlamada.Location = new System.Drawing.Point(12, 20);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(446, 40);
            this.lblLlamada.TabIndex = 2;
            this.lblLlamada.Text = "AREA DE TRANSFERENCIAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblLlamada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 76);
            this.panel1.TabIndex = 3;
            // 
            // panelGrafo
            // 
            this.panelGrafo.Location = new System.Drawing.Point(519, 138);
            this.panelGrafo.Name = "panelGrafo";
            this.panelGrafo.Size = new System.Drawing.Size(431, 416);
            this.panelGrafo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 150);
            this.label1.TabIndex = 5;
            this.label1.Text = "1. Atención al Cliente. (AC)\r\n2. Facturación. (F)\r\n3. Soporte Tecnico. (ST)\r\n4. R" +
    "ecursos Humanos. (R.R.H.H)\r\n5. TI Interno. (TI)\r\n6. Administración. (A)";
            // 
            // lblUltimaLlamadaInfo
            // 
            this.lblUltimaLlamadaInfo.AutoSize = true;
            this.lblUltimaLlamadaInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaLlamadaInfo.Location = new System.Drawing.Point(11, 28);
            this.lblUltimaLlamadaInfo.Name = "lblUltimaLlamadaInfo";
            this.lblUltimaLlamadaInfo.Size = new System.Drawing.Size(47, 17);
            this.lblUltimaLlamadaInfo.TabIndex = 6;
            this.lblUltimaLlamadaInfo.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTiempoTransferencia);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.btnTransferir);
            this.groupBox1.Controls.Add(this.cmbAreas);
            this.groupBox1.Controls.Add(this.lblUltimaLlamadaInfo);
            this.groupBox1.Location = new System.Drawing.Point(19, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llamada en Atención";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmbAreas
            // 
            this.cmbAreas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(14, 103);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(257, 25);
            this.cmbAreas.TabIndex = 0;
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.Turquoise;
            this.btnTransferir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(291, 93);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(101, 42);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(410, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblTiempoTransferencia
            // 
            this.lblTiempoTransferencia.AutoSize = true;
            this.lblTiempoTransferencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTransferencia.Location = new System.Drawing.Point(18, 178);
            this.lblTiempoTransferencia.Name = "lblTiempoTransferencia";
            this.lblTiempoTransferencia.Size = new System.Drawing.Size(54, 18);
            this.lblTiempoTransferencia.TabIndex = 10;
            this.lblTiempoTransferencia.Text = "label2";
            // 
            // timerTransferencia
            // 
            this.timerTransferencia.Interval = 1000;
            this.timerTransferencia.Tick += new System.EventHandler(this.timerTransferencia_Tick);
            // 
            // FormTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGrafo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransferencias";
            this.Text = "FormTransferencias";
            this.Load += new System.EventHandler(this.FormTransferencias_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGrafo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUltimaLlamadaInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTiempoTransferencia;
        private System.Windows.Forms.Timer timerTransferencia;
    }
}