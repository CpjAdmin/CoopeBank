
namespace AppEscritorio.Colocaciones
{
    partial class FrmEliminarMedio_ICFMP
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
            this.dgMediosElect = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMedio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_MONEDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLAZO_MAXIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGARES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COBERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgMediosElect)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMediosElect
            // 
            this.dgMediosElect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMediosElect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.CODIGO_PRODUCTO,
            this.MARCA,
            this.TIPO_MONEDA,
            this.PLAZO,
            this.PLAZO_MAXIMO,
            this.LUGARES,
            this.COBERTURA});
            this.dgMediosElect.Location = new System.Drawing.Point(6, 32);
            this.dgMediosElect.Name = "dgMediosElect";
            this.dgMediosElect.RowHeadersWidth = 51;
            this.dgMediosElect.Size = new System.Drawing.Size(901, 291);
            this.dgMediosElect.TabIndex = 0;
            this.dgMediosElect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMediosElect_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblMedio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.dgMediosElect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Medio Electrónico";
            // 
            // lblMedio
            // 
            this.lblMedio.AutoSize = true;
            this.lblMedio.Location = new System.Drawing.Point(173, 368);
            this.lblMedio.Name = "lblMedio";
            this.lblMedio.Size = new System.Drawing.Size(0, 13);
            this.lblMedio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eliminar Registro:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(576, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 50);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(382, 368);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 4;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // CODIGO_PRODUCTO
            // 
            this.CODIGO_PRODUCTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CODIGO_PRODUCTO.HeaderText = "CODIGO_PRODUCTO";
            this.CODIGO_PRODUCTO.Name = "CODIGO_PRODUCTO";
            this.CODIGO_PRODUCTO.Width = 141;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.MinimumWidth = 6;
            this.MARCA.Name = "MARCA";
            this.MARCA.Width = 125;
            // 
            // TIPO_MONEDA
            // 
            this.TIPO_MONEDA.HeaderText = "TIPO_MONEDA";
            this.TIPO_MONEDA.Name = "TIPO_MONEDA";
            // 
            // PLAZO
            // 
            this.PLAZO.HeaderText = "PLAZO";
            this.PLAZO.MinimumWidth = 6;
            this.PLAZO.Name = "PLAZO";
            this.PLAZO.Width = 125;
            // 
            // PLAZO_MAXIMO
            // 
            this.PLAZO_MAXIMO.HeaderText = "PLAZO_MAXIMO";
            this.PLAZO_MAXIMO.MinimumWidth = 6;
            this.PLAZO_MAXIMO.Name = "PLAZO_MAXIMO";
            this.PLAZO_MAXIMO.Width = 125;
            // 
            // LUGARES
            // 
            this.LUGARES.HeaderText = "LUGARES";
            this.LUGARES.MinimumWidth = 6;
            this.LUGARES.Name = "LUGARES";
            this.LUGARES.Width = 125;
            // 
            // COBERTURA
            // 
            this.COBERTURA.HeaderText = "COBERTURA";
            this.COBERTURA.MinimumWidth = 6;
            this.COBERTURA.Name = "COBERTURA";
            this.COBERTURA.Width = 125;
            // 
            // FrmEliminarMedio_ICFMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEliminarMedio_ICFMP";
            this.Text = "FrmEliminarMedio_ICFMP";
            this.Load += new System.EventHandler(this.FrmEliminarMedio_ICFMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMediosElect)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMediosElect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_MONEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLAZO_MAXIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGARES;
        private System.Windows.Forms.DataGridViewTextBoxColumn COBERTURA;
    }
}