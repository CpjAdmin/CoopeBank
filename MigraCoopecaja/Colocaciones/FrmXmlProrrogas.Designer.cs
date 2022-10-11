namespace AppEscritorio.Colocaciones
{
    partial class FrmXmlProrrogas
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
            this.DtPeriodo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtPeriodo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // DtPeriodo
            // 
            this.DtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtPeriodo.Location = new System.Drawing.Point(97, 54);
            this.DtPeriodo.Name = "DtPeriodo";
            this.DtPeriodo.Size = new System.Drawing.Size(223, 26);
            this.DtPeriodo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Periodo";
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarXml.Location = new System.Drawing.Point(146, 131);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(139, 36);
            this.btnGenerarXml.TabIndex = 17;
            this.btnGenerarXml.Text = "Generar XML";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // FrmXmlProrrogas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 179);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmXmlProrrogas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xml Clase 39- ModificacionesCreditoEmergenciaCOVID19";
            this.Load += new System.EventHandler(this.FrmXmlProrrogas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerarXml;
    }
}