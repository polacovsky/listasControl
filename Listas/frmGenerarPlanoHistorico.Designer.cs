namespace Listas
{
    partial class frmGenerarPlanoHistorico
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
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFuente = new System.Windows.Forms.CheckBox();
            this.cmbFuentes = new System.Windows.Forms.ComboBox();
            this.dpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlDown.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDown.Controls.Add(this.btnGenerar);
            this.pnlDown.Controls.Add(this.btnCerrar);
            this.pnlDown.Controls.Add(this.label5);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 87);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDown.Size = new System.Drawing.Size(377, 52);
            this.pnlDown.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerar.Image = global::Listas.Properties.Resources.export_icon;
            this.btnGenerar.Location = new System.Drawing.Point(190, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(90, 40);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::Listas.Properties.Resources.close_icon;
            this.btnCerrar.Location = new System.Drawing.Point(280, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 40);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puerto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFuente);
            this.groupBox2.Controls.Add(this.cmbFuentes);
            this.groupBox2.Controls.Add(this.dpFechaFinal);
            this.groupBox2.Controls.Add(this.dpFechaInicial);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo";
            // 
            // chkFuente
            // 
            this.chkFuente.AutoSize = true;
            this.chkFuente.Location = new System.Drawing.Point(16, 48);
            this.chkFuente.Name = "chkFuente";
            this.chkFuente.Size = new System.Drawing.Size(62, 17);
            this.chkFuente.TabIndex = 6;
            this.chkFuente.Text = "Fuente:";
            this.chkFuente.UseVisualStyleBackColor = true;
            this.chkFuente.CheckedChanged += new System.EventHandler(this.chkFuente_CheckedChanged);
            // 
            // cmbFuentes
            // 
            this.cmbFuentes.FormattingEnabled = true;
            this.cmbFuentes.Location = new System.Drawing.Point(89, 46);
            this.cmbFuentes.Name = "cmbFuentes";
            this.cmbFuentes.Size = new System.Drawing.Size(259, 21);
            this.cmbFuentes.TabIndex = 7;
            // 
            // dpFechaFinal
            // 
            this.dpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaFinal.Location = new System.Drawing.Point(263, 19);
            this.dpFechaFinal.Name = "dpFechaFinal";
            this.dpFechaFinal.Size = new System.Drawing.Size(85, 20);
            this.dpFechaFinal.TabIndex = 5;
            // 
            // dpFechaInicial
            // 
            this.dpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaInicial.Location = new System.Drawing.Point(89, 19);
            this.dpFechaInicial.Name = "dpFechaInicial";
            this.dpFechaInicial.Size = new System.Drawing.Size(85, 20);
            this.dpFechaInicial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(377, 87);
            this.panel2.TabIndex = 0;
            // 
            // frmGenerarPlanoHistorico
            // 
            this.AcceptButton = this.btnGenerar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 139);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGenerarPlanoHistorico";
            this.Text = "Generar Plano Historico";
            this.Load += new System.EventHandler(this.frmGenerarPlano_Load);
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpFechaFinal;
        private System.Windows.Forms.DateTimePicker dpFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFuentes;
        private System.Windows.Forms.CheckBox chkFuente;
    }
}