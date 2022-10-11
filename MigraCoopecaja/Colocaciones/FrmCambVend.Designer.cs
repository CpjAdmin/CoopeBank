namespace AppEscritorio.Colocaciones
{
    partial class FrmCambVend
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
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNomAsesor = new System.Windows.Forms.TextBox();
            this.txtCodAsesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomAsesorN = new System.Windows.Forms.TextBox();
            this.txtCodAsesorN = new System.Windows.Forms.TextBox();
            this.btnAsesor = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rdbSoli = new System.Windows.Forms.RadioButton();
            this.rdbOper = new System.Windows.Forms.RadioButton();
            this.btnSucursal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomSucursalN = new System.Windows.Forms.TextBox();
            this.txtSucursalN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomSucursal = new System.Windows.Forms.TextBox();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomCliente.Enabled = false;
            this.txtNomCliente.Location = new System.Drawing.Point(134, 81);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.ReadOnly = true;
            this.txtNomCliente.Size = new System.Drawing.Size(335, 20);
            this.txtNomCliente.TabIndex = 53;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(12, 81);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCodCliente.TabIndex = 52;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 36);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtSolicitud_TextChanged);
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtSolicitud_Validating);
            // 
            // txtNomAsesor
            // 
            this.txtNomAsesor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomAsesor.Enabled = false;
            this.txtNomAsesor.Location = new System.Drawing.Point(134, 128);
            this.txtNomAsesor.Name = "txtNomAsesor";
            this.txtNomAsesor.ReadOnly = true;
            this.txtNomAsesor.Size = new System.Drawing.Size(335, 20);
            this.txtNomAsesor.TabIndex = 56;
            // 
            // txtCodAsesor
            // 
            this.txtCodAsesor.Enabled = false;
            this.txtCodAsesor.Location = new System.Drawing.Point(12, 128);
            this.txtCodAsesor.Name = "txtCodAsesor";
            this.txtCodAsesor.Size = new System.Drawing.Size(100, 20);
            this.txtCodAsesor.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Asesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nuevo Asesor";
            // 
            // txtNomAsesorN
            // 
            this.txtNomAsesorN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomAsesorN.Enabled = false;
            this.txtNomAsesorN.Location = new System.Drawing.Point(134, 179);
            this.txtNomAsesorN.Name = "txtNomAsesorN";
            this.txtNomAsesorN.ReadOnly = true;
            this.txtNomAsesorN.Size = new System.Drawing.Size(335, 20);
            this.txtNomAsesorN.TabIndex = 61;
            // 
            // txtCodAsesorN
            // 
            this.txtCodAsesorN.Enabled = false;
            this.txtCodAsesorN.Location = new System.Drawing.Point(12, 179);
            this.txtCodAsesorN.Name = "txtCodAsesorN";
            this.txtCodAsesorN.Size = new System.Drawing.Size(100, 20);
            this.txtCodAsesorN.TabIndex = 60;
            // 
            // btnAsesor
            // 
            this.btnAsesor.Location = new System.Drawing.Point(475, 177);
            this.btnAsesor.Name = "btnAsesor";
            this.btnAsesor.Size = new System.Drawing.Size(26, 23);
            this.btnAsesor.TabIndex = 2;
            this.btnAsesor.Text = "...";
            this.btnAsesor.UseVisualStyleBackColor = true;
            this.btnAsesor.Click += new System.EventHandler(this.btnAsesor_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(228, 325);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rdbSoli
            // 
            this.rdbSoli.AutoSize = true;
            this.rdbSoli.Checked = true;
            this.rdbSoli.Location = new System.Drawing.Point(12, 12);
            this.rdbSoli.Name = "rdbSoli";
            this.rdbSoli.Size = new System.Drawing.Size(65, 17);
            this.rdbSoli.TabIndex = 63;
            this.rdbSoli.TabStop = true;
            this.rdbSoli.Text = "Solicitud";
            this.rdbSoli.UseVisualStyleBackColor = true;
            // 
            // rdbOper
            // 
            this.rdbOper.AutoSize = true;
            this.rdbOper.Location = new System.Drawing.Point(80, 12);
            this.rdbOper.Name = "rdbOper";
            this.rdbOper.Size = new System.Drawing.Size(74, 17);
            this.rdbOper.TabIndex = 64;
            this.rdbOper.Text = "Operación";
            this.rdbOper.UseVisualStyleBackColor = true;
            // 
            // btnSucursal
            // 
            this.btnSucursal.Location = new System.Drawing.Point(476, 281);
            this.btnSucursal.Name = "btnSucursal";
            this.btnSucursal.Size = new System.Drawing.Size(26, 23);
            this.btnSucursal.TabIndex = 65;
            this.btnSucursal.Text = "...";
            this.btnSucursal.UseVisualStyleBackColor = true;
            this.btnSucursal.Click += new System.EventHandler(this.btnSucursal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Nueva Sucursal";
            // 
            // txtNomSucursalN
            // 
            this.txtNomSucursalN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomSucursalN.Enabled = false;
            this.txtNomSucursalN.Location = new System.Drawing.Point(135, 283);
            this.txtNomSucursalN.Name = "txtNomSucursalN";
            this.txtNomSucursalN.ReadOnly = true;
            this.txtNomSucursalN.Size = new System.Drawing.Size(335, 20);
            this.txtNomSucursalN.TabIndex = 70;
            // 
            // txtSucursalN
            // 
            this.txtSucursalN.Enabled = false;
            this.txtSucursalN.Location = new System.Drawing.Point(13, 283);
            this.txtSucursalN.Name = "txtSucursalN";
            this.txtSucursalN.Size = new System.Drawing.Size(100, 20);
            this.txtSucursalN.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Sucursal";
            // 
            // txtNomSucursal
            // 
            this.txtNomSucursal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNomSucursal.Enabled = false;
            this.txtNomSucursal.Location = new System.Drawing.Point(135, 232);
            this.txtNomSucursal.Name = "txtNomSucursal";
            this.txtNomSucursal.ReadOnly = true;
            this.txtNomSucursal.Size = new System.Drawing.Size(335, 20);
            this.txtNomSucursal.TabIndex = 67;
            // 
            // txtSucursal
            // 
            this.txtSucursal.Enabled = false;
            this.txtSucursal.Location = new System.Drawing.Point(13, 232);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(100, 20);
            this.txtSucursal.TabIndex = 66;
            // 
            // FrmCambVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 368);
            this.Controls.Add(this.btnSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomSucursalN);
            this.Controls.Add(this.txtSucursalN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomSucursal);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.rdbOper);
            this.Controls.Add(this.rdbSoli);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAsesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomAsesorN);
            this.Controls.Add(this.txtCodAsesorN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomAsesor);
            this.Controls.Add(this.txtCodAsesor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(this.txtCodCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCambVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de vendedores y sucursales en operaciones";
            this.Load += new System.EventHandler(this.FrmCambVend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNomAsesor;
        private System.Windows.Forms.TextBox txtCodAsesor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomAsesorN;
        private System.Windows.Forms.TextBox txtCodAsesorN;
        private System.Windows.Forms.Button btnAsesor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RadioButton rdbSoli;
        private System.Windows.Forms.RadioButton rdbOper;
        private System.Windows.Forms.Button btnSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomSucursalN;
        private System.Windows.Forms.TextBox txtSucursalN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomSucursal;
        private System.Windows.Forms.TextBox txtSucursal;
    }
}