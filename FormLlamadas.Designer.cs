namespace GRUPO01_EF_ESTDAT_UPN
{
    partial class FormLlamadas
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCantidadLlamada = new System.Windows.Forms.Label();
            this.lblCantidadLLamadas = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarLlamada = new System.Windows.Forms.Button();
            this.btnAtenderLlamada = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.pnlEmpresa = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.pnlEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(201)))), ((int)(((byte)(217)))));
            this.pnlTop.Controls.Add(this.lblCantidadLlamada);
            this.pnlTop.Controls.Add(this.lblCantidadLLamadas);
            this.pnlTop.Controls.Add(this.btnSimular);
            this.pnlTop.Controls.Add(this.btnVaciar);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.txtCliente);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.cmbTipoCliente);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnAgregarLlamada);
            this.pnlTop.Controls.Add(this.btnAtenderLlamada);
            this.pnlTop.Controls.Add(this.txtTelefono);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(950, 218);
            this.pnlTop.TabIndex = 0;
            // 
            // lblCantidadLlamada
            // 
            this.lblCantidadLlamada.AutoSize = true;
            this.lblCantidadLlamada.Location = new System.Drawing.Point(658, 173);
            this.lblCantidadLlamada.Name = "lblCantidadLlamada";
            this.lblCantidadLlamada.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadLlamada.TabIndex = 24;
            this.lblCantidadLlamada.Text = "label7";
            // 
            // lblCantidadLLamadas
            // 
            this.lblCantidadLLamadas.AutoSize = true;
            this.lblCantidadLLamadas.Location = new System.Drawing.Point(744, 183);
            this.lblCantidadLLamadas.Name = "lblCantidadLLamadas";
            this.lblCantidadLLamadas.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadLLamadas.TabIndex = 23;
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSimular.FlatAppearance.BorderSize = 0;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(559, 23);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(99, 29);
            this.btnSimular.TabIndex = 22;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVaciar.FlatAppearance.BorderSize = 0;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.Location = new System.Drawing.Point(80, 159);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(195, 37);
            this.btnVaciar.TabIndex = 21;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo de Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(99, 105);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(176, 24);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teléfono:";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.AutoCompleteCustomSource.AddRange(new string[] {
            "Cliente General",
            "Empresa"});
            this.cmbTipoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Cliente General",
            "Empresarial"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(454, 88);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(204, 25);
            this.cmbTipoCliente.TabIndex = 3;
            this.cmbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "GESTOR DE LLAMADAS";
            // 
            // btnAgregarLlamada
            // 
            this.btnAgregarLlamada.BackColor = System.Drawing.Color.Turquoise;
            this.btnAgregarLlamada.FlatAppearance.BorderSize = 0;
            this.btnAgregarLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLlamada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLlamada.Location = new System.Drawing.Point(690, 79);
            this.btnAgregarLlamada.Name = "btnAgregarLlamada";
            this.btnAgregarLlamada.Size = new System.Drawing.Size(195, 37);
            this.btnAgregarLlamada.TabIndex = 4;
            this.btnAgregarLlamada.Text = "Agregar Llamada";
            this.btnAgregarLlamada.UseVisualStyleBackColor = false;
            this.btnAgregarLlamada.Click += new System.EventHandler(this.btnAgregarLlamada_Click);
            // 
            // btnAtenderLlamada
            // 
            this.btnAtenderLlamada.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAtenderLlamada.FlatAppearance.BorderSize = 0;
            this.btnAtenderLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtenderLlamada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtenderLlamada.Location = new System.Drawing.Point(324, 157);
            this.btnAtenderLlamada.Name = "btnAtenderLlamada";
            this.btnAtenderLlamada.Size = new System.Drawing.Size(314, 41);
            this.btnAtenderLlamada.TabIndex = 5;
            this.btnAtenderLlamada.Text = "Atender Llamada";
            this.btnAtenderLlamada.UseVisualStyleBackColor = false;
            this.btnAtenderLlamada.Click += new System.EventHandler(this.btnAtenderLlamada_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(99, 69);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(176, 24);
            this.txtTelefono.TabIndex = 1;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.pnlGeneral.Controls.Add(this.label5);
            this.pnlGeneral.Controls.Add(this.dgvGeneral);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGeneral.Location = new System.Drawing.Point(0, 218);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(477, 417);
            this.pnlGeneral.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Lista de Llamadas General:";
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Location = new System.Drawing.Point(12, 36);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.Size = new System.Drawing.Size(450, 369);
            this.dgvGeneral.TabIndex = 0;
            // 
            // pnlEmpresa
            // 
            this.pnlEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.pnlEmpresa.Controls.Add(this.label6);
            this.pnlEmpresa.Controls.Add(this.dgvEmpresa);
            this.pnlEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmpresa.Location = new System.Drawing.Point(477, 218);
            this.pnlEmpresa.Name = "pnlEmpresa";
            this.pnlEmpresa.Size = new System.Drawing.Size(473, 417);
            this.pnlEmpresa.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Lista Llamadas de Empresas:";
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(12, 36);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(448, 368);
            this.dgvEmpresa.TabIndex = 1;
            // 
            // FormLlamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 635);
            this.Controls.Add(this.pnlEmpresa);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLlamadas";
            this.Text = "FormLlamadas";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.pnlEmpresa.ResumeLayout(false);
            this.pnlEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlGeneral;
        private System.Windows.Forms.Panel pnlEmpresa;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarLlamada;
        private System.Windows.Forms.Button btnAtenderLlamada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantidadLLamadas;
        private System.Windows.Forms.Label lblCantidadLlamada;
    }
}