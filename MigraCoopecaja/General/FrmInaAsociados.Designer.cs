namespace AppEscritorio.General
{
    partial class FrmInaAsociados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInaAsociados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbParte = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarAsoActivo = new System.Windows.Forms.TextBox();
            this.BtnInactivar = new System.Windows.Forms.Button();
            this.dgAsoActivos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaAfiliacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsociado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBuscarInactivo = new System.Windows.Forms.TextBox();
            this.dgInactivados = new System.Windows.Forms.DataGridView();
            this.colCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecInactivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPFecReingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuAfilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbParte.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsoActivos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInactivados)).BeginInit();
            this.SuspendLayout();
            // 
            // TbParte
            // 
            this.TbParte.Controls.Add(this.tabPage1);
            this.TbParte.Controls.Add(this.tabPage2);
            this.TbParte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbParte.Location = new System.Drawing.Point(0, 0);
            this.TbParte.Name = "TbParte";
            this.TbParte.SelectedIndex = 0;
            this.TbParte.Size = new System.Drawing.Size(800, 450);
            this.TbParte.TabIndex = 9;
            this.TbParte.SelectedIndexChanged += new System.EventHandler(this.TbParte_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBuscarAsoActivo);
            this.tabPage1.Controls.Add(this.BtnInactivar);
            this.tabPage1.Controls.Add(this.dgAsoActivos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFechaAfiliacion);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAsociado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIdentificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestión";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar";
            // 
            // txtBuscarAsoActivo
            // 
            this.txtBuscarAsoActivo.Location = new System.Drawing.Point(236, 369);
            this.txtBuscarAsoActivo.Name = "txtBuscarAsoActivo";
            this.txtBuscarAsoActivo.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarAsoActivo.TabIndex = 18;
            this.txtBuscarAsoActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarAsoActivo_KeyPress);
            // 
            // BtnInactivar
            // 
            this.BtnInactivar.FlatAppearance.BorderSize = 0;
            this.BtnInactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInactivar.Image = ((System.Drawing.Image)(resources.GetObject("BtnInactivar.Image")));
            this.BtnInactivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnInactivar.Location = new System.Drawing.Point(585, 25);
            this.BtnInactivar.Name = "BtnInactivar";
            this.BtnInactivar.Size = new System.Drawing.Size(119, 90);
            this.BtnInactivar.TabIndex = 17;
            this.BtnInactivar.Text = "Inactivar Asociado";
            this.BtnInactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnInactivar.UseVisualStyleBackColor = true;
            this.BtnInactivar.Click += new System.EventHandler(this.BtnInactivar_Click);
            // 
            // dgAsoActivos
            // 
            this.dgAsoActivos.AllowUserToAddRows = false;
            this.dgAsoActivos.AllowUserToDeleteRows = false;
            this.dgAsoActivos.AllowUserToResizeColumns = false;
            this.dgAsoActivos.AllowUserToResizeRows = false;
            this.dgAsoActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsoActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodCliente,
            this.colDesIdentificacion,
            this.colNomCliente,
            this.colFecAfiliacion,
            this.colFecInactivo,
            this.colFecRegistro,
            this.colPFecReingreso,
            this.colUsuRegistro,
            this.colUsuAfilia,
            this.colCodEstado});
            this.dgAsoActivos.Location = new System.Drawing.Point(8, 148);
            this.dgAsoActivos.MultiSelect = false;
            this.dgAsoActivos.Name = "dgAsoActivos";
            this.dgAsoActivos.ReadOnly = true;
            this.dgAsoActivos.RowHeadersVisible = false;
            this.dgAsoActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsoActivos.Size = new System.Drawing.Size(776, 201);
            this.dgAsoActivos.TabIndex = 16;
            this.dgAsoActivos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAsoActivos_CellEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha afiliación";
            // 
            // txtFechaAfiliacion
            // 
            this.txtFechaAfiliacion.Location = new System.Drawing.Point(142, 94);
            this.txtFechaAfiliacion.Name = "txtFechaAfiliacion";
            this.txtFechaAfiliacion.ReadOnly = true;
            this.txtFechaAfiliacion.Size = new System.Drawing.Size(314, 20);
            this.txtFechaAfiliacion.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asociado";
            // 
            // txtAsociado
            // 
            this.txtAsociado.Location = new System.Drawing.Point(142, 54);
            this.txtAsociado.Name = "txtAsociado";
            this.txtAsociado.ReadOnly = true;
            this.txtAsociado.Size = new System.Drawing.Size(314, 20);
            this.txtAsociado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Identificacion";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(142, 17);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(173, 20);
            this.txtIdentificacion.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtBuscarInactivo);
            this.tabPage2.Controls.Add(this.dgInactivados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bitacora";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Buscar";
            // 
            // TxtBuscarInactivo
            // 
            this.TxtBuscarInactivo.Location = new System.Drawing.Point(236, 369);
            this.TxtBuscarInactivo.Name = "TxtBuscarInactivo";
            this.TxtBuscarInactivo.Size = new System.Drawing.Size(275, 20);
            this.TxtBuscarInactivo.TabIndex = 20;
            this.TxtBuscarInactivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarInactivo_KeyPress);
            // 
            // dgInactivados
            // 
            this.dgInactivados.AllowUserToAddRows = false;
            this.dgInactivados.AllowUserToDeleteRows = false;
            this.dgInactivados.AllowUserToResizeColumns = false;
            this.dgInactivados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInactivados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgInactivados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInactivados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInactivados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgInactivados.Location = new System.Drawing.Point(6, 6);
            this.dgInactivados.MultiSelect = false;
            this.dgInactivados.Name = "dgInactivados";
            this.dgInactivados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInactivados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgInactivados.RowHeadersVisible = false;
            this.dgInactivados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInactivados.Size = new System.Drawing.Size(776, 339);
            this.dgInactivados.TabIndex = 17;
            // 
            // colCodCliente
            // 
            this.colCodCliente.DataPropertyName = "COD_CLIENTE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCodCliente.HeaderText = "Cod_Cliente";
            this.colCodCliente.Name = "colCodCliente";
            this.colCodCliente.ReadOnly = true;
            this.colCodCliente.Visible = false;
            // 
            // colDesIdentificacion
            // 
            this.colDesIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDesIdentificacion.DataPropertyName = "DES_IDENTIFICACION";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDesIdentificacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDesIdentificacion.HeaderText = "Identificacion";
            this.colDesIdentificacion.Name = "colDesIdentificacion";
            this.colDesIdentificacion.ReadOnly = true;
            this.colDesIdentificacion.Width = 95;
            // 
            // colNomCliente
            // 
            this.colNomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNomCliente.DataPropertyName = "NOM_CLIENTE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNomCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNomCliente.HeaderText = "Asociado";
            this.colNomCliente.Name = "colNomCliente";
            this.colNomCliente.ReadOnly = true;
            // 
            // colFecAfiliacion
            // 
            this.colFecAfiliacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFecAfiliacion.DataPropertyName = "FEC_AFILIACION";
            this.colFecAfiliacion.HeaderText = "Afiliacion";
            this.colFecAfiliacion.Name = "colFecAfiliacion";
            this.colFecAfiliacion.ReadOnly = true;
            this.colFecAfiliacion.Width = 74;
            // 
            // colFecInactivo
            // 
            this.colFecInactivo.DataPropertyName = "FEC_INACTIVO";
            this.colFecInactivo.HeaderText = "FecInactivo";
            this.colFecInactivo.Name = "colFecInactivo";
            this.colFecInactivo.ReadOnly = true;
            this.colFecInactivo.Visible = false;
            // 
            // colFecRegistro
            // 
            this.colFecRegistro.DataPropertyName = "FEC_REGISTRO";
            this.colFecRegistro.HeaderText = "FecRegistro";
            this.colFecRegistro.Name = "colFecRegistro";
            this.colFecRegistro.ReadOnly = true;
            this.colFecRegistro.Visible = false;
            // 
            // colPFecReingreso
            // 
            this.colPFecReingreso.DataPropertyName = "PFEC_REINGRESO";
            this.colPFecReingreso.HeaderText = "Reingreso";
            this.colPFecReingreso.Name = "colPFecReingreso";
            this.colPFecReingreso.ReadOnly = true;
            this.colPFecReingreso.Visible = false;
            // 
            // colUsuRegistro
            // 
            this.colUsuRegistro.DataPropertyName = "USU_REGISTRO";
            this.colUsuRegistro.HeaderText = "Usuario";
            this.colUsuRegistro.Name = "colUsuRegistro";
            this.colUsuRegistro.ReadOnly = true;
            this.colUsuRegistro.Visible = false;
            // 
            // colUsuAfilia
            // 
            this.colUsuAfilia.DataPropertyName = "USU_AFILIA";
            this.colUsuAfilia.HeaderText = "Afilia";
            this.colUsuAfilia.Name = "colUsuAfilia";
            this.colUsuAfilia.ReadOnly = true;
            this.colUsuAfilia.Visible = false;
            // 
            // colCodEstado
            // 
            this.colCodEstado.DataPropertyName = "COD_ESTADO";
            this.colCodEstado.HeaderText = "Estado";
            this.colCodEstado.Name = "colCodEstado";
            this.colCodEstado.ReadOnly = true;
            this.colCodEstado.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DES_IDENTIFICACION";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identificacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "COD_CLIENTE";
            this.Column1.HeaderText = "CodCliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FEC_AFILIACION";
            this.Column2.HeaderText = "FecAfiliacion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FEC_REGISTRO";
            this.Column3.HeaderText = "FecRegistro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PFEC_REINGRESO";
            this.Column4.HeaderText = "PFecReingreso";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "USU_AFILIA";
            this.Column5.HeaderText = "UsuAfilia";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "COD_ESTADO";
            this.Column6.HeaderText = "CodEstado";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOM_CLIENTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Asociado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FEC_INACTIVO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Inactivo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "USU_REGISTRO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 68;
            // 
            // FrmInaAsociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbParte);
            this.Name = "FrmInaAsociados";
            this.Text = "Inactivar Asociados";
            this.Load += new System.EventHandler(this.FrmInaAsociados_Load);
            this.TbParte.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsoActivos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInactivados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbParte;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarAsoActivo;
        private System.Windows.Forms.Button BtnInactivar;
        private System.Windows.Forms.DataGridView dgAsoActivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaAfiliacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsociado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBuscarInactivo;
        private System.Windows.Forms.DataGridView dgInactivados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecInactivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPFecReingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuAfilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}