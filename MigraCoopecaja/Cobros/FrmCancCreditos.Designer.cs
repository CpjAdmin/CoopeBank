namespace AppEscritorio.Cobros
{
    partial class FrmCancCreditos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblTotalCancelar = new System.Windows.Forms.Label();
            this.LblCantOpeCance = new System.Windows.Forms.Label();
            this.BtnTodas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCanSaldo = new System.Windows.Forms.Button();
            this.DgCreditosInco = new System.Windows.Forms.DataGridView();
            this.dgIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgCodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgAsociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgUltimoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgCancelar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgCod_Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgFEC_Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgCuotaCancelada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgCod_Centro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgPor_Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtOpeCancelada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtCancelacion = new System.Windows.Forms.DateTimePicker();
            this.DgCredIncoCanc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCreditosInco)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCredIncoCanc)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(753, 446);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblTotalCancelar);
            this.tabPage1.Controls.Add(this.LblCantOpeCance);
            this.tabPage1.Controls.Add(this.BtnTodas);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BtnCanSaldo);
            this.tabPage1.Controls.Add(this.DgCreditosInco);
            this.tabPage1.Controls.Add(this.TxtBusqueda);
            this.tabPage1.Controls.Add(this.BtnConsultar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(745, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestión";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblTotalCancelar
            // 
            this.LblTotalCancelar.AutoSize = true;
            this.LblTotalCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalCancelar.ForeColor = System.Drawing.Color.Blue;
            this.LblTotalCancelar.Location = new System.Drawing.Point(289, 382);
            this.LblTotalCancelar.Name = "LblTotalCancelar";
            this.LblTotalCancelar.Size = new System.Drawing.Size(0, 25);
            this.LblTotalCancelar.TabIndex = 7;
            // 
            // LblCantOpeCance
            // 
            this.LblCantOpeCance.AutoSize = true;
            this.LblCantOpeCance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantOpeCance.ForeColor = System.Drawing.Color.Blue;
            this.LblCantOpeCance.Location = new System.Drawing.Point(249, 356);
            this.LblCantOpeCance.Name = "LblCantOpeCance";
            this.LblCantOpeCance.Size = new System.Drawing.Size(0, 25);
            this.LblCantOpeCance.TabIndex = 6;
            // 
            // BtnTodas
            // 
            this.BtnTodas.Location = new System.Drawing.Point(648, 14);
            this.BtnTodas.Name = "BtnTodas";
            this.BtnTodas.Size = new System.Drawing.Size(75, 23);
            this.BtnTodas.TabIndex = 5;
            this.BtnTodas.Text = "Todas";
            this.BtnTodas.UseVisualStyleBackColor = true;
            this.BtnTodas.Click += new System.EventHandler(this.BtnTodas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // BtnCanSaldo
            // 
            this.BtnCanSaldo.Image = global::AppEscritorio.Properties.Resources.procesar;
            this.BtnCanSaldo.Location = new System.Drawing.Point(639, 340);
            this.BtnCanSaldo.Name = "BtnCanSaldo";
            this.BtnCanSaldo.Size = new System.Drawing.Size(98, 67);
            this.BtnCanSaldo.TabIndex = 3;
            this.BtnCanSaldo.Text = "Procesar";
            this.BtnCanSaldo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCanSaldo.UseVisualStyleBackColor = true;
            this.BtnCanSaldo.Click += new System.EventHandler(this.BtnCanSaldo_Click);
            // 
            // DgCreditosInco
            // 
            this.DgCreditosInco.AllowUserToAddRows = false;
            this.DgCreditosInco.AllowUserToDeleteRows = false;
            this.DgCreditosInco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCreditosInco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgIdentificacion,
            this.DgCodCliente,
            this.DgAsociado,
            this.DgOperacion,
            this.DgUltimoPago,
            this.DgSaldo,
            this.DgCancelar,
            this.DgCod_Compania,
            this.DgFEC_Vencimiento,
            this.DgCuotaCancelada,
            this.DgCod_Centro,
            this.DgPor_Tasa});
            this.DgCreditosInco.Location = new System.Drawing.Point(10, 43);
            this.DgCreditosInco.Name = "DgCreditosInco";
            this.DgCreditosInco.RowHeadersVisible = false;
            this.DgCreditosInco.Size = new System.Drawing.Size(729, 291);
            this.DgCreditosInco.TabIndex = 2;
            this.DgCreditosInco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellClick);
            this.DgCreditosInco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellContentClick);
            this.DgCreditosInco.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellEndEdit);
            this.DgCreditosInco.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellEnter);
            this.DgCreditosInco.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellLeave);
            this.DgCreditosInco.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgCreditosInco_CellMouseClick);
            this.DgCreditosInco.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellValidated);
            this.DgCreditosInco.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCreditosInco_CellValueChanged);
            this.DgCreditosInco.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DgCreditosInco_CellValuePushed);
            this.DgCreditosInco.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgCreditosInco_CurrentCellDirtyStateChanged);
            // 
            // dgIdentificacion
            // 
            this.dgIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgIdentificacion.DataPropertyName = "DES_IDENTIFICACION";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgIdentificacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgIdentificacion.HeaderText = "Identificación";
            this.dgIdentificacion.Name = "dgIdentificacion";
            this.dgIdentificacion.ReadOnly = true;
            this.dgIdentificacion.Width = 95;
            // 
            // DgCodCliente
            // 
            this.DgCodCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DgCodCliente.DataPropertyName = "COD_CLIENTE";
            this.DgCodCliente.HeaderText = "CodCliente";
            this.DgCodCliente.Name = "DgCodCliente";
            this.DgCodCliente.ReadOnly = true;
            this.DgCodCliente.Width = 83;
            // 
            // DgAsociado
            // 
            this.DgAsociado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DgAsociado.DataPropertyName = "NOM_CLIENTE";
            this.DgAsociado.HeaderText = "Asociado";
            this.DgAsociado.Name = "DgAsociado";
            this.DgAsociado.ReadOnly = true;
            // 
            // DgOperacion
            // 
            this.DgOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DgOperacion.DataPropertyName = "NUM_OPERACION";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgOperacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgOperacion.HeaderText = "Operación";
            this.DgOperacion.Name = "DgOperacion";
            this.DgOperacion.ReadOnly = true;
            this.DgOperacion.Width = 81;
            // 
            // DgUltimoPago
            // 
            this.DgUltimoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DgUltimoPago.DataPropertyName = "FEC_ULTPINT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgUltimoPago.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgUltimoPago.HeaderText = "UltimoPago";
            this.DgUltimoPago.Name = "DgUltimoPago";
            this.DgUltimoPago.ReadOnly = true;
            this.DgUltimoPago.Width = 86;
            // 
            // DgSaldo
            // 
            this.DgSaldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DgSaldo.DataPropertyName = "Saldo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            this.DgSaldo.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgSaldo.HeaderText = "Saldo";
            this.DgSaldo.Name = "DgSaldo";
            this.DgSaldo.ReadOnly = true;
            this.DgSaldo.Width = 59;
            // 
            // DgCancelar
            // 
            this.DgCancelar.DataPropertyName = "CancelarSaldo";
            this.DgCancelar.FalseValue = "0";
            this.DgCancelar.HeaderText = "CancelarSaldo";
            this.DgCancelar.IndeterminateValue = "1";
            this.DgCancelar.Name = "DgCancelar";
            this.DgCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCancelar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DgCancelar.TrueValue = "1";
            // 
            // DgCod_Compania
            // 
            this.DgCod_Compania.DataPropertyName = "COD_COMPANIA";
            this.DgCod_Compania.HeaderText = "Compania";
            this.DgCod_Compania.Name = "DgCod_Compania";
            this.DgCod_Compania.ReadOnly = true;
            this.DgCod_Compania.Visible = false;
            // 
            // DgFEC_Vencimiento
            // 
            this.DgFEC_Vencimiento.DataPropertyName = "FEC_VENCIMIENTO";
            this.DgFEC_Vencimiento.HeaderText = "Vencimiento";
            this.DgFEC_Vencimiento.Name = "DgFEC_Vencimiento";
            this.DgFEC_Vencimiento.ReadOnly = true;
            this.DgFEC_Vencimiento.Visible = false;
            // 
            // DgCuotaCancelada
            // 
            this.DgCuotaCancelada.DataPropertyName = "CuotaCancela";
            this.DgCuotaCancelada.HeaderText = "CuotaCancelar";
            this.DgCuotaCancelada.Name = "DgCuotaCancelada";
            this.DgCuotaCancelada.ReadOnly = true;
            this.DgCuotaCancelada.Visible = false;
            // 
            // DgCod_Centro
            // 
            this.DgCod_Centro.DataPropertyName = "COD_CENTRO";
            this.DgCod_Centro.HeaderText = "Centro";
            this.DgCod_Centro.Name = "DgCod_Centro";
            this.DgCod_Centro.ReadOnly = true;
            this.DgCod_Centro.Visible = false;
            // 
            // DgPor_Tasa
            // 
            this.DgPor_Tasa.DataPropertyName = "POR_TASA";
            this.DgPor_Tasa.HeaderText = "Tasa";
            this.DgPor_Tasa.Name = "DgPor_Tasa";
            this.DgPor_Tasa.ReadOnly = true;
            this.DgPor_Tasa.Visible = false;
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(76, 16);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(145, 20);
            this.TxtBusqueda.TabIndex = 1;
            this.TxtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusqueda_KeyPress);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = global::AppEscritorio.Properties.Resources.refres;
            this.BtnConsultar.Location = new System.Drawing.Point(8, 340);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(98, 67);
            this.BtnConsultar.TabIndex = 0;
            this.BtnConsultar.Text = "Refrescar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtOpeCancelada);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DtCancelacion);
            this.tabPage2.Controls.Add(this.DgCredIncoCanc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(745, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bitacora";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtOpeCancelada
            // 
            this.TxtOpeCancelada.Location = new System.Drawing.Point(151, 53);
            this.TxtOpeCancelada.Name = "TxtOpeCancelada";
            this.TxtOpeCancelada.Size = new System.Drawing.Size(107, 20);
            this.TxtOpeCancelada.TabIndex = 4;
            this.TxtOpeCancelada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOpeCancelada_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operación cancelada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha cancelación";
            // 
            // DtCancelacion
            // 
            this.DtCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtCancelacion.Location = new System.Drawing.Point(151, 19);
            this.DtCancelacion.Name = "DtCancelacion";
            this.DtCancelacion.Size = new System.Drawing.Size(107, 20);
            this.DtCancelacion.TabIndex = 1;
            this.DtCancelacion.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DgCredIncoCanc
            // 
            this.DgCredIncoCanc.AllowUserToAddRows = false;
            this.DgCredIncoCanc.AllowUserToDeleteRows = false;
            this.DgCredIncoCanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCredIncoCanc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgCredIncoCanc.Location = new System.Drawing.Point(6, 93);
            this.DgCredIncoCanc.Name = "DgCredIncoCanc";
            this.DgCredIncoCanc.ReadOnly = true;
            this.DgCredIncoCanc.RowHeadersVisible = false;
            this.DgCredIncoCanc.Size = new System.Drawing.Size(731, 251);
            this.DgCredIncoCanc.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "pOperacion";
            this.Column1.HeaderText = "Operacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "pSaldoCancelado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "SaldoCancelado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "pUsuarioCancelo";
            this.Column3.HeaderText = "UsuarioCancelo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "pFechaCancela";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "FechaCancela";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmCancCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 446);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCancCreditos";
            this.Text = "Cancelación de creditos incobrables";
            this.Load += new System.EventHandler(this.FrmCancCreditos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCreditosInco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCredIncoCanc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnTodas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCanSaldo;
        private System.Windows.Forms.DataGridView DgCreditosInco;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtCancelacion;
        private System.Windows.Forms.DataGridView DgCredIncoCanc;
        private System.Windows.Forms.TextBox TxtOpeCancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgCodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgAsociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgUltimoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgSaldo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgCod_Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgFEC_Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgCuotaCancelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgCod_Centro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgPor_Tasa;
        private System.Windows.Forms.Label LblCantOpeCance;
        private System.Windows.Forms.Label LblTotalCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}