
namespace AppEscritorio.Captacion
{
    partial class FrmCategoriaComercial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCargaAhorros = new System.Windows.Forms.Button();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMontoFin = new System.Windows.Forms.TextBox();
            this.txtMontoIni = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblModulo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMontoI = new System.Windows.Forms.Label();
            this.lblMontoF = new System.Windows.Forms.Label();
            this.Módulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgCategoria);
            this.groupBox2.Location = new System.Drawing.Point(18, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 306);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Categoría Comercial";
            // 
            // dgCategoria
            // 
            this.dgCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategoria.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Módulo,
            this.Tipo_Cliente,
            this.Monto_Inicial,
            this.Monto_Final,
            this.Categoría,
            this.Mensaje});
            this.dgCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgCategoria.Location = new System.Drawing.Point(6, 20);
            this.dgCategoria.Name = "dgCategoria";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dgCategoria.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategoria.Size = new System.Drawing.Size(906, 281);
            this.dgCategoria.TabIndex = 0;
            this.dgCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellClick);
            this.dgCategoria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgCategoria_CellFormatting);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIngresar.Location = new System.Drawing.Point(200, 440);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 27);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEliminar.Location = new System.Drawing.Point(323, 440);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 27);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCargaAhorros
            // 
            this.btnCargaAhorros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCargaAhorros.Location = new System.Drawing.Point(750, 469);
            this.btnCargaAhorros.Name = "btnCargaAhorros";
            this.btnCargaAhorros.Size = new System.Drawing.Size(147, 27);
            this.btnCargaAhorros.TabIndex = 7;
            this.btnCargaAhorros.Text = "Ir a Ahorros";
            this.btnCargaAhorros.UseVisualStyleBackColor = true;
            this.btnCargaAhorros.Click += new System.EventHandler(this.btnCargaAhorros_Click);
            // 
            // cmbModulo
            // 
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Items.AddRange(new object[] {
            "AHORROS",
            "CERTIFICADOS"});
            this.cmbModulo.Location = new System.Drawing.Point(3, 31);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(131, 21);
            this.cmbModulo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Módulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(140, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(277, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(414, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(551, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(688, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mensaje";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.FormattingEnabled = true;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "FISÍCAS",
            "JURÍDICAS"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(140, 31);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(131, 21);
            this.cmbTipoCliente.TabIndex = 8;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(551, 31);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(131, 20);
            this.txtCategoria.TabIndex = 11;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(688, 31);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(215, 20);
            this.txtMensaje.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel1.Controls.Add(this.txtMontoFin, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMontoIni, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMensaje, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCategoria, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbModulo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoCliente, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // txtMontoFin
            // 
            this.txtMontoFin.Location = new System.Drawing.Point(414, 31);
            this.txtMontoFin.Name = "txtMontoFin";
            this.txtMontoFin.Size = new System.Drawing.Size(131, 20);
            this.txtMontoFin.TabIndex = 16;
            this.txtMontoFin.Leave += new System.EventHandler(this.txtMontoFin_Leave);
            // 
            // txtMontoIni
            // 
            this.txtMontoIni.Location = new System.Drawing.Point(277, 31);
            this.txtMontoIni.Name = "txtMontoIni";
            this.txtMontoIni.Size = new System.Drawing.Size(131, 20);
            this.txtMontoIni.TabIndex = 15;
            this.txtMontoIni.Leave += new System.EventHandler(this.txtMontoIni_Leave);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConsultar.Location = new System.Drawing.Point(441, 440);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(95, 27);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(555, 440);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 27);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(62, 483);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(0, 13);
            this.lblModulo.TabIndex = 11;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(164, 483);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 12;
            // 
            // lblMontoI
            // 
            this.lblMontoI.AutoSize = true;
            this.lblMontoI.Location = new System.Drawing.Point(274, 483);
            this.lblMontoI.Name = "lblMontoI";
            this.lblMontoI.Size = new System.Drawing.Size(0, 13);
            this.lblMontoI.TabIndex = 13;
            // 
            // lblMontoF
            // 
            this.lblMontoF.AutoSize = true;
            this.lblMontoF.Location = new System.Drawing.Point(377, 483);
            this.lblMontoF.Name = "lblMontoF";
            this.lblMontoF.Size = new System.Drawing.Size(0, 13);
            this.lblMontoF.TabIndex = 14;
            // 
            // Módulo
            // 
            this.Módulo.FillWeight = 52.04181F;
            this.Módulo.HeaderText = "Módulo";
            this.Módulo.Name = "Módulo";
            // 
            // Tipo_Cliente
            // 
            this.Tipo_Cliente.FillWeight = 82.65986F;
            this.Tipo_Cliente.HeaderText = "Tipo Cliente";
            this.Tipo_Cliente.Name = "Tipo_Cliente";
            // 
            // Monto_Inicial
            // 
            this.Monto_Inicial.FillWeight = 100.5076F;
            this.Monto_Inicial.HeaderText = "Monto Inicial";
            this.Monto_Inicial.Name = "Monto_Inicial";
            // 
            // Monto_Final
            // 
            this.Monto_Final.FillWeight = 84.18044F;
            this.Monto_Final.HeaderText = "Monto Final";
            this.Monto_Final.Name = "Monto_Final";
            // 
            // Categoría
            // 
            this.Categoría.FillWeight = 58.91471F;
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.Name = "Categoría";
            // 
            // Mensaje
            // 
            this.Mensaje.FillWeight = 221.6956F;
            this.Mensaje.HeaderText = "Mensaje";
            this.Mensaje.Name = "Mensaje";
            // 
            // FrmCategoriaComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 515);
            this.Controls.Add(this.lblMontoF);
            this.Controls.Add(this.lblMontoI);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCargaAhorros);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "FrmCategoriaComercial";
            this.Text = "Categoría Comercial";
            this.Load += new System.EventHandler(this.FrmCategoriaComercial_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCargaAhorros;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTipoCliente;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMontoI;
        private System.Windows.Forms.Label lblMontoF;
        private System.Windows.Forms.TextBox txtMontoIni;
        private System.Windows.Forms.TextBox txtMontoFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Módulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensaje;
    }
}