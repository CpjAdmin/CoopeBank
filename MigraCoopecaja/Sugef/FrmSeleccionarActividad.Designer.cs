
namespace AppEscritorio.Sugef
{
    partial class FrmSeleccionarActividad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgActividad = new System.Windows.Forms.DataGridView();
            this.CODIGO_SUBCLASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbDescripcion = new System.Windows.Forms.PictureBox();
            this.pbCodigo = new System.Windows.Forms.PictureBox();
            this.pbRefrescar = new System.Windows.Forms.PictureBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.txtDescripcion1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgActividad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción de la Actividad";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(190, 18);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(190, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // dgActividad
            // 
            this.dgActividad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_SUBCLASE,
            this.TITULO});
            this.dgActividad.Location = new System.Drawing.Point(46, 156);
            this.dgActividad.Name = "dgActividad";
            this.dgActividad.Size = new System.Drawing.Size(452, 167);
            this.dgActividad.TabIndex = 4;
            this.dgActividad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgActividad_CellClick);
            // 
            // CODIGO_SUBCLASE
            // 
            this.CODIGO_SUBCLASE.FillWeight = 60.9137F;
            this.CODIGO_SUBCLASE.HeaderText = "CODIGO_SUBCLASE";
            this.CODIGO_SUBCLASE.Name = "CODIGO_SUBCLASE";
            // 
            // TITULO
            // 
            this.TITULO.FillWeight = 139.0863F;
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbRefrescar);
            this.groupBox1.Controls.Add(this.pbDescripcion);
            this.groupBox1.Controls.Add(this.pbCodigo);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Actividad";
            // 
            // pbDescripcion
            // 
            this.pbDescripcion.Image = global::AppEscritorio.Properties.Resources.buscar;
            this.pbDescripcion.Location = new System.Drawing.Point(399, 54);
            this.pbDescripcion.Name = "pbDescripcion";
            this.pbDescripcion.Size = new System.Drawing.Size(22, 18);
            this.pbDescripcion.TabIndex = 5;
            this.pbDescripcion.TabStop = false;
            this.pbDescripcion.Click += new System.EventHandler(this.pbDescripcion_Click);
            // 
            // pbCodigo
            // 
            this.pbCodigo.Image = global::AppEscritorio.Properties.Resources.buscar;
            this.pbCodigo.Location = new System.Drawing.Point(310, 18);
            this.pbCodigo.Name = "pbCodigo";
            this.pbCodigo.Size = new System.Drawing.Size(22, 18);
            this.pbCodigo.TabIndex = 4;
            this.pbCodigo.TabStop = false;
            this.pbCodigo.Click += new System.EventHandler(this.pbCodigo_Click);
            // 
            // pbRefrescar
            // 
            this.pbRefrescar.Image = global::AppEscritorio.Properties.Resources.refres;
            this.pbRefrescar.Location = new System.Drawing.Point(387, 8);
            this.pbRefrescar.Name = "pbRefrescar";
            this.pbRefrescar.Size = new System.Drawing.Size(34, 30);
            this.pbRefrescar.TabIndex = 6;
            this.pbRefrescar.TabStop = false;
            this.pbRefrescar.Click += new System.EventHandler(this.pbRefrescar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(141, 383);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(113, 29);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(276, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 29);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Location = new System.Drawing.Point(108, 341);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo1.TabIndex = 9;
            // 
            // txtDescripcion1
            // 
            this.txtDescripcion1.Location = new System.Drawing.Point(236, 341);
            this.txtDescripcion1.Name = "txtDescripcion1";
            this.txtDescripcion1.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion1.TabIndex = 10;
            // 
            // FrmSeleccionarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 424);
            this.Controls.Add(this.txtDescripcion1);
            this.Controls.Add(this.txtCodigo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgActividad);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "FrmSeleccionarActividad";
            this.Text = "Seleccionar Actividad Económica";
            this.Load += new System.EventHandler(this.FrmSeleccionarActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgActividad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgActividad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_SUBCLASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.PictureBox pbCodigo;
        private System.Windows.Forms.PictureBox pbDescripcion;
        private System.Windows.Forms.PictureBox pbRefrescar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtCodigo1;
        public System.Windows.Forms.TextBox txtDescripcion1;
    }
}