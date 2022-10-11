namespace AppEscritorio.General
{
    partial class FrmReingresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReingresos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TbParte = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbUsuReingreso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtReingreso = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarRenunciado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgRenuncias = new System.Windows.Forms.DataGridView();
            this.colCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecAfiliacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecRenuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodUsuarioRen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUbiRenuncia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaRenuncia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsociado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBuscarReingrso = new System.Windows.Forms.TextBox();
            this.dgReingresados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbParte.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRenuncias)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReingresados)).BeginInit();
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
            this.TbParte.TabIndex = 8;
            this.TbParte.SelectedIndexChanged += new System.EventHandler(this.TbParte_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbUsuReingreso);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtReingreso);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBuscarRenunciado);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dgRenuncias);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFechaRenuncia);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtAsociado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtIdentificacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reingresos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // cmbUsuReingreso
            // 
            this.cmbUsuReingreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuReingreso.FormattingEnabled = true;
            this.cmbUsuReingreso.Location = new System.Drawing.Point(142, 174);
            this.cmbUsuReingreso.Name = "cmbUsuReingreso";
            this.cmbUsuReingreso.Size = new System.Drawing.Size(314, 21);
            this.cmbUsuReingreso.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Usuario reingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha reingreso";
            // 
            // dtReingreso
            // 
            this.dtReingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReingreso.Location = new System.Drawing.Point(142, 130);
            this.dtReingreso.Name = "dtReingreso";
            this.dtReingreso.Size = new System.Drawing.Size(200, 20);
            this.dtReingreso.TabIndex = 20;
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
            // txtBuscarRenunciado
            // 
            this.txtBuscarRenunciado.Location = new System.Drawing.Point(236, 369);
            this.txtBuscarRenunciado.Name = "txtBuscarRenunciado";
            this.txtBuscarRenunciado.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarRenunciado.TabIndex = 18;
            this.txtBuscarRenunciado.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscarRenunciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(585, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 90);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reingresar Asociado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgRenuncias
            // 
            this.dgRenuncias.AllowUserToAddRows = false;
            this.dgRenuncias.AllowUserToDeleteRows = false;
            this.dgRenuncias.AllowUserToResizeColumns = false;
            this.dgRenuncias.AllowUserToResizeRows = false;
            this.dgRenuncias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRenuncias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodCliente,
            this.colDesIdentificacion,
            this.colNomCliente,
            this.colFecAfiliacion,
            this.colFecRenuncia,
            this.colCodUsuarioRen,
            this.colUbiRenuncia});
            this.dgRenuncias.Location = new System.Drawing.Point(8, 211);
            this.dgRenuncias.MultiSelect = false;
            this.dgRenuncias.Name = "dgRenuncias";
            this.dgRenuncias.ReadOnly = true;
            this.dgRenuncias.RowHeadersVisible = false;
            this.dgRenuncias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRenuncias.Size = new System.Drawing.Size(776, 138);
            this.dgRenuncias.TabIndex = 16;
            this.dgRenuncias.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgRenuncias_CellEnter);
            // 
            // colCodCliente
            // 
            this.colCodCliente.DataPropertyName = "COD_CLIENTE";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodCliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCodCliente.HeaderText = "COD_CLIENTE";
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
            // colFecRenuncia
            // 
            this.colFecRenuncia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colFecRenuncia.DataPropertyName = "FEC_RENUNCIA";
            this.colFecRenuncia.HeaderText = "Renuncia";
            this.colFecRenuncia.Name = "colFecRenuncia";
            this.colFecRenuncia.ReadOnly = true;
            this.colFecRenuncia.Width = 78;
            // 
            // colCodUsuarioRen
            // 
            this.colCodUsuarioRen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCodUsuarioRen.DataPropertyName = "COD_USUARIO_REN";
            this.colCodUsuarioRen.HeaderText = "Usuario";
            this.colCodUsuarioRen.Name = "colCodUsuarioRen";
            this.colCodUsuarioRen.ReadOnly = true;
            this.colCodUsuarioRen.Width = 68;
            // 
            // colUbiRenuncia
            // 
            this.colUbiRenuncia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUbiRenuncia.DataPropertyName = "UBI_RENUNCIA";
            this.colUbiRenuncia.HeaderText = "Ubicacion";
            this.colUbiRenuncia.Name = "colUbiRenuncia";
            this.colUbiRenuncia.ReadOnly = true;
            this.colUbiRenuncia.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha renuncia";
            // 
            // txtFechaRenuncia
            // 
            this.txtFechaRenuncia.Location = new System.Drawing.Point(142, 94);
            this.txtFechaRenuncia.Name = "txtFechaRenuncia";
            this.txtFechaRenuncia.ReadOnly = true;
            this.txtFechaRenuncia.Size = new System.Drawing.Size(314, 20);
            this.txtFechaRenuncia.TabIndex = 14;
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
            this.txtIdentificacion.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtBuscarReingrso);
            this.tabPage2.Controls.Add(this.dgReingresados);
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
            // TxtBuscarReingrso
            // 
            this.TxtBuscarReingrso.Location = new System.Drawing.Point(236, 369);
            this.TxtBuscarReingrso.Name = "TxtBuscarReingrso";
            this.TxtBuscarReingrso.Size = new System.Drawing.Size(275, 20);
            this.TxtBuscarReingrso.TabIndex = 20;
            this.TxtBuscarReingrso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarReingrso_KeyPress);
            // 
            // dgReingresados
            // 
            this.dgReingresados.AllowUserToAddRows = false;
            this.dgReingresados.AllowUserToDeleteRows = false;
            this.dgReingresados.AllowUserToResizeColumns = false;
            this.dgReingresados.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReingresados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgReingresados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReingresados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReingresados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgReingresados.Location = new System.Drawing.Point(6, 6);
            this.dgReingresados.MultiSelect = false;
            this.dgReingresados.Name = "dgReingresados";
            this.dgReingresados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReingresados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgReingresados.RowHeadersVisible = false;
            this.dgReingresados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReingresados.Size = new System.Drawing.Size(776, 339);
            this.dgReingresados.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PDES_IDENTIFICACION";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identificacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOM_CLIENTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Asociado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PFEC_REINGRESO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Afiliacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 74;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "USU_AFILIA";
            this.Column1.HeaderText = "Afilia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PFEC_REGISTRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 71;
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
            // FrmReingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbParte);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmReingresos";
            this.Text = "Reingreso de asociados";
            this.Load += new System.EventHandler(this.FrmReingresos_Load);
            this.TbParte.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRenuncias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReingresados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbParte;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgRenuncias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaRenuncia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsociado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarRenunciado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtReingreso;
        private System.Windows.Forms.ComboBox cmbUsuReingreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgReingresados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBuscarReingrso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecAfiliacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecRenuncia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodUsuarioRen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUbiRenuncia;
    }
}