namespace AppEscritorio.Colocaciones
{
    partial class FrmMedioElectronico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BntModificarCargo = new System.Windows.Forms.Button();
            this.BtnEliminarCargo = new System.Windows.Forms.Button();
            this.BtnRegCargoMedio = new System.Windows.Forms.Button();
            this.DgCargosMedio = new System.Windows.Forms.DataGridView();
            this.dgCol_CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_CodTipoCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoValorCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_ObsCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_pDesTipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_pDesTipoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_ValorCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoMonedaCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtObsCargos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbTipoMonedaCargo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbTipoValorCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtValorCargo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CmbTipoCargo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnNuevoMedio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbCobertura = new System.Windows.Forms.ComboBox();
            this.TxtBeneficios = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtLugares = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPlazoMaximo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPlazo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLineaCredito = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoMoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNombreMedio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbMarcaMedio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTipoMedio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCargosMedio)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BntModificarCargo);
            this.groupBox1.Controls.Add(this.BtnEliminarCargo);
            this.groupBox1.Controls.Add(this.BtnRegCargoMedio);
            this.groupBox1.Controls.Add(this.DgCargosMedio);
            this.groupBox1.Controls.Add(this.TxtObsCargos);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CmbTipoMonedaCargo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.CmbTipoValorCargo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TxtValorCargo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.CmbTipoCargo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(629, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 704);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargos asociados";
            // 
            // BntModificarCargo
            // 
            this.BntModificarCargo.Enabled = false;
            this.BntModificarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntModificarCargo.Location = new System.Drawing.Point(237, 320);
            this.BntModificarCargo.Name = "BntModificarCargo";
            this.BntModificarCargo.Size = new System.Drawing.Size(137, 33);
            this.BntModificarCargo.TabIndex = 25;
            this.BntModificarCargo.Text = "Modificar";
            this.BntModificarCargo.UseVisualStyleBackColor = true;
            this.BntModificarCargo.Click += new System.EventHandler(this.BntModificarCargo_Click);
            // 
            // BtnEliminarCargo
            // 
            this.BtnEliminarCargo.Enabled = false;
            this.BtnEliminarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCargo.Location = new System.Drawing.Point(409, 320);
            this.BtnEliminarCargo.Name = "BtnEliminarCargo";
            this.BtnEliminarCargo.Size = new System.Drawing.Size(137, 33);
            this.BtnEliminarCargo.TabIndex = 24;
            this.BtnEliminarCargo.Text = "Eliminar";
            this.BtnEliminarCargo.UseVisualStyleBackColor = true;
            this.BtnEliminarCargo.Click += new System.EventHandler(this.BtnEliminarCargo_Click);
            // 
            // BtnRegCargoMedio
            // 
            this.BtnRegCargoMedio.Enabled = false;
            this.BtnRegCargoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegCargoMedio.Location = new System.Drawing.Point(65, 320);
            this.BtnRegCargoMedio.Name = "BtnRegCargoMedio";
            this.BtnRegCargoMedio.Size = new System.Drawing.Size(137, 33);
            this.BtnRegCargoMedio.TabIndex = 23;
            this.BtnRegCargoMedio.Text = "Nuevo";
            this.BtnRegCargoMedio.UseVisualStyleBackColor = true;
            this.BtnRegCargoMedio.Click += new System.EventHandler(this.BtnRegCargoMedio_Click);
            // 
            // DgCargosMedio
            // 
            this.DgCargosMedio.AllowUserToAddRows = false;
            this.DgCargosMedio.AllowUserToDeleteRows = false;
            this.DgCargosMedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCargosMedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCol_CodigoProducto,
            this.dgCol_CodTipoCobro,
            this.dgCol_TipoCargo,
            this.dgCol_TipoValorCargo,
            this.dgCol_ObsCargo,
            this.dgCol_pDesTipoCargo,
            this.dgCol_pDesTipoValor,
            this.dgCol_ValorCargo,
            this.dgCol_TipoMonedaCargo});
            this.DgCargosMedio.Location = new System.Drawing.Point(23, 379);
            this.DgCargosMedio.Name = "DgCargosMedio";
            this.DgCargosMedio.ReadOnly = true;
            this.DgCargosMedio.RowHeadersVisible = false;
            this.DgCargosMedio.RowHeadersWidth = 51;
            this.DgCargosMedio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCargosMedio.Size = new System.Drawing.Size(556, 303);
            this.DgCargosMedio.TabIndex = 22;
            this.DgCargosMedio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCargosMedio_CellContentClick);
            this.DgCargosMedio.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCargosMedio_CellEnter);
            // 
            // dgCol_CodigoProducto
            // 
            this.dgCol_CodigoProducto.DataPropertyName = "pCodigoProducto";
            this.dgCol_CodigoProducto.HeaderText = "CodigoProducto";
            this.dgCol_CodigoProducto.MinimumWidth = 6;
            this.dgCol_CodigoProducto.Name = "dgCol_CodigoProducto";
            this.dgCol_CodigoProducto.ReadOnly = true;
            this.dgCol_CodigoProducto.Visible = false;
            this.dgCol_CodigoProducto.Width = 125;
            // 
            // dgCol_CodTipoCobro
            // 
            this.dgCol_CodTipoCobro.DataPropertyName = "pCodTipoCobro";
            this.dgCol_CodTipoCobro.HeaderText = "CodTipoCobro";
            this.dgCol_CodTipoCobro.MinimumWidth = 6;
            this.dgCol_CodTipoCobro.Name = "dgCol_CodTipoCobro";
            this.dgCol_CodTipoCobro.ReadOnly = true;
            this.dgCol_CodTipoCobro.Visible = false;
            this.dgCol_CodTipoCobro.Width = 125;
            // 
            // dgCol_TipoCargo
            // 
            this.dgCol_TipoCargo.DataPropertyName = "pTipoCargo";
            this.dgCol_TipoCargo.HeaderText = "Tipo";
            this.dgCol_TipoCargo.MinimumWidth = 6;
            this.dgCol_TipoCargo.Name = "dgCol_TipoCargo";
            this.dgCol_TipoCargo.ReadOnly = true;
            this.dgCol_TipoCargo.Visible = false;
            this.dgCol_TipoCargo.Width = 125;
            // 
            // dgCol_TipoValorCargo
            // 
            this.dgCol_TipoValorCargo.DataPropertyName = "pTipoValorCargo";
            this.dgCol_TipoValorCargo.HeaderText = "TipoValor";
            this.dgCol_TipoValorCargo.MinimumWidth = 6;
            this.dgCol_TipoValorCargo.Name = "dgCol_TipoValorCargo";
            this.dgCol_TipoValorCargo.ReadOnly = true;
            this.dgCol_TipoValorCargo.Visible = false;
            this.dgCol_TipoValorCargo.Width = 125;
            // 
            // dgCol_ObsCargo
            // 
            this.dgCol_ObsCargo.DataPropertyName = "pObsCargo";
            this.dgCol_ObsCargo.HeaderText = "Obs";
            this.dgCol_ObsCargo.MinimumWidth = 6;
            this.dgCol_ObsCargo.Name = "dgCol_ObsCargo";
            this.dgCol_ObsCargo.ReadOnly = true;
            this.dgCol_ObsCargo.Visible = false;
            this.dgCol_ObsCargo.Width = 125;
            // 
            // dgCol_pDesTipoCargo
            // 
            this.dgCol_pDesTipoCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCol_pDesTipoCargo.DataPropertyName = "pDesTipoCargo";
            this.dgCol_pDesTipoCargo.HeaderText = "TipoCargo";
            this.dgCol_pDesTipoCargo.MinimumWidth = 6;
            this.dgCol_pDesTipoCargo.Name = "dgCol_pDesTipoCargo";
            this.dgCol_pDesTipoCargo.ReadOnly = true;
            // 
            // dgCol_pDesTipoValor
            // 
            this.dgCol_pDesTipoValor.DataPropertyName = "pDesTipoValor";
            this.dgCol_pDesTipoValor.HeaderText = "TipoValor";
            this.dgCol_pDesTipoValor.MinimumWidth = 6;
            this.dgCol_pDesTipoValor.Name = "dgCol_pDesTipoValor";
            this.dgCol_pDesTipoValor.ReadOnly = true;
            this.dgCol_pDesTipoValor.Width = 125;
            // 
            // dgCol_ValorCargo
            // 
            this.dgCol_ValorCargo.DataPropertyName = "pValorCargo";
            this.dgCol_ValorCargo.HeaderText = "Valor";
            this.dgCol_ValorCargo.MinimumWidth = 6;
            this.dgCol_ValorCargo.Name = "dgCol_ValorCargo";
            this.dgCol_ValorCargo.ReadOnly = true;
            this.dgCol_ValorCargo.Width = 125;
            // 
            // dgCol_TipoMonedaCargo
            // 
            this.dgCol_TipoMonedaCargo.DataPropertyName = "pTipoMonedaCargo";
            this.dgCol_TipoMonedaCargo.HeaderText = "MonedaCargo";
            this.dgCol_TipoMonedaCargo.MinimumWidth = 6;
            this.dgCol_TipoMonedaCargo.Name = "dgCol_TipoMonedaCargo";
            this.dgCol_TipoMonedaCargo.ReadOnly = true;
            this.dgCol_TipoMonedaCargo.Visible = false;
            this.dgCol_TipoMonedaCargo.Width = 125;
            // 
            // TxtObsCargos
            // 
            this.TxtObsCargos.Enabled = false;
            this.TxtObsCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObsCargos.Location = new System.Drawing.Point(165, 221);
            this.TxtObsCargos.Multiline = true;
            this.TxtObsCargos.Name = "TxtObsCargos";
            this.TxtObsCargos.Size = new System.Drawing.Size(295, 79);
            this.TxtObsCargos.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 224);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Observaciones";
            // 
            // CmbTipoMonedaCargo
            // 
            this.CmbTipoMonedaCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoMonedaCargo.Enabled = false;
            this.CmbTipoMonedaCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoMonedaCargo.FormattingEnabled = true;
            this.CmbTipoMonedaCargo.Items.AddRange(new object[] {
            "Colones"});
            this.CmbTipoMonedaCargo.Location = new System.Drawing.Point(165, 174);
            this.CmbTipoMonedaCargo.Name = "CmbTipoMonedaCargo";
            this.CmbTipoMonedaCargo.Size = new System.Drawing.Size(261, 28);
            this.CmbTipoMonedaCargo.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Moneda";
            // 
            // CmbTipoValorCargo
            // 
            this.CmbTipoValorCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoValorCargo.Enabled = false;
            this.CmbTipoValorCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoValorCargo.FormattingEnabled = true;
            this.CmbTipoValorCargo.Location = new System.Drawing.Point(165, 127);
            this.CmbTipoValorCargo.Name = "CmbTipoValorCargo";
            this.CmbTipoValorCargo.Size = new System.Drawing.Size(261, 28);
            this.CmbTipoValorCargo.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tipo Valor";
            // 
            // TxtValorCargo
            // 
            this.TxtValorCargo.Enabled = false;
            this.TxtValorCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorCargo.Location = new System.Drawing.Point(165, 81);
            this.TxtValorCargo.Name = "TxtValorCargo";
            this.TxtValorCargo.Size = new System.Drawing.Size(261, 26);
            this.TxtValorCargo.TabIndex = 7;
            this.TxtValorCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Valor";
            // 
            // CmbTipoCargo
            // 
            this.CmbTipoCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoCargo.Enabled = false;
            this.CmbTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoCargo.FormattingEnabled = true;
            this.CmbTipoCargo.Location = new System.Drawing.Point(165, 34);
            this.CmbTipoCargo.Name = "CmbTipoCargo";
            this.CmbTipoCargo.Size = new System.Drawing.Size(261, 28);
            this.CmbTipoCargo.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tipo Cargo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNuevoMedio);
            this.groupBox2.Location = new System.Drawing.Point(12, 722);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1217, 100);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // BtnNuevoMedio
            // 
            this.BtnNuevoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoMedio.Location = new System.Drawing.Point(453, 30);
            this.BtnNuevoMedio.Name = "BtnNuevoMedio";
            this.BtnNuevoMedio.Size = new System.Drawing.Size(246, 33);
            this.BtnNuevoMedio.TabIndex = 0;
            this.BtnNuevoMedio.Text = "Nuevo";
            this.BtnNuevoMedio.UseVisualStyleBackColor = true;
            this.BtnNuevoMedio.Click += new System.EventHandler(this.BtnNuevoMedio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CmbCobertura);
            this.groupBox3.Controls.Add(this.TxtBeneficios);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TxtObs);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TxtLugares);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TxtPlazoMaximo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TxtPlazo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtLineaCredito);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.CmbTipoMoneda);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.TxtNombreMedio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CmbMarcaMedio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CmbTipoMedio);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 704);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medio de pago";
            // 
            // CmbCobertura
            // 
            this.CmbCobertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCobertura.Enabled = false;
            this.CmbCobertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCobertura.FormattingEnabled = true;
            this.CmbCobertura.Location = new System.Drawing.Point(180, 404);
            this.CmbCobertura.Name = "CmbCobertura";
            this.CmbCobertura.Size = new System.Drawing.Size(261, 28);
            this.CmbCobertura.TabIndex = 44;
            // 
            // TxtBeneficios
            // 
            this.TxtBeneficios.Enabled = false;
            this.TxtBeneficios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBeneficios.Location = new System.Drawing.Point(180, 574);
            this.TxtBeneficios.Multiline = true;
            this.TxtBeneficios.Name = "TxtBeneficios";
            this.TxtBeneficios.Size = new System.Drawing.Size(375, 97);
            this.TxtBeneficios.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 577);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Beneficios";
            // 
            // TxtObs
            // 
            this.TxtObs.Enabled = false;
            this.TxtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObs.Location = new System.Drawing.Point(180, 451);
            this.TxtObs.Multiline = true;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(375, 91);
            this.TxtObs.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 458);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cobertura";
            // 
            // TxtLugares
            // 
            this.TxtLugares.Enabled = false;
            this.TxtLugares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLugares.Location = new System.Drawing.Point(180, 359);
            this.TxtLugares.Name = "TxtLugares";
            this.TxtLugares.Size = new System.Drawing.Size(261, 26);
            this.TxtLugares.TabIndex = 37;
            this.TxtLugares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Lugares";
            // 
            // TxtPlazoMaximo
            // 
            this.TxtPlazoMaximo.Enabled = false;
            this.TxtPlazoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlazoMaximo.Location = new System.Drawing.Point(180, 313);
            this.TxtPlazoMaximo.Name = "TxtPlazoMaximo";
            this.TxtPlazoMaximo.Size = new System.Drawing.Size(261, 26);
            this.TxtPlazoMaximo.TabIndex = 35;
            this.TxtPlazoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Plazo Máximo";
            // 
            // TxtPlazo
            // 
            this.TxtPlazo.Enabled = false;
            this.TxtPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlazo.Location = new System.Drawing.Point(180, 267);
            this.TxtPlazo.Name = "TxtPlazo";
            this.TxtPlazo.Size = new System.Drawing.Size(261, 26);
            this.TxtPlazo.TabIndex = 33;
            this.TxtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Plazo";
            // 
            // TxtLineaCredito
            // 
            this.TxtLineaCredito.Enabled = false;
            this.TxtLineaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLineaCredito.Location = new System.Drawing.Point(180, 221);
            this.TxtLineaCredito.Name = "TxtLineaCredito";
            this.TxtLineaCredito.Size = new System.Drawing.Size(261, 26);
            this.TxtLineaCredito.TabIndex = 31;
            this.TxtLineaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtLineaCredito.Leave += new System.EventHandler(this.TxtLineaCredito_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Monto Máximo";
            // 
            // CmbTipoMoneda
            // 
            this.CmbTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoMoneda.Enabled = false;
            this.CmbTipoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoMoneda.FormattingEnabled = true;
            this.CmbTipoMoneda.Location = new System.Drawing.Point(180, 174);
            this.CmbTipoMoneda.Name = "CmbTipoMoneda";
            this.CmbTipoMoneda.Size = new System.Drawing.Size(261, 28);
            this.CmbTipoMoneda.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Moneda";
            // 
            // TxtNombreMedio
            // 
            this.TxtNombreMedio.Enabled = false;
            this.TxtNombreMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreMedio.Location = new System.Drawing.Point(180, 128);
            this.TxtNombreMedio.Name = "TxtNombreMedio";
            this.TxtNombreMedio.Size = new System.Drawing.Size(261, 26);
            this.TxtNombreMedio.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nombre";
            // 
            // CmbMarcaMedio
            // 
            this.CmbMarcaMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarcaMedio.Enabled = false;
            this.CmbMarcaMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMarcaMedio.FormattingEnabled = true;
            this.CmbMarcaMedio.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "NA"});
            this.CmbMarcaMedio.Location = new System.Drawing.Point(180, 81);
            this.CmbMarcaMedio.Name = "CmbMarcaMedio";
            this.CmbMarcaMedio.Size = new System.Drawing.Size(261, 28);
            this.CmbMarcaMedio.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marca";
            // 
            // CmbTipoMedio
            // 
            this.CmbTipoMedio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoMedio.Enabled = false;
            this.CmbTipoMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoMedio.FormattingEnabled = true;
            this.CmbTipoMedio.Location = new System.Drawing.Point(180, 34);
            this.CmbTipoMedio.Name = "CmbTipoMedio";
            this.CmbTipoMedio.Size = new System.Drawing.Size(261, 28);
            this.CmbTipoMedio.TabIndex = 23;
            this.CmbTipoMedio.SelectedIndexChanged += new System.EventHandler(this.CmbTipoMedio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo Medio";
            // 
            // FrmMedioElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 834);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedioElectronico";
            this.Text = "Nuevo Medio Electrónico";
            this.Load += new System.EventHandler(this.FrmMedioElectronico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCargosMedio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgCargosMedio;
        private System.Windows.Forms.TextBox TxtObsCargos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbTipoMonedaCargo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbTipoValorCargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtValorCargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CmbTipoCargo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnNuevoMedio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtBeneficios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtLugares;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPlazoMaximo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPlazo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLineaCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNombreMedio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbMarcaMedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTipoMedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarCargo;
        private System.Windows.Forms.Button BtnRegCargoMedio;
        private System.Windows.Forms.Button BntModificarCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_CodTipoCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoValorCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_ObsCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_pDesTipoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_pDesTipoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_ValorCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoMonedaCargo;
        private System.Windows.Forms.ComboBox CmbCobertura;
    }
}