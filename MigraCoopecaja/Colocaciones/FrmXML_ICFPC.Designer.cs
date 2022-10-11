namespace AppEscritorio.Colocaciones
{
    partial class FrmXML_ICFPC
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
            this.BtnModiEnca = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DtPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtArchivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboTipoPersona = new System.Windows.Forms.ComboBox();
            this.TxtContacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.dgCol_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoGenerador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_Prima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TipoTasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_MontoMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TasaNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_TasaMoratoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_ObsTasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_Beneficios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.Cmb_TipoMoneda = new System.Windows.Forms.ComboBox();
            this.BtnGuardarDetProd = new System.Windows.Forms.Button();
            this.TxtObsTasa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_TipoGenerador = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoCliente = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoTasa = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoUso = new System.Windows.Forms.ComboBox();
            this.Cmb_TipoProducto = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DgCargos = new System.Windows.Forms.DataGridView();
            this.dgCol_pObsCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_pTipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_pTipoValorCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCol_pValorCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGenerarXML = new System.Windows.Forms.Button();
            this.abrirArhivo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnModiEnca);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.DtPeriodo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtArchivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtTelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtCorreo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboTipoPersona);
            this.groupBox1.Controls.Add(this.TxtContacto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnModiEnca
            // 
            this.BtnModiEnca.Location = new System.Drawing.Point(369, 176);
            this.BtnModiEnca.Name = "BtnModiEnca";
            this.BtnModiEnca.Size = new System.Drawing.Size(246, 23);
            this.BtnModiEnca.TabIndex = 13;
            this.BtnModiEnca.Text = "Modificar";
            this.BtnModiEnca.UseVisualStyleBackColor = true;
            this.BtnModiEnca.Click += new System.EventHandler(this.BtnModiEnca_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(529, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Persona";
            // 
            // DtPeriodo
            // 
            this.DtPeriodo.Enabled = false;
            this.DtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPeriodo.Location = new System.Drawing.Point(649, 126);
            this.DtPeriodo.Name = "DtPeriodo";
            this.DtPeriodo.Size = new System.Drawing.Size(261, 26);
            this.DtPeriodo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Periodo";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Enabled = false;
            this.TxtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArchivo.Location = new System.Drawing.Point(195, 124);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(261, 26);
            this.TxtArchivo.TabIndex = 9;
            this.TxtArchivo.Text = "IndiceProductosCrediticios.xml";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Archivo";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Enabled = false;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(649, 80);
            this.TxtTelefono.MaxLength = 8;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(261, 26);
            this.TxtTelefono.TabIndex = 7;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Enabled = false;
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(195, 79);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(261, 26);
            this.TxtCorreo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
            // 
            // ComboTipoPersona
            // 
            this.ComboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipoPersona.Enabled = false;
            this.ComboTipoPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTipoPersona.FormattingEnabled = true;
            this.ComboTipoPersona.Items.AddRange(new object[] {
            "Juridico",
            "Fisico"});
            this.ComboTipoPersona.Location = new System.Drawing.Point(649, 32);
            this.ComboTipoPersona.Name = "ComboTipoPersona";
            this.ComboTipoPersona.Size = new System.Drawing.Size(261, 28);
            this.ComboTipoPersona.TabIndex = 3;
            // 
            // TxtContacto
            // 
            this.TxtContacto.Enabled = false;
            this.TxtContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContacto.Location = new System.Drawing.Point(195, 34);
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(261, 26);
            this.TxtContacto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Responsable";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DgProductos
            // 
            this.DgProductos.AllowUserToAddRows = false;
            this.DgProductos.AllowUserToDeleteRows = false;
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCol_Codigo,
            this.dgCol_TipoProducto,
            this.dgCol_TipoUso,
            this.dgCol_TipoGenerador,
            this.dgCol_TipoCliente,
            this.dgCol_NombreProducto,
            this.dgCol_TipoMoneda,
            this.dgCol_Plazo,
            this.dgCol_Prima,
            this.dgCol_TipoTasa,
            this.dgCol_MontoMaximo,
            this.dgCol_TasaNominal,
            this.dgCol_TasaMoratoria,
            this.dgCol_ObsTasa,
            this.dgCol_Beneficios});
            this.DgProductos.Location = new System.Drawing.Point(12, 272);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.ReadOnly = true;
            this.DgProductos.RowHeadersVisible = false;
            this.DgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProductos.Size = new System.Drawing.Size(1007, 168);
            this.DgProductos.TabIndex = 1;
            this.DgProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProductos_CellEnter);
            // 
            // dgCol_Codigo
            // 
            this.dgCol_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_Codigo.DataPropertyName = "CodigoProducto";
            this.dgCol_Codigo.HeaderText = "Codigo";
            this.dgCol_Codigo.Name = "dgCol_Codigo";
            this.dgCol_Codigo.ReadOnly = true;
            this.dgCol_Codigo.Visible = false;
            // 
            // dgCol_TipoProducto
            // 
            this.dgCol_TipoProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TipoProducto.DataPropertyName = "TipoProducto";
            this.dgCol_TipoProducto.HeaderText = "Tipo";
            this.dgCol_TipoProducto.Name = "dgCol_TipoProducto";
            this.dgCol_TipoProducto.ReadOnly = true;
            this.dgCol_TipoProducto.Visible = false;
            // 
            // dgCol_TipoUso
            // 
            this.dgCol_TipoUso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TipoUso.DataPropertyName = "TipoUso";
            this.dgCol_TipoUso.HeaderText = "Uso";
            this.dgCol_TipoUso.Name = "dgCol_TipoUso";
            this.dgCol_TipoUso.ReadOnly = true;
            this.dgCol_TipoUso.Visible = false;
            // 
            // dgCol_TipoGenerador
            // 
            this.dgCol_TipoGenerador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TipoGenerador.DataPropertyName = "TipoGenerador";
            this.dgCol_TipoGenerador.HeaderText = "Generardor";
            this.dgCol_TipoGenerador.Name = "dgCol_TipoGenerador";
            this.dgCol_TipoGenerador.ReadOnly = true;
            this.dgCol_TipoGenerador.Visible = false;
            // 
            // dgCol_TipoCliente
            // 
            this.dgCol_TipoCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TipoCliente.DataPropertyName = "TipoCliente";
            this.dgCol_TipoCliente.HeaderText = "Cliente";
            this.dgCol_TipoCliente.Name = "dgCol_TipoCliente";
            this.dgCol_TipoCliente.ReadOnly = true;
            this.dgCol_TipoCliente.Visible = false;
            // 
            // dgCol_NombreProducto
            // 
            this.dgCol_NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCol_NombreProducto.DataPropertyName = "NombreProducto";
            this.dgCol_NombreProducto.HeaderText = "Producto";
            this.dgCol_NombreProducto.Name = "dgCol_NombreProducto";
            this.dgCol_NombreProducto.ReadOnly = true;
            // 
            // dgCol_TipoMoneda
            // 
            this.dgCol_TipoMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TipoMoneda.DataPropertyName = "TipoMoneda";
            this.dgCol_TipoMoneda.HeaderText = "Moneda";
            this.dgCol_TipoMoneda.Name = "dgCol_TipoMoneda";
            this.dgCol_TipoMoneda.ReadOnly = true;
            this.dgCol_TipoMoneda.Visible = false;
            // 
            // dgCol_Plazo
            // 
            this.dgCol_Plazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_Plazo.DataPropertyName = "Plazo";
            this.dgCol_Plazo.HeaderText = "Plazo";
            this.dgCol_Plazo.Name = "dgCol_Plazo";
            this.dgCol_Plazo.ReadOnly = true;
            this.dgCol_Plazo.Width = 58;
            // 
            // dgCol_Prima
            // 
            this.dgCol_Prima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_Prima.DataPropertyName = "Prima";
            this.dgCol_Prima.HeaderText = "Prima";
            this.dgCol_Prima.Name = "dgCol_Prima";
            this.dgCol_Prima.ReadOnly = true;
            this.dgCol_Prima.Width = 58;
            // 
            // dgCol_TipoTasa
            // 
            this.dgCol_TipoTasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TipoTasa.DataPropertyName = "TipoTasa";
            this.dgCol_TipoTasa.HeaderText = "TipoTasa";
            this.dgCol_TipoTasa.Name = "dgCol_TipoTasa";
            this.dgCol_TipoTasa.ReadOnly = true;
            this.dgCol_TipoTasa.Visible = false;
            // 
            // dgCol_MontoMaximo
            // 
            this.dgCol_MontoMaximo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_MontoMaximo.DataPropertyName = "MontoMaximo";
            this.dgCol_MontoMaximo.HeaderText = "Maximo";
            this.dgCol_MontoMaximo.Name = "dgCol_MontoMaximo";
            this.dgCol_MontoMaximo.ReadOnly = true;
            this.dgCol_MontoMaximo.Width = 68;
            // 
            // dgCol_TasaNominal
            // 
            this.dgCol_TasaNominal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TasaNominal.DataPropertyName = "TasaNominal";
            this.dgCol_TasaNominal.HeaderText = "Tasa";
            this.dgCol_TasaNominal.Name = "dgCol_TasaNominal";
            this.dgCol_TasaNominal.ReadOnly = true;
            this.dgCol_TasaNominal.Width = 56;
            // 
            // dgCol_TasaMoratoria
            // 
            this.dgCol_TasaMoratoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_TasaMoratoria.DataPropertyName = "TasaMoratoria";
            this.dgCol_TasaMoratoria.HeaderText = "Moratoria";
            this.dgCol_TasaMoratoria.Name = "dgCol_TasaMoratoria";
            this.dgCol_TasaMoratoria.ReadOnly = true;
            this.dgCol_TasaMoratoria.Width = 76;
            // 
            // dgCol_ObsTasa
            // 
            this.dgCol_ObsTasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_ObsTasa.DataPropertyName = "ObsTasa";
            this.dgCol_ObsTasa.HeaderText = "ObsTasa";
            this.dgCol_ObsTasa.Name = "dgCol_ObsTasa";
            this.dgCol_ObsTasa.ReadOnly = true;
            this.dgCol_ObsTasa.Visible = false;
            // 
            // dgCol_Beneficios
            // 
            this.dgCol_Beneficios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_Beneficios.DataPropertyName = "Beneficios";
            this.dgCol_Beneficios.HeaderText = "Beneficios";
            this.dgCol_Beneficios.Name = "dgCol_Beneficios";
            this.dgCol_Beneficios.ReadOnly = true;
            this.dgCol_Beneficios.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 446);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1007, 430);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.Cmb_TipoMoneda);
            this.tabPage1.Controls.Add(this.BtnGuardarDetProd);
            this.tabPage1.Controls.Add(this.TxtObsTasa);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Cmb_TipoGenerador);
            this.tabPage1.Controls.Add(this.Cmb_TipoCliente);
            this.tabPage1.Controls.Add(this.Cmb_TipoTasa);
            this.tabPage1.Controls.Add(this.Cmb_TipoUso);
            this.tabPage1.Controls.Add(this.Cmb_TipoProducto);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(999, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(525, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Moneda";
            // 
            // Cmb_TipoMoneda
            // 
            this.Cmb_TipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoMoneda.Enabled = false;
            this.Cmb_TipoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoMoneda.FormattingEnabled = true;
            this.Cmb_TipoMoneda.Location = new System.Drawing.Point(645, 128);
            this.Cmb_TipoMoneda.Name = "Cmb_TipoMoneda";
            this.Cmb_TipoMoneda.Size = new System.Drawing.Size(261, 28);
            this.Cmb_TipoMoneda.TabIndex = 13;
            // 
            // BtnGuardarDetProd
            // 
            this.BtnGuardarDetProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarDetProd.Location = new System.Drawing.Point(365, 357);
            this.BtnGuardarDetProd.Name = "BtnGuardarDetProd";
            this.BtnGuardarDetProd.Size = new System.Drawing.Size(246, 33);
            this.BtnGuardarDetProd.TabIndex = 12;
            this.BtnGuardarDetProd.Text = "Modificar";
            this.BtnGuardarDetProd.UseVisualStyleBackColor = true;
            this.BtnGuardarDetProd.Visible = false;
            this.BtnGuardarDetProd.Click += new System.EventHandler(this.BtnGuardarDetProd_Click);
            // 
            // TxtObsTasa
            // 
            this.TxtObsTasa.Enabled = false;
            this.TxtObsTasa.Location = new System.Drawing.Point(49, 229);
            this.TxtObsTasa.Multiline = true;
            this.TxtObsTasa.Name = "TxtObsTasa";
            this.TxtObsTasa.Size = new System.Drawing.Size(857, 117);
            this.TxtObsTasa.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Observaciones tasa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tipo Tasa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Generador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Uso Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirigido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Producto";
            // 
            // Cmb_TipoGenerador
            // 
            this.Cmb_TipoGenerador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoGenerador.Enabled = false;
            this.Cmb_TipoGenerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoGenerador.FormattingEnabled = true;
            this.Cmb_TipoGenerador.Location = new System.Drawing.Point(645, 79);
            this.Cmb_TipoGenerador.Name = "Cmb_TipoGenerador";
            this.Cmb_TipoGenerador.Size = new System.Drawing.Size(261, 28);
            this.Cmb_TipoGenerador.TabIndex = 4;
            // 
            // Cmb_TipoCliente
            // 
            this.Cmb_TipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoCliente.Enabled = false;
            this.Cmb_TipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoCliente.FormattingEnabled = true;
            this.Cmb_TipoCliente.Location = new System.Drawing.Point(645, 29);
            this.Cmb_TipoCliente.Name = "Cmb_TipoCliente";
            this.Cmb_TipoCliente.Size = new System.Drawing.Size(261, 28);
            this.Cmb_TipoCliente.TabIndex = 3;
            // 
            // Cmb_TipoTasa
            // 
            this.Cmb_TipoTasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoTasa.Enabled = false;
            this.Cmb_TipoTasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoTasa.FormattingEnabled = true;
            this.Cmb_TipoTasa.Location = new System.Drawing.Point(191, 128);
            this.Cmb_TipoTasa.Name = "Cmb_TipoTasa";
            this.Cmb_TipoTasa.Size = new System.Drawing.Size(261, 28);
            this.Cmb_TipoTasa.TabIndex = 2;
            // 
            // Cmb_TipoUso
            // 
            this.Cmb_TipoUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoUso.Enabled = false;
            this.Cmb_TipoUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoUso.FormattingEnabled = true;
            this.Cmb_TipoUso.Location = new System.Drawing.Point(191, 79);
            this.Cmb_TipoUso.Name = "Cmb_TipoUso";
            this.Cmb_TipoUso.Size = new System.Drawing.Size(261, 28);
            this.Cmb_TipoUso.TabIndex = 1;
            // 
            // Cmb_TipoProducto
            // 
            this.Cmb_TipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_TipoProducto.Enabled = false;
            this.Cmb_TipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_TipoProducto.FormattingEnabled = true;
            this.Cmb_TipoProducto.Location = new System.Drawing.Point(191, 29);
            this.Cmb_TipoProducto.Name = "Cmb_TipoProducto";
            this.Cmb_TipoProducto.Size = new System.Drawing.Size(261, 28);
            this.Cmb_TipoProducto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DgCargos);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(999, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DgCargos
            // 
            this.DgCargos.AllowUserToAddRows = false;
            this.DgCargos.AllowUserToDeleteRows = false;
            this.DgCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCol_pObsCargo,
            this.dgCol_pTipoCargo,
            this.dgCol_pTipoValorCargo,
            this.dgCol_pValorCargo});
            this.DgCargos.Location = new System.Drawing.Point(6, 6);
            this.DgCargos.Name = "DgCargos";
            this.DgCargos.ReadOnly = true;
            this.DgCargos.RowHeadersVisible = false;
            this.DgCargos.Size = new System.Drawing.Size(987, 389);
            this.DgCargos.TabIndex = 0;
            // 
            // dgCol_pObsCargo
            // 
            this.dgCol_pObsCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCol_pObsCargo.DataPropertyName = "pObsCargo";
            this.dgCol_pObsCargo.HeaderText = "Cargo";
            this.dgCol_pObsCargo.Name = "dgCol_pObsCargo";
            this.dgCol_pObsCargo.ReadOnly = true;
            // 
            // dgCol_pTipoCargo
            // 
            this.dgCol_pTipoCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_pTipoCargo.DataPropertyName = "pTipoCargo";
            this.dgCol_pTipoCargo.HeaderText = "Tipo";
            this.dgCol_pTipoCargo.Name = "dgCol_pTipoCargo";
            this.dgCol_pTipoCargo.ReadOnly = true;
            this.dgCol_pTipoCargo.Width = 62;
            // 
            // dgCol_pTipoValorCargo
            // 
            this.dgCol_pTipoValorCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_pTipoValorCargo.DataPropertyName = "pTipoValorCargo";
            this.dgCol_pTipoValorCargo.HeaderText = "Calculo";
            this.dgCol_pTipoValorCargo.Name = "dgCol_pTipoValorCargo";
            this.dgCol_pTipoValorCargo.ReadOnly = true;
            this.dgCol_pTipoValorCargo.Width = 83;
            // 
            // dgCol_pValorCargo
            // 
            this.dgCol_pValorCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgCol_pValorCargo.DataPropertyName = "pValorCargo";
            this.dgCol_pValorCargo.HeaderText = "Valor";
            this.dgCol_pValorCargo.Name = "dgCol_pValorCargo";
            this.dgCol_pValorCargo.ReadOnly = true;
            this.dgCol_pValorCargo.Width = 67;
            // 
            // BtnGenerarXML
            // 
            this.BtnGenerarXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarXML.Location = new System.Drawing.Point(770, 893);
            this.BtnGenerarXML.Name = "BtnGenerarXML";
            this.BtnGenerarXML.Size = new System.Drawing.Size(246, 33);
            this.BtnGenerarXML.TabIndex = 3;
            this.BtnGenerarXML.Text = "Generar XML";
            this.BtnGenerarXML.UseVisualStyleBackColor = true;
            this.BtnGenerarXML.Click += new System.EventHandler(this.BtnGenerarXML_Click);
            // 
            // abrirArhivo
            // 
            this.abrirArhivo.FileName = "openFileDialog1";
            // 
            // FrmXML_ICFPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 949);
            this.Controls.Add(this.BtnGenerarXML);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DgProductos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmXML_ICFPC";
            this.Text = "Competencia financiera para productos crediticios (ICFPC)";
            this.Load += new System.EventHandler(this.FrmXML_ICFPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboTipoPersona;
        private System.Windows.Forms.TextBox TxtContacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgProductos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox Cmb_TipoGenerador;
        private System.Windows.Forms.ComboBox Cmb_TipoCliente;
        private System.Windows.Forms.ComboBox Cmb_TipoTasa;
        private System.Windows.Forms.ComboBox Cmb_TipoUso;
        private System.Windows.Forms.ComboBox Cmb_TipoProducto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtObsTasa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenerarXML;
        private System.Windows.Forms.Button BtnGuardarDetProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Cmb_TipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoUso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoGenerador;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_Plazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_Prima;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TipoTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_MontoMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TasaNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_TasaMoratoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_ObsTasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_Beneficios;
        private System.Windows.Forms.Button BtnModiEnca;
        private System.Windows.Forms.DataGridView DgCargos;
        private System.Windows.Forms.OpenFileDialog abrirArhivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_pObsCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_pTipoCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_pTipoValorCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCol_pValorCargo;
    }
}