
namespace AppEscritorio.Sugef
{
    partial class FrmActividadEconomica
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
            this.dgTransacciones = new System.Windows.Forms.DataGridView();
            this.COD_PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DES_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP_OPERACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEC_TRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP_TRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRI_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEG_APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MON_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_MONEDA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MON_EGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_MONEDA_EGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DET_TRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DET_ORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPersona = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDetalleOrigen = new System.Windows.Forms.TextBox();
            this.txtDetalleTransaccion = new System.Windows.Forms.TextBox();
            this.txtCodigoEgreso = new System.Windows.Forms.TextBox();
            this.txtMontoEgreso = new System.Windows.Forms.TextBox();
            this.txtMontoIngreso = new System.Windows.Forms.TextBox();
            this.txtCodigoIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtTipoOperacion = new System.Windows.Forms.TextBox();
            this.txtTipoTransaccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActividadEconomica = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransacciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTransacciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransacciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_PERSONA,
            this.DES_IDENTIFICACION,
            this.TIP_OPERACION,
            this.FEC_TRANSACCION,
            this.TIP_TRANSACCION,
            this.NOM_PERSONA,
            this.PRI_APELLIDO,
            this.SEG_APELLIDO,
            this.NOM_RAZON_SOCIAL,
            this.MON_INGRESO,
            this.COD_MONEDA_INGRESO,
            this.MON_EGRESO,
            this.COD_MONEDA_EGRESO,
            this.DET_TRANSACCION,
            this.DET_ORIGEN});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTransacciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgTransacciones.Location = new System.Drawing.Point(16, 19);
            this.dgTransacciones.Name = "dgTransacciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTransacciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgTransacciones.Size = new System.Drawing.Size(1186, 406);
            this.dgTransacciones.TabIndex = 0;
            this.dgTransacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransacciones_CellClick);
            this.dgTransacciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgTransacciones_CellFormatting);
            // 
            // COD_PERSONA
            // 
            this.COD_PERSONA.HeaderText = "COD_PERSONA";
            this.COD_PERSONA.Name = "COD_PERSONA";
            // 
            // DES_IDENTIFICACION
            // 
            this.DES_IDENTIFICACION.HeaderText = "IDENTIFICACION";
            this.DES_IDENTIFICACION.Name = "DES_IDENTIFICACION";
            // 
            // TIP_OPERACION
            // 
            this.TIP_OPERACION.HeaderText = "TIP_OPERACION";
            this.TIP_OPERACION.Name = "TIP_OPERACION";
            // 
            // FEC_TRANSACCION
            // 
            this.FEC_TRANSACCION.HeaderText = "FEC_TRANSACCION";
            this.FEC_TRANSACCION.Name = "FEC_TRANSACCION";
            // 
            // TIP_TRANSACCION
            // 
            this.TIP_TRANSACCION.HeaderText = "TIP_TRANSACCION";
            this.TIP_TRANSACCION.Name = "TIP_TRANSACCION";
            // 
            // NOM_PERSONA
            // 
            this.NOM_PERSONA.HeaderText = "NOM_PERSONA";
            this.NOM_PERSONA.Name = "NOM_PERSONA";
            // 
            // PRI_APELLIDO
            // 
            this.PRI_APELLIDO.HeaderText = "PRI_APELLIDO";
            this.PRI_APELLIDO.Name = "PRI_APELLIDO";
            // 
            // SEG_APELLIDO
            // 
            this.SEG_APELLIDO.HeaderText = "SEG_APELLIDO";
            this.SEG_APELLIDO.Name = "SEG_APELLIDO";
            // 
            // NOM_RAZON_SOCIAL
            // 
            this.NOM_RAZON_SOCIAL.HeaderText = "RAZON_SOCIAL";
            this.NOM_RAZON_SOCIAL.Name = "NOM_RAZON_SOCIAL";
            // 
            // MON_INGRESO
            // 
            this.MON_INGRESO.HeaderText = "MON_INGRESO";
            this.MON_INGRESO.Name = "MON_INGRESO";
            // 
            // COD_MONEDA_INGRESO
            // 
            this.COD_MONEDA_INGRESO.HeaderText = "COD_MONEDA_INGRESO";
            this.COD_MONEDA_INGRESO.Name = "COD_MONEDA_INGRESO";
            // 
            // MON_EGRESO
            // 
            this.MON_EGRESO.HeaderText = "MON_EGRESO";
            this.MON_EGRESO.Name = "MON_EGRESO";
            // 
            // COD_MONEDA_EGRESO
            // 
            this.COD_MONEDA_EGRESO.HeaderText = "COD_MONEDA_EGRESO";
            this.COD_MONEDA_EGRESO.Name = "COD_MONEDA_EGRESO";
            // 
            // DET_TRANSACCION
            // 
            this.DET_TRANSACCION.HeaderText = "DET_TRANSACCION";
            this.DET_TRANSACCION.Name = "DET_TRANSACCION";
            // 
            // DET_ORIGEN
            // 
            this.DET_ORIGEN.HeaderText = "DET_ORIGEN";
            this.DET_ORIGEN.Name = "DET_ORIGEN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgTransacciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transacciones Mayores a $10 000";
            // 
            // txtCodigoPersona
            // 
            this.txtCodigoPersona.Location = new System.Drawing.Point(3, 18);
            this.txtCodigoPersona.Name = "txtCodigoPersona";
            this.txtCodigoPersona.Size = new System.Drawing.Size(139, 20);
            this.txtCodigoPersona.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 586F));
            this.tableLayoutPanel1.Controls.Add(this.txtDetalleOrigen, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDetalleTransaccion, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoEgreso, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMontoEgreso, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMontoIngreso, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoIngreso, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigoPersona, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label14, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFecha, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIdentificacion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoOperacion, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoTransaccion, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPrimerApellido, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSegundoApellido, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtRazonSocial, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 202);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtDetalleOrigen
            // 
            this.txtDetalleOrigen.Location = new System.Drawing.Point(603, 148);
            this.txtDetalleOrigen.Name = "txtDetalleOrigen";
            this.txtDetalleOrigen.Size = new System.Drawing.Size(387, 20);
            this.txtDetalleOrigen.TabIndex = 28;
            // 
            // txtDetalleTransaccion
            // 
            this.txtDetalleTransaccion.Location = new System.Drawing.Point(603, 83);
            this.txtDetalleTransaccion.Name = "txtDetalleTransaccion";
            this.txtDetalleTransaccion.Size = new System.Drawing.Size(387, 20);
            this.txtDetalleTransaccion.TabIndex = 24;
            // 
            // txtCodigoEgreso
            // 
            this.txtCodigoEgreso.Location = new System.Drawing.Point(303, 148);
            this.txtCodigoEgreso.Name = "txtCodigoEgreso";
            this.txtCodigoEgreso.Size = new System.Drawing.Size(144, 20);
            this.txtCodigoEgreso.TabIndex = 27;
            // 
            // txtMontoEgreso
            // 
            this.txtMontoEgreso.Location = new System.Drawing.Point(453, 148);
            this.txtMontoEgreso.Name = "txtMontoEgreso";
            this.txtMontoEgreso.Size = new System.Drawing.Size(139, 20);
            this.txtMontoEgreso.TabIndex = 26;
            this.txtMontoEgreso.TextChanged += new System.EventHandler(this.txtMontoEgreso_TextChanged);
            // 
            // txtMontoIngreso
            // 
            this.txtMontoIngreso.Location = new System.Drawing.Point(153, 148);
            this.txtMontoIngreso.Name = "txtMontoIngreso";
            this.txtMontoIngreso.Size = new System.Drawing.Size(139, 20);
            this.txtMontoIngreso.TabIndex = 24;
            this.txtMontoIngreso.TextChanged += new System.EventHandler(this.txtMontoIngreso_TextChanged);
            // 
            // txtCodigoIngreso
            // 
            this.txtCodigoIngreso.Location = new System.Drawing.Point(3, 148);
            this.txtCodigoIngreso.Name = "txtCodigoIngreso";
            this.txtCodigoIngreso.Size = new System.Drawing.Size(139, 20);
            this.txtCodigoIngreso.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Operación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Transacción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de Razón Social";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Transacción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Primer Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Segundo Apellido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Detalle de la Transacción";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Código Moneda Ingreso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Monto del Ingreso";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Código Moneda Egreso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Monto del Egreso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(603, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Detalle del Origen de Fondos";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(3, 83);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(139, 20);
            this.txtFecha.TabIndex = 15;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(153, 18);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(139, 20);
            this.txtIdentificacion.TabIndex = 16;
            // 
            // txtTipoOperacion
            // 
            this.txtTipoOperacion.Location = new System.Drawing.Point(303, 18);
            this.txtTipoOperacion.Name = "txtTipoOperacion";
            this.txtTipoOperacion.Size = new System.Drawing.Size(139, 20);
            this.txtTipoOperacion.TabIndex = 17;
            // 
            // txtTipoTransaccion
            // 
            this.txtTipoTransaccion.Location = new System.Drawing.Point(453, 18);
            this.txtTipoTransaccion.Name = "txtTipoTransaccion";
            this.txtTipoTransaccion.Size = new System.Drawing.Size(139, 20);
            this.txtTipoTransaccion.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(303, 83);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(139, 20);
            this.txtPrimerApellido.TabIndex = 20;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(453, 83);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(139, 20);
            this.txtSegundoApellido.TabIndex = 22;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(603, 18);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(387, 20);
            this.txtRazonSocial.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAsignar);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1208, 335);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de Transacción";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(649, 262);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(114, 34);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar Actividad";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActividadEconomica);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.txtActividad);
            this.groupBox3.Location = new System.Drawing.Point(66, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 78);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignar Actividad Económica a Transacción";
            // 
            // btnActividadEconomica
            // 
            this.btnActividadEconomica.Location = new System.Drawing.Point(453, 34);
            this.btnActividadEconomica.Name = "btnActividadEconomica";
            this.btnActividadEconomica.Size = new System.Drawing.Size(30, 20);
            this.btnActividadEconomica.TabIndex = 8;
            this.btnActividadEconomica.Text = "...";
            this.btnActividadEconomica.UseVisualStyleBackColor = true;
            this.btnActividadEconomica.Click += new System.EventHandler(this.btnActividadEconomica_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(23, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(144, 34);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(294, 20);
            this.txtActividad.TabIndex = 6;
            // 
            // FrmActividadEconomica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 823);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmActividadEconomica";
            this.Text = "Asignar Actividad Económica";
            this.Load += new System.EventHandler(this.FrmActividadEconomica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransacciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTransacciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DES_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP_OPERACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_TRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP_TRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRI_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEG_APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MON_INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MONEDA_INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MON_EGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_MONEDA_EGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DET_TRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn DET_ORIGEN;
        private System.Windows.Forms.TextBox txtCodigoPersona;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDetalleOrigen;
        private System.Windows.Forms.TextBox txtDetalleTransaccion;
        private System.Windows.Forms.TextBox txtCodigoEgreso;
        private System.Windows.Forms.TextBox txtMontoEgreso;
        private System.Windows.Forms.TextBox txtMontoIngreso;
        private System.Windows.Forms.TextBox txtCodigoIngreso;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtTipoOperacion;
        private System.Windows.Forms.TextBox txtTipoTransaccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActividadEconomica;
        public System.Windows.Forms.TextBox txtActividad;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}