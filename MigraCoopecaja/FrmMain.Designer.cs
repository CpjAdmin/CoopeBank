namespace AppEscritorio
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BarraGeneral = new System.Windows.Forms.StatusStrip();
            this.BgEtiquetaUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnPrin = new System.Windows.Forms.Panel();
            this.MnuSugef = new System.Windows.Forms.Button();
            this.pnSugef = new System.Windows.Forms.Panel();
            this.LstSugef = new System.Windows.Forms.ListView();
            this.imglista = new System.Windows.Forms.ImageList(this.components);
            this.pnTesoreria = new System.Windows.Forms.Panel();
            this.LstTesoreria = new System.Windows.Forms.ListView();
            this.MnuTesoreria = new System.Windows.Forms.Button();
            this.pnColocaciones = new System.Windows.Forms.Panel();
            this.LstColocaciones = new System.Windows.Forms.ListView();
            this.MnuColocaciones = new System.Windows.Forms.Button();
            this.pnCaptacion = new System.Windows.Forms.Panel();
            this.LstCaptacion = new System.Windows.Forms.ListView();
            this.MnuCaptacion = new System.Windows.Forms.Button();
            this.pnBackOffice = new System.Windows.Forms.Panel();
            this.LstBackOffice = new System.Windows.Forms.ListView();
            this.MnuBackOffice = new System.Windows.Forms.Button();
            this.pnGeneral = new System.Windows.Forms.Panel();
            this.LstGeneral = new System.Windows.Forms.ListView();
            this.MnuGeneral = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BarraGeneral.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.pnPrin.SuspendLayout();
            this.pnSugef.SuspendLayout();
            this.pnTesoreria.SuspendLayout();
            this.pnColocaciones.SuspendLayout();
            this.pnCaptacion.SuspendLayout();
            this.pnBackOffice.SuspendLayout();
            this.pnGeneral.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraGeneral
            // 
            this.BarraGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BgEtiquetaUsuario,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.BarraGeneral.Location = new System.Drawing.Point(0, 859);
            this.BarraGeneral.Name = "BarraGeneral";
            this.BarraGeneral.Size = new System.Drawing.Size(1184, 22);
            this.BarraGeneral.TabIndex = 2;
            this.BarraGeneral.Text = "StatusStrip";
            // 
            // BgEtiquetaUsuario
            // 
            this.BgEtiquetaUsuario.Name = "BgEtiquetaUsuario";
            this.BgEtiquetaUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnMain.Controls.Add(this.pnPrin);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.Location = new System.Drawing.Point(21, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(170, 859);
            this.pnMain.TabIndex = 4;
            // 
            // pnPrin
            // 
            this.pnPrin.Controls.Add(this.MnuSugef);
            this.pnPrin.Controls.Add(this.pnSugef);
            this.pnPrin.Controls.Add(this.pnTesoreria);
            this.pnPrin.Controls.Add(this.MnuTesoreria);
            this.pnPrin.Controls.Add(this.pnColocaciones);
            this.pnPrin.Controls.Add(this.MnuColocaciones);
            this.pnPrin.Controls.Add(this.pnCaptacion);
            this.pnPrin.Controls.Add(this.MnuCaptacion);
            this.pnPrin.Controls.Add(this.pnBackOffice);
            this.pnPrin.Controls.Add(this.MnuBackOffice);
            this.pnPrin.Controls.Add(this.pnGeneral);
            this.pnPrin.Controls.Add(this.MnuGeneral);
            this.pnPrin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrin.Location = new System.Drawing.Point(0, 0);
            this.pnPrin.Name = "pnPrin";
            this.pnPrin.Size = new System.Drawing.Size(170, 859);
            this.pnPrin.TabIndex = 6;
            // 
            // MnuSugef
            // 
            this.MnuSugef.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnuSugef.Location = new System.Drawing.Point(0, 596);
            this.MnuSugef.Name = "MnuSugef";
            this.MnuSugef.Size = new System.Drawing.Size(170, 23);
            this.MnuSugef.TabIndex = 15;
            this.MnuSugef.Text = "Sugef";
            this.MnuSugef.UseVisualStyleBackColor = true;
            this.MnuSugef.Visible = false;
            this.MnuSugef.Click += new System.EventHandler(this.MnuSugef_Click_1);
            // 
            // pnSugef
            // 
            this.pnSugef.Controls.Add(this.LstSugef);
            this.pnSugef.Location = new System.Drawing.Point(0, 616);
            this.pnSugef.Name = "pnSugef";
            this.pnSugef.Size = new System.Drawing.Size(170, 160);
            this.pnSugef.TabIndex = 14;
            // 
            // LstSugef
            // 
            this.LstSugef.BackColor = System.Drawing.SystemColors.Control;
            this.LstSugef.BackgroundImageTiled = true;
            this.LstSugef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstSugef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstSugef.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LstSugef.HideSelection = false;
            this.LstSugef.LargeImageList = this.imglista;
            this.LstSugef.Location = new System.Drawing.Point(0, 0);
            this.LstSugef.Name = "LstSugef";
            this.LstSugef.Size = new System.Drawing.Size(170, 160);
            this.LstSugef.SmallImageList = this.imglista;
            this.LstSugef.TabIndex = 9;
            this.LstSugef.UseCompatibleStateImageBehavior = false;
            this.LstSugef.View = System.Windows.Forms.View.Details;
            this.LstSugef.Visible = false;
            this.LstSugef.DoubleClick += new System.EventHandler(this.LstSugef_DoubleClick_1);
            // 
            // imglista
            // 
            this.imglista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglista.ImageStream")));
            this.imglista.TransparentColor = System.Drawing.Color.Transparent;
            this.imglista.Images.SetKeyName(0, "Configuration.png");
            this.imglista.Images.SetKeyName(1, "support.png");
            this.imglista.Images.SetKeyName(2, "data.png");
            this.imglista.Images.SetKeyName(3, "Plani64.png");
            this.imglista.Images.SetKeyName(4, "conta.png");
            this.imglista.Images.SetKeyName(5, "carpetaOut.png");
            this.imglista.Images.SetKeyName(6, "OperEspecial.png");
            this.imglista.Images.SetKeyName(7, "change.png");
            this.imglista.Images.SetKeyName(8, "certificado.png");
            this.imglista.Images.SetKeyName(9, "ConstruirTabla.png");
            this.imglista.Images.SetKeyName(10, "Planillas.png");
            this.imglista.Images.SetKeyName(11, "dinero.png");
            this.imglista.Images.SetKeyName(12, "Liqu.png");
            this.imglista.Images.SetKeyName(13, "Vendedor.png");
            this.imglista.Images.SetKeyName(14, "Incob.png");
            this.imglista.Images.SetKeyName(15, "GestExcedentes.png");
            this.imglista.Images.SetKeyName(16, "Reingresos.png");
            this.imglista.Images.SetKeyName(17, "AsoInactivo.png");
            this.imglista.Images.SetKeyName(18, "ICFPC.png");
            this.imglista.Images.SetKeyName(19, "ICFPM.png");
            // 
            // pnTesoreria
            // 
            this.pnTesoreria.Controls.Add(this.LstTesoreria);
            this.pnTesoreria.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTesoreria.Location = new System.Drawing.Point(0, 436);
            this.pnTesoreria.Name = "pnTesoreria";
            this.pnTesoreria.Size = new System.Drawing.Size(170, 160);
            this.pnTesoreria.TabIndex = 8;
            // 
            // LstTesoreria
            // 
            this.LstTesoreria.BackColor = System.Drawing.SystemColors.Control;
            this.LstTesoreria.BackgroundImageTiled = true;
            this.LstTesoreria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstTesoreria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstTesoreria.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LstTesoreria.HideSelection = false;
            this.LstTesoreria.LargeImageList = this.imglista;
            this.LstTesoreria.Location = new System.Drawing.Point(0, 0);
            this.LstTesoreria.Name = "LstTesoreria";
            this.LstTesoreria.Size = new System.Drawing.Size(170, 160);
            this.LstTesoreria.SmallImageList = this.imglista;
            this.LstTesoreria.TabIndex = 8;
            this.LstTesoreria.UseCompatibleStateImageBehavior = false;
            this.LstTesoreria.View = System.Windows.Forms.View.Details;
            this.LstTesoreria.Visible = false;
            this.LstTesoreria.DoubleClick += new System.EventHandler(this.LstTesoreria_DoubleClick);
            // 
            // MnuTesoreria
            // 
            this.MnuTesoreria.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnuTesoreria.Location = new System.Drawing.Point(0, 413);
            this.MnuTesoreria.Name = "MnuTesoreria";
            this.MnuTesoreria.Size = new System.Drawing.Size(170, 23);
            this.MnuTesoreria.TabIndex = 13;
            this.MnuTesoreria.Text = "Tesoreria";
            this.MnuTesoreria.UseVisualStyleBackColor = true;
            this.MnuTesoreria.Visible = false;
            this.MnuTesoreria.Click += new System.EventHandler(this.MnuTesoreria_Click);
            // 
            // pnColocaciones
            // 
            this.pnColocaciones.Controls.Add(this.LstColocaciones);
            this.pnColocaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnColocaciones.Location = new System.Drawing.Point(0, 253);
            this.pnColocaciones.Name = "pnColocaciones";
            this.pnColocaciones.Size = new System.Drawing.Size(170, 160);
            this.pnColocaciones.TabIndex = 12;
            // 
            // LstColocaciones
            // 
            this.LstColocaciones.BackColor = System.Drawing.SystemColors.Control;
            this.LstColocaciones.BackgroundImageTiled = true;
            this.LstColocaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstColocaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstColocaciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LstColocaciones.HideSelection = false;
            this.LstColocaciones.LargeImageList = this.imglista;
            this.LstColocaciones.Location = new System.Drawing.Point(0, 0);
            this.LstColocaciones.Name = "LstColocaciones";
            this.LstColocaciones.Size = new System.Drawing.Size(170, 160);
            this.LstColocaciones.SmallImageList = this.imglista;
            this.LstColocaciones.TabIndex = 5;
            this.LstColocaciones.UseCompatibleStateImageBehavior = false;
            this.LstColocaciones.View = System.Windows.Forms.View.Details;
            this.LstColocaciones.Visible = false;
            this.LstColocaciones.DoubleClick += new System.EventHandler(this.LstColocaciones_DoubleClick);
            // 
            // MnuColocaciones
            // 
            this.MnuColocaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnuColocaciones.Location = new System.Drawing.Point(0, 230);
            this.MnuColocaciones.Name = "MnuColocaciones";
            this.MnuColocaciones.Size = new System.Drawing.Size(170, 23);
            this.MnuColocaciones.TabIndex = 11;
            this.MnuColocaciones.Text = "Colocaciones";
            this.MnuColocaciones.UseVisualStyleBackColor = true;
            this.MnuColocaciones.Visible = false;
            this.MnuColocaciones.Click += new System.EventHandler(this.MnuColocaciones_Click);
            // 
            // pnCaptacion
            // 
            this.pnCaptacion.Controls.Add(this.LstCaptacion);
            this.pnCaptacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCaptacion.Location = new System.Drawing.Point(0, 170);
            this.pnCaptacion.Name = "pnCaptacion";
            this.pnCaptacion.Size = new System.Drawing.Size(170, 60);
            this.pnCaptacion.TabIndex = 10;
            // 
            // LstCaptacion
            // 
            this.LstCaptacion.BackColor = System.Drawing.SystemColors.Control;
            this.LstCaptacion.BackgroundImageTiled = true;
            this.LstCaptacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstCaptacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstCaptacion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LstCaptacion.HideSelection = false;
            this.LstCaptacion.LargeImageList = this.imglista;
            this.LstCaptacion.Location = new System.Drawing.Point(0, 0);
            this.LstCaptacion.Name = "LstCaptacion";
            this.LstCaptacion.Size = new System.Drawing.Size(170, 60);
            this.LstCaptacion.SmallImageList = this.imglista;
            this.LstCaptacion.TabIndex = 5;
            this.LstCaptacion.UseCompatibleStateImageBehavior = false;
            this.LstCaptacion.View = System.Windows.Forms.View.Details;
            this.LstCaptacion.Visible = false;
            this.LstCaptacion.DoubleClick += new System.EventHandler(this.LstCaptacion_DoubleClick);
            // 
            // MnuCaptacion
            // 
            this.MnuCaptacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnuCaptacion.Location = new System.Drawing.Point(0, 147);
            this.MnuCaptacion.Name = "MnuCaptacion";
            this.MnuCaptacion.Size = new System.Drawing.Size(170, 23);
            this.MnuCaptacion.TabIndex = 9;
            this.MnuCaptacion.Text = "Captación";
            this.MnuCaptacion.UseVisualStyleBackColor = true;
            this.MnuCaptacion.Visible = false;
            this.MnuCaptacion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnBackOffice
            // 
            this.pnBackOffice.Controls.Add(this.LstBackOffice);
            this.pnBackOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBackOffice.Location = new System.Drawing.Point(0, 87);
            this.pnBackOffice.Name = "pnBackOffice";
            this.pnBackOffice.Size = new System.Drawing.Size(170, 60);
            this.pnBackOffice.TabIndex = 8;
            // 
            // LstBackOffice
            // 
            this.LstBackOffice.BackColor = System.Drawing.SystemColors.Control;
            this.LstBackOffice.BackgroundImageTiled = true;
            this.LstBackOffice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstBackOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstBackOffice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LstBackOffice.HideSelection = false;
            this.LstBackOffice.LargeImageList = this.imglista;
            this.LstBackOffice.Location = new System.Drawing.Point(0, 0);
            this.LstBackOffice.Name = "LstBackOffice";
            this.LstBackOffice.Size = new System.Drawing.Size(170, 60);
            this.LstBackOffice.SmallImageList = this.imglista;
            this.LstBackOffice.TabIndex = 5;
            this.LstBackOffice.UseCompatibleStateImageBehavior = false;
            this.LstBackOffice.View = System.Windows.Forms.View.Details;
            this.LstBackOffice.Visible = false;
            this.LstBackOffice.DoubleClick += new System.EventHandler(this.LstBackOffice_DoubleClick);
            // 
            // MnuBackOffice
            // 
            this.MnuBackOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnuBackOffice.Location = new System.Drawing.Point(0, 64);
            this.MnuBackOffice.Name = "MnuBackOffice";
            this.MnuBackOffice.Size = new System.Drawing.Size(170, 23);
            this.MnuBackOffice.TabIndex = 7;
            this.MnuBackOffice.Text = "BackOffice";
            this.MnuBackOffice.UseVisualStyleBackColor = true;
            this.MnuBackOffice.Visible = false;
            this.MnuBackOffice.Click += new System.EventHandler(this.MnuCaptacion_Click);
            // 
            // pnGeneral
            // 
            this.pnGeneral.Controls.Add(this.LstGeneral);
            this.pnGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGeneral.Location = new System.Drawing.Point(0, 23);
            this.pnGeneral.Name = "pnGeneral";
            this.pnGeneral.Size = new System.Drawing.Size(170, 41);
            this.pnGeneral.TabIndex = 6;
            // 
            // LstGeneral
            // 
            this.LstGeneral.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.LstGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.LstGeneral.BackgroundImageTiled = true;
            this.LstGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstGeneral.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LstGeneral.HideSelection = false;
            this.LstGeneral.LargeImageList = this.imglista;
            this.LstGeneral.Location = new System.Drawing.Point(0, 0);
            this.LstGeneral.Name = "LstGeneral";
            this.LstGeneral.Size = new System.Drawing.Size(170, 41);
            this.LstGeneral.SmallImageList = this.imglista;
            this.LstGeneral.TabIndex = 5;
            this.LstGeneral.UseCompatibleStateImageBehavior = false;
            this.LstGeneral.View = System.Windows.Forms.View.Details;
            this.LstGeneral.Visible = false;
            this.LstGeneral.ItemActivate += new System.EventHandler(this.LstGeneral_ItemActivate);
            this.LstGeneral.SelectedIndexChanged += new System.EventHandler(this.LstGeneral_SelectedIndexChanged);
            this.LstGeneral.DoubleClick += new System.EventHandler(this.LstGeneral_DoubleClick);
            // 
            // MnuGeneral
            // 
            this.MnuGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.MnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.MnuGeneral.Name = "MnuGeneral";
            this.MnuGeneral.Size = new System.Drawing.Size(170, 23);
            this.MnuGeneral.TabIndex = 5;
            this.MnuGeneral.Text = "General";
            this.MnuGeneral.UseVisualStyleBackColor = true;
            this.MnuGeneral.Visible = false;
            this.MnuGeneral.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 859);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::AppEscritorio.Properties.Resources.move;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 859);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppEscritorio.Properties.Resources.FondoSistema6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 881);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraGeneral);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "CoopeBank (Sistema complementario Coopecaja)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.MouseHover += new System.EventHandler(this.FrmMain_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.BarraGeneral.ResumeLayout(false);
            this.BarraGeneral.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnPrin.ResumeLayout(false);
            this.pnSugef.ResumeLayout(false);
            this.pnTesoreria.ResumeLayout(false);
            this.pnColocaciones.ResumeLayout(false);
            this.pnCaptacion.ResumeLayout(false);
            this.pnBackOffice.ResumeLayout(false);
            this.pnGeneral.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip BarraGeneral;
        private System.Windows.Forms.ToolStripStatusLabel BgEtiquetaUsuario;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ListView LstGeneral;
        private System.Windows.Forms.Button MnuGeneral;
        private System.Windows.Forms.ImageList imglista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnPrin;
        private System.Windows.Forms.Panel pnGeneral;
        private System.Windows.Forms.Panel pnBackOffice;
        private System.Windows.Forms.ListView LstBackOffice;
        private System.Windows.Forms.Button MnuBackOffice;
        private System.Windows.Forms.Panel pnCaptacion;
        private System.Windows.Forms.ListView LstCaptacion;
        private System.Windows.Forms.Button MnuCaptacion;
        private System.Windows.Forms.Panel pnColocaciones;
        private System.Windows.Forms.ListView LstColocaciones;
        private System.Windows.Forms.Button MnuColocaciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnTesoreria;
        private System.Windows.Forms.ListView LstTesoreria;
        private System.Windows.Forms.Button MnuTesoreria;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Panel pnSugef;
        private System.Windows.Forms.ListView LstSugef;
        private System.Windows.Forms.Button MnuSugef;
    }
}



