namespace App
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlAbajo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargueDeListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generacionArchivosPlanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarHistoricosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasIBSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.causalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposIdentificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homologacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.causalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoIdentificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.rutasDeLasListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAbajo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAbajo
            // 
            this.pnlAbajo.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlAbajo.Controls.Add(this.btnCerrar);
            this.pnlAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAbajo.Location = new System.Drawing.Point(0, 484);
            this.pnlAbajo.Name = "pnlAbajo";
            this.pnlAbajo.Padding = new System.Windows.Forms.Padding(3);
            this.pnlAbajo.Size = new System.Drawing.Size(865, 33);
            this.pnlAbajo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrar.Image = global::App.Properties.Resources.logout;
            this.btnCerrar.Location = new System.Drawing.Point(3, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(55, 27);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargueDeListasToolStripMenuItem,
            this.visoresToolStripMenuItem,
            this.generacionArchivosPlanosToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ventanaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "mnPrincipal";
            // 
            // cargueDeListasToolStripMenuItem
            // 
            this.cargueDeListasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ofacToolStripMenuItem,
            this.onuToolStripMenuItem});
            this.cargueDeListasToolStripMenuItem.Name = "cargueDeListasToolStripMenuItem";
            this.cargueDeListasToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.cargueDeListasToolStripMenuItem.Text = "Cargue de listas";
            // 
            // ofacToolStripMenuItem
            // 
            this.ofacToolStripMenuItem.Name = "ofacToolStripMenuItem";
            this.ofacToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.ofacToolStripMenuItem.Text = "Ofac";
            this.ofacToolStripMenuItem.Click += new System.EventHandler(this.ofacToolStripMenuItem_Click);
            // 
            // onuToolStripMenuItem
            // 
            this.onuToolStripMenuItem.Name = "onuToolStripMenuItem";
            this.onuToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.onuToolStripMenuItem.Text = "Onu";
            this.onuToolStripMenuItem.Click += new System.EventHandler(this.onuToolStripMenuItem_Click);
            // 
            // visoresToolStripMenuItem
            // 
            this.visoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaActualToolStripMenuItem});
            this.visoresToolStripMenuItem.Name = "visoresToolStripMenuItem";
            this.visoresToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.visoresToolStripMenuItem.Text = "Visores";
            // 
            // listaActualToolStripMenuItem
            // 
            this.listaActualToolStripMenuItem.Name = "listaActualToolStripMenuItem";
            this.listaActualToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.listaActualToolStripMenuItem.Text = "Lista Actual";
            this.listaActualToolStripMenuItem.Click += new System.EventHandler(this.listaActualToolStripMenuItem_Click);
            // 
            // generacionArchivosPlanosToolStripMenuItem
            // 
            this.generacionArchivosPlanosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.generarHistoricosToolStripMenuItem});
            this.generacionArchivosPlanosToolStripMenuItem.Name = "generacionArchivosPlanosToolStripMenuItem";
            this.generacionArchivosPlanosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.generacionArchivosPlanosToolStripMenuItem.Text = "Archivos Planos";
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.generarToolStripMenuItem_Click);
            // 
            // generarHistoricosToolStripMenuItem
            // 
            this.generarHistoricosToolStripMenuItem.Name = "generarHistoricosToolStripMenuItem";
            this.generarHistoricosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.generarHistoricosToolStripMenuItem.Text = "Generar Historicos";
            this.generarHistoricosToolStripMenuItem.Click += new System.EventHandler(this.generarHistoricosToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasIBSToolStripMenuItem,
            this.homologacionesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.rutasDeLasListasToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // tablasIBSToolStripMenuItem
            // 
            this.tablasIBSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.causalesToolStripMenuItem,
            this.paisesToolStripMenuItem,
            this.tiposIdentificacionToolStripMenuItem});
            this.tablasIBSToolStripMenuItem.Name = "tablasIBSToolStripMenuItem";
            this.tablasIBSToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tablasIBSToolStripMenuItem.Text = "Tablas IBS";
            // 
            // causalesToolStripMenuItem
            // 
            this.causalesToolStripMenuItem.Name = "causalesToolStripMenuItem";
            this.causalesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.causalesToolStripMenuItem.Text = "Causales";
            this.causalesToolStripMenuItem.Click += new System.EventHandler(this.causalesToolStripMenuItem_Click);
            // 
            // paisesToolStripMenuItem
            // 
            this.paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            this.paisesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.paisesToolStripMenuItem.Text = "Paises";
            this.paisesToolStripMenuItem.Click += new System.EventHandler(this.paisesToolStripMenuItem_Click);
            // 
            // tiposIdentificacionToolStripMenuItem
            // 
            this.tiposIdentificacionToolStripMenuItem.Name = "tiposIdentificacionToolStripMenuItem";
            this.tiposIdentificacionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.tiposIdentificacionToolStripMenuItem.Text = "Tipos Identificacion";
            this.tiposIdentificacionToolStripMenuItem.Click += new System.EventHandler(this.tiposIdentificacionToolStripMenuItem_Click);
            // 
            // homologacionesToolStripMenuItem
            // 
            this.homologacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.causalesToolStripMenuItem1,
            this.tipoIdentificacionToolStripMenuItem,
            this.paisesToolStripMenuItem1});
            this.homologacionesToolStripMenuItem.Name = "homologacionesToolStripMenuItem";
            this.homologacionesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.homologacionesToolStripMenuItem.Text = "Homologaciones";
            // 
            // causalesToolStripMenuItem1
            // 
            this.causalesToolStripMenuItem1.Name = "causalesToolStripMenuItem1";
            this.causalesToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.causalesToolStripMenuItem1.Text = "Causales";
            this.causalesToolStripMenuItem1.Click += new System.EventHandler(this.causalesToolStripMenuItem1_Click);
            // 
            // tipoIdentificacionToolStripMenuItem
            // 
            this.tipoIdentificacionToolStripMenuItem.Name = "tipoIdentificacionToolStripMenuItem";
            this.tipoIdentificacionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tipoIdentificacionToolStripMenuItem.Text = "Tipo Identificacion";
            this.tipoIdentificacionToolStripMenuItem.Click += new System.EventHandler(this.tipoIdentificacionToolStripMenuItem_Click);
            // 
            // paisesToolStripMenuItem1
            // 
            this.paisesToolStripMenuItem1.Name = "paisesToolStripMenuItem1";
            this.paisesToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.paisesToolStripMenuItem1.Text = "Paises";
            this.paisesToolStripMenuItem1.Click += new System.EventHandler(this.paisesToolStripMenuItem1_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // rutasDeLasListasToolStripMenuItem
            // 
            this.rutasDeLasListasToolStripMenuItem.Name = "rutasDeLasListasToolStripMenuItem";
            this.rutasDeLasListasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rutasDeLasListasToolStripMenuItem.Text = "Rutas de las listas";
            this.rutasDeLasListasToolStripMenuItem.Click += new System.EventHandler(this.rutasDeLasListasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 517);
            this.Controls.Add(this.pnlAbajo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "GENERADOR LISTA DE CONTROL EXTERNA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.pnlAbajo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAbajo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargueDeListasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ofacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generacionArchivosPlanosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarHistoricosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasIBSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposIdentificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem causalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homologacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem causalesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoIdentificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rutasDeLasListasToolStripMenuItem;
    }
}