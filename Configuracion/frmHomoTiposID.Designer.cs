namespace Configuracion
{
    partial class frmHomoTiposID
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.codtipoIBS = new System.Windows.Forms.TextBox();
            this.linkCausal = new System.Windows.Forms.LinkLabel();
            this.txtNomIDlIBS = new System.Windows.Forms.TextBox();
            this.linkFuente = new System.Windows.Forms.LinkLabel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAESTRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MAESTRO)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Size = new System.Drawing.Size(855, 49);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(668, 5);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(758, 5);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 205);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(367, 152);
            this.dataGridView1.TabIndex = 3;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 34);
            this.panel3.TabIndex = 4;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(45, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(144, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(383, 215);
            this.panel2.TabIndex = 2;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.codtipoIBS);
            this.gbDatos.Controls.Add(this.linkCausal);
            this.gbDatos.Controls.Add(this.txtNomIDlIBS);
            this.gbDatos.Controls.Add(this.linkFuente);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.txtFuente);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(5, 5);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(462, 107);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // codtipoIBS
            // 
            this.codtipoIBS.Location = new System.Drawing.Point(80, 76);
            this.codtipoIBS.MaxLength = 4;
            this.codtipoIBS.Name = "codtipoIBS";
            this.codtipoIBS.Size = new System.Drawing.Size(69, 20);
            this.codtipoIBS.TabIndex = 7;
            this.codtipoIBS.TextChanged += new System.EventHandler(this.txtCodCausal_TextChanged);
            // 
            // linkCausal
            // 
            this.linkCausal.AutoSize = true;
            this.linkCausal.Location = new System.Drawing.Point(12, 79);
            this.linkCausal.Name = "linkCausal";
            this.linkCausal.Size = new System.Drawing.Size(65, 13);
            this.linkCausal.TabIndex = 6;
            this.linkCausal.TabStop = true;
            this.linkCausal.Text = "Tipo ID IBS:";
            this.linkCausal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCausal_LinkClicked);
            // 
            // txtNomIDlIBS
            // 
            this.txtNomIDlIBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomIDlIBS.Location = new System.Drawing.Point(157, 76);
            this.txtNomIDlIBS.MaxLength = 4;
            this.txtNomIDlIBS.Name = "txtNomIDlIBS";
            this.txtNomIDlIBS.Size = new System.Drawing.Size(298, 20);
            this.txtNomIDlIBS.TabIndex = 5;
            // 
            // linkFuente
            // 
            this.linkFuente.AutoSize = true;
            this.linkFuente.Location = new System.Drawing.Point(12, 23);
            this.linkFuente.Name = "linkFuente";
            this.linkFuente.Size = new System.Drawing.Size(43, 13);
            this.linkFuente.TabIndex = 4;
            this.linkFuente.TabStop = true;
            this.linkFuente.Text = "Fuente:";
            this.linkFuente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFuente_LinkClicked);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(80, 46);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // txtFuente
            // 
            this.txtFuente.Location = new System.Drawing.Point(80, 20);
            this.txtFuente.MaxLength = 4;
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(234, 20);
            this.txtFuente.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gbDatos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(383, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(472, 117);
            this.panel4.TabIndex = 4;
            // 
            // frmHomoTiposID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(855, 264);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHomoTiposID";
            this.Text = " Homologacion Tipos ID";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.BS_MAESTRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_MAESTRO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkFuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.LinkLabel linkCausal;
        private System.Windows.Forms.TextBox txtNomIDlIBS;
        private System.Windows.Forms.TextBox codtipoIBS;
        
        
    }
}
