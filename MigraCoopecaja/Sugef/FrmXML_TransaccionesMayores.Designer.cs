
namespace AppEscritorio.Sugef
{
    partial class FrmXML_TransaccionesMayores
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
            this.pbRefrescar = new System.Windows.Forms.PictureBox();
            this.dtFecha_Despues = new System.Windows.Forms.DateTimePicker();
            this.dtFecha_Antes = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.pbFecha = new System.Windows.Forms.PictureBox();
            this.dgTransacciones = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOrigenFondos = new System.Windows.Forms.TextBox();
            this.txtTipoActividad = new System.Windows.Forms.TextBox();
            this.txtTipoTransaccion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTipoMoneda = new System.Windows.Forms.TextBox();
            this.txtTipoEntradaSalida = new System.Windows.Forms.TextBox();
            this.txtTipo_Operacion = new System.Windows.Forms.TextBox();
            this.txtIdPersona = new System.Windows.Forms.TextBox();
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
            this.txtTipoPersona = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOOPERACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOENTRADASALIDAFONDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOMONEDATRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHATRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOTRANSACCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOACTIVIDADECONOMICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORIGENFONDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransacciones)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbRefrescar);
            this.groupBox1.Controls.Add(this.dtFecha_Despues);
            this.groupBox1.Controls.Add(this.dtFecha_Antes);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pbFecha);
            this.groupBox1.Controls.Add(this.dgTransacciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta Transacciones Mayores a $10 000";
            // 
            // pbRefrescar
            // 
            this.pbRefrescar.Image = global::AppEscritorio.Properties.Resources.refres;
            this.pbRefrescar.Location = new System.Drawing.Point(1137, 51);
            this.pbRefrescar.Name = "pbRefrescar";
            this.pbRefrescar.Size = new System.Drawing.Size(37, 37);
            this.pbRefrescar.TabIndex = 28;
            this.pbRefrescar.TabStop = false;
            this.pbRefrescar.Click += new System.EventHandler(this.pbRefrescar_Click);
            // 
            // dtFecha_Despues
            // 
            this.dtFecha_Despues.Location = new System.Drawing.Point(462, 36);
            this.dtFecha_Despues.Name = "dtFecha_Despues";
            this.dtFecha_Despues.Size = new System.Drawing.Size(207, 20);
            this.dtFecha_Despues.TabIndex = 27;
            // 
            // dtFecha_Antes
            // 
            this.dtFecha_Antes.Location = new System.Drawing.Point(223, 36);
            this.dtFecha_Antes.Name = "dtFecha_Antes";
            this.dtFecha_Antes.Size = new System.Drawing.Size(207, 20);
            this.dtFecha_Antes.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Seleccione el rango de fechas:";
            // 
            // pbFecha
            // 
            this.pbFecha.Image = global::AppEscritorio.Properties.Resources.buscar;
            this.pbFecha.Location = new System.Drawing.Point(696, 36);
            this.pbFecha.Name = "pbFecha";
            this.pbFecha.Size = new System.Drawing.Size(23, 20);
            this.pbFecha.TabIndex = 3;
            this.pbFecha.TabStop = false;
            this.pbFecha.Click += new System.EventHandler(this.pbFecha_Click);
            // 
            // dgTransacciones
            // 
            this.dgTransacciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIPOPERSONA,
            this.IDPERSONA,
            this.TIPOOPERACION,
            this.TIPOENTRADASALIDAFONDOS,
            this.TIPOMONEDATRANSACCION,
            this.MONTO,
            this.FECHATRANSACCION,
            this.TIPOTRANSACCION,
            this.TIPOACTIVIDADECONOMICA,
            this.ORIGENFONDOS});
            this.dgTransacciones.Location = new System.Drawing.Point(9, 94);
            this.dgTransacciones.Name = "dgTransacciones";
            this.dgTransacciones.Size = new System.Drawing.Size(1168, 162);
            this.dgTransacciones.TabIndex = 0;
            this.dgTransacciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransacciones_CellClick);
            this.dgTransacciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgTransacciones_CellFormatting);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtOrigenFondos, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoActividad, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoTransaccion, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFecha, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMonto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoMoneda, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoEntradaSalida, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTipo_Operacion, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdPersona, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTipoPersona, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1152, 118);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtOrigenFondos
            // 
            this.txtOrigenFondos.Location = new System.Drawing.Point(923, 80);
            this.txtOrigenFondos.Name = "txtOrigenFondos";
            this.txtOrigenFondos.Size = new System.Drawing.Size(221, 20);
            this.txtOrigenFondos.TabIndex = 19;
            // 
            // txtTipoActividad
            // 
            this.txtTipoActividad.Location = new System.Drawing.Point(693, 80);
            this.txtTipoActividad.Name = "txtTipoActividad";
            this.txtTipoActividad.Size = new System.Drawing.Size(221, 20);
            this.txtTipoActividad.TabIndex = 18;
            // 
            // txtTipoTransaccion
            // 
            this.txtTipoTransaccion.AcceptsReturn = true;
            this.txtTipoTransaccion.Location = new System.Drawing.Point(463, 80);
            this.txtTipoTransaccion.Name = "txtTipoTransaccion";
            this.txtTipoTransaccion.Size = new System.Drawing.Size(221, 20);
            this.txtTipoTransaccion.TabIndex = 17;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(233, 80);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(221, 20);
            this.txtFecha.TabIndex = 16;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(3, 80);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(221, 20);
            this.txtMonto.TabIndex = 15;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtTipoMoneda
            // 
            this.txtTipoMoneda.Location = new System.Drawing.Point(923, 22);
            this.txtTipoMoneda.Name = "txtTipoMoneda";
            this.txtTipoMoneda.Size = new System.Drawing.Size(221, 20);
            this.txtTipoMoneda.TabIndex = 14;
            // 
            // txtTipoEntradaSalida
            // 
            this.txtTipoEntradaSalida.Location = new System.Drawing.Point(693, 22);
            this.txtTipoEntradaSalida.Name = "txtTipoEntradaSalida";
            this.txtTipoEntradaSalida.Size = new System.Drawing.Size(221, 20);
            this.txtTipoEntradaSalida.TabIndex = 13;
            // 
            // txtTipo_Operacion
            // 
            this.txtTipo_Operacion.Location = new System.Drawing.Point(463, 22);
            this.txtTipo_Operacion.Name = "txtTipo_Operacion";
            this.txtTipo_Operacion.Size = new System.Drawing.Size(221, 20);
            this.txtTipo_Operacion.TabIndex = 12;
            // 
            // txtIdPersona
            // 
            this.txtIdPersona.Location = new System.Drawing.Point(233, 22);
            this.txtIdPersona.Name = "txtIdPersona";
            this.txtIdPersona.Size = new System.Drawing.Size(221, 20);
            this.txtIdPersona.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO_PERSONA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID_PERSONA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO_OPERACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(693, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIPO_ENTRADA_SALIDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIPO_MONEDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "MONTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "FECHA_TRANSACCION";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "TIPO_TRANSACCION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "TIPO_ACTIVIDAD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(923, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "ORIGEN_FONDOS";
            // 
            // txtTipoPersona
            // 
            this.txtTipoPersona.Location = new System.Drawing.Point(3, 22);
            this.txtTipoPersona.Name = "txtTipoPersona";
            this.txtTipoPersona.Size = new System.Drawing.Size(221, 20);
            this.txtTipoPersona.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Datos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(696, 163);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(555, 163);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(857, 536);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 35);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar XML";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "label12";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // TIPOPERSONA
            // 
            this.TIPOPERSONA.HeaderText = "TIPO_PERSONA";
            this.TIPOPERSONA.Name = "TIPOPERSONA";
            // 
            // IDPERSONA
            // 
            this.IDPERSONA.HeaderText = "ID_PERSONA";
            this.IDPERSONA.Name = "IDPERSONA";
            // 
            // TIPOOPERACION
            // 
            this.TIPOOPERACION.HeaderText = "TIPO_OPERACION";
            this.TIPOOPERACION.Name = "TIPOOPERACION";
            // 
            // TIPOENTRADASALIDAFONDOS
            // 
            this.TIPOENTRADASALIDAFONDOS.HeaderText = "TIPOENTRADA_SALIDAFONDOS";
            this.TIPOENTRADASALIDAFONDOS.Name = "TIPOENTRADASALIDAFONDOS";
            // 
            // TIPOMONEDATRANSACCION
            // 
            this.TIPOMONEDATRANSACCION.HeaderText = "TIPO_MONEDATRANSACCION";
            this.TIPOMONEDATRANSACCION.Name = "TIPOMONEDATRANSACCION";
            // 
            // MONTO
            // 
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            // 
            // FECHATRANSACCION
            // 
            this.FECHATRANSACCION.HeaderText = "FECHA_TRANSACCION";
            this.FECHATRANSACCION.Name = "FECHATRANSACCION";
            // 
            // TIPOTRANSACCION
            // 
            this.TIPOTRANSACCION.HeaderText = "TIPO_TRANSACCION";
            this.TIPOTRANSACCION.Name = "TIPOTRANSACCION";
            // 
            // TIPOACTIVIDADECONOMICA
            // 
            this.TIPOACTIVIDADECONOMICA.HeaderText = "TIPO_ACTIVIDADECONOMICA";
            this.TIPOACTIVIDADECONOMICA.Name = "TIPOACTIVIDADECONOMICA";
            // 
            // ORIGENFONDOS
            // 
            this.ORIGENFONDOS.HeaderText = "ORIGEN_FONDOS";
            this.ORIGENFONDOS.Name = "ORIGENFONDOS";
            // 
            // FrmXML_TransaccionesMayores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 584);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmXML_TransaccionesMayores";
            this.Text = "Generar XML Transacciones Mayores - Tipo 50";
            this.Load += new System.EventHandler(this.FrmXML_TransaccionesMayores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransacciones)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgTransacciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigenFondos;
        private System.Windows.Forms.TextBox txtTipoActividad;
        private System.Windows.Forms.TextBox txtTipoTransaccion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTipoMoneda;
        private System.Windows.Forms.TextBox txtTipoEntradaSalida;
        private System.Windows.Forms.TextBox txtTipo_Operacion;
        private System.Windows.Forms.TextBox txtIdPersona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipoPersona;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pbFecha;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFecha_Antes;
        private System.Windows.Forms.DateTimePicker dtFecha_Despues;
        private System.Windows.Forms.PictureBox pbRefrescar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOOPERACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOENTRADASALIDAFONDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOMONEDATRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHATRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOTRANSACCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOACTIVIDADECONOMICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGENFONDOS;
    }
}